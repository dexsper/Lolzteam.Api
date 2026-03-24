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

        var entries = CollectSchemaEntries(propsObj, rawSpec, componentSchemaNames, name, nestedRecords, requiredSet);
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
                rawSpec,
                componentSchemaNames,
                typeName,
                nestedRecords,
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
    private static void EmitPositionalRecord(
        CodeWriter w, string typeName,
        List<(string jsonName, string csharpType, bool required)> entries)
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
            var (jsonName, csharpType, required) = entries[i];
            var propName = DeduplicateName(Naming.SafeCSharpName(jsonName), seen);
            var typeStr = required ? csharpType : MakeNullable(csharpType);
            var comma = i < entries.Count - 1 ? "," : "";
            w.Line($"[property: JsonPropertyName(\"{jsonName}\")] {typeStr} {propName}{comma}");
        }

        w.Pop().Open(")");
        EmitReadFromMethods(w, typeName, entries.ConvertAll(e => (e.jsonName, e.csharpType)));
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

    private static List<(string jsonName, string csharpType, bool required)> CollectSchemaEntries(
        JsonObject propsObj, JsonNode rawSpec, HashSet<string> componentSchemaNames,
        string parentTypeName, List<string> nestedRecords, HashSet<string> requiredSet)
    {
        var entries = new List<(string, string, bool)>();
        foreach (var kvp in propsObj)
        {
            if (kvp.Value is null) continue;
            var csharpType = ResolveComponentPropertyType(
                kvp.Value, rawSpec, componentSchemaNames, parentTypeName, kvp.Key, nestedRecords);
            entries.Add((kvp.Key, csharpType, requiredSet.Contains(kvp.Key)));
        }

        return entries;
    }

    /// <summary>
    /// Resolve the C# type for a property within a component schema or response record.
    /// Handles <c>$ref</c>, arrays, multi-type fields (<c>StringOrLong</c>), inline objects,
    /// and primitive scalars. Inline objects emit a nested record and are added to
    /// <paramref name="nestedRecords"/> for emission after the parent.
    /// </summary>
    private static string ResolveComponentPropertyType(
        JsonNode schema, JsonNode rawSpec, HashSet<string> componentSchemaNames,
        string? parentTypeName = null, string? propName = null, List<string>? nestedRecords = null)
    {
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
                return ResolveComponentPropertyType(
                    resolved,
                    rawSpec,
                    componentSchemaNames,
                    parentTypeName,
                    propName,
                    nestedRecords);
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

            return nonNull is ["integer", "string"]
                ? "Lolzteam.Api.Runtime.StringOrLong"
                : "JsonElement";
        }

        string? type = null;
        if (typeEl is JsonValue typeVal && typeVal.TryGetValue<string>(out var tv))
            type = tv;

        if (type == "array")
        {
            var items = sObj["items"];
            if (items is not null)
            {
                var itemType = ResolveComponentPropertyType(items, rawSpec, componentSchemaNames, parentTypeName,
                    propName, nestedRecords);
                return $"List<{itemType}>";
            }

            return "List<JsonElement>";
        }

        if (type == "object" || sObj["properties"] is not null)
        {
            if (sObj["properties"] is not JsonObject { Count: > 0 } innerProps
                || parentTypeName is null || propName is null ||
                nestedRecords is null)
                return "JsonElement";

            var nestedName = parentTypeName + Naming.SnakeToPascal(Naming.SanitizeName(propName));
            var nestedRequired = CollectRequiredSet(sObj);
            var nestedEntries = CollectSchemaEntries(
                innerProps,
                rawSpec,
                componentSchemaNames,
                nestedName,
                nestedRecords,
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
