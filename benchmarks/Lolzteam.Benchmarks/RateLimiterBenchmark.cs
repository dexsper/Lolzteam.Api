using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Measures rate limiter throughput at high rates (so throttling is minimal).
/// Focus is on semaphore overhead and allocation profile.
/// </summary>
[MemoryDiagnoser]
public class RateLimiterBenchmark : IDisposable
{
    private readonly RateLimiter _limiter = new RateLimiter(6000);

    [Benchmark]
    public Task AcquireAsync() =>
        _limiter.AcquireAsync(CancellationToken.None);

    [GlobalCleanup]
    public void Cleanup() => Dispose();

    public void Dispose()
    {
        _limiter.Dispose();
        GC.SuppressFinalize(this);
    }
}
