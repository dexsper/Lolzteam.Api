using BenchmarkDotNet.Running;
using Lolzteam.Benchmarks;

BenchmarkSwitcher.FromAssembly(typeof(DeserializationBenchmark).Assembly).Run(args);
