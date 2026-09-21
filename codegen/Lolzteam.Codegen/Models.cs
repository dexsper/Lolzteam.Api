using System.Text.Json.Nodes;
// ReSharper disable NotAccessedPositionalProperty.Global

namespace Lolzteam.Codegen;

internal sealed record ApiConfig(
    string SchemaPath,
    string OutputDir,
    string ClientName,
    string InterfaceName,
    string DefaultBaseUrl,
    int DefaultRateLimit,
    string SubPackage,
    int DefaultSearchRateLimit
);

internal abstract record EnumVariant
{
    internal sealed record IntVariant(long Value, string? Description = null) : EnumVariant;

    internal sealed record StringVariant(string Value, string? Description = null) : EnumVariant;
}

internal sealed record EnumDefinition(string TypeName, bool IsIntEnum, List<EnumVariant> Values);

internal sealed record ParseResult(
    List<ParsedGroup> Groups,
    string BaseUrl,
    SortedDictionary<string, JsonObject> ComponentSchemas
);

internal sealed record ParsedGroup(string GroupName, List<MethodDefinition> Methods);

internal sealed record ParsedParameter(
    string Name,
    string Type,
    bool Required,
    List<EnumVariant>? EnumValues = null,
    string? DefaultValue = null,
    string? Description = null
);

internal sealed record OperationParameters(
    List<ParsedParameter> PathParams,
    List<ParsedParameter> QueryParams
);

internal sealed record BodyProperty(
    string Name,
    string Type,
    bool Required,
    List<EnumVariant>? EnumValues = null,
    string? DefaultValue = null,
    string? Description = null
);

/// <summary>A property to emit inside a generated <c>WriteTo(Utf8JsonWriter)</c> method.</summary>
internal sealed record WriteProperty(string JsonName, string PropName, string DeclaredType);

/// <summary>One positional field of a generated response or component record.</summary>
internal sealed record RecordField(string JsonName, string CSharpType, bool Required);

/// <summary>Query or body field before it is turned into a C# property.</summary>
internal sealed record InputProperty(
    string Name,
    string IntermediateType,
    bool Required,
    string? DefaultValue = null,
    string? Description = null
);

/// <summary>Everything <c>EmitPropertyDecl</c> needs to write one property.</summary>
internal sealed record PropertyDecl(
    string CSharpType,
    string PropName,
    string JsonName,
    bool Required,
    string? DefaultLiteral = null,
    string? Description = null,
    string? DefaultNote = null
);

/// <summary>Shared state while resolving a component or response schema into C# types.</summary>
internal sealed record SchemaScope(
    JsonNode RawSpec,
    HashSet<string> ComponentSchemaNames,
    string? ParentTypeName = null,
    List<string>? NestedRecords = null
);

/// <summary>Flags that decide how a generated method builds <c>RequestOptions</c>.</summary>
internal sealed record RequestEmit(
    string HttpMethod,
    string PathExpression,
    bool HasQuery,
    bool IncludeBody,
    bool BodyRequired,
    string BodyEncoding,
    bool IsSearch,
    bool IncludeByteFields = false,
    bool IncludeJsonObject = false,
    string? BodyArrayItemType = null
);

/// <summary>A string enum member and the JSON value its <c>ToJsonValue</c> method returns.</summary>
internal sealed record EnumJsonMember(string Name, string JsonValue);

/// <summary>Enum types collected from a spec, plus the operation-parameter lookup that points at them.</summary>
internal sealed record EnumCatalog(List<EnumDefinition> Definitions, Dictionary<string, string> ParamToType);

/// <summary>Inputs for generating the <c>Types/</c> files of one API.</summary>
internal sealed record TypeGeneration(
    List<ParsedGroup> Groups,
    string SubPackage,
    SortedDictionary<string, JsonObject> ComponentSchemas,
    JsonNode RawSpec,
    EnumCatalog Enums
);

internal sealed record OneOfVariant(
    string Title,
    string DiscriminatorField,
    string DiscriminatorValue,
    List<BodyProperty> Properties
);

internal sealed record BodyExtractionResult(
    List<BodyProperty> Properties,
    bool BodyIsArray = false,
    string? BodyArrayItemType = null,
    string BodyEncoding = "form",
    List<OneOfVariant>? OneOfVariants = null
);

internal sealed record MethodDefinition(
    string OperationId,
    string? Description,
    string MethodName,
    string HttpMethod,
    string Path,
    OperationParameters Params,
    List<BodyProperty> BodyProperties,
    bool HasBody,
    bool BodyRequired,
    string ResponseType,
    bool BodyIsArray,
    string? BodyArrayItemType,
    string BodyEncoding,
    JsonObject? RawResponseSchema = null,
    List<OneOfVariant>? BodyOneOfVariants = null,
    bool ReturnsHtml = false
);
