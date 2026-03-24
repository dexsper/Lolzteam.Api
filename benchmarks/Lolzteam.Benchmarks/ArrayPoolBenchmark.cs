using System.Buffers;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Compares three deserialization strategies end-to-end through <see cref="LolzteamHttpClient"/>:
///
/// <list type="number">
///   <item><b>ReadFrom (typed)</b> — new path: bytes go directly to the generated
///     <c>ReadFromReader(ref Utf8JsonReader)</c> method. No <c>JsonDocument</c>, no
///     intermediate tree, no <c>Clone()</c>. One pass: bytes → managed record.</item>
///   <item><b>JsonElement (ArrayPool)</b> — legacy path with <c>Content-Length</c>:
///     rented buffer → <c>JsonDocument.Parse</c> → <c>Clone()</c>.
///     Two copies: buffer + cloned element tree.</item>
///   <item><b>JsonElement (Stream)</b> — legacy path without <c>Content-Length</c>:
///     <c>MemoryStream</c> buffer → <c>JsonDocument.ParseAsync</c> → <c>Clone()</c>.</item>
/// </list>
///
/// A simple ad-hoc response record <c>BenchResponse</c> is used so all three paths
/// exercise equivalent work.  Payload sizes match realistic Lolzteam API responses.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(BenchmarkConfig))]
public class ArrayPoolBenchmark : IDisposable
{
    [Params(1, 16, 64)]
    public int PayloadKb { get; set; }

    private LolzteamHttpClient? _clientWithContentLength;
    private LolzteamHttpClient? _clientChunked;
    private static readonly RequestOptions Opts = new() { Method = "GET", Path = "/bench" };

    /// <summary>Mirrors the shape of the payload produced by <see cref="BuildPayload"/>.</summary>
    public sealed record BenchResponse(long Total)
    {
        public static BenchResponse ReadFrom(ReadOnlyMemory<byte> json)
        {
            var reader = new Utf8JsonReader(json.Span);
            reader.Read(); // StartObject
            return ReadFromReader(ref reader);
        }

        internal static BenchResponse ReadFromReader(ref Utf8JsonReader reader)
        {
            long v0 = default;
            while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
            {
                if (reader.TokenType != JsonTokenType.PropertyName) continue;
                if (reader.ValueTextEquals("total"u8))
                {
                    reader.Read();
                    v0 = reader.GetInt64();
                }
                else { reader.Read(); reader.Skip(); }
            }
            return new BenchResponse(v0);
        }
    }

    /// <summary>Responds with <c>Content-Length</c> set → ArrayPool fast path.</summary>
    private sealed class ContentLengthHandler(byte[] body) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage _, CancellationToken __)
        {
            var content = new ByteArrayContent(body);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json")
            {
                CharSet = "utf-8",
            };
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = content });
        }
    }

    /// <summary>Responds without <c>Content-Length</c> (simulates chunked) → stream fallback.</summary>
    private sealed class ChunkedHandler(byte[] body) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage _, CancellationToken __)
        {
            var content = new StreamContent(new System.IO.MemoryStream(body));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json")
            {
                CharSet = "utf-8",
            };
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = content });
        }
    }

    [GlobalSetup]
    public void Setup()
    {
        var body = BuildPayload(PayloadKb * 1024);

        var config = new ClientConfig { Token = "bench", BaseUrl = "http://bench.test" };

        _clientWithContentLength = new LolzteamHttpClient(
            config.WithHttpClient(new HttpClient(new ContentLengthHandler(body))));

        _clientChunked = new LolzteamHttpClient(
            config.WithHttpClient(new HttpClient(new ChunkedHandler(body))));
    }

    [GlobalCleanup]
    public void Cleanup() => Dispose();

    public void Dispose()
    {
        _clientWithContentLength?.Dispose();
        _clientChunked?.Dispose();
        GC.SuppressFinalize(this);
    }

    /// <summary>Bytes → <c>ReadFromReader</c> → typed record. No <c>JsonDocument</c>, no <c>Clone()</c>.</summary>
    [Benchmark(Baseline = true)]
    public async Task<BenchResponse> ReadFrom_typed()
        => await _clientWithContentLength!.RequestAsync(Opts, BenchResponse.ReadFrom);

    /// <summary>JsonElement path with known <c>Content-Length</c>: ArrayPool buffer → <c>JsonDocument.Parse</c> → <c>Clone()</c>.</summary>
    [Benchmark]
    public async Task<JsonElement> JsonElement_ArrayPool_path()
        => await _clientWithContentLength!.RequestAsync(Opts);

    /// <summary>JsonElement path without <c>Content-Length</c> (chunked): <c>MemoryStream</c> → <c>JsonDocument.ParseAsync</c> → <c>Clone()</c>.</summary>
    [Benchmark]
    public async Task<JsonElement> JsonElement_Stream_path()
        => await _clientChunked!.RequestAsync(Opts);

    private static byte[] BuildPayload(int targetBytes)
    {
        var sb = new StringBuilder(targetBytes + 256);
        sb.Append("{\"items\":[");
        var i = 0;
        while (sb.Length < targetBytes - 64)
        {
            if (i > 0) sb.Append(',');
            sb.Append(CultureInfo.InvariantCulture,
                $"{{\"id\":{i},\"title\":\"Item {i}\",\"price\":{i * 1.5},\"active\":true}}");
            i++;
        }
        sb.Append(CultureInfo.InvariantCulture, $"],\"total\":{i}}}");
        return Encoding.UTF8.GetBytes(sb.ToString());
    }
}
