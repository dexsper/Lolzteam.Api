using System.Runtime.CompilerServices;
using Lolzteam.Api.Runtime;

[assembly: InternalsVisibleTo("Lolzteam.Api.Tests")]

namespace Lolzteam.Api.DependencyInjection;

/// <summary>
/// Fluent builder for <see cref="ClientConfig"/>.
/// </summary>
/// <example>
/// <code>
/// services.AddLolzteamClient&lt;ForumClient&gt;(b => b
///     .WithToken("mytoken")
///     .WithProxy("socks5://proxy:1080")
///     .WithTimeout(TimeSpan.FromSeconds(60))
///     .WithRateLimit(300)
/// );
/// </code>
/// </example>
public sealed class ClientConfigBuilder
{
    private string? _token;
    private string? _baseUrl;
    private ProxyConfig? _proxy;
    private RetryConfig? _retry = RetryConfig.Default;
    private RateLimitConfig? _rateLimit;
    private RateLimitConfig? _searchRateLimit;
    private TimeSpan _timeout = TimeSpan.FromSeconds(30);
    private Action<RetryContext>? _onRetry;

    /// <summary>Bearer token for API authentication (required).</summary>
    public ClientConfigBuilder WithToken(string token)
    {
        _token = token;
        return this;
    }

    /// <summary>Override the default base URL.</summary>
    public ClientConfigBuilder WithBaseUrl(string baseUrl)
    {
        _baseUrl = baseUrl;
        return this;
    }

    /// <summary>Set a proxy by URL. Supports http://, https://, socks5://.</summary>
    public ClientConfigBuilder WithProxy(string proxyUrl)
    {
        _proxy = new ProxyConfig(proxyUrl);
        return this;
    }

    /// <summary>Set a proxy using an existing <see cref="ProxyConfig"/>.</summary>
    public ClientConfigBuilder WithProxy(ProxyConfig proxy)
    {
        _proxy = proxy;
        return this;
    }

    /// <summary>Set a custom retry policy.</summary>
    public ClientConfigBuilder WithRetry(RetryConfig retry)
    {
        _retry = retry;
        return this;
    }

    /// <summary>Disable retries entirely.</summary>
    public ClientConfigBuilder WithoutRetry()
    {
        _retry = null;
        return this;
    }

    /// <summary>Enable client-side rate limiting at <paramref name="requestsPerMinute"/> req/min.</summary>
    public ClientConfigBuilder WithRateLimit(int requestsPerMinute)
    {
        _rateLimit = new RateLimitConfig(requestsPerMinute);
        return this;
    }

    /// <summary>Enable a separate rate limit for category-search endpoints.</summary>
    public ClientConfigBuilder WithSearchRateLimit(int requestsPerMinute)
    {
        _searchRateLimit = new RateLimitConfig(requestsPerMinute);
        return this;
    }

    /// <summary>Set the per-request timeout. Defaults to 30 seconds.</summary>
    public ClientConfigBuilder WithTimeout(TimeSpan timeout)
    {
        _timeout = timeout;
        return this;
    }

    /// <summary>Register a callback invoked on each retry attempt.</summary>
    public ClientConfigBuilder OnRetry(Action<RetryContext> callback)
    {
        _onRetry = callback;
        return this;
    }

    internal ClientConfig Build()
    {
        if (string.IsNullOrWhiteSpace(_token))
            throw new InvalidOperationException("Token is required. Call WithToken(\"...\") before registering the client.");

        return new ClientConfig
        {
            Token         = _token!,
            BaseUrl       = _baseUrl,
            Proxy         = _proxy,
            Retry         = _retry,
            RateLimit     = _rateLimit,
            SearchRateLimit = _searchRateLimit,
            Timeout       = _timeout,
            OnRetry       = _onRetry,
        };
    }
}
