using BenchmarkDotNet.Running;
using Lolzteam.Benchmarks;

BenchmarkSwitcher.FromAssembly(typeof(DeserializationBenchmark).Assembly).RunAll();
