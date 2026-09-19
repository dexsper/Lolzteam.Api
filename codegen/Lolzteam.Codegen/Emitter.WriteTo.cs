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
            var nullable = prop.DeclaredType.EndsWith('?');
            var baseType = prop.DeclaredType.TrimEnd('?');

            if (!nullable)
            {
                w.Line($"writer.WritePropertyName(\"{prop.JsonName}\"u8);");
                EmitWriteValue(w, prop.PropName, baseType, enumIsInt);
                continue;
            }

            w.Open($"if ({prop.PropName} is not null)")
                .Line($"writer.WritePropertyName(\"{prop.JsonName}\"u8);");

            var expr = IsWriteValueType(baseType, enumIsInt) ? $"{prop.PropName}.Value" : prop.PropName;
            EmitWriteValue(w, expr, baseType, enumIsInt);
            w.Close();
        }
    }

    /// <summary>
    /// Emit a single value-writing statement for <paramref name="expr"/> (already known non-null) of
    /// <paramref name="baseType"/>. Recurses into <c>List&lt;T&gt;</c> and <c>Dictionary&lt;string, T&gt;</c>.
    /// </summary>
    private static void EmitWriteValue(
        CodeWriter w, string expr, string baseType, Dictionary<string, bool> enumIsInt, int depth = 0)
    {
        switch (baseType)
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

        if (baseType.StartsWith("List<") && baseType.EndsWith('>'))
        {
            var itemTypeRaw = baseType[5..^1];
            var itemNullable = itemTypeRaw.EndsWith('?');
            var itemType = itemTypeRaw.TrimEnd('?');
            var itemVar = $"__w{DepthSuffix(depth)}";

            // Items aren't null-checked individually (same simplification as the ReadFrom side),
            // so use GetValueOrDefault() rather than .Value to avoid a nullable warning.
            var itemExpr = itemNullable && IsWriteValueType(itemType, enumIsInt)
                ? $"{itemVar}.GetValueOrDefault()"
                : itemVar;

            w.Line("writer.WriteStartArray();")
                .Open($"foreach (var {itemVar} in {expr})");
            EmitWriteValue(w, itemExpr, itemType, enumIsInt, depth + 1);
            w.Close()
                .Line("writer.WriteEndArray();");
            return;
        }

        if (baseType.StartsWith("Dictionary<string, ") && baseType.EndsWith('>'))
        {
            var valTypeRaw = baseType["Dictionary<string, ".Length..^1];
            var valNullable = valTypeRaw.EndsWith('?');
            var valType = valTypeRaw.TrimEnd('?');
            var kvpVar = $"__wkv{DepthSuffix(depth)}";
            var valExpr = valNullable && IsWriteValueType(valType, enumIsInt)
                ? $"{kvpVar}.Value.GetValueOrDefault()"
                : $"{kvpVar}.Value";

            w.Line("writer.WriteStartObject();")
                .Open($"foreach (var {kvpVar} in {expr})")
                .Line($"writer.WritePropertyName({kvpVar}.Key);");
            EmitWriteValue(w, valExpr, valType, enumIsInt, depth + 1);
            w.Close()
                .Line("writer.WriteEndObject();");
            return;
        }

        if (enumIsInt.TryGetValue(baseType, out var isInt))
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
    }

    /// <summary>True when the value is a nullable value type and must be unwrapped before writing.</summary>
    private static bool IsWriteValueType(string baseType, Dictionary<string, bool> enumIsInt) =>
        baseType is "long" or "int" or "double" or "float" or "bool" or "JsonElement"
            or "Lolzteam.Api.Runtime.StringOrLong" or "StringOrLong"
        || enumIsInt.ContainsKey(baseType);

    /// <summary>Build a TypeName-to-IsIntEnum lookup for <see cref="EmitWriteValue"/>.</summary>
    private static Dictionary<string, bool> BuildEnumIsIntLookup(List<EnumDefinition>? enumDefs)
    {
        var lookup = new Dictionary<string, bool>();
        if (enumDefs is null) return lookup;

        foreach (var def in enumDefs)
            lookup[def.TypeName] = def.IsIntEnum;

        return lookup;
    }

    /// <summary>Compute the effective declared C# type for a query/body property, matching <see cref="EmitPropertyDecl"/>.</summary>
    private static string ComputeDeclaredType(string csharpType, bool required, string? defaultLiteral)
    {
        if (required && defaultLiteral is null) return csharpType;
        if (defaultLiteral is not null) return required ? csharpType : MakeNullable(csharpType);
        return MakeNullable(csharpType);
    }
}
