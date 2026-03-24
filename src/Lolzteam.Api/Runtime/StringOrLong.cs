using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Runtime;

/// <summary>
/// Discriminated union for OpenAPI fields typed as ["string", "integer"].
/// Avoids boxing via struct + implicit conversions.
/// </summary>
[JsonConverter(typeof(StringOrLongConverter))]
public readonly struct StringOrLong : IEquatable<StringOrLong>
{
    private readonly string? _str;
    private readonly long _long;
    private readonly bool _isLong;

    private StringOrLong(string value) { _str = value; _isLong = false; }
    private StringOrLong(long value) { _long = value; _isLong = true; }

    /// <summary>True if the value is a string.</summary>
    public bool IsString => !_isLong;

    /// <summary>True if the value is a long integer.</summary>
    public bool IsLong => _isLong;

    /// <summary>Return the value as string (converts long to string if needed).</summary>
    public string? AsString() => _isLong ? _long.ToString(CultureInfo.InvariantCulture) : _str;

    /// <summary>Return the value as long. Throws if the value is a string.</summary>
    public long AsLong() => _isLong ? _long : throw new InvalidOperationException("Value is a string, not a long.");

    /// <summary>Implicitly create from string.</summary>
    public static implicit operator StringOrLong(string value) => new(value);

    /// <summary>Implicitly create from long.</summary>
    public static implicit operator StringOrLong(long value) => new(value);

    /// <summary>
    /// Read directly from a <see cref="Utf8JsonReader"/> — no JsonDocument, no string intermediate.
    /// Used by the generated <c>ReadFromReader</c> methods.
    /// </summary>
    public static StringOrLong ReadFrom(ref Utf8JsonReader reader)
    {
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out var l))
            return l;

        if (reader.TokenType == JsonTokenType.String)
            return reader.GetString() ?? string.Empty;

        return default;
    }

    /// <inheritdoc />
    public bool Equals(StringOrLong v) => _isLong == v._isLong && (_isLong ? _long == v._long : _str == v._str);

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is StringOrLong o && Equals(o);

    /// <inheritdoc />
    public override int GetHashCode() => _isLong ? _long.GetHashCode() : (_str?.GetHashCode() ?? 0);

    /// <inheritdoc />
    public override string ToString() => AsString() ?? string.Empty;

    /// <summary>Equality operator.</summary>
    public static bool operator ==(StringOrLong left, StringOrLong right) => left.Equals(right);

    /// <summary>Inequality operator.</summary>
    public static bool operator !=(StringOrLong left, StringOrLong right) => !left.Equals(right);
}

internal sealed class StringOrLongConverter : JsonConverter<StringOrLong>
{
    public override StringOrLong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetInt64(out var l))
            return l;

        if (reader.TokenType == JsonTokenType.String)
            return reader.GetString() ?? string.Empty;

        return default;
    }

    public override void Write(Utf8JsonWriter writer, StringOrLong value, JsonSerializerOptions options)
    {
        if (value.IsLong) writer.WriteNumberValue(value.AsLong());
        else writer.WriteStringValue(value.AsString());
    }
}
