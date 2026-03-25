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
    internal sealed record IntVariant(long Value) : EnumVariant;

    internal sealed record StringVariant(string Value) : EnumVariant;
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

internal sealed record ResponseProperty(
    string Name,
    string CSharpType,
    bool Required,
    string? ComponentSchemaRef
);

internal sealed record ResponseSchemaInfo(List<ResponseProperty> Properties);

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
