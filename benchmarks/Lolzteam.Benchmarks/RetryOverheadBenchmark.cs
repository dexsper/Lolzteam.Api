#pragma warning disable CA1822 // BenchmarkDotNet requires instance (non-static) benchmark methods.
using BenchmarkDotNet.Attributes;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Measures the overhead of the retry pipeline on a clean (no-retry) response.
/// Should be near-zero allocations since no retry actually occurs.
/// </summary>
[MemoryDiagnoser]
public class RetryOverheadBenchmark
{
    private static readonly RetryConfig Config = new()
    {
        MaxRetries = 3,
        BaseDelay = TimeSpan.FromMilliseconds(100),
        MaxDelay = TimeSpan.FromSeconds(10),
    };

    [Benchmark(Baseline = true, Description = "Direct call (no retry wrapper)")]
    public Task<int> DirectCall() => Task.FromResult(42);

    [Benchmark(Description = "Via retry pipeline (happy path)")]
    public Task<int> ViaRetryPipeline() => RetryHandler.ExecuteWithRetryAsync(
        _ => Task.FromResult(42),
        Config, null, "GET", "/", CancellationToken.None
    );
}
