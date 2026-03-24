using System.Diagnostics;
using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

public sealed class RateLimiterTests
{
    [Fact]
    public async Task Acquire_completes_immediately_for_first_call()
    {
        using var limiter = new RateLimiter(60);
        var sw = Stopwatch.StartNew();
        await limiter.AcquireAsync(CancellationToken.None);
        sw.Elapsed.Should().BeLessThan(TimeSpan.FromMilliseconds(50));
    }

    [Fact]
    public async Task Acquire_throttles_second_call()
    {
        using var limiter = new RateLimiter(60);
        await limiter.AcquireAsync(CancellationToken.None);

        var sw = Stopwatch.StartNew();
        await limiter.AcquireAsync(CancellationToken.None);
        sw.Elapsed.Should().BeGreaterThan(TimeSpan.FromMilliseconds(800));
    }

    [Fact]
    public async Task Acquire_respects_cancellation()
    {
        using var limiter = new RateLimiter(60); // 1 req/sec
        await limiter.AcquireAsync(CancellationToken.None); // consume first slot

        using var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(50));
        var act = async () => await limiter.AcquireAsync(cts.Token);
        await act.Should().ThrowAsync<OperationCanceledException>();
    }

    [Fact]
    public void Constructor_throws_for_invalid_rate()
    {
        var act = () => new RateLimiter(0);
        act.Should().Throw<ArgumentOutOfRangeException>();
    }
}
