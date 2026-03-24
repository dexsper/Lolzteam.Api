using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Transforms
{
    [GeneratedRegex(@"^Array<(.+)>$")]
    private static partial Regex ArrayTypePattern();

    /// <summary>Follow a JSON pointer path like #/components/schemas/Foo.</summary>
    internal static JsonNode? ResolveRef(string reference, JsonNode spec)
    {
        var parts = reference.TrimStart('#', '/').Split('/');
        var current = spec;
        foreach (var part in parts)
        {
            if (current is not JsonObject obj) return null;
            current = obj[part];
            if (current is null) return null;
        }

        return current;
    }

    /// <summary>Shallow $ref resolution.</summary>
    private static JsonNode DerefShallow(JsonNode value, JsonNode spec)
    {
        if (value is not JsonObject obj)
            return value;

        var refNode = obj["$ref"];
        if (refNode is not JsonValue jv || !jv.TryGetValue<string>(out var refStr))
            return value;

        var resolved = ResolveRef(refStr, spec);
        return resolved is not null ? DerefShallow(resolved, spec) : value;
    }

    /// <summary>Recursively resolve all $ref pointers.</summary>
    internal static JsonNode DerefDeep(JsonNode value, JsonNode spec, HashSet<string> visited)
    {
        switch (value)
        {
            case JsonObject obj:
            {
                var refNode = obj["$ref"];
                if (refNode is JsonValue jv && jv.TryGetValue<string>(out var refStr))
                {
                    if (visited.Contains(refStr))
                    {
                        return new JsonObject();
                    }

                    var newVisited = new HashSet<string>(visited) { refStr };
                    var resolved = ResolveRef(refStr, spec);
                    return resolved is null ? value : DerefDeep(resolved, spec, newVisited);
                }

                var result = new JsonObject();
                foreach (var kvp in obj)
                {
                    if (kvp.Value is null) continue;
                    result[kvp.Key] = DerefDeep(kvp.Value, spec, [..visited]);
                }

                return result;
            }
            case JsonArray arr:
            {
                var result = new JsonArray();
                foreach (var item in arr)
                {
                    if (item is null)
                    {
                        result.Add(null);
                        continue;
                    }

                    result.Add(DerefDeep(item, spec, [..visited]));
                }

                return result;
            }
            default:
            {
                return value.DeepClone();
            }
        }
    }

    /// <summary>Convert an OpenAPI schema to an intermediate type string.</summary>
    private static string SchemaToTypeString(JsonNode? schema, JsonNode spec)
    {
        if (schema is null) return "unknown";
        if (schema is JsonObject { Count: 0 }) return "unknown";

        if (schema is JsonObject refObj)
        {
            var refNode = refObj["$ref"];
            if (refNode is JsonValue jv && jv.TryGetValue<string>(out _))
            {
                var resolved = DerefShallow(schema, spec);
                return SchemaToTypeString(resolved, spec);
            }
        }

        if (schema is not JsonObject sObj) return "unknown";

        var enumValues = sObj["enum"];
        if (enumValues is JsonArray { Count: > 0 } enumArr)
        {
            var literals = new List<string>();
            foreach (var el in enumArr)
            {
                if (el is not JsonValue ev)
                    continue;

                if (ev.TryGetValue<string>(out var str))
                {
                    literals.Add("\"" + str.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"");
                    continue;
                }

                literals.Add(el.ToString());
            }

            if (literals.Count > 0) return string.Join(" | ", literals);
        }

        var oneOf = sObj["oneOf"];
        if (oneOf is JsonArray { Count: > 0 } oneOfArr)
        {
            var types = new List<string>();
            foreach (var item in oneOfArr) types.Add(SchemaToTypeString(item, spec));
            return string.Join(" | ", types);
        }

        var anyOf = sObj["anyOf"];
        if (anyOf is JsonArray { Count: > 0 } anyOfArr)
        {
            var types = new List<string>();
            foreach (var item in anyOfArr) types.Add(SchemaToTypeString(item, spec));
            return string.Join(" | ", types);
        }

        var allOf = sObj["allOf"];
        if (allOf is JsonArray { Count: > 0 } allOfArr)
        {
            var types = new List<string>();
            foreach (var item in allOfArr) types.Add(SchemaToTypeString(item, spec));
            return string.Join(" & ", types);
        }

        var typeEl = sObj["type"];
        if (typeEl is JsonArray typeArr)
        {
            var types = new List<string>();
            var hasNull = false;
            foreach (var t in typeArr)
            {
                var typeStr = t!.GetValue<string>();
                if (typeStr == "null")
                {
                    hasNull = true;
                }
                else
                {
                    types.Add(PrimitiveType(typeStr));
                }
            }

            var result = string.Join(" | ", types);
            return hasNull ? result + " | null" : result;
        }

        string? type = null;
        if (typeEl is JsonValue typeVal && typeVal.TryGetValue<string>(out var tv))
        {
            type = tv;
        }

        if (type == "array")
        {
            var itemType = SchemaToTypeString(sObj["items"], spec);
            return "Array<" + itemType + ">";
        }

        if (type == "object" || sObj["properties"] is not null)
        {
            var props = sObj["properties"];
            if (props is not null && props is JsonObject propsObj && propsObj.Count != 0)
                return "{}";

            var addlProps = sObj["additionalProperties"];
            if (addlProps is null || addlProps is JsonValue)
                return "Record<string, unknown>";

            var valType = SchemaToTypeString(addlProps, spec);
            return "Record<string, " + valType + ">";
        }

        if (type is not null) return PrimitiveType(type);

        return "unknown";
    }

    private static string PrimitiveType(string t) => t switch
    {
        "string" => "string",
        "integer" => "integer",
        "number" => "number",
        "boolean" => "boolean",
        "null" => "null",
        _ => "unknown",
    };

    /// <summary>Map intermediate type string to C# type.</summary>
    internal static string ToCSharpType(string tsType)
    {
        // Union / intersection types
        if (tsType.Contains(" | ") || tsType.Contains(" & "))
        {
            var parts = tsType.Split(" | ");
            var nonNull = new List<string>();
            foreach (var p in parts)
            {
                var trimmed = p.Trim();
                if (trimmed != "null")
                {
                    nonNull.Add(trimmed);
                }
            }

            if (nonNull.Count == 1 && parts.Length > nonNull.Count)
                return ToCSharpType(nonNull[0]);

            // All string literals → string
            if (nonNull.Count > 0 && nonNull.TrueForAll(s => s.StartsWith('"') && s.EndsWith('"')))
                return "string";

            var sorted = nonNull.OrderBy(s => s).ToList();
            if (sorted is ["integer", "string"])
            {
                return "Lolzteam.Api.Runtime.StringOrLong";
            }

            return "JsonElement";
        }

        // Array<T>
        var arrayMatch = ArrayTypePattern().Match(tsType);
        if (arrayMatch.Success)
        {
            return "List<" + ToCSharpType(arrayMatch.Groups[1].Value) + ">";
        }

        // Inline objects
        if (tsType.StartsWith('{') || tsType.Contains("Record<"))
        {
            return "JsonElement";
        }

        return tsType switch
        {
            "string" => "string",
            "number" => "double?",
            "integer" => "long?",
            "boolean" => "bool?",
            "unknown" => "JsonElement",
            "Blob" => "byte[]",
            _ when tsType.StartsWith('"') || Regex.IsMatch(tsType, @"^\d+$") => "string",
            _ => "JsonElement",
        };
    }

    /// <summary>Extract raw enum values from a schema node (after deref).</summary>
    private static List<EnumVariant>? ExtractEnumValues(JsonNode? schema, JsonNode spec)
    {
        if (schema is null) return null;

        // Follow $ref
        if (schema is JsonObject refObj)
        {
            var refNode = refObj["$ref"];
            if (refNode is JsonValue jv && jv.TryGetValue<string>(out _))
            {
                var resolved = DerefShallow(schema, spec);
                return ExtractEnumValues(resolved, spec);
            }
        }

        if (schema is not JsonObject sObj) return null;

        var enumArr = sObj["enum"];
        if (enumArr is not JsonArray arr || arr.Count == 0) return null;

        var typeNode = sObj["type"];
        string? type = null;
        if (typeNode is JsonValue tv && tv.TryGetValue<string>(out var ts))
        {
            type = ts;
        }

        var values = new List<EnumVariant>();
        foreach (var el in arr)
        {
            if (el is not JsonValue ev) continue;

            if (type == "integer" || (type is null && ev.TryGetValue<long>(out _)))
            {
                if (ev.TryGetValue<long>(out var longVal))
                    values.Add(new EnumVariant.IntVariant(longVal));

                continue;
            }

            values.Add(ev.TryGetValue<string>(out var strVal)
                ? new EnumVariant.StringVariant(strVal)
                : new EnumVariant.StringVariant(ev.ToString()));
        }

        return values.Count > 0 ? values : null;
    }

    /// <summary>Extract the "default" value from a schema node as a string, or null if absent.</summary>
    private static string? ExtractDefaultValue(JsonNode? schema)
    {
        if (schema is not JsonObject sObj)
            return null;

        var defaultNode = sObj["default"];
        if (defaultNode is null)
            return null;

        if (defaultNode is not JsonValue jv)
            return defaultNode.ToJsonString();

        if (jv.TryGetValue<string>(out var s)) return s;
        if (jv.TryGetValue<bool>(out var b)) return b ? "true" : "false";
        if (jv.TryGetValue<long>(out var l)) return l.ToString();
        if (jv.TryGetValue<double>(out var d)) return d.ToString(System.Globalization.CultureInfo.InvariantCulture);

        return defaultNode.ToJsonString();
    }

    private static OperationParameters ExtractParameters(JsonNode operation, JsonNode spec)
    {
        var pathParams = new List<ParsedParameter>();
        var queryParams = new List<ParsedParameter>();

        var rawParams = (operation as JsonObject)?["parameters"];
        if (rawParams is not JsonArray paramsArr)
        {
            return new OperationParameters(pathParams, queryParams);
        }

        foreach (var rawParam in paramsArr)
        {
            if (rawParam is null) continue;
            var param = DerefShallow(rawParam, spec);
            if (param is not JsonObject paramObj) continue;

            var inNode = paramObj["in"];
            string? inValue = null;
            if (inNode is JsonValue inVal && inVal.TryGetValue<string>(out var iv))
            {
                inValue = iv;
            }

            if (inValue is null || inValue == "header" || inValue == "cookie") continue;

            var nameNode = paramObj["name"];
            if (nameNode is null) continue;
            var name = nameNode.GetValue<string>();
            var paramSchema = paramObj["schema"];
            var type = SchemaToTypeString(paramSchema, spec);
            var requiredNode = paramObj["required"];
            var required = requiredNode is JsonValue rv && rv.TryGetValue<bool>(out var rBool) && rBool;
            var enumValues = ExtractEnumValues(paramSchema, spec);
            // For array params, extract enum values from items schema
            if (enumValues is null && paramSchema is JsonObject paramSchemaObj)
            {
                var paramTypeNode = paramSchemaObj["type"];
                if (paramTypeNode is JsonValue ptv && ptv.TryGetValue<string>(out var paramType) &&
                    paramType == "array")
                {
                    var itemsSchema = paramSchemaObj["items"];
                    if (itemsSchema is not null)
                    {
                        enumValues = ExtractEnumValues(itemsSchema, spec);
                    }
                }
            }

            var defaultValue = ExtractDefaultValue(paramSchema);

            var parsed = new ParsedParameter(
                name,
                type,
                inValue == "path" || required,
                enumValues,
                defaultValue
            );

            if (inValue == "path")
            {
                pathParams.Add(parsed);
            }
            else if (inValue == "query")
            {
                queryParams.Add(parsed);
            }
        }

        return new OperationParameters(pathParams, queryParams);
    }

    /// <summary>Try to detect a discriminated union from oneOf variants.</summary>
    private static List<OneOfVariant>? TryExtractDiscriminatedOneOf(JsonArray oneOfArr, JsonNode spec)
    {
        if (oneOfArr.Count < 2) return null;

        // All variants must have properties
        foreach (var variant in oneOfArr)
        {
            if (variant is not JsonObject vObj) return null;
            if (vObj["properties"] is not JsonObject) return null;
        }

        // Find discriminator field
        var firstObj = (JsonObject)oneOfArr[0]!;
        var firstProps = (JsonObject)firstObj["properties"]!;
        string? discriminatorField = null;

        foreach (var kvp in firstProps)
        {
            if (kvp.Value is not JsonObject propSchema) continue;
            var enumArr = propSchema["enum"];
            if (enumArr is not JsonArray ea || ea.Count != 1) continue;

            var allMatch = true;
            for (var i = 1; i < oneOfArr.Count; i++)
            {
                var vObj = (JsonObject)oneOfArr[i]!;
                var vProps = (JsonObject)vObj["properties"]!;
                var vProp = vProps[kvp.Key];
                if (vProp is not JsonObject vPropObj)
                {
                    allMatch = false;
                    break;
                }

                var vEnum = vPropObj["enum"];
                if (vEnum is not JsonArray ve || ve.Count != 1)
                {
                    allMatch = false;
                    break;
                }
            }

            if (allMatch)
            {
                discriminatorField = kvp.Key;
                break;
            }
        }

        if (discriminatorField is null) return null;

        var variants = new List<OneOfVariant>();
        foreach (var variant in oneOfArr)
        {
            var vObj = (JsonObject)variant!;
            var title = vObj["title"]?.GetValue<string>() ?? "Unknown";
            var props = (JsonObject)vObj["properties"]!;

            var requiredSet = new HashSet<string>();
            var reqArr = vObj["required"];
            if (reqArr is JsonArray rArr)
            {
                foreach (var r in rArr) requiredSet.Add(r!.GetValue<string>());
            }

            var discProp = (JsonObject)props[discriminatorField]!;
            var discEnum = (JsonArray)discProp["enum"]!;
            var discValue = discEnum[0]!.ToString();

            var bodyProps = new List<BodyProperty>();
            foreach (var kvp in props)
            {
                if (kvp.Key == discriminatorField) continue;
                var propEnumValues = ExtractEnumValues(kvp.Value, spec);
                var propDefaultValue = ExtractDefaultValue(kvp.Value);
                bodyProps.Add(new BodyProperty(
                    kvp.Key,
                    SchemaToTypeString(kvp.Value, spec),
                    requiredSet.Contains(kvp.Key),
                    propEnumValues,
                    propDefaultValue
                ));
            }

            variants.Add(new OneOfVariant(title, discriminatorField, discValue, bodyProps));
        }

        return variants;
    }

    /// <summary>Extract discriminated oneOf variants from an operation's request body.</summary>
    private static List<OneOfVariant>? ExtractOneOfVariants(JsonNode operation, JsonNode spec)
    {
        var rawRequestBody = (operation as JsonObject)?["requestBody"];
        if (rawRequestBody is null) return null;

        var requestBody = DerefShallow(rawRequestBody, spec);
        if (requestBody is not JsonObject rbObj) return null;

        var content = rbObj["content"];
        if (content is not JsonObject contentObj) return null;

        JsonNode? mediaType = contentObj["application/x-www-form-urlencoded"];
        mediaType ??= contentObj["application/json"];
        mediaType ??= contentObj["multipart/form-data"];
        if (mediaType is not JsonObject mtObj) return null;

        var schema = mtObj["schema"];
        if (schema is not JsonObject schemaObj) return null;

        var oneOf = schemaObj["oneOf"];
        if (oneOf is not JsonArray oneOfArr) return null;

        return TryExtractDiscriminatedOneOf(oneOfArr, spec);
    }

    private static BodyExtractionResult ExtractBody(JsonNode operation, JsonNode spec)
    {
        var empty = new BodyExtractionResult([]);

        var rawRequestBody = (operation as JsonObject)?["requestBody"];
        if (rawRequestBody is null) return empty;

        var requestBody = DerefShallow(rawRequestBody, spec);
        if (requestBody is not JsonObject rbObj) return empty;

        var content = rbObj["content"];
        if (content is not JsonObject contentObj) return empty;

        // 3-way content-type detection
        var hasForm = contentObj["application/x-www-form-urlencoded"] is not null;
        var hasJson = contentObj["application/json"] is not null;
        var hasMultipart = contentObj["multipart/form-data"] is not null;

        string bodyEncoding;
        if (hasMultipart && !hasForm)
        {
            bodyEncoding = "multipart";
        }
        else if (hasJson && !hasForm)
        {
            bodyEncoding = "json";
        }
        else
        {
            bodyEncoding = "form";
        }

        // Pick schema from best available content type
        JsonNode? mediaType = contentObj["application/x-www-form-urlencoded"];
        mediaType ??= contentObj["application/json"];
        mediaType ??= contentObj["multipart/form-data"];
        if (mediaType is not JsonObject mtObj) return empty;

        var schema = mtObj["schema"];
        if (schema is not JsonObject schemaObj) return empty;

        // Array body
        var schemaTypeNode = schemaObj["type"];
        string? schemaType = null;
        if (schemaTypeNode is JsonValue stv && stv.TryGetValue<string>(out var st))
        {
            schemaType = st;
        }

        if (schemaType == "array" && schemaObj["properties"] is null)
        {
            var items = schemaObj["items"];
            var itemType = items is not null ? SchemaToTypeString(items, spec) : "unknown";
            return new BodyExtractionResult([], true, itemType, bodyEncoding);
        }

        var bodyProperties = new List<BodyProperty>();

        // oneOf
        var oneOf = schemaObj["oneOf"];
        if (oneOf is JsonArray oneOfArr)
        {
            var allProps = new Dictionary<string, List<JsonNode>>();
            var variantRequiredSets = new List<HashSet<string>>();
            foreach (var variant in oneOfArr)
            {
                if (variant is not JsonObject variantObj) continue;
                var variantRequired = new HashSet<string>();
                var reqArr = variantObj["required"];
                if (reqArr is JsonArray vrArr)
                {
                    foreach (var r in vrArr)
                    {
                        variantRequired.Add(r!.GetValue<string>());
                    }
                }

                variantRequiredSets.Add(variantRequired);

                var variantProps = variantObj["properties"];
                if (variantProps is not JsonObject vpObj) continue;
                foreach (var kvp in vpObj)
                {
                    if (!allProps.TryGetValue(kvp.Key, out var schemas))
                    {
                        schemas = [];
                        allProps[kvp.Key] = schemas;
                    }

                    schemas.Add(kvp.Value!);
                }
            }

            foreach (var kvp in allProps)
            {
                // Intersection: required only if present in ALL variants
                var isRequired = variantRequiredSets.Count > 0 &&
                                 variantRequiredSets.TrueForAll(rs => rs.Contains(kvp.Key));

                // Merge schemas: if all have enums, merge enum values
                JsonNode mergedSchema;
                if (kvp.Value.Count == 1)
                {
                    mergedSchema = kvp.Value[0];
                }
                else
                {
                    var allEnums = new List<JsonNode>();
                    var allAreEnums = true;
                    foreach (var ps in kvp.Value)
                    {
                        if (ps is JsonObject psObj && psObj["enum"] is JsonArray enumArr)
                        {
                            foreach (var v in enumArr)
                            {
                                if (v is not null) allEnums.Add(v.DeepClone());
                            }
                        }
                        else
                        {
                            allAreEnums = false;
                            break;
                        }
                    }

                    if (allAreEnums && allEnums.Count > 0)
                    {
                        // Deduplicate enum values
                        var seen = new HashSet<string>();
                        var uniqueEnums = new JsonArray();
                        foreach (var v in allEnums)
                        {
                            var key = v.ToJsonString();
                            if (seen.Add(key))
                            {
                                uniqueEnums.Add(v);
                            }
                        }

                        mergedSchema = new JsonObject { ["enum"] = uniqueEnums };
                    }
                    else
                    {
                        // Different types — use last schema (best effort)
                        mergedSchema = kvp.Value[^1];
                    }
                }

                var mergedEnumValues = ExtractEnumValues(mergedSchema, spec);
                var mergedDefaultValue = ExtractDefaultValue(mergedSchema);
                bodyProperties.Add(new BodyProperty(
                    kvp.Key,
                    SchemaToTypeString(mergedSchema, spec),
                    isRequired,
                    mergedEnumValues,
                    mergedDefaultValue
                ));
            }
        }
        else
        {
            var properties = schemaObj["properties"];
            if (properties is JsonObject propsObj)
            {
                var requiredSet = new HashSet<string>();
                var requiredArr = schemaObj["required"];
                if (requiredArr is JsonArray reqArr)
                {
                    foreach (var r in reqArr)
                    {
                        requiredSet.Add(r!.GetValue<string>());
                    }
                }

                foreach (var kvp in propsObj)
                {
                    var propName = kvp.Key;
                    var propSchema = kvp.Value!;
                    string? format = null;
                    if (propSchema is JsonObject psObj)
                    {
                        var fmtNode = psObj["format"];
                        if (fmtNode is JsonValue fv && fv.TryGetValue<string>(out var fmt))
                        {
                            format = fmt;
                        }
                    }

                    var propType = format == "binary" ? "Blob" : SchemaToTypeString(propSchema, spec);
                    var propEnumValues = format == "binary" ? null : ExtractEnumValues(propSchema, spec);
                    // For array properties, extract enum values from items schema
                    if (propEnumValues is null && propSchema is JsonObject propSchemaObj2)
                    {
                        var propTypeNode = propSchemaObj2["type"];
                        if (propTypeNode is JsonValue ptv2 && ptv2.TryGetValue<string>(out var pt2) && pt2 == "array")
                        {
                            var itemsSchema = propSchemaObj2["items"];
                            if (itemsSchema is not null)
                            {
                                propEnumValues = ExtractEnumValues(itemsSchema, spec);
                            }
                        }
                    }

                    var propDefaultValue = format == "binary" ? null : ExtractDefaultValue(propSchema);
                    bodyProperties.Add(new BodyProperty(propName, propType, requiredSet.Contains(propName),
                        propEnumValues, propDefaultValue));
                }
            }
        }

        return new BodyExtractionResult(bodyProperties, false, null, bodyEncoding);
    }

    /// <summary>Check if the response content type is text/html (not application/json).</summary>
    private static bool IsHtmlResponse(JsonNode operation, JsonNode spec)
    {
        var responses = (operation as JsonObject)?["responses"];
        if (responses is not JsonObject respObj) return false;
        var rawSuccess = respObj["200"] ?? respObj["201"];
        if (rawSuccess is null) return false;
        var success = DerefShallow(rawSuccess, spec);
        if (success is not JsonObject successObj) return false;
        var content = successObj["content"];
        if (content is not JsonObject contentObj) return false;
        return contentObj["text/html"] is not null && contentObj["application/json"] is null;
    }

    private static string ExtractResponseType(JsonNode operation, JsonNode spec)
    {
        var responses = (operation as JsonObject)?["responses"];
        if (responses is not JsonObject respObj) return "unknown";
        var rawSuccess = respObj["200"] ?? respObj["201"];
        if (rawSuccess is null) return "unknown";
        var success = DerefShallow(rawSuccess, spec);
        if (success is not JsonObject successObj) return "unknown";
        var content = successObj["content"];
        if (content is not JsonObject contentObj) return "unknown";
        var jsonContent = contentObj["application/json"];
        if (jsonContent is not JsonObject jsonObj) return "unknown";
        var rawSchema = jsonObj["schema"];
        if (rawSchema is null) return "unknown";
        var schema = DerefShallow(rawSchema, spec);
        return SchemaToTypeString(schema, spec);
    }

    /// <summary>
    /// Extract typed response schema info from the raw (pre-deref) operation,
    /// preserving component schema $ref names.
    /// </summary>
    internal static ResponseSchemaInfo? ExtractResponseSchema(JsonNode? rawOperation, JsonNode rawSpec,
        HashSet<string> componentSchemaNames)
    {
        if (rawOperation is not JsonObject rawOpObj) return null;

        var responses = rawOpObj["responses"];
        if (responses is not JsonObject respObj) return null;
        var rawSuccess = respObj["200"] ?? respObj["201"];
        if (rawSuccess is null) return null;
        var success = DerefShallow(rawSuccess, rawSpec);
        if (success is not JsonObject successObj) return null;
        var content = successObj["content"];
        if (content is not JsonObject contentObj) return null;
        var jsonContent = contentObj["application/json"];
        if (jsonContent is not JsonObject jsonObj) return null;
        var rawSchema = jsonObj["schema"];
        if (rawSchema is null) return null;
        var schema = DerefShallow(rawSchema, rawSpec);
        if (schema is not JsonObject schemaObj) return null;

        var properties = schemaObj["properties"];
        if (properties is not JsonObject propsObj || propsObj.Count == 0) return null;

        var requiredSet = new HashSet<string>();
        var requiredArr = schemaObj["required"];
        if (requiredArr is JsonArray reqArr)
        {
            foreach (var r in reqArr)
            {
                requiredSet.Add(r!.GetValue<string>());
            }
        }

        var result = new List<ResponseProperty>();
        foreach (var kvp in propsObj)
        {
            var propName = kvp.Key;
            var propSchema = kvp.Value;
            if (propSchema is null) continue;

            var required = requiredSet.Contains(propName);
            var (csharpType, componentRef) = ResolvePropertyType(propSchema, rawSpec, componentSchemaNames);
            result.Add(new ResponseProperty(propName, csharpType, required, componentRef));
        }

        return result.Count > 0 ? new ResponseSchemaInfo(result) : null;
    }

    /// <summary>
    /// Extract raw resolved response schema object for nested record generation.
    /// </summary>
    private static JsonObject? ExtractResponseSchemaRaw(JsonNode? rawOperation, JsonNode rawSpec)
    {
        if (rawOperation is not JsonObject rawOpObj) return null;

        var responses = rawOpObj["responses"];
        if (responses is not JsonObject respObj) return null;

        var rawSuccess = respObj["200"] ?? respObj["201"];
        if (rawSuccess is null) return null;

        var success = DerefShallow(rawSuccess, rawSpec);
        if (success is not JsonObject successObj) return null;

        var content = successObj["content"];
        if (content is not JsonObject contentObj) return null;

        var jsonContent = contentObj["application/json"];
        if (jsonContent is not JsonObject jsonObj) return null;

        var rawSchema = jsonObj["schema"];
        if (rawSchema is null) return null;

        var schema = DerefShallow(rawSchema, rawSpec);
        if (schema is not JsonObject schemaObj) return null;

        var properties = schemaObj["properties"];
        if (properties is not JsonObject propsObj || propsObj.Count == 0) return null;

        return schemaObj.DeepClone() as JsonObject;
    }

    /// <summary>
    /// Resolve a property schema to a C# type, preserving component schema references.
    /// Returns (csharpType, componentSchemaRef or null).
    /// </summary>
    private static (string CSharpType, string? ComponentRef) ResolvePropertyType(
        JsonNode schema, JsonNode rawSpec, HashSet<string> componentSchemaNames)
    {
        // Direct $ref to component schema
        if (schema is JsonObject refObj)
        {
            var refNode = refObj["$ref"];
            if (refNode is JsonValue jv && jv.TryGetValue<string>(out var refStr))
            {
                if (refStr.StartsWith("#/components/schemas/"))
                {
                    var schemaName = refStr["#/components/schemas/".Length..];
                    if (componentSchemaNames.Contains(schemaName))
                    {
                        return (schemaName, schemaName);
                    }
                }

                // Resolve and recurse
                var resolved = ResolveRef(refStr, rawSpec);
                if (resolved is not null)
                {
                    return ResolvePropertyType(resolved, rawSpec, componentSchemaNames);
                }
            }
        }

        if (schema is not JsonObject sObj) return ("JsonElement", null);

        // Multi-type array: type: ['string', 'integer'] → StringOrLong, etc.
        var typeEl = sObj["type"];
        if (typeEl is JsonArray typeArr)
        {
            var nonNullTypes = new List<string>();
            foreach (var t in typeArr)
            {
                var ts = t!.GetValue<string>();
                if (ts != "null") nonNullTypes.Add(ts);
            }

            var sortedTypes = nonNullTypes.OrderBy(s => s).ToList();
            if (sortedTypes is ["integer", "string"])
            {
                return ("Lolzteam.Api.Runtime.StringOrLong", null);
            }

            return ("JsonElement", null);
        }

        string? type = null;
        if (typeEl is JsonValue typeVal && typeVal.TryGetValue<string>(out var tv))
        {
            type = tv;
        }

        // Array — check if items ref a component schema
        if (type == "array")
        {
            var items = sObj["items"];
            if (items is not null)
            {
                var (itemType, itemRef) = ResolvePropertyType(items, rawSpec, componentSchemaNames);
                return ($"List<{itemType}>", itemRef);
            }

            return ("List<JsonElement>", null);
        }

        // Object with properties → inline object (will be JsonElement for now, could be nested record)
        if (type == "object" || sObj["properties"] is not null)
        {
            return ("JsonElement", null);
        }

        // Primitives
        if (type is not null)
        {
            var csharp = type switch
            {
                "string" => "string",
                "integer" => "long",
                "number" => "double",
                "boolean" => "bool",
                _ => "JsonElement",
            };
            return (csharp, null);
        }

        // enum → string
        var enumValues = sObj["enum"];
        if (enumValues is JsonArray { Count: > 0 })
        {
            return ("string", null);
        }

        return ("JsonElement", null);
    }

    internal static MethodDefinition ExtractMethodDefinition(
        string operationId,
        string methodName,
        string httpMethod,
        string path,
        JsonNode operation,
        JsonNode? rawOperation,
        JsonNode rawSpec)
    {
        string? operationDescription = "";

        var operationDescNode = operation["description"];
        if (operationDescNode is JsonValue opDescVal)
            opDescVal.TryGetValue(out operationDescription);

        var emptySpec = new JsonObject();
        var parameters = ExtractParameters(operation, emptySpec);
        var body = ExtractBody(operation, emptySpec);
        var oneOfVariants = ExtractOneOfVariants(operation, emptySpec);
        var responseType = ExtractResponseType(operation, emptySpec);
        var returnsHtml = IsHtmlResponse(operation, emptySpec);
        var rawResponseSchema = ExtractResponseSchemaRaw(rawOperation, rawSpec);

        var isGet = httpMethod.Equals("GET", StringComparison.OrdinalIgnoreCase);

        // GET requests can't have body — treat body properties as query params
        List<ParsedParameter> effectiveQueryParams;
        if (isGet)
        {
            var combined = new List<ParsedParameter>(parameters.QueryParams);
            foreach (var prop in body.Properties)
            {
                combined.Add(new ParsedParameter(prop.Name, prop.Type, false, prop.EnumValues, prop.DefaultValue));
            }

            effectiveQueryParams = combined;
        }
        else
        {
            effectiveQueryParams = parameters.QueryParams;
        }

        var rawRequestBody = (operation as JsonObject)?["requestBody"];
        bool bodyRequired;
        if (isGet)
        {
            bodyRequired = false;
        }
        else if (rawRequestBody is not null)
        {
            var rb = DerefShallow(rawRequestBody, emptySpec);
            var reqNode = (rb as JsonObject)?["required"];
            var explicitRequired = reqNode is JsonValue rv && rv.TryGetValue<bool>(out var rBool) && rBool;
            bodyRequired = explicitRequired || body.Properties.Exists(p => p.Required);
        }
        else
        {
            bodyRequired = false;
        }

        return new MethodDefinition(
            operationId,
            operationDescription,
            methodName,
            httpMethod.ToUpperInvariant(),
            path,
            parameters with { QueryParams = effectiveQueryParams },
            isGet ? [] : body.Properties,
            !isGet && rawRequestBody is not null,
            bodyRequired,
            responseType,
            !isGet && body.BodyIsArray,
            isGet ? null : body.BodyArrayItemType,
            isGet ? "form" : body.BodyEncoding,
            rawResponseSchema,
            isGet ? null : oneOfVariants,
            returnsHtml
        );
    }
}
