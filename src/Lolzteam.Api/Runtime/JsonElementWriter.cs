#if NET6_0_OR_GREATER
using System.Buffers;
#endif
using System.Text.Json;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// Builds a <see cref="JsonElement"/> from a hand-written <see cref="Utf8JsonWriter"/> callback.
/// Used by generated request-serialization code instead of <c>JsonSerializer.SerializeToElement&lt;T&gt;</c>,
/// which needs reflection-based type metadata that is unavailable when reflection-based JSON is disabled
/// (the default under Native AOT). The callback itself (generated <c>WriteTo</c> methods,
/// <c>JsonElement.WriteTo</c>, <c>JsonNode.WriteTo</c>) never uses reflection.
/// </summary>
public static class JsonElementWriter
{
    /// <summary>Invoke <paramref name="write"/> and parse the resulting bytes into a <see cref="JsonElement"/>.</summary>
    public static JsonElement Build(Action<Utf8JsonWriter> write)
    {
#if NET6_0_OR_GREATER
        var buffer = new ArrayBufferWriter<byte>();
        using (var writer = new Utf8JsonWriter(buffer))
        {
            write(writer);
            writer.Flush();
        }

        using var document = JsonDocument.Parse(buffer.WrittenMemory);
#else
        // ArrayBufferWriter<T> is internal in the netstandard2.0/2.1 System.Memory shim.
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream))
        {
            write(writer);
            writer.Flush();
        }

        stream.Position = 0;
        using var document = JsonDocument.Parse(stream);
#endif
        return document.RootElement.Clone();
    }
}
