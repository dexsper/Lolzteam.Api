using System.Net;
using System.Net.Sockets;
using System.Text;
using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Integration;

/// <summary>
/// Integration tests for <see cref="LolzteamHttpClient.BuildHandler"/>.
/// Each test spins up lightweight in-process TCP servers (no external deps) to verify that the
/// produced <see cref="System.Net.Http.HttpMessageHandler"/> correctly routes traffic.
/// </summary>
public sealed class ProxyIntegrationTests
{
    private sealed class MiniProxy : IAsyncDisposable
    {
        private readonly TcpListener _listener;
        private readonly CancellationTokenSource _cts = new();

        /// <summary>First request-line the proxy received, or null if no connection arrived.</summary>
        public string? ReceivedRequestLine { get; private set; }

        /// <summary>Number of connections accepted.</summary>
        public int ConnectionCount { get; private set; }

        private readonly string _responseBody;
        private readonly int _responseStatus;

        public int Port => ((IPEndPoint)_listener.LocalEndpoint).Port;

        private MiniProxy(string responseBody, int responseStatus)
        {
            _responseBody = responseBody;
            _responseStatus = responseStatus;
            _listener = new TcpListener(IPAddress.Loopback, 0);
            _listener.Start();
        }

        public static MiniProxy Start(string responseBody = "{\"proxied\":true}", int status = 200)
        {
            var proxy = new MiniProxy(responseBody, status);
            _ = proxy.AcceptLoopAsync(proxy._cts.Token);
            return proxy;
        }

        private async Task AcceptLoopAsync(CancellationToken ct)
        {
            try
            {
                while (!ct.IsCancellationRequested)
                {
                    TcpClient client;
                    try
                    {
                        client = await _listener.AcceptTcpClientAsync(ct);
                    }
                    catch
                    {
                        break;
                    }

                    ConnectionCount++;
                    _ = HandleClientAsync(client, ct);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        private async Task HandleClientAsync(TcpClient client, CancellationToken ct)
        {
            using (client)
            await using (var stream = client.GetStream())
            using (var reader = new StreamReader(stream, Encoding.ASCII, leaveOpen: true))
            {
                // Read the request line
                var requestLine = await reader.ReadLineAsync(ct);
                ReceivedRequestLine = requestLine;

                // Drain the rest of the headers (until blank line)
                while (!string.IsNullOrEmpty(await reader.ReadLineAsync(ct)))
                {
                }

                // Respond with the configured body
                var body = Encoding.UTF8.GetBytes(_responseBody);
                var statusText = _responseStatus == 200 ? "OK" : "Error";
                var response =
                    $"HTTP/1.1 {_responseStatus} {statusText}\r\n" +
                    $"Content-Type: application/json; charset=utf-8\r\n" +
                    $"Content-Length: {body.Length}\r\n" +
                    $"Connection: close\r\n" +
                    $"\r\n";

                var headerBytes = Encoding.ASCII.GetBytes(response);
                await stream.WriteAsync(headerBytes, ct);
                await stream.WriteAsync(body, ct);
                await stream.FlushAsync(ct);
            }
        }

        public async ValueTask DisposeAsync()
        {
            await _cts.CancelAsync();
            _listener.Stop();
        }
    }

    private sealed class MiniServer : IAsyncDisposable
    {
        private readonly TcpListener _listener;
        private readonly CancellationTokenSource _cts = new();
        private readonly string _responseBody;

        public int Port => ((IPEndPoint)_listener.LocalEndpoint).Port;

        private MiniServer(string responseBody)
        {
            _responseBody = responseBody;
            _listener = new TcpListener(IPAddress.Loopback, 0);
            _listener.Start();
        }

        public static MiniServer Start(string responseBody = "{\"ok\":true}")
        {
            var s = new MiniServer(responseBody);
            _ = s.AcceptLoopAsync(s._cts.Token);
            return s;
        }

        private async Task AcceptLoopAsync(CancellationToken ct)
        {
            try
            {
                while (!ct.IsCancellationRequested)
                {
                    TcpClient client;
                    try
                    {
                        client = await _listener.AcceptTcpClientAsync(ct);
                    }
                    catch
                    {
                        break;
                    }

                    _ = HandleClientAsync(client, ct);
                }
            }
            catch (OperationCanceledException)
            {
            }
        }

        private async Task HandleClientAsync(TcpClient client, CancellationToken ct)
        {
            using (client)
            await using (var stream = client.GetStream())
            using (var reader = new StreamReader(stream, Encoding.ASCII, leaveOpen: true))
            {
                while (!string.IsNullOrEmpty(await reader.ReadLineAsync(ct)))
                {
                }

                var body = Encoding.UTF8.GetBytes(_responseBody);
                var response =
                    "HTTP/1.1 200 OK\r\n" +
                    "Content-Type: application/json; charset=utf-8\r\n" +
                    $"Content-Length: {body.Length}\r\n" +
                    "Connection: close\r\n" +
                    "\r\n";

                await stream.WriteAsync(Encoding.ASCII.GetBytes(response), ct);
                await stream.WriteAsync(body, ct);
                await stream.FlushAsync(ct);
            }
        }

        public async ValueTask DisposeAsync()
        {
            await _cts.CancelAsync();
            _listener.Stop();
        }
    }

    [Fact]
    public async Task BuildHandler_no_proxy_returns_working_handler()
    {
        await using var server = MiniServer.Start("{\"direct\":true}");

        var handler = LolzteamHttpClient.BuildHandler(null);
        using var httpClient = new HttpClient(handler);

        var url = $"http://127.0.0.1:{server.Port}/test";
        var resp = await httpClient.GetAsync(url);
        var body = await resp.Content.ReadAsStringAsync();

        body.Should().Contain("direct");
    }

    [Fact]
    public async Task BuildHandler_with_http_proxy_routes_traffic_through_proxy()
    {
        // Proxy will intercept the request and return a synthetic response.
        await using var proxy = MiniProxy.Start();
        var handler = LolzteamHttpClient.BuildHandler(new ProxyConfig($"http://127.0.0.1:{proxy.Port}"));
        using var httpClient = new HttpClient(handler);

        // The target URL doesn't need to exist — the proxy will intercept the request
        // and respond directly, never actually connecting to api.test.
        await httpClient.GetAsync("http://api.test/some/path");

        proxy.ConnectionCount.Should().BeGreaterThan(0,
            "the handler must have routed the request through the proxy"
        );

        proxy.ReceivedRequestLine.Should().Contain("api.test",
            "the proxy receives an absolute-URI request line pointing to the real target"
        );
    }

    [Fact]
    public async Task BuildHandler_with_http_proxy_response_is_deserialized_correctly()
    {
        await using var proxy = MiniProxy.Start("{\"value\":99}");
        var config = new ClientConfig
        {
            Token = "proxy-token",
            BaseUrl = "http://api.test",
            Proxy = new ProxyConfig($"http://127.0.0.1:{proxy.Port}"),
        };

        using var client = new LolzteamHttpClient(config);
        var result = await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/ping" });
        result.GetProperty("value").GetInt64().Should().Be(99L);
    }

    [Fact]
    public async Task BuildHandler_with_authenticated_proxy_sets_credentials()
    {
        // Proxy server records the request — we verify the handler did NOT throw on
        // credential-bearing proxy URL construction (BuildWebProxy path).
        await using var proxy = MiniProxy.Start("{\"auth\":true}");

        var proxyUrl = $"http://user:pass@127.0.0.1:{proxy.Port}";
        var handler = LolzteamHttpClient.BuildHandler(new ProxyConfig(proxyUrl));

        using var httpClient = new HttpClient(handler);
        await httpClient.GetAsync("http://api.test/auth-test");

        proxy.ConnectionCount.Should().BeGreaterThan(0);
    }

    [Fact]
    public void BuildHandler_with_invalid_proxy_url_throws_ConfigException()
    {
        var act = () => LolzteamHttpClient.BuildHandler(new ProxyConfig("not-a-valid-url"));
        act.Should().Throw<ConfigException>();
    }

    [Fact]
    public void BuildHandler_with_unsupported_proxy_scheme_throws_ConfigException()
    {
        var act = () => LolzteamHttpClient.BuildHandler(new ProxyConfig("ftp://proxy.local"));
        act.Should().Throw<ConfigException>().WithMessage("*ftp*");
    }

    // SOCKS5 is only supported on net6+ via SocketsHttpHandler.
    // On older TFMs BuildHandler throws PlatformNotSupportedException.
    [Fact]
    public void BuildHandler_with_socks5_does_not_throw_on_net6_plus()
    {
#if NET6_0_OR_GREATER
        var act = () => LolzteamHttpClient.BuildHandler(new ProxyConfig("socks5://127.0.0.1:1080"));
        act.Should().NotThrow();
#else
        var act = () => LolzteamHttpClient.BuildHandler(new ProxyConfig("socks5://127.0.0.1:1080"));
        act.Should().Throw<PlatformNotSupportedException>();
#endif
    }
}
