namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    /// <summary>
    /// Emit <c>WriteTo(Utf8JsonWriter)</c> inside an already-opened record body.
    /// Mirrors <see cref="EmitReadFromMethods"/> for the write side: no reflection, no <c>JsonSerializer</c>.
    /// </summary>
    private static void EmitWriteToMethod(CodeWriter w, List<WriteProperty> props, Dictionary<string, bool> enumIsInt)
    {
        w.Line()
            .Line("/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>")
            .Open("public void WriteTo(Utf8JsonWriter writer)")
            .Line("writer.WriteStartObject();");

        EmitWritePropertyLoop(w, props, enumIsInt);

        w.Line("writer.WriteEndObject();").Close();
    }

    /// <summary>
    /// Emit one <c>WritePropertyName</c> + value statement per property, guarded by a null-check for
    /// optional ones. Does not emit <c>WriteStartObject</c>/<c>WriteEndObject</c> so callers can write
    /// extra fields first (e.g. a discriminated-union tag).
    /// </summary>
    private static void EmitWritePropertyLoop(CodeWriter w, List<WriteProperty> props, Dictionary<string, bool> enumIsInt)
    {
        foreach (var prop in props)
        {
            var type = CsharpType.Parse(prop.DeclaredType);
            if (type is not CsharpType.Nullable optional)
            {
                w.Line($"writer.WritePropertyName(\"{prop.JsonName}\"u8);");
                EmitWriteValue(w, prop.PropName, type, enumIsInt);
                continue;
            }

            w.Open($"if ({prop.PropName} is not null)")
                .Line($"writer.WritePropertyName(\"{prop.JsonName}\"u8);");

            var expr = IsWriteValueType(optional.Inner, enumIsInt) ? $"{prop.PropName}.Value" : prop.PropName;
            EmitWriteValue(w, expr, optional.Inner, enumIsInt);
            w.Close();
        }
    }

    /// <summary>
    /// Emit a single value-writing statement for <paramref name="expr"/> (already known non-null) of
    /// <paramref name="type"/>. Recurses into <c>List&lt;T&gt;</c> and <c>Dictionary&lt;string, T&gt;</c>.
    /// </summary>
    private static void EmitWriteValue(
        CodeWriter w, string expr, CsharpType type, Dictionary<string, bool> enumIsInt, int depth = 0)
    {
        if (type is CsharpType.Primitive primitive)
        {
            switch (primitive.Name)
            {
                case "long":
                case "int":
                case "double":
                case "float":
                    w.Line($"writer.WriteNumberValue({expr});");
                    return;
                case "bool":
                    w.Line($"writer.WriteBooleanValue({expr});");
                    return;
                case "string":
                    w.Line($"writer.WriteStringValue({expr});");
                    return;
                case "byte[]":
                    w.Line($"writer.WriteBase64StringValue({expr});");
                    return;
                case "JsonElement":
                case "Lolzteam.Api.Runtime.StringOrLong":
                case "StringOrLong":
                    w.Line($"{expr}.WriteTo(writer);");
                    return;
            }

            if (enumIsInt.TryGetValue(primitive.Name, out var isInt))
            {
                w.Line(isInt
                    ? $"writer.WriteNumberValue((long){expr});"
                    : $"writer.WriteStringValue({expr}.ToJsonValue());");
                return;
            }

            // Query/body properties never resolve to a named component type, so this branch should be
            // unreachable in practice. Kept as a defensive fallback that fails at codegen build time
            // (missing WriteTo method) rather than silently emitting wrong JSON.
            w.Line($"{expr}.WriteTo(writer);");
            return;
        }

        if (type is CsharpType.List list)
        {
            var itemVar = $"__w{DepthSuffix(depth)}";
            var itemExpr = WriteElementExpr(itemVar, list.Item, enumIsInt);

            w.Line("writer.WriteStartArray();")
                .Open($"foreach (var {itemVar} in {expr})");
            EmitWriteValue(w, itemExpr, list.Item.Unwrap(), enumIsInt, depth + 1);
            w.Close()
                .Line("writer.WriteEndArray();");
            return;
        }

        if (type is CsharpType.Map map)
        {
            var kvpVar = $"__wkv{DepthSuffix(depth)}";
            var valExpr = WriteElementExpr($"{kvpVar}.Value", map.Value, enumIsInt);

            w.Line("writer.WriteStartObject();")
                .Open($"foreach (var {kvpVar} in {expr})")
                .Line($"writer.WritePropertyName({kvpVar}.Key);");
            EmitWriteValue(w, valExpr, map.Value.Unwrap(), enumIsInt, depth + 1);
            w.Close()
                .Line("writer.WriteEndObject();");
            return;
        }

        throw new InvalidOperationException($"Cannot write C# type '{type.Render()}'.");
    }

    /// <summary>
    /// Expression for one list item or dictionary value. Nullable value types use <c>GetValueOrDefault()</c>
    /// because items are not null-checked one by one.
    /// </summary>
    private static string WriteElementExpr(string access, CsharpType elementType, Dictionary<string, bool> enumIsInt)
    {
        if (elementType is CsharpType.Nullable nullable && IsWriteValueType(nullable.Inner, enumIsInt))
            return $"{access}.GetValueOrDefault()";

        return access;
    }

    /// <summary>True when a nullable value must be unwrapped with <c>.Value</c> before writing.</summary>
    private static bool IsWriteValueType(CsharpType type, Dictionary<string, bool> enumIsInt)
    {
        if (type is not CsharpType.Primitive primitive)
            return false;

        if (JsonScalars.IsStruct(primitive.Name))
            return true;

        return enumIsInt.ContainsKey(primitive.Name);
    }

    /// <summary>Build a TypeName-to-IsIntEnum lookup for <see cref="EmitWriteValue"/>.</summary>
    private static Dictionary<string, bool> BuildEnumIsIntLookup(List<EnumDefinition>? enumDefs)
    {
        var lookup = new Dictionary<string, bool>();
        if (enumDefs is null) return lookup;

        foreach (var def in enumDefs)
            lookup[def.TypeName] = def.IsIntEnum;

        return lookup;
    }

    /// <summary>Declared C# type for a query/body property, matching <see cref="EmitPropertyDecl"/>.</summary>
    private static string ComputeDeclaredType(string csharpType, bool required) =>
        required ? csharpType : MakeNullable(csharpType);
}
