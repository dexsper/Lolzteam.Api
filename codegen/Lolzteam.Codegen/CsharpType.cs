namespace Lolzteam.Codegen;

/// <summary>
/// C# type used by the emitters: a primitive or named type, a list, a string-keyed dictionary, or a nullable wrapper.
/// Parsed once so read/write code does not recover nullability with <c>TrimEnd('?')</c> or generic shape with <c>StartsWith</c>.
/// </summary>
internal abstract record CsharpType
{
    private CsharpType()
    {
    }

    internal sealed record Primitive(string Name) : CsharpType;

    internal sealed record List(CsharpType Item) : CsharpType;

    internal sealed record Map(CsharpType Value) : CsharpType;

    internal sealed record Nullable(CsharpType Inner) : CsharpType;

    /// <summary>Drop a single outer <c>?</c>. <c>List&lt;long?&gt;</c> stays a list of nullable longs.</summary>
    internal CsharpType Unwrap() => this is Nullable nullable ? nullable.Inner : this;

    internal string Render()
    {
        switch (this)
        {
            case Primitive primitive:
                return primitive.Name;
            case List list:
                return $"List<{list.Item.Render()}>";
            case Map map:
                return $"Dictionary<string, {map.Value.Render()}>";
            case Nullable nullable:
                return nullable.Inner.Render() + "?";
            default:
                throw new InvalidOperationException("Unknown C# type shape.");
        }
    }

    internal static CsharpType Parse(string type)
    {
        if (HasOuterNullableMarker(type))
            return new Nullable(Parse(type[..^1]));

        if (TryTakeGeneric(type, "List<", out var item))
            return new List(Parse(item));

        if (TryTakeGeneric(type, "Dictionary<string, ", out var value))
            return new Map(Parse(value));

        return new Primitive(type);
    }

    private static bool HasOuterNullableMarker(string type)
    {
        if (type.Length == 0 || type[^1] != '?')
            return false;

        return BracketDepth(type) == 0;
    }

    /// <summary>
    /// True when <paramref name="type"/> is exactly <paramref name="prefix"/> plus a balanced argument list closed by the final <c>&gt;</c>.
    /// </summary>
    private static bool TryTakeGeneric(string type, string prefix, out string inner)
    {
        inner = "";
        if (!type.StartsWith(prefix, StringComparison.Ordinal) || type[^1] != '>')
            return false;

        if (BracketDepth(type) != 0)
            return false;

        var depth = 0;
        var opened = false;
        for (var i = 0; i < type.Length - 1; i++)
        {
            if (type[i] == '<')
            {
                depth++;
                opened = true;
            }
            else if (type[i] == '>')
            {
                depth--;
            }

            // A '>' that closes the prefix before the final character means this is not one generic type.
            if (opened && depth == 0)
                return false;
        }

        inner = type[prefix.Length..^1];
        return true;
    }

    private static int BracketDepth(string type)
    {
        var depth = 0;
        foreach (var ch in type)
        {
            if (ch == '<') depth++;
            else if (ch == '>') depth--;
        }

        return depth;
    }
}

/// <summary>Scalar JSON types shared by the read and write emitters.</summary>
internal static class JsonScalars
{
    internal static bool IsStruct(string name)
    {
        switch (name)
        {
            case "long":
            case "int":
            case "double":
            case "float":
            case "bool":
            case "JsonElement":
            case "StringOrLong":
            case "Lolzteam.Api.Runtime.StringOrLong":
                return true;
            default:
                return false;
        }
    }

    /// <summary>Reader expression for a scalar, or <see langword="null"/> when <paramref name="name"/> is a list, dictionary, or named record.</summary>
    internal static string? ReadExpression(string name, bool required)
    {
        switch (name)
        {
            case "long":
            case "int":
                return "reader.GetInt64()";
            case "double":
            case "float":
                return "reader.GetDouble()";
            case "bool":
                return "reader.GetBoolean()";
            case "string":
                return required ? "reader.GetString()!" : "reader.GetString()";
            case "StringOrLong":
            case "Lolzteam.Api.Runtime.StringOrLong":
                return "Lolzteam.Api.Runtime.StringOrLong.ReadFrom(ref reader)";
            case "JsonElement":
                return "JsonDocument.ParseValue(ref reader).RootElement.Clone()";
            default:
                return null;
        }
    }
}
