namespace Lolzteam.Api.Runtime;

/// <summary>Immutable configuration for a Forum or Market client.</summary>
public sealed record ClientConfig
{
    /// <summary>Bearer token for API authentication.</summary>
    public required string Token { get; init; }

    /// <summary>Override the default base URL (optional).</summary>
    public string? BaseUrl { get; init; }

    /// <summary>Proxy settings (optional). Supports http://, https://, socks5://.</summary>
    public ProxyConfig? Proxy { get; init; }

    /// <summary>Retry policy. Set to null to disable retries entirely.</summary>
    public RetryConfig? Retry { get; init; } = RetryConfig.Default;

    /// <summary>Client-side rate limiting (optional). Helps avoid 429 proactively.</summary>
    public RateLimitConfig? RateLimit { get; init; }

    /// <summary>Separate rate limit for category-search endpoints (optional).</summary>
    public RateLimitConfig? SearchRateLimit { get; init; }

    /// <summary>Request timeout. Defaults to 30 seconds.</summary>
    public TimeSpan Timeout { get; init; } = TimeSpan.FromSeconds(30);

    /// <summary>Callback invoked on each retry attempt.</summary>
    public Action<RetryContext>? OnRetry { get; init; }

    /// <summary>Inject a pre-built HttpClient (for testing or IHttpClientFactory integration).</summary>
    internal HttpClient? HttpClient { get; init; }

    /// <summary>Return a copy of this config with an injected HttpClient (for DI / testing).</summary>
    internal ClientConfig WithHttpClient(HttpClient httpClient) => this with { HttpClient = httpClient };
}

/// <summary>Client-side rate limiter configuration.</summary>
/// <param name="RequestsPerMinute">Maximum requests allowed per minute.</param>
public sealed record RateLimitConfig(int RequestsPerMinute);
