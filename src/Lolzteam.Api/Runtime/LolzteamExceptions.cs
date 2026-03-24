using System.Net.Http.Headers;

namespace Lolzteam.Api.Runtime;

/// <summary>Base exception for all Lolzteam API errors.</summary>
public abstract class LolzteamException : Exception
{
    /// <inheritdoc cref="Exception(string)"/>
    protected LolzteamException(string message) : base(message) { }

    /// <inheritdoc cref="Exception(string, Exception)"/>
    protected LolzteamException(string message, Exception inner) : base(message, inner) { }
}

/// <summary>HTTP error returned by the API (4xx / 5xx).</summary>
public sealed class HttpApiException : LolzteamException
{
    /// <summary>HTTP status code.</summary>
    public int StatusCode { get; }

    /// <summary>Raw response body.</summary>
    public string? ResponseBody { get; }

    /// <summary>Create an <see cref="HttpApiException"/> with an explicit status code, body, and message.</summary>
    public HttpApiException(int statusCode, string? responseBody, string message) : base(message)
    {
        StatusCode = statusCode;
        ResponseBody = responseBody;
    }

    internal static HttpApiException Create(int statusCode, string? body, HttpResponseHeaders headers)
    {
        var message = statusCode switch
        {
            400 => "Bad Request",
            401 => "Unauthorized — check your token.",
            403 => "Forbidden — insufficient permissions.",
            404 => "Not Found.",
            429 => BuildRateLimitMessage(headers),
            500 => "Internal Server Error.",
            502 => "Bad Gateway — try again later.",
            503 => "Service Unavailable — try again later.",
            504 => "Gateway Timeout — try again later.",
            _ => $"HTTP {statusCode}",
        };
        return new HttpApiException(statusCode, body, message);
    }

    private static string BuildRateLimitMessage(HttpResponseHeaders headers)
    {
        if (!headers.TryGetValues("Retry-After", out var vals))
            return "Too Many Requests — rate limited.";

        foreach (var v in vals)
            return $"Rate limited. Retry-After: {v}s.";

        return "Too Many Requests — rate limited.";
    }
}

/// <summary>Rate-limit error (HTTP 429) — contains parsed Retry-After if available.</summary>
public sealed class RateLimitException : LolzteamException
{
    /// <summary>Suggested retry delay parsed from Retry-After header, or null if not provided.</summary>
    public TimeSpan? RetryAfter { get; }

    /// <summary>Always 429.</summary>
    public static int StatusCode => 429;

    /// <summary>Create a <see cref="RateLimitException"/> with an optional retry delay and message.</summary>
    public RateLimitException(TimeSpan? retryAfter, string message) : base(message)
    {
        RetryAfter = retryAfter;
    }
}

/// <summary>Server-side error (5xx).</summary>
public sealed class ServerException : LolzteamException
{
    /// <summary>HTTP status code.</summary>
    public int StatusCode { get; }

    /// <summary>Raw response body.</summary>
    public string? ResponseBody { get; }

    /// <summary>Create a <see cref="ServerException"/> for the given status code and body.</summary>
    public ServerException(int statusCode, string? body) : base($"Server error {statusCode}.")
    {
        StatusCode = statusCode;
        ResponseBody = body;
    }
}

/// <summary>Network-level failure (connection refused, timeout, DNS, etc.).</summary>
public sealed class NetworkException : LolzteamException
{
    /// <summary>True if the error is likely transient and worth retrying.</summary>
    public bool IsTransient { get; }

    /// <summary>Create a <see cref="NetworkException"/> wrapping an inner exception.</summary>
    public NetworkException(string message, Exception inner, bool isTransient = true) : base(message, inner)
    {
        IsTransient = isTransient;
    }
}

/// <summary>All retry attempts exhausted.</summary>
public sealed class RetryExhaustedException : LolzteamException
{
    /// <summary>Number of attempts made (including the initial attempt).</summary>
    public int Attempts { get; }

    /// <summary>Create a <see cref="RetryExhaustedException"/> after exhausting all retries.</summary>
    public RetryExhaustedException(int attempts, Exception lastException) : base(
        $"Retry exhausted after {attempts} attempt(s). Last error: {lastException.Message}", lastException)
    {
        Attempts = attempts;
    }
}

/// <summary>Invalid or unsupported client configuration.</summary>
public sealed class ConfigException : LolzteamException
{
    /// <inheritdoc cref="Exception(string)"/>
    public ConfigException(string message) : base(message) { }
}
