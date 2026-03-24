using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

internal static class RetryHandler
{
#if NET6_0_OR_GREATER
    private static double NextDouble() => Random.Shared.NextDouble();
#else
    private static readonly Random Rng = new();
    private static readonly object RngLock = new();

    private static double NextDouble()
    {
        lock (RngLock) return Rng.NextDouble();
    }
#endif

    /// <summary>
    /// Execute <paramref name="send"/> with retry logic.
    /// Retries on: 429 (RateLimitException), 502/503/504 (ServerException), transient network errors.
    /// </summary>
    internal static async Task<T> ExecuteWithRetryAsync<T>(
        Func<CancellationToken, Task<T>> send,
        RetryConfig config,
        Action<RetryContext>? onRetry,
        string method,
        string path,
        CancellationToken cancellationToken)
    {
        var maxRetries = config.MaxRetries;

        for (var attempt = 0;; attempt++)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                return await send(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex) when (IsRetryable(ex) && attempt < maxRetries)
            {
                var delay = ComputeDelay(config, attempt, ex);
                var statusCode = GetStatusCode(ex);

                onRetry?.Invoke(new RetryContext(attempt + 1, delay, ex, method, path, statusCode));
                await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex) when (IsRetryable(ex))
            {
                throw new RetryExhaustedException(attempt + 1, ex);
            }
        }
    }

    internal static bool IsRetryable(Exception ex) => ex switch
    {
        RateLimitException => true,
        ServerException s => s.StatusCode is 502 or 503 or 504,
        NetworkException { IsTransient: true } => true,
        _ => false,
    };

    private static TimeSpan ComputeDelay(RetryConfig config, int attempt, Exception ex)
    {
        if (ex is RateLimitException { RetryAfter: { } retryAfter })
        {
            return retryAfter > config.MaxDelay ? config.MaxDelay : retryAfter;
        }

        var baseMs = config.BaseDelay.TotalMilliseconds;
        var exponential = baseMs * Math.Pow(2, attempt + 1);
        var jitter = NextDouble() * baseMs;
        var totalMs = exponential + jitter;
        var delay = TimeSpan.FromMilliseconds(totalMs);

        return delay > config.MaxDelay ? config.MaxDelay : delay;
    }

    private static int? GetStatusCode(Exception ex) => ex switch
    {
        RateLimitException => RateLimitException.StatusCode,
        ServerException s => s.StatusCode,
        _ => null,
    };

    /// <summary>Parse an HTTP response and throw the appropriate exception if not successful.</summary>
    internal static LolzteamException CreateException(int statusCode, string? body, HttpResponseHeaders headers)
    {
        switch (statusCode)
        {
            case 429:
            {
                var retryAfter = ParseRetryAfter(headers);
                return new RateLimitException(retryAfter, "Rate limited (429).");
            }
            case >= 500 and <= 599:
            {
                return new ServerException(statusCode, body);
            }
            default:
            {
                return HttpApiException.Create(statusCode, body, headers);
            }
        }
    }

    private static TimeSpan? ParseRetryAfter(HttpResponseHeaders headers)
    {
        if (!headers.TryGetValues("Retry-After", out var vals))
            return null;

        var numbersStyle = System.Globalization.NumberStyles.Any;
        var dateTimeStyle = System.Globalization.DateTimeStyles.None;
        var culture = System.Globalization.CultureInfo.InvariantCulture;

        foreach (var v in vals)
        {
            if (double.TryParse(v, numbersStyle, culture, out var secs))
            {
                return TimeSpan.FromSeconds(secs);
            }

            if (!DateTimeOffset.TryParseExact(v, "r", culture, dateTimeStyle, out var date))
                continue;

            var diff = date - DateTimeOffset.UtcNow;
            return diff > TimeSpan.Zero ? diff : TimeSpan.Zero;
        }

        return null;
    }
}
