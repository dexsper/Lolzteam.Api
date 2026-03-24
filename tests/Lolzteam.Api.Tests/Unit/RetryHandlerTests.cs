using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

public sealed class RetryHandlerTests
{
    private static readonly RetryConfig FastConfig = new()
    {
        MaxRetries = 3,
        BaseDelay = TimeSpan.FromMilliseconds(1),
        MaxDelay = TimeSpan.FromMilliseconds(10),
    };

    [Fact]
    public async Task Succeeds_on_first_attempt_no_retry()
    {
        var calls = 0;
        var result = await RetryHandler.ExecuteWithRetryAsync(
            _ =>
            {
                calls++;
                return Task.FromResult(42);
            },
            FastConfig,
            null,
            "GET",
            "/test",
            CancellationToken.None
        );

        result.Should().Be(42);
        calls.Should().Be(1);
    }

    [Fact]
    public async Task Retries_on_429_then_succeeds()
    {
        var attempts = 0;
        var result = await RetryHandler.ExecuteWithRetryAsync(
            _ =>
            {
                attempts++;
                return attempts < 2
                    ? throw new RateLimitException(TimeSpan.FromMilliseconds(1), "rate limit")
                    : Task.FromResult("ok");
            },
            FastConfig,
            null,
            "GET",
            "/",
            CancellationToken.None
        );

        result.Should().Be("ok");
        attempts.Should().Be(2);
    }

    [Fact]
    public async Task Retries_on_502_then_succeeds()
    {
        var attempts = 0;
        var result = await RetryHandler.ExecuteWithRetryAsync(
            _ =>
            {
                attempts++;
                return attempts < 3 ? throw new ServerException(502, null) : Task.FromResult(true);
            },
            FastConfig,
            null,
            "GET",
            "/",
            CancellationToken.None
        );

        result.Should().BeTrue();
        attempts.Should().Be(3);
    }

    [Fact]
    public async Task Throws_RetryExhausted_when_all_attempts_fail()
    {
        var attempts = 0;
        var act = async () => await RetryHandler.ExecuteWithRetryAsync(
            _ =>
            {
                attempts++;
                throw new ServerException(503, null);
#pragma warning disable CS0162
                return Task.FromResult(0);
#pragma warning restore CS0162
            },
            FastConfig, null, "GET", "/", CancellationToken.None);

        await act.Should().ThrowAsync<RetryExhaustedException>();
        attempts.Should().Be(FastConfig.MaxRetries + 1);
    }

    [Fact]
    public async Task Does_not_retry_on_400()
    {
        var attempts = 0;
        var act = async () => await RetryHandler.ExecuteWithRetryAsync(
            _ =>
            {
                attempts++;
                throw new HttpApiException(400, null, "Bad Request");
#pragma warning disable CS0162
                return Task.FromResult(0);
#pragma warning restore CS0162
            },
            FastConfig, null, "GET", "/", CancellationToken.None);

        await act.Should().ThrowAsync<HttpApiException>();
        attempts.Should().Be(1);
    }

    [Fact]
    public async Task Respects_cancellation()
    {
        using var cts = new CancellationTokenSource();
        await cts.CancelAsync();

        var act = async () => await RetryHandler.ExecuteWithRetryAsync(
            _ => Task.FromResult(0),
            FastConfig,
            null,
            "GET",
            "/",
            cts.Token
        );

        await act.Should().ThrowAsync<OperationCanceledException>();
    }

    [Fact]
    public async Task OnRetry_callback_receives_correct_context()
    {
        RetryContext? capturedCtx = null;
        var config = FastConfig with { MaxRetries = 1 };

        try
        {
            await RetryHandler.ExecuteWithRetryAsync<int>(
                _ => throw new RateLimitException(TimeSpan.FromMilliseconds(1), "test"),
                config,
                ctx => capturedCtx = ctx,
                "POST", "/test", CancellationToken.None
            );
        }
        catch (RetryExhaustedException)
        {
        }

        capturedCtx.Should().NotBeNull();
        capturedCtx!.StatusCode.Should().Be(429);
        capturedCtx.Method.Should().Be("POST");
        capturedCtx.Path.Should().Be("/test");
        capturedCtx.Attempt.Should().Be(1);
    }

    [Fact]
    public void IsRetryable_returns_true_for_retryable_codes()
    {
        RetryHandler.IsRetryable(new RateLimitException(null, "")).Should().BeTrue();
        RetryHandler.IsRetryable(new ServerException(502, null)).Should().BeTrue();
        RetryHandler.IsRetryable(new ServerException(503, null)).Should().BeTrue();
        RetryHandler.IsRetryable(new ServerException(504, null)).Should().BeTrue();
    }

    [Fact]
    public void IsRetryable_returns_false_for_non_retryable_codes()
    {
        RetryHandler.IsRetryable(new ServerException(500, null)).Should().BeFalse();
        RetryHandler.IsRetryable(new ServerException(501, null)).Should().BeFalse();
        RetryHandler.IsRetryable(new HttpApiException(400, null, "bad")).Should().BeFalse();
        RetryHandler.IsRetryable(new ConfigException("cfg")).Should().BeFalse();
    }

    [Fact]
    public void IsRetryable_returns_true_for_transient_network_exception()
    {
        var inner = new IOException("connection refused");
        var transient = new NetworkException("connection refused", inner, isTransient: true);
        var permanent = new NetworkException("bad gateway", inner, isTransient: false);
        RetryHandler.IsRetryable(transient).Should().BeTrue();
        RetryHandler.IsRetryable(permanent).Should().BeFalse();
    }

    [Fact]
    public async Task Retries_on_transient_network_exception()
    {
        var inner = new IOException("timeout");
        var attempts = 0;
        var result = await RetryHandler.ExecuteWithRetryAsync(
            _ =>
            {
                attempts++;
                return attempts < 2
                    ? throw new NetworkException("timeout", inner, isTransient: true)
                    : Task.FromResult("recovered");
            },
            FastConfig,
            null,
            "GET",
            "/net",
            CancellationToken.None
        );

        result.Should().Be("recovered");
        attempts.Should().Be(2);
    }

    [Fact]
    public void CreateException_429_parses_retry_after_delta_seconds()
    {
        var headers = new HttpResponseMessage().Headers;
        headers.TryAddWithoutValidation("Retry-After", "30");

        var ex = RetryHandler.CreateException(429, null, headers);

        ex.Should().BeOfType<RateLimitException>();
        ((RateLimitException)ex).RetryAfter.Should().BeCloseTo(
            TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(1)
        );
    }

    [Fact]
    public void CreateException_429_parses_retry_after_http_date()
    {
        var futureDate = DateTimeOffset.UtcNow.AddSeconds(60);
        var httpDate = futureDate.ToString("r"); // RFC1123 format, e.g. "Sun, 06 Nov 1994 08:49:37 GMT"

        var headers = new HttpResponseMessage().Headers;
        headers.TryAddWithoutValidation("Retry-After", httpDate);

        var ex = RetryHandler.CreateException(429, null, headers);

        ex.Should().BeOfType<RateLimitException>();
        ((RateLimitException)ex).RetryAfter.Should().BeGreaterThan(TimeSpan.FromSeconds(55));
    }

    [Fact]
    public void CreateException_429_with_no_retry_after_header()
    {
        var headers = new HttpResponseMessage().Headers;
        var ex = RetryHandler.CreateException(429, null, headers);

        ex.Should().BeOfType<RateLimitException>();
        ((RateLimitException)ex).RetryAfter.Should().BeNull();
    }

    [Fact]
    public void CreateException_503_returns_server_exception()
    {
        var headers = new HttpResponseMessage().Headers;
        var ex = RetryHandler.CreateException(503, "service unavailable", headers);

        ex.Should().BeOfType<ServerException>().Which.StatusCode.Should().Be(503);
    }

    [Fact]
    public void CreateException_400_returns_http_api_exception()
    {
        var headers = new HttpResponseMessage().Headers;
        var ex = RetryHandler.CreateException(400, "bad request", headers);

        ex.Should().BeOfType<HttpApiException>().Which.StatusCode.Should().Be(400);
    }

    [Fact]
    public async Task Max_delay_is_capped_correctly()
    {
        var config = new RetryConfig
        {
            MaxRetries = 2,
            BaseDelay = TimeSpan.FromMilliseconds(5000),
            MaxDelay = TimeSpan.FromMilliseconds(5)
        };

        var attempts = 0;
        var sw = System.Diagnostics.Stopwatch.StartNew();
        try
        {
            await RetryHandler.ExecuteWithRetryAsync(
                _ =>
                {
                    attempts++;
                    throw new ServerException(503, null);
#pragma warning disable CS0162
                    return Task.FromResult(0);
#pragma warning restore CS0162
                },
                config,
                null,
                "GET",
                "/cap",
                CancellationToken.None
            );
        }
        catch (RetryExhaustedException)
        {
        }

        sw.Stop();
        sw.Elapsed.Should().BeLessThan(TimeSpan.FromSeconds(2), "MaxDelay cap must prevent huge waits");
        attempts.Should().Be(3);
    }
}
