using System.Buffers;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// Core HTTP transport for Lolzteam API clients.
/// Uses a static pooled handler to avoid socket exhaustion.
/// On .NET 6+ uses SocketsHttpHandler; falls back to HttpClientHandler on older TFMs.
/// </summary>
public sealed class LolzteamHttpClient : ILolzteamHttpClient
{
    const int ArrayPoolThreshold = 1024 * 1024;
    private static readonly char[] ColonSeparator = [':'];

    // Keyed by proxy URL; never disposed — lifetime tied to the process.
    private static readonly ConcurrentDictionary<string, HttpMessageHandler> HandlerPool = new();

    private readonly ClientConfig _config;
    private readonly HttpClient _httpClient;
    private readonly bool _ownsHttpClient;
    private readonly RateLimiter? _rateLimiter;
    private readonly RateLimiter? _searchRateLimiter;
    private bool _disposed;

    /// <summary>
    /// Create a client. If <paramref name="config"/> has an injected HttpClient (e.g. from IHttpClientFactory)
    /// it is used as-is; otherwise a pooled handler is used.
    /// </summary>
    public LolzteamHttpClient(ClientConfig config)
    {
        _config = config ?? throw new ArgumentNullException(nameof(config));

        if (config.HttpClient is { } injected)
        {
            _httpClient = injected;
            _ownsHttpClient = false;
        }
        else
        {
            var poolKey = config.Proxy?.Url ?? string.Empty;
            var handler = HandlerPool.GetOrAdd(poolKey, _ => BuildHandler(config.Proxy));
            _httpClient = new HttpClient(handler, disposeHandler: false)
            {
                Timeout = config.Timeout,
            };
            _ownsHttpClient = true;
        }

        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", config.Token);

        if (config.RateLimit is { } rl)
            _rateLimiter = new RateLimiter(rl.RequestsPerMinute);

        if (config.SearchRateLimit is { } srl)
            _searchRateLimiter = new RateLimiter(srl.RequestsPerMinute);
    }

    /// <inheritdoc />
    public Task<JsonElement> RequestAsync(RequestOptions options, CancellationToken cancellationToken = default)
    {
        ThrowIfDisposed();
        return ExecuteWithPipelineAsync(
            ct => ExecuteAsync(options, ct),
            options,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<T> RequestAsync<T>(
        RequestOptions options,
        Func<ReadOnlyMemory<byte>, T> deserializer,
        CancellationToken cancellationToken = default)
    {
        ThrowIfDisposed();
        return ExecuteWithPipelineAsync(
            ct => ExecuteAsync(options, deserializer, ct),
            options,
            cancellationToken
        );
    }

    /// <inheritdoc />
    public Task<string> RequestRawAsync(RequestOptions options, CancellationToken cancellationToken = default)
    {
        ThrowIfDisposed();
        return ExecuteWithPipelineAsync(
            ct => ExecuteRawAsync(options, ct),
            options,
            cancellationToken
        );
    }

    private void ThrowIfDisposed()
    {
        if (!_disposed) return;
        throw new ObjectDisposedException(nameof(LolzteamHttpClient));
    }

    private async Task<T> ExecuteWithPipelineAsync<T>(
        Func<CancellationToken, Task<T>> core,
        RequestOptions options,
        CancellationToken cancellationToken)
    {
        if (_rateLimiter != null)
            await _rateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);

        if (options.IsSearch && _searchRateLimiter != null)
            await _searchRateLimiter.AcquireAsync(cancellationToken).ConfigureAwait(false);

        if (_config.Retry is not { } retryConfig)
            return await core(cancellationToken).ConfigureAwait(false);

        return await RetryHandler.ExecuteWithRetryAsync(
            core, retryConfig, _config.OnRetry,
            options.Method, options.Path, cancellationToken
        ).ConfigureAwait(false);
    }

    private async Task<JsonElement> ExecuteAsync(RequestOptions options, CancellationToken cancellationToken)
    {
        using var request = BuildRequest(options);
        using var response = await _httpClient
            .SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationToken)
            .ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            var errorBody = await response.Content
#if NET6_0_OR_GREATER
                .ReadAsStringAsync(cancellationToken)
#else
                .ReadAsStringAsync()
#endif
                .ConfigureAwait(false);
            throw RetryHandler.CreateException((int)response.StatusCode, errorBody, response.Headers);
        }

        var contentLength = response.Content.Headers.ContentLength;
        if (contentLength is > 0 and <= ArrayPoolThreshold)
        {
            var length = (int)contentLength.Value;
            var pool = ArrayPool<byte>.Shared;
            var buffer = pool.Rent(length);
            try
            {
#if NET6_0_OR_GREATER
                await using var poolStream =
 await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
                using var poolStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif
                var totalRead = 0;
                while (totalRead < length)
                {
#if NET6_0_OR_GREATER
                    var read = await poolStream
                        .ReadAsync(buffer.AsMemory(totalRead, length - totalRead), cancellationToken)
                        .ConfigureAwait(false);
#else
                    var read = await poolStream
                        .ReadAsync(buffer, totalRead, length - totalRead, cancellationToken)
                        .ConfigureAwait(false);
#endif
                    if (read == 0) break;
                    totalRead += read;
                }

                if (totalRead == 0) return default;

                using var document = JsonDocument.Parse(new ReadOnlyMemory<byte>(buffer, 0, totalRead));
                return document.RootElement.Clone();
            }
            finally
            {
                pool.Return(buffer);
            }
        }

#if NET6_0_OR_GREATER
        await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
        using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif

        if (stream.CanSeek && stream.Length == 0)
            return default;

        using var fallbackDoc = await JsonDocument
            .ParseAsync(stream, cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        return fallbackDoc.RootElement.Clone();
    }

    private async Task<T> ExecuteAsync<T>(
        RequestOptions options,
        Func<ReadOnlyMemory<byte>, T> deserializer,
        CancellationToken cancellationToken)
    {
        using var request = BuildRequest(options);
        using var response = await _httpClient
            .SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationToken)
            .ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            var errorBody = await response.Content
#if NET6_0_OR_GREATER
                .ReadAsStringAsync(cancellationToken)
#else
                .ReadAsStringAsync()
#endif
                .ConfigureAwait(false);
            throw RetryHandler.CreateException((int)response.StatusCode, errorBody, response.Headers);
        }

        var contentLength = response.Content.Headers.ContentLength;

        if (contentLength is > 0 and <= ArrayPoolThreshold)
        {
            var length = (int)contentLength.Value;
            var pool = ArrayPool<byte>.Shared;
            var buffer = pool.Rent(length);
            try
            {
#if NET6_0_OR_GREATER
                await using var poolStream =
 await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
                using var poolStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif
                var totalRead = 0;
                while (totalRead < length)
                {
#if NET6_0_OR_GREATER
                    var read = await poolStream
                        .ReadAsync(buffer.AsMemory(totalRead, length - totalRead), cancellationToken)
                        .ConfigureAwait(false);
#else
                    var read = await poolStream
                        .ReadAsync(buffer, totalRead, length - totalRead, cancellationToken)
                        .ConfigureAwait(false);
#endif
                    if (read == 0) break;
                    totalRead += read;
                }

                if (totalRead == 0) return default!;

                return deserializer(new ReadOnlyMemory<byte>(buffer, 0, totalRead));
            }
            finally
            {
                pool.Return(buffer);
            }
        }

#if NET6_0_OR_GREATER
        await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
#else
        using var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
#endif
        using var ms = new MemoryStream();
#if NET6_0_OR_GREATER
        await stream.CopyToAsync(ms, cancellationToken).ConfigureAwait(false);
#else
        await stream.CopyToAsync(ms).ConfigureAwait(false);
#endif
        if (ms.Length == 0) return default!;
        return deserializer(ms.GetBuffer().AsMemory(0, (int)ms.Length));
    }

    private async Task<string> ExecuteRawAsync(RequestOptions options, CancellationToken cancellationToken)
    {
        using var request = BuildRequest(options);
        using var response = await _httpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            var errorBody = await response.Content
#if NET6_0_OR_GREATER
                .ReadAsStringAsync(cancellationToken)
#else
                .ReadAsStringAsync()
#endif
                .ConfigureAwait(false);
            throw RetryHandler.CreateException((int)response.StatusCode, errorBody, response.Headers);
        }

        return await response.Content
#if NET6_0_OR_GREATER
            .ReadAsStringAsync(cancellationToken)
#else
            .ReadAsStringAsync()
#endif
            .ConfigureAwait(false);
    }

    private HttpRequestMessage BuildRequest(RequestOptions options)
    {
        var url = BuildUrl(options.Path, options.Query);
        var request = new HttpRequestMessage(new HttpMethod(options.Method), url);
        SetBody(request, options);
        return request;
    }

    private string BuildUrl(string path, JsonElement? query)
    {
        var baseUrl = (_config.BaseUrl ?? string.Empty).TrimEnd('/');
        var sb = new StringBuilder(baseUrl.Length + path.Length + 64);
        sb.Append(baseUrl);
        sb.Append(path);

        if (query is not { ValueKind: JsonValueKind.Object } q)
            return sb.ToString();

        var separator = '?';
        foreach (var prop in q.EnumerateObject())
        {
            if (prop.Value.ValueKind == JsonValueKind.Null) continue;

            if (prop.Value.ValueKind == JsonValueKind.Array)
            {
                foreach (var item in prop.Value.EnumerateArray())
                {
                    sb.Append(separator);
                    sb.Append(Uri.EscapeDataString(prop.Name));
                    sb.Append('=');
                    sb.Append(Uri.EscapeDataString(FormatQueryValue(item)));
                    separator = '&';
                }

                continue;
            }

            sb.Append(separator);
            sb.Append(Uri.EscapeDataString(prop.Name));
            sb.Append('=');
            sb.Append(Uri.EscapeDataString(FormatQueryValue(prop.Value)));
            separator = '&';
        }

        return sb.ToString();
    }

    private static void SetBody(HttpRequestMessage request, RequestOptions options)
    {
        var hasBody = options.Body is { ValueKind: JsonValueKind.Object };
        var hasByteFields = options.ByteArrayFields is { Count: > 0 };

        if (!hasBody && !hasByteFields) return;

        switch (options.BodyEncoding)
        {
            case BodyEncoding.Json:
            {
                var json = options.Body is { } b ? JsonSerializer.Serialize(b) : "{}";
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
                break;
            }
            case BodyEncoding.Multipart:
            {
                var multipart = new MultipartFormDataContent();
                if (options.Body is { ValueKind: JsonValueKind.Object } mb)
                {
                    foreach (var prop in mb.EnumerateObject())
                    {
                        if (prop.Value.ValueKind == JsonValueKind.Null) continue;
                        multipart.Add(new StringContent(FormatQueryValue(prop.Value)), prop.Name);
                    }
                }

                if (options.ByteArrayFields != null)
                {
                    foreach (var kvp in options.ByteArrayFields)
                    {
                        multipart.Add(new ByteArrayContent(kvp.Value), kvp.Key, kvp.Key);
                    }
                }

                request.Content = multipart;
                break;
            }
            default:
            {
                if (options.Body is not { ValueKind: JsonValueKind.Object } fb)
                {
                    break;
                }

                var pairs = new List<KeyValuePair<string, string>>();
                foreach (var prop in fb.EnumerateObject())
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                        continue;

                    if (prop.Value.ValueKind != JsonValueKind.Array)
                    {
                        pairs.Add(new KeyValuePair<string, string>(prop.Name, FormatQueryValue(prop.Value)));
                        continue;
                    }

                    foreach (var item in prop.Value.EnumerateArray())
                        pairs.Add(new KeyValuePair<string, string>(prop.Name, FormatQueryValue(item)));
                }

                request.Content = new FormUrlEncodedContent(pairs);
                break;
            }
        }
    }

    private static string FormatQueryValue(JsonElement el) => el.ValueKind switch
    {
        JsonValueKind.True => "1",
        JsonValueKind.False => "0",
        JsonValueKind.Number => el.GetRawText(),
        JsonValueKind.String => el.GetString() ?? string.Empty,
        _ => el.GetRawText(),
    };

    /// <summary>Build a poolable HttpMessageHandler for the given proxy config. Used by IHttpClientFactory integration.</summary>
    public static HttpMessageHandler BuildHandler(ProxyConfig? proxyConfig)
    {
        if (proxyConfig != null)
            ValidateProxy(proxyConfig);

#if NET6_0_OR_GREATER
        var handler = new SocketsHttpHandler
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(2),
            AutomaticDecompression = DecompressionMethods.All,
        };

        if (proxyConfig == null || !Uri.TryCreate(proxyConfig.Url, UriKind.Absolute, out var proxyUri))
            return handler;

        var scheme = proxyUri.Scheme;
        if (scheme == "socks5")
        {
            handler.UseProxy = true;
            handler.Proxy = new WebProxy(proxyUri);
        }
        else
        {
            handler.UseProxy = true;
            handler.Proxy = BuildWebProxy(proxyUri);
        }

        return handler;
#else
        var handler = new HttpClientHandler
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
        };

        if (proxyConfig == null || !Uri.TryCreate(proxyConfig.Url, UriKind.Absolute, out var proxyUri))
            return handler;

        var scheme = proxyUri.Scheme;
        if (scheme == "socks5")
        {
            throw new PlatformNotSupportedException(
                "SOCKS5 proxy requires .NET 6 or later. Upgrade your target framework or use an HTTP/HTTPS proxy on this runtime."
            );
        }

        handler.UseProxy = true;
        handler.Proxy = BuildWebProxy(proxyUri);

        return handler;
#endif
    }

    private static void ValidateProxy(ProxyConfig proxy)
    {
        if (!Uri.TryCreate(proxy.Url, UriKind.Absolute, out var uri))
            throw new ConfigException($"Invalid proxy URL: '{proxy.Url}'.");

        var scheme = uri.Scheme;
        if (scheme is "http" or "https" or "socks5") return;

        throw new ConfigException($"Unsupported proxy scheme '{scheme}'. Supported: http, https, socks5.");
    }

    private static WebProxy BuildWebProxy(Uri proxyUri)
    {
        var proxy = new WebProxy(proxyUri);
        if (string.IsNullOrEmpty(proxyUri.UserInfo))
            return proxy;

        var parts = proxyUri.UserInfo.Split(ColonSeparator, 2);
        if (parts.Length == 2)
        {
            proxy.Credentials = new NetworkCredential(
                Uri.UnescapeDataString(parts[0]),
                Uri.UnescapeDataString(parts[1])
            );
        }

        return proxy;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        if (_disposed)
            return;

        _disposed = true;
        _rateLimiter?.Dispose();
        _searchRateLimiter?.Dispose();

        if (!_ownsHttpClient)
            return;

        _httpClient.Dispose();
    }
}
