using System;
using System.Threading;
using System.Threading.Tasks;
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
    private static readonly RetryConfig Config = new RetryConfig
    {
        MaxRetries = 3,
        BaseDelay = TimeSpan.FromMilliseconds(100),
        MaxDelay = TimeSpan.FromSeconds(10),
    };

    [Benchmark(Baseline = true, Description = "Direct call (no retry wrapper)")]
    public static Task<int> DirectCall() => Task.FromResult(42);

    [Benchmark(Description = "Via retry pipeline (happy path)")]
    public static Task<int> ViaRetryPipeline() =>
        RetryHandler.ExecuteWithRetryAsync(
            ct => Task.FromResult(42),
            Config, null, "GET", "/", CancellationToken.None);
}
