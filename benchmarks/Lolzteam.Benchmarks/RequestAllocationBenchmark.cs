using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Compares the allocation profile of the pooled-handler path (new LolzteamHttpClient)
/// versus the naïve pattern of newing up an HttpClient per request.
///
/// Expected outcome: pooled path has near-zero per-call overhead in the transport layer;
/// naïve path pays a measurable cost per HttpClientHandler creation.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(BenchmarkConfig))]
public class RequestAllocationBenchmark : IDisposable
{
    private static readonly byte[] JsonBody =
        Encoding.UTF8.GetBytes("{\"ok\":true,\"value\":42,\"name\":\"bench\"}");

    private sealed class StubHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage _, CancellationToken __)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(JsonBody),
            };
            response.Content.Headers.ContentType =
                new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            return Task.FromResult(response);
        }
    }

    private LolzteamHttpClient? _pooledClient;
    private static readonly RequestOptions Opts =
        new() { Method = "GET", Path = "/bench" };

    [GlobalSetup]
    public void Setup()
    {
        var stub = new StubHandler();
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

    /// <summary>Single request through the pooled client — measures per-request overhead.</summary>
    [Benchmark(Baseline = true)]
    public async Task<JsonElement> Pooled_single_request()
        => await _pooledClient!.RequestAsync(Opts);

    /// <summary>Naïve pattern: create new HttpClient (and handler) on every call.</summary>
    [Benchmark]
    public static async Task<JsonElement> Naive_new_HttpClient_per_request()
    {
        using var handler = new StubHandler();
        using var httpClient = new HttpClient(handler) { BaseAddress = new System.Uri("http://bench.test") };
        using var request = new HttpRequestMessage(HttpMethod.Get, "/bench");
        request.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "bench");
        using var response = await httpClient.SendAsync(request);
        using var stream = await response.Content.ReadAsStreamAsync();
        using var doc = await JsonDocument.ParseAsync(stream);
        return doc.RootElement.Clone();
    }
}
