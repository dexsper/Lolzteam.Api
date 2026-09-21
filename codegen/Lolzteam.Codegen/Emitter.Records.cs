using System.Text.Json.Nodes;

namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    private static void EmitComponentSchemaRecord(
        CodeWriter w, string name, JsonObject schema, JsonNode rawSpec,
        HashSet<string> componentSchemaNames)
    {
        var nestedRecords = new List<string>();
        var requiredSet = CollectRequiredSet(schema);

        if (schema["properties"] is not JsonObject propsObj || propsObj.Count == 0)
        {
            w.Line($"public sealed record {name}();");
            return;
        }

        var entries = CollectSchemaEntries(
            propsObj,
            new SchemaScope(rawSpec, componentSchemaNames, name, nestedRecords),
            requiredSet
        );

        EmitPositionalRecord(w, name, entries);
        foreach (var nested in nestedRecords)
            w.Line().Raw(nested);
    }

    private static void EmitResponseRecord(
        CodeWriter w, string group, MethodDefinition method, JsonNode rawSpec,
        HashSet<string> componentSchemaNames)
    {
        var typeName = $"{Naming.BuildTypeName(group, method.MethodName)}Response";
        if (method.ReturnsHtml)
        {
            w.Line($"public sealed record {typeName}(string Data);").Line();
            return;
        }

        if (method.RawResponseSchema is { } rawSchema && rawSchema["properties"] is JsonObject { Count: > 0 } propsObj)
        {
            var nestedRecords = new List<string>();
            var requiredSet = CollectRequiredSet(rawSchema);
            var entries = CollectSchemaEntries(
                propsObj,
                new SchemaScope(rawSpec, componentSchemaNames, typeName, nestedRecords),
                requiredSet
            );

            EmitPositionalRecord(w, typeName, entries);
            foreach (var nested in nestedRecords)
                w.Line().Raw(nested);

            w.Line();
            return;
        }

        var fallbackType = Transforms.ToCSharpType(method.ResponseType);
        w.Open($"public sealed record {typeName}({fallbackType} Data)");
        w.Line("/// <summary>Deserialize from raw UTF-8 JSON bytes.</summary>")
            .Open($"public static {typeName} ReadFrom(ReadOnlyMemory<byte> json)");

        if (fallbackType == "JsonElement")
        {
            w.Line("var reader = new Utf8JsonReader(json.Span);")
                .Line($"return new {typeName}(JsonDocument.ParseValue(ref reader).RootElement.Clone());");
        }
        else
        {
            w.Line($"return new {typeName}(System.Text.Json.JsonSerializer.Deserialize<{fallbackType}>(json.Span)!);");
        }

        w.Close().Close().Line();
    }

    /// <summary>
    /// Emit a <c>public sealed record T(…)</c> with generated
    /// <c>ReadFrom(ReadOnlyMemory&lt;byte&gt;)</c> and <c>ReadFromReader(ref Utf8JsonReader)</c> methods.
    /// </summary>
    private static void EmitPositionalRecord(CodeWriter w, string typeName, List<RecordField> entries)
    {
        if (entries.Count == 0)
        {
            w.Line($"public sealed record {typeName}();");
            return;
        }

        var seen = new HashSet<string>();
        w.Line($"public sealed record {typeName}(").Push();

        for (var i = 0; i < entries.Count; i++)
        {
            var field = entries[i];
            var propName = DeduplicateName(Naming.SafeCSharpName(field.JsonName), seen);
            var typeStr = field.Required ? field.CSharpType : MakeNullable(field.CSharpType);
            var comma = i < entries.Count - 1 ? "," : "";
            w.Line($"[property: JsonPropertyName(\"{field.JsonName}\")] {typeStr} {propName}{comma}");
        }

        w.Pop().Open(")");
        EmitReadFromMethods(w, typeName, entries);
        w.Close();
    }

    private static HashSet<string> CollectRequiredSet(JsonNode schema)
    {
        var set = new HashSet<string>();
        if (schema["required"] is not JsonArray arr)
            return set;

        foreach (var r in arr)
            set.Add(r!.GetValue<string>());

        return set;
    }

    private static List<RecordField> CollectSchemaEntries(JsonObject propsObj, SchemaScope scope,
        HashSet<string> requiredSet)
    {
        var entries = new List<RecordField>();
        foreach (var kvp in propsObj)
        {
            if (kvp.Value is null) continue;
            var csharpType = ResolveComponentPropertyType(kvp.Value, scope, kvp.Key);
            entries.Add(new RecordField(kvp.Key, csharpType, requiredSet.Contains(kvp.Key)));
        }

        return entries;
    }

    /// <summary>
    /// Resolve the C# type for a property within a component schema or response record.
    /// Handles <c>$ref</c>, arrays, multi-type fields (<c>StringOrLong</c>), inline objects,
    /// and primitive scalars. Inline objects emit a nested record onto <see cref="SchemaScope.NestedRecords"/>.
    /// </summary>
    private static string ResolveComponentPropertyType(JsonNode schema, SchemaScope scope, string? propName = null)
    {
        var rawSpec = scope.RawSpec;
        var parentTypeName = scope.ParentTypeName;
        var nestedRecords = scope.NestedRecords;
        var componentSchemaNames = scope.ComponentSchemaNames;

        if (schema is JsonObject refObj && refObj["$ref"] is JsonValue jv && jv.TryGetValue<string>(out var refStr))
        {
            if (refStr.StartsWith("#/components/schemas/"))
            {
                var schemaName = refStr["#/components/schemas/".Length..];
                if (componentSchemaNames.Contains(schemaName))
                    return schemaName;
            }

            var resolved = Transforms.ResolveRef(refStr, rawSpec);
            if (resolved is not null)
            {
                return ResolveComponentPropertyType(resolved, scope, propName);
            }
        }

        if (schema is not JsonObject sObj) return "JsonElement";

        var typeEl = sObj["type"];
        if (typeEl is JsonArray multiTypeArr)
        {
            var nonNull = multiTypeArr
                .Select(t => t!.GetValue<string>())
                .Where(t => t != "null")
                .OrderBy(t => t)
                .ToList();

            if (nonNull is ["integer", "string"])
                return "Lolzteam.Api.Runtime.StringOrLong";

            // Single non-null type combined with null → resolve as that base type
            // (nullability is applied by the caller via MakeNullable)
            if (nonNull.Count == 1)
            {
                return ResolveComponentPropertyType(new JsonObject { ["type"] = nonNull[0] }, scope, propName);
            }

            return "JsonElement";
        }

        string? type = null;
        if (typeEl is JsonValue typeVal && typeVal.TryGetValue<string>(out var tv))
            type = tv;

        if (type == "array")
        {
            var items = sObj["items"];
            if (items is not null)
            {
                var itemType = ResolveComponentPropertyType(items, scope, propName);
                return $"List<{itemType}>";
            }

            return "List<JsonElement>";
        }

        var properties = sObj["properties"];
        var additionalProps = sObj["additionalProperties"];

        if (type == "object" || properties is not null)
        {
            if (additionalProps is JsonObject additionalPropsSchema && properties is null or JsonObject { Count: 0 })
            {
                var valType = ResolveComponentPropertyType(additionalPropsSchema, scope, propName);
                return $"Dictionary<string, {valType}>";
            }

            if (properties is not JsonObject { Count: > 0 } innerProps)
                return "JsonElement";

            if (parentTypeName is null || propName is null || nestedRecords is null)
                return "JsonElement";

            var nestedName = parentTypeName + Naming.SnakeToPascal(Naming.SanitizeName(propName));
            var nestedRequired = CollectRequiredSet(sObj);
            var nestedEntries = CollectSchemaEntries(
                innerProps, scope with { ParentTypeName = nestedName },
                nestedRequired
            );

            var nw = new CodeWriter();
            EmitPositionalRecord(nw, nestedName, nestedEntries);
            nestedRecords.Add(nw.ToString());

            return nestedName;
        }

        if (type is not null)
        {
            return type switch
            {
                "string" => "string",
                "integer" => "long",
                "number" => "double",
                "boolean" => "bool",
                _ => "JsonElement",
            };
        }

        return sObj["enum"] is JsonArray ? "string" : "JsonElement";
    }
}
