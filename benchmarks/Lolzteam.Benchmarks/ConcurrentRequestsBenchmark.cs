using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Measures throughput of the <see cref="LolzteamHttpClient"/> under concurrent load,
/// and compares the pooled (shared handler) path against per-request HttpClient creation.
///
/// Key insight: under concurrency the pooled path avoids TIME_WAIT socket exhaustion and
/// handler creation overhead that would dominate in the naïve path.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(BenchmarkConfig))]
public class ConcurrentRequestsBenchmark : IDisposable
{
    private static readonly byte[] Body =
        Encoding.UTF8.GetBytes("{\"id\":1,\"status\":\"ok\"}");

    private sealed class AlwaysOkHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage _, CancellationToken __)
        {
            var r = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(Body),
            };
            r.Content.Headers.ContentType =
                new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            return Task.FromResult(r);
        }
    }

    private LolzteamHttpClient? _pooledClient;
    private static readonly RequestOptions Opts = new() { Method = "GET", Path = "/concurrent" };

    [Params(4, 16, 64)]
    public int Concurrency { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        var stub = new AlwaysOkHandler();
        var httpClient = new HttpClient(stub);
        var config = new ClientConfig { Token = "bench", BaseUrl = "http://bench.test" };
        _pooledClient = new LolzteamHttpClient(config.WithHttpClient(httpClient));
    }

    [GlobalCleanup]
    public void Cleanup() => Dispose();

    public void Dispose()
    {
        _pooledClient?.Dispose();
        GC.SuppressFinalize(this);
    }

    /// <summary>Fan-out N concurrent requests through the shared pooled client.</summary>
    [Benchmark(Baseline = true)]
    public Task Pooled_concurrent()
    {
        var tasks = Enumerable.Range(0, Concurrency)
            .Select(_ => _pooledClient!.RequestAsync(Opts));
        return Task.WhenAll(tasks);
    }

    /// <summary>Fan-out N concurrent requests, each creating its own HttpClient (naïve).</summary>
    [Benchmark]
    public Task Naive_concurrent()
    {
        var tasks = Enumerable.Range(0, Concurrency).Select(_ =>
        {
            var handler = new AlwaysOkHandler();
            var client = new HttpClient(handler) { BaseAddress = new Uri("http://bench.test") };
            using var req = new HttpRequestMessage(HttpMethod.Get, "/concurrent");
            return client.SendAsync(req).ContinueWith(t =>
            {
                client.Dispose();
                handler.Dispose();
                return t;
            }).Unwrap();
        });
        return Task.WhenAll(tasks);
    }
}
