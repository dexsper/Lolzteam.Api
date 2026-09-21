namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    /// <summary>
    /// Emit <c>ReadFrom(ReadOnlyMemory&lt;byte&gt;)</c> and <c>ReadFromReader(ref Utf8JsonReader)</c>
    /// inside an already-opened record body.
    /// Zero reflection, no <c>JsonDocument</c> in the happy path.
    /// </summary>
    private static void EmitReadFromMethods(
        CodeWriter w, string typeName,
        List<(string jsonName, string csharpType, bool required)> props)
    {
        w.Line()
            .Line("/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>")
            .Open($"public static {typeName} ReadFrom(ReadOnlyMemory<byte> json)")
            .Line("var reader = new Utf8JsonReader(json.Span);")
            .Line("reader.Read(); // advance to StartObject")
            .Line("return ReadFromReader(ref reader);")
            .Close()
            .Line()
            .Open($"internal static {typeName} ReadFromReader(ref Utf8JsonReader reader)");

        // One local variable per property.
        // Index prefix (v0, v1, …) guarantees uniqueness even when SafeCSharpName produces collisions.
        for (var pi = 0; pi < props.Count; pi++)
        {
            var (_, csharpType, required) = props[pi];
            var declared = required ? csharpType : MakeNullable(csharpType);
            var init = required && !IsJsonStruct(csharpType) ? "null!" : "default";
            w.Line($"{declared} v{pi} = {init};");
        }

        w.Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)")
            .Line("if (reader.TokenType != JsonTokenType.PropertyName) continue;")
            .Line();

        var first = true;
        for (var pi = 0; pi < props.Count; pi++)
        {
            var (jsonName, csharpType, required) = props[pi];
            var keyword = first ? "if" : "else if";
            w.Open($"{keyword} (reader.ValueTextEquals(\"{jsonName}\"u8))")
                .Line("reader.Read();");

            EmitReadValueInto(w, $"v{pi}", csharpType, required);
            w.Close();
            first = false;
        }

        if (!first) // at least one property matched — add skip-unknown fallback
        {
            w.Open("else")
                .Line("reader.Read();")
                .Line("reader.Skip();")
                .Close();
        }

        w.Close();
        var args = string.Join(", ", Enumerable.Range(0, props.Count).Select(i => "v" + i));
        w.Line($"return new {typeName}({args});").Close();
    }

    /// <summary>
    /// Emit <c>localName = &lt;read expression&gt;;</c> for the given C# type,
    /// handling nullability, primitives, <c>StringOrLong</c>, nested records, and <c>List&lt;T&gt;</c>.
    /// </summary>
    private static void EmitReadValueInto(CodeWriter w, string localName, string csharpType, bool required)
    {
        string? scalarExpr = csharpType switch
        {
            "long" or "int" => "reader.GetInt64()",
            "double" or "float" => "reader.GetDouble()",
            "bool" => "reader.GetBoolean()",
            "string" => required ? "reader.GetString()!" : "reader.GetString()",
            "Lolzteam.Api.Runtime.StringOrLong" or "StringOrLong" =>
                "Lolzteam.Api.Runtime.StringOrLong.ReadFrom(ref reader)",
            "JsonElement" => "JsonDocument.ParseValue(ref reader).RootElement.Clone()",
            _ => null,
        };

        if (scalarExpr is not null)
        {
            if (!required && IsJsonStruct(csharpType))
            {
                w.Open("if (reader.TokenType == JsonTokenType.Null)")
                    .Line($"{localName} = null;")
                    .Close()
                    .Open("else")
                    .Line($"{localName} = {scalarExpr};")
                    .Close();
                return;
            }

            w.Line($"{localName} = {scalarExpr};");
            return;
        }

        if (csharpType.StartsWith("List<") && csharpType.EndsWith('>'))
        {
            var itemType = csharpType[5..^1];
            w.Open("if (reader.TokenType == JsonTokenType.StartArray)")
                .Line($"var __lst = new {csharpType}();")
                .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)");

            EmitInlineListItem(w, itemType);

            w.Line("__lst.Add(__item);")
                .Close()
                .Line($"{localName} = __lst;")
                .Close();
            return;
        }

        if (csharpType.StartsWith("Dictionary<string, ") && csharpType.EndsWith('>'))
        {
            var valType = csharpType["Dictionary<string, ".Length..^1];
            w.Open("if (reader.TokenType == JsonTokenType.StartObject)")
                .Line($"var __dict = new {csharpType}();")
                .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)")
                .Line("if (reader.TokenType != JsonTokenType.PropertyName) continue;")
                .Line("var __key = reader.GetString()!;")
                .Line("reader.Read();");

            EmitInlineDictValue(w, valType);

            w.Line("__dict[__key] = __val;")
                .Close()
                .Line($"{localName} = __dict;")
                .Close();
            return;
        }

        var nullLiteral = required ? "null!" : "null";
        w.Line(
            $"{localName} = reader.TokenType == JsonTokenType.Null ? {nullLiteral} : {csharpType}.ReadFromReader(ref reader);");
    }

    private static bool IsJsonStruct(string csharpType)
    {
        switch (csharpType)
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

    private static string DepthSuffix(int depth) => depth == 0 ? "" : depth.ToString();

    /// <summary>Emit a variable declaration for a list item at the given nesting depth.</summary>
    private static void EmitInlineListItem(CodeWriter w, string itemType, int depth = 0)
    {
        EmitInlineToken(w, itemType.TrimEnd('?'), $"__item{DepthSuffix(depth)}", depth);
    }

    /// <summary>Emit a variable declaration for a dictionary value at the given nesting depth.</summary>
    private static void EmitInlineDictValue(CodeWriter w, string valueType, int depth = 0)
    {
        EmitInlineToken(w, valueType.TrimEnd('?'), $"__val{DepthSuffix(depth)}", depth);
    }

    /// <summary>
    /// Emit a declaration + population for <paramref name="varName"/> of <paramref name="baseType"/>.
    /// Handles primitives (single line), <c>List&lt;T&gt;</c>, and <c>Dictionary&lt;string, T&gt;</c>
    /// recursively. <paramref name="depth"/> tracks nesting to generate unique variable names:
    /// depth 0 → <c>__item</c> / <c>__val</c>, depth 1 → <c>__item1</c> / <c>__val1</c>, etc.
    /// </summary>
    private static void EmitInlineToken(CodeWriter w, string baseType, string varName, int depth)
    {
        string? expr = baseType switch
        {
            "long" or "int" => "reader.GetInt64()",
            "double" or "float" => "reader.GetDouble()",
            "bool" => "reader.GetBoolean()",
            "string" => "reader.GetString()!",
            "Lolzteam.Api.Runtime.StringOrLong" or "StringOrLong" =>
                "Lolzteam.Api.Runtime.StringOrLong.ReadFrom(ref reader)",
            "JsonElement" => "JsonDocument.ParseValue(ref reader).RootElement.Clone()",
            _ when baseType.StartsWith("List<") && baseType.EndsWith('>') => null,
            _ when baseType.StartsWith("Dictionary<string, ") && baseType.EndsWith('>') => null,
            _ => $"{baseType}.ReadFromReader(ref reader)",
        };

        if (expr is not null)
        {
            w.Line($"var {varName} = {expr};");
            return;
        }

        if (baseType.StartsWith("List<") && baseType.EndsWith('>'))
        {
            var innerItemName = $"__item{DepthSuffix(depth + 1)}";
            var itemType = baseType[5..^1];

            w.Line($"var {varName} = new {baseType}();")
                .Open("if (reader.TokenType == JsonTokenType.StartArray)")
                .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)");

            EmitInlineListItem(w, itemType, depth + 1);
            w.Line($"{varName}.Add({innerItemName});").Close().Close();
            return;
        }

        var innerValName = $"__val{DepthSuffix(depth + 1)}";
        var valType = baseType["Dictionary<string, ".Length..^1];

        w.Line($"var {varName} = new {baseType}();")
            .Open("if (reader.TokenType == JsonTokenType.StartObject)")
            .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)")
            .Line("if (reader.TokenType != JsonTokenType.PropertyName) continue;")
            .Line($"var __key{DepthSuffix(depth)} = reader.GetString()!;")
            .Line("reader.Read();");

        EmitInlineDictValue(w, valType, depth + 1);
        w.Line($"{varName}[__key{DepthSuffix(depth)}] = {innerValName};").Close().Close();
    }
}
