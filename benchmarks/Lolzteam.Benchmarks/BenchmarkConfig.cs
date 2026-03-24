using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Shared BenchmarkDotNet configuration for all benchmarks in this assembly.
/// Enables memory diagnostics and adds allocation / GC columns so that every benchmark
/// automatically reports both throughput and allocation data.
/// </summary>
public sealed class BenchmarkConfig : ManualConfig
{
    public BenchmarkConfig()
    {
        AddDiagnoser(MemoryDiagnoser.Default);
        AddColumn(StatisticColumn.P95);
        Options |= ConfigOptions.JoinSummary;
    }
}
