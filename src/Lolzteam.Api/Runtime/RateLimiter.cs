namespace Lolzteam.Api.Runtime;

/// <summary>Token-bucket rate limiter. Thread-safe.</summary>
public sealed class RateLimiter : IDisposable
{
    private readonly SemaphoreSlim _semaphore;
    private readonly TimeSpan _interval;
    private bool _disposed;

    /// <summary>Create a rate limiter for the specified maximum requests per minute.</summary>
    public RateLimiter(int requestsPerMinute)
    {
        if (requestsPerMinute <= 0)
            throw new ArgumentOutOfRangeException(nameof(requestsPerMinute), "Must be > 0.");

        _semaphore = new SemaphoreSlim(1, 1);
        _interval = TimeSpan.FromMilliseconds(60_000.0 / requestsPerMinute);
    }

    private DateTimeOffset _lastRelease = DateTimeOffset.MinValue;

    /// <summary>Acquire a rate-limit slot. Waits until it is safe to proceed.</summary>
    public async Task AcquireAsync(CancellationToken cancellationToken)
    {
        await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            var now = DateTimeOffset.UtcNow;
            var nextAllowed = _lastRelease + _interval;
            if (nextAllowed > now)
            {
                var wait = nextAllowed - now;
                await Task.Delay(wait, cancellationToken).ConfigureAwait(false);
            }

            _lastRelease = DateTimeOffset.UtcNow;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    /// <inheritdoc />
    public void Dispose()
    {
        if (_disposed)
            return;

        _disposed = true;
        _semaphore.Dispose();
    }
}
