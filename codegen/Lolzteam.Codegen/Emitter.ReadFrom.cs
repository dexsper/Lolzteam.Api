namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    /// <summary>
    /// Emit <c>ReadFrom(ReadOnlyMemory&lt;byte&gt;)</c> and <c>ReadFromReader(ref Utf8JsonReader)</c>
    /// inside an already-opened record body.
    /// Zero reflection, no <c>JsonDocument</c> in the happy path.
    /// </summary>
    private static void EmitReadFromMethods(CodeWriter w, string typeName, List<RecordField> props)
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
            var field = props[pi];
            var declared = field.Required ? field.CSharpType : MakeNullable(field.CSharpType);
            var init = field.Required && !JsonScalars.IsStruct(field.CSharpType) ? "null!" : "default";
            w.Line($"{declared} v{pi} = {init};");
        }

        w.Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)")
            .Line("if (reader.TokenType != JsonTokenType.PropertyName) continue;")
            .Line();

        var first = true;
        for (var pi = 0; pi < props.Count; pi++)
        {
            var field = props[pi];
            var keyword = first ? "if" : "else if";
            w.Open($"{keyword} (reader.ValueTextEquals(\"{field.JsonName}\"u8))")
                .Line("reader.Read();");

            EmitReadValueInto(w, $"v{pi}", field.CSharpType, field.Required);
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
        EmitReadNode(w, localName, CsharpType.Parse(csharpType), required, csharpType);
    }

    private static void EmitReadNode(CodeWriter w, string localName, CsharpType type, bool required, string constructorType)
    {
        if (type is CsharpType.Primitive primitive && JsonScalars.ReadExpression(primitive.Name, required) is { } scalarExpr)
        {
            if (!required && JsonScalars.IsStruct(primitive.Name))
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

        if (type is CsharpType.List list)
        {
            w.Open("if (reader.TokenType == JsonTokenType.StartArray)")
                .Line($"var __lst = new {constructorType}();")
                .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)");

            EmitInlineToken(w, list.Item, "__item", 0);

            w.Line("__lst.Add(__item);")
                .Close()
                .Line($"{localName} = __lst;")
                .Close();
            return;
        }

        if (type is CsharpType.Map map)
        {
            w.Open("if (reader.TokenType == JsonTokenType.StartObject)")
                .Line($"var __dict = new {constructorType}();")
                .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)")
                .Line("if (reader.TokenType != JsonTokenType.PropertyName) continue;")
                .Line("var __key = reader.GetString()!;")
                .Line("reader.Read();");

            EmitInlineToken(w, map.Value, "__val", 0);

            w.Line("__dict[__key] = __val;")
                .Close()
                .Line($"{localName} = __dict;")
                .Close();
            return;
        }

        var nullLiteral = required ? "null!" : "null";
        w.Line(
            $"{localName} = reader.TokenType == JsonTokenType.Null ? {nullLiteral} : {constructorType}.ReadFromReader(ref reader);");
    }

    private static string DepthSuffix(int depth) => depth == 0 ? "" : depth.ToString();

    /// <summary>
    /// Emit a declaration + population for <paramref name="varName"/> of <paramref name="type"/>.
    /// List and dictionary items drop one outer nullable marker and are read as the underlying value,
    /// matching the existing generated readers. <paramref name="depth"/> keeps nested names unique:
    /// depth 0 → <c>__item</c> / <c>__val</c>, depth 1 → <c>__item1</c> / <c>__val1</c>.
    /// </summary>
    private static void EmitInlineToken(CodeWriter w, CsharpType type, string varName, int depth)
    {
        var concrete = type.Unwrap();
        if (concrete is CsharpType.Primitive primitive && JsonScalars.ReadExpression(primitive.Name, required: true) is { } expr)
        {
            w.Line($"var {varName} = {expr};");
            return;
        }

        var rendered = concrete.Render();
        if (concrete is CsharpType.List list)
        {
            var innerItemName = $"__item{DepthSuffix(depth + 1)}";
            w.Line($"var {varName} = new {rendered}();")
                .Open("if (reader.TokenType == JsonTokenType.StartArray)")
                .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)");

            EmitInlineToken(w, list.Item, innerItemName, depth + 1);
            w.Line($"{varName}.Add({innerItemName});").Close().Close();
            return;
        }

        if (concrete is CsharpType.Map map)
        {
            var innerValName = $"__val{DepthSuffix(depth + 1)}";
            w.Line($"var {varName} = new {rendered}();")
                .Open("if (reader.TokenType == JsonTokenType.StartObject)")
                .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)")
                .Line("if (reader.TokenType != JsonTokenType.PropertyName) continue;")
                .Line($"var __key{DepthSuffix(depth)} = reader.GetString()!;")
                .Line("reader.Read();");

            EmitInlineToken(w, map.Value, innerValName, depth + 1);
            w.Line($"{varName}[__key{DepthSuffix(depth)}] = {innerValName};").Close().Close();
            return;
        }

        w.Line($"var {varName} = {rendered}.ReadFromReader(ref reader);");
    }
}
