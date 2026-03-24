using System.Text.Json;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// Abstraction over the Lolzteam HTTP transport.
/// Implement this interface to inject a mock or stub in tests,
/// swap implementations, or wrap with additional behavior (logging, tracing, etc.).
/// </summary>
public interface ILolzteamHttpClient : IDisposable
{
    /// <summary>Execute a request and return the raw JSON response as a <see cref="JsonElement"/>.</summary>
    Task<JsonElement> RequestAsync(RequestOptions options, CancellationToken cancellationToken = default);

    /// <summary>
    /// Execute a request and deserialize the response by calling <paramref name="deserializer"/>
    /// on the raw UTF-8 bytes — no <see cref="System.Text.Json.JsonDocument"/>, no reflection, AOT-safe.
    /// The bytes are only valid for the duration of the delegate call; copy any data you need.
    /// </summary>
    Task<T> RequestAsync<T>(
        RequestOptions options,
        Func<ReadOnlyMemory<byte>, T> deserializer,
        CancellationToken cancellationToken = default
    );

    /// <summary>Execute a request and return the raw response body as a string (e.g. HTML endpoints).</summary>
    Task<string> RequestRawAsync(RequestOptions options, CancellationToken cancellationToken = default);
}
