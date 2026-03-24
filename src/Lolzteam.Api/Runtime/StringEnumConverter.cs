using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Runtime;

/// <summary>Marks an enum member with its JSON string value.</summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class EnumValueAttribute : Attribute
{
    /// <summary>The JSON string that represents this enum member.</summary>
    public string Value { get; }

    /// <summary>Create an <see cref="EnumValueAttribute"/> with the given JSON string.</summary>
    public EnumValueAttribute(string value) => Value = value;
}

/// <summary>
/// JSON converter for string-backed enums decorated with <see cref="EnumValueAttribute"/>.
/// Zero reflection at deserialization time — reads string and compares.
/// </summary>
public sealed class StringEnumConverter<T> : JsonConverter<T> where T : struct, Enum
{
    private static readonly (string json, T value)[] Map = BuildMap();

    private static (string json, T value)[] BuildMap()
    {
        var fields = typeof(T).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        var result = new (string, T)[fields.Length];
        for (var i = 0; i < fields.Length; i++)
        {
            var f = fields[i];
            var attr = (EnumValueAttribute?)Attribute.GetCustomAttribute(f, typeof(EnumValueAttribute));
            var jsonName = attr?.Value ?? f.Name;
            result[i] = (jsonName, (T)f.GetValue(null)!);
        }
        return result;
    }

    /// <inheritdoc />
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return default;

        if (reader.TokenType != JsonTokenType.String)
            return default;

        foreach (var (json, value) in Map)
        {
            if (reader.ValueTextEquals(json))
                return value;
        }

        return default;
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        foreach (var (json, v) in Map)
        {
            if (!EqualityComparer<T>.Default.Equals(v, value))
                continue;

            writer.WriteStringValue(json);
            return;
        }
        writer.WriteStringValue(value.ToString());
    }
}
