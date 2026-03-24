using System.Net;
using System.Text;
using System.Text.Json;
using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Integration;

/// <summary>
/// Integration tests using an in-memory <see cref="HttpMessageHandler"/> stub.
/// No TCP connections — deterministic, fast, and cross-platform.
/// </summary>
public sealed class HttpClientIntegrationTests
{
    private static (LolzteamHttpClient client, List<HttpRequestMessage> captured) BuildClient(
        Func<HttpRequestMessage, Task<HttpResponseMessage>> handler,
        RetryConfig? retry = null)
    {
        var captured = new List<HttpRequestMessage>();
        var stub = new StubHandler(req =>
        {
            captured.Add(req);
            return handler(req);
        });

        var httpClient = new HttpClient(stub);
        var config = new ClientConfig
        {
            Token = "test-token",
            BaseUrl = "http://api.test",
            Retry = retry,
        };

        return (new LolzteamHttpClient(config.WithHttpClient(httpClient)), captured);
    }

    private static HttpResponseMessage Json(int status, string json)
    {
        var resp = new HttpResponseMessage((HttpStatusCode)status);
        resp.Content = new StringContent(json, Encoding.UTF8, "application/json");
        return resp;
    }

    private static HttpResponseMessage Empty(int status, Dictionary<string, string>? headers = null)
    {
        var resp = new HttpResponseMessage((HttpStatusCode)status);
        if (headers == null)
            return resp;

        foreach (var (k, v) in headers)
            resp.Headers.TryAddWithoutValidation(k, v);

        return resp;
    }

    [Fact]
    public async Task Sends_authorization_bearer_header()
    {
        var (client, captured) = BuildClient(_ => Task.FromResult(Json(200, "{\"ok\":true}")));

        await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/test" });

        captured.Should().ContainSingle();
        captured[0].Headers.Authorization!.Scheme.Should().Be("Bearer");
        captured[0].Headers.Authorization!.Parameter.Should().Be("test-token");
    }

    [Fact]
    public async Task Returns_deserialized_response()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(Json(200, "{\"value\":42}")));

        var result = await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/echo" });
        result.GetProperty("value").GetInt32().Should().Be(42);
    }

    [Fact]
    public async Task Throws_HttpApiException_on_400()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(Empty(400)));

        var act = async () => await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/bad" });
        await act.Should().ThrowAsync<HttpApiException>().Where(e => e.StatusCode == 400);
    }

    [Fact]
    public async Task Throws_RateLimitException_on_429()
    {
        var (client, _) = BuildClient(_ =>
        {
            var resp = Empty(429);
            resp.Headers.TryAddWithoutValidation("Retry-After", "5");
            return Task.FromResult(resp);
        });

        var act = async () => await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/limited" });
        var ex = await act.Should().ThrowAsync<RateLimitException>();

        ex.Which.RetryAfter.Should().BeCloseTo(TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(1));
    }

    [Fact]
    public async Task Throws_ServerException_on_503()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(Empty(503)));

        var act = async () => await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/down" });
        await act.Should().ThrowAsync<ServerException>().Where(e => e.StatusCode == 503);
    }

    [Fact]
    public async Task Retry_succeeds_after_429()
    {
        var callCount = 0;
        var retryConfig = new RetryConfig
        {
            MaxRetries = 2,
            BaseDelay = TimeSpan.FromMilliseconds(1),
            MaxDelay = TimeSpan.FromMilliseconds(10),
        };

        var (client, _) = BuildClient(_ =>
        {
            callCount++;
            if (callCount != 1)
                return Task.FromResult(Json(200, "{\"ok\":true}"));

            var r = Empty(429);
            r.Headers.TryAddWithoutValidation("Retry-After", "0");
            return Task.FromResult(r);
        }, retryConfig);

        var result = await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/retry" });

        result.GetProperty("ok").GetBoolean().Should().BeTrue();
        callCount.Should().Be(2);
    }

    [Fact]
    public async Task Sends_query_parameters_in_url()
    {
        string? capturedUrl = null;
        var (client, _) = BuildClient(req =>
        {
            capturedUrl = req.RequestUri?.AbsoluteUri;
            return Task.FromResult(Json(200, "{}"));
        });

        var query = JsonSerializer.SerializeToElement(new { q = "hello world", page = 2 });
        await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/search",
            Query = query,
        });

        capturedUrl.Should().Contain("q=hello%20world");
        capturedUrl.Should().Contain("page=2");
    }

    [Fact]
    public async Task Sends_form_body_on_post()
    {
        string? capturedBody = null;
        var (client, _) = BuildClient(async req =>
        {
            capturedBody = await req.Content!.ReadAsStringAsync();
            return Json(200, "{}");
        });

        var body = JsonSerializer.SerializeToElement(new { foo = "bar", num = 42 });
        await client.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/post",
            Body = body,
            BodyEncoding = BodyEncoding.Form,
        });

        capturedBody.Should().Contain("foo=bar");
        capturedBody.Should().Contain("num=42");
    }

    [Fact]
    public async Task Sends_json_body_on_post()
    {
        string? capturedBody = null;
        string? capturedContentType = null;
        var (client, _) = BuildClient(async req =>
        {
            capturedBody = await req.Content!.ReadAsStringAsync();
            capturedContentType = req.Content?.Headers.ContentType?.MediaType;
            return Json(200, "{}");
        });

        var body = JsonSerializer.SerializeToElement(new { key = "value" });
        await client.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/json",
            Body = body,
            BodyEncoding = BodyEncoding.Json,
        });

        capturedContentType.Should().Be("application/json");
        capturedBody.Should().Contain("\"key\"");
    }

    [Fact]
    public async Task RequestRawAsync_returns_html_string()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("<html>Hello</html>", Encoding.UTF8, "text/html"),
            })
        );

        var html = await client.RequestRawAsync(new RequestOptions { Method = "GET", Path = "/page" });
        html.Should().Contain("<html>");
    }

    [Fact]
    public async Task Disposed_client_throws_ObjectDisposedException()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(Json(200, "{}")));
        client.Dispose();

        var act = async () => await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/x" });
        await act.Should().ThrowAsync<ObjectDisposedException>();
    }

    [Fact]
    public void ValidateProxy_throws_on_invalid_url()
    {
        var config = new ClientConfig
        {
            Token = "t",
            Proxy = new ProxyConfig("not-a-url"),
        };

        var act = () => new LolzteamHttpClient(config);
        act.Should().Throw<ConfigException>();
    }

    [Fact]
    public void ValidateProxy_throws_on_unsupported_scheme()
    {
        var config = new ClientConfig
        {
            Token = "t",
            Proxy = new ProxyConfig("ftp://proxy.example.com"),
        };

        var act = () => new LolzteamHttpClient(config);
        act.Should().Throw<ConfigException>().WithMessage("*ftp*");
    }

    [Fact]
    public async Task ILolzteamHttpClient_interface_can_be_used_to_abstract_client()
    {
        var (concreteClient, _) = BuildClient(_ => Task.FromResult(Json(200, "{\"v\":1}")));
        var result = await concreteClient.RequestAsync(new RequestOptions { Method = "GET", Path = "/if" });

        result.GetProperty("v").GetInt32().Should().Be(1);
    }

    [Fact]
    public async Task RequestAsync_generic_returns_deserialized_value()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(Json(200, "{\"score\":99}")));
        var result = await client.RequestAsync(
            new RequestOptions { Method = "GET", Path = "/generic" },
            bytes => JsonSerializer.Deserialize<ScoreResponse>(bytes.Span)
        );

        result!.Score.Should().Be(99);
    }

    [Fact]
    public async Task RequestAsync_generic_throws_on_error()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(Empty(400)));
        var act = async () => await client.RequestAsync(
            new RequestOptions { Method = "GET", Path = "/bad" },
            bytes => JsonSerializer.Deserialize<ScoreResponse>(bytes.Span)
        );

        await act.Should().ThrowAsync<HttpApiException>().Where(e => e.StatusCode == 400);
    }

    [Fact]
    public async Task RequestAsync_generic_chunked_uses_stream_fallback()
    {
        var (client, _) = BuildClient(_ =>
        {
            var resp = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ChunkedContent("{\"score\":7}"),
            };
            return Task.FromResult(resp);
        });

        var result = await client.RequestAsync(
            new RequestOptions { Method = "GET", Path = "/chunked" },
            bytes => JsonSerializer.Deserialize<ScoreResponse>(bytes.Span)
        );

        result!.Score.Should().Be(7);
    }

    [Fact]
    public async Task RequestAsync_chunked_uses_stream_fallback()
    {
        var (client, _) = BuildClient(_ =>
        {
            var resp = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ChunkedContent("{\"v\":55}"),
            };
            return Task.FromResult(resp);
        });

        var result = await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/chunked-json" });
        result.GetProperty("v").GetInt32().Should().Be(55);
    }

    [Fact]
    public async Task RequestRawAsync_throws_on_error_response()
    {
        var (client, _) = BuildClient(_ => Task.FromResult(Empty(503)));

        var act = async () => await client.RequestRawAsync(
            new RequestOptions { Method = "GET", Path = "/down" }
        );

        await act.Should().ThrowAsync<ServerException>().Where(e => e.StatusCode == 503);
    }

    [Fact]
    public async Task RequestAsync_with_search_rate_limit_does_not_block_for_high_limit()
    {
        var stub = new StubHandler(_ => Task.FromResult(Json(200, "{\"ok\":true}")));
        var config = new ClientConfig
        {
            Token = "t",
            BaseUrl = "http://api.test",
            SearchRateLimit = new RateLimitConfig(6000),
            Retry = null,
        };
        using var client = new LolzteamHttpClient(config.WithHttpClient(new HttpClient(stub)));

        var result = await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/search",
            IsSearch = true,
        });

        result.GetProperty("ok").GetBoolean().Should().BeTrue();
    }

    [Fact]
    public async Task Sends_array_query_parameter()
    {
        string? capturedUrl = null;
        var (client, _) = BuildClient(req =>
        {
            capturedUrl = req.RequestUri?.AbsoluteUri;
            return Task.FromResult(Json(200, "{}"));
        });

        var query = JsonSerializer.SerializeToElement(new { ids = new List<int> { 1, 2, 3 } });
        await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/items",
            Query = query,
        });

        capturedUrl.Should().Contain("ids=1");
        capturedUrl.Should().Contain("ids=2");
        capturedUrl.Should().Contain("ids=3");
    }

    [Fact]
    public async Task Sends_multipart_body()
    {
        string? capturedContentType = null;
        var (client, _) = BuildClient(async req =>
        {
            capturedContentType = req.Content?.Headers.ContentType?.MediaType;
            _ = await req.Content!.ReadAsStringAsync();
            return Json(200, "{}");
        });

        var body = JsonSerializer.SerializeToElement(new { caption = "hello" });
        await client.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/upload",
            Body = body,
            BodyEncoding = BodyEncoding.Multipart,
        });

        capturedContentType.Should().StartWith("multipart/form-data");
    }
}

internal sealed record ScoreResponse(
    [property: System.Text.Json.Serialization.JsonPropertyName("score")]
    int Score
);

/// <summary>HTTP content without a Content-Length header, simulating chunked transfer encoding.</summary>
internal sealed class ChunkedContent : HttpContent
{
    private readonly byte[] _bytes;

    internal ChunkedContent(string json) => _bytes = Encoding.UTF8.GetBytes(json);

    protected override Task SerializeToStreamAsync(Stream stream, TransportContext? context)
        => stream.WriteAsync(_bytes, 0, _bytes.Length);

    protected override bool TryComputeLength(out long length)
    {
        length = 0;
        return false;
    }
}

/// <summary>In-memory HTTP handler for deterministic tests.</summary>
internal sealed class StubHandler : HttpMessageHandler
{
    private readonly Func<HttpRequestMessage, Task<HttpResponseMessage>> _handler;

    internal StubHandler(Func<HttpRequestMessage, Task<HttpResponseMessage>> handler)
    {
        _handler = handler;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token)
    {
        return _handler(request);
    }
}
