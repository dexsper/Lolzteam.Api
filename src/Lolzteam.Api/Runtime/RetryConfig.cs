namespace Lolzteam.Api.Runtime;

/// <summary>Retry policy configuration.</summary>
public sealed record RetryConfig
{
    /// <summary>Maximum number of retry attempts (not counting the initial attempt).</summary>
    public int MaxRetries { get; init; } = 3;

    /// <summary>Base delay for exponential backoff.</summary>
    public TimeSpan BaseDelay { get; init; } = TimeSpan.FromMilliseconds(500);

    /// <summary>Maximum delay between retries (caps exponential growth).</summary>
    public TimeSpan MaxDelay { get; init; } = TimeSpan.FromSeconds(30);

    /// <summary>Default policy: 3 retries, 500ms base, 30s max.</summary>
    public static readonly RetryConfig Default = new();
}

/// <summary>Context passed to the <see cref="ClientConfig.OnRetry"/> callback.</summary>
public sealed record RetryContext(
    int Attempt,
    TimeSpan Delay,
    Exception Exception,
    string Method,
    string Path,
    int? StatusCode
);
