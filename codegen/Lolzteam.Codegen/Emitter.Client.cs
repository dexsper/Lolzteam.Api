using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    internal sealed record CSharpMethod(
        string TypeName,
        string ClassName,
        string PathExpression,
        bool IsSearch,
        bool HasQueryType,
        string ResponseTypeName,
        bool HasBodyType
    );

    private static void EmitGroupClass(CodeWriter w, ParsedGroup group)
    {
        var className = Naming.GroupToClassName(group.GroupName);
        w.Open($"public sealed class {className}")
            .Line("private readonly LolzteamHttpClient _http;")
            .Line()
            .Open($"public {className}(LolzteamHttpClient http)")
            .Line("_http = http;")
            .Close();

        foreach (var method in group.Methods)
        {
            w.Line();
            EmitCSharpMethod(w, group.GroupName, method);
        }

        w.Close();
    }

    private static void EmitClientClass(
        CodeWriter w, List<ParsedGroup> groups,
        string clientName, string interfaceName,
        string defaultBaseUrl, int defaultRateLimit, int defaultSearchRateLimit)
    {
        w.Open($"public sealed class {clientName} : {interfaceName}");
        foreach (var group in groups)
        {
            w.Line(
                $"public {Naming.GroupToClassName(group.GroupName)} {Naming.GroupToPropertyName(group.GroupName)} {{ get; }}"
            );
        }

        w.Line().Line("private readonly LolzteamHttpClient _http;").Line();
        w.Line("/// <summary>Create a new client.</summary>")
            .Open($"public {clientName}(ClientConfig config)")
            .Open("var resolvedConfig = config with")
            .Line($"BaseUrl = config.BaseUrl ?? \"{defaultBaseUrl}\",")
            .Line($"RateLimit = config.RateLimit ?? new RateLimitConfig({defaultRateLimit}),");

        if (defaultSearchRateLimit > 0)
            w.Line($"SearchRateLimit = config.SearchRateLimit ?? new RateLimitConfig({defaultSearchRateLimit}),");

        w.Close(";").Line("_http = new LolzteamHttpClient(resolvedConfig);").Line();
        foreach (var group in groups)
        {
            w.Line(
                $"{Naming.GroupToPropertyName(group.GroupName)} = new {Naming.GroupToClassName(group.GroupName)}(_http);"
            );
        }

        w.Close()
            .Line()
            .Line("/// <summary>Internal constructor for IHttpClientFactory integration.</summary>")
            .Open($"internal {clientName}(LolzteamHttpClient http)")
            .Line("_http = http;");

        foreach (var group in groups)
        {
            w.Line(
                $"{Naming.GroupToPropertyName(group.GroupName)} = new {Naming.GroupToClassName(group.GroupName)}(_http);"
            );
        }

        w.Close()
            .Line()
            .Open("public void Dispose()")
            .Line("_http.Dispose();")
            .Close()
            .Close();
    }

    private static string EmitClientInterface(
        List<ParsedGroup> groups, string interfaceName, string subPackage)
    {
        var ns = "Lolzteam.Api.Generated." + Naming.CapitalizeFirst(subPackage);
        var w = new CodeWriter();

        w.Line("// Auto-generated. Do not edit manually.")
            .Line("#nullable enable")
            .Line()
            .Line($"namespace {ns};")
            .Line()
            .Line($"/// <summary>Interface for the {interfaceName[1..]}.</summary>")
            .Open($"public interface {interfaceName} : System.IDisposable");

        foreach (var group in groups)
        {
            w.Line($"/// <summary>{Naming.CapitalizeFirst(group.GroupName)} API operations.</summary>");
            w.Line(
                $"{Naming.GroupToClassName(group.GroupName)} {Naming.GroupToPropertyName(group.GroupName)} {{ get; }}"
            );
        }

        w.Close();
        return w.ToString();
    }

    private static void EmitCSharpMethod(CodeWriter w, string group, MethodDefinition definition)
    {
        var typeName = Naming.BuildTypeName(group, definition.MethodName);
        var className = Naming.GroupToClassName(group);
        var hasQueryType = definition.Params.QueryParams.Count > 0;
        var hasBodyType = definition.HasBody && (definition.BodyProperties.Count > 0 || definition.BodyIsArray);

        var pathExpr = BuildPathExpression(definition.Path, definition.Params.PathParams);
        var isSearch = group.Equals("category", StringComparison.OrdinalIgnoreCase);
        var responseTypeName = $"{className}Types.{typeName}Response";

        var method = new CSharpMethod(
            typeName,
            className,
            pathExpr,
            isSearch,
            hasQueryType,
            responseTypeName,
            hasBodyType
        );

        EmitMethodDescription(w, definition);
        EmitMethodSignature(w, definition, method);

        if (definition.ReturnsHtml)
        {
            EmitHtmlMethodBody(w, definition, method);
            w.Close();
            return;
        }

        if (definition.BodyEncoding == "multipart" && definition.BodyProperties.Exists(p => p.Type == "Blob"))
        {
            EmitMultipartByteArrayMethodBody(w, definition, method);
            w.Close();
            return;
        }

        EmitStandardMethodBody(w, definition, method);
        w.Close();
    }

    private static void EmitMethodDescription(CodeWriter w, MethodDefinition definition)
    {
        if (definition.Description == null)
            return;

        w.Line("/// <summary>");

        var descriptionLines = definition.Description
            .Replace("\r\n", "\n")
            .Replace("\r", "\n")
            .Split('\n')
            .ToList();

        foreach (var line in descriptionLines)
            w.Line($"/// {System.Security.SecurityElement.Escape(line)}");

        w.Line("/// </summary>");
    }

    private static void EmitMethodSignature(CodeWriter w, MethodDefinition definition, CSharpMethod method)
    {
        var args = new List<string>();
        foreach (var p in definition.Params.PathParams)
            args.Add($"{PathParamToCSharpType(p.Type)} {Naming.SnakeToPascal(Naming.SanitizeName(p.Name))}");

        var bodyTypeName = $"{method.ClassName}Types.{method.TypeName}Body";

        if (method.HasBodyType)
        {
            if (definition.BodyIsArray)
            {
                bodyTypeName = $"List<{Transforms.ToCSharpType(definition.BodyArrayItemType ?? "unknown")}>";
            }

            args.Add(definition.BodyRequired ? $"{bodyTypeName} body" : $"{bodyTypeName}? body = null");
        }

        if (method.HasQueryType)
            args.Add($"{method.ClassName}Types.{method.TypeName}Params? @params = null");

        args.Add("CancellationToken cancellationToken = default");
        w.Open($"public async Task<{method.ResponseTypeName}> {definition.MethodName}Async({string.Join(", ", args)})");
    }

    /// <summary>Body for text/html endpoints: use <c>RequestRawAsync</c> and wrap the result.</summary>
    private static void EmitHtmlMethodBody(CodeWriter w, MethodDefinition definition, CSharpMethod method)
    {
        EmitBuildOpts(w,
            definition.HttpMethod,
            method.PathExpression,
            method.HasQueryType,
            includeBody: false,
            bodyRequired: false,
            bodyEncoding: "form",
            method.IsSearch,
            includeByteFields: false,
            includeJsonObj: false
        );

        w.Line("var __raw = await _http.RequestRawAsync(__opts, cancellationToken).ConfigureAwait(false);");
        w.Line($"return new {method.ResponseTypeName}(__raw);");
    }

    /// <summary>Body for standard JSON/form endpoints.</summary>
    private static void EmitStandardMethodBody(CodeWriter w, MethodDefinition definition, CSharpMethod method)
    {
        EmitBuildOpts(w,
            definition.HttpMethod,
            method.PathExpression,
            definition.Params.QueryParams.Count > 0,
            includeBody: method.HasBodyType,
            bodyRequired: definition.BodyRequired,
            bodyEncoding: definition.BodyEncoding,
            method.IsSearch,
            includeByteFields: false, includeJsonObj: false
        );

        EmitRequestAndReturn(w, method.ResponseTypeName);
    }

    /// <summary>Body for multipart endpoints that include raw byte-array (file upload) fields.</summary>
    private static void EmitMultipartByteArrayMethodBody(CodeWriter w, MethodDefinition definition, CSharpMethod method)
    {
        var serializableProps = definition.BodyProperties.FindAll(p => p.Type != "Blob");
        var blobFields = definition.BodyProperties.FindAll(p => p.Type == "Blob");
        var hasQueryType = definition.Params.QueryParams.Count > 0;

        void EmitBodyAndReturn()
        {
            if (serializableProps.Count > 0)
            {
                w.Line("var jsonObj = new System.Text.Json.Nodes.JsonObject();");
                foreach (var prop in serializableProps)
                {
                    var pn = Naming.SnakeToPascal(Naming.SanitizeName(prop.Name));
                    if (prop.Required)
                    {
                        w.Line($"jsonObj[\"{prop.Name}\"] = System.Text.Json.Nodes.JsonValue.Create(body.{pn});");
                        continue;
                    }

                    w.Line(
                        $"if (body.{pn} is not null) jsonObj[\"{prop.Name}\"] = System.Text.Json.Nodes.JsonValue.Create(body.{pn});"
                    );
                }
            }

            w.Line("var byteFields = new Dictionary<string, byte[]>();");
            foreach (var field in blobFields)
            {
                var pn = Naming.SnakeToPascal(Naming.SanitizeName(field.Name));
                w.Line(field.Required
                    ? $"byteFields[\"{field.Name}\"] = body.{pn};"
                    : $"if (body.{pn} is not null) byteFields[\"{field.Name}\"] = body.{pn};");
            }

            EmitBuildOpts(w,
                definition.HttpMethod,
                method.PathExpression,
                hasQueryType,
                includeBody: serializableProps.Count > 0,
                bodyRequired: true,
                bodyEncoding: "multipart",
                method.IsSearch,
                includeByteFields: true,
                includeJsonObj: serializableProps.Count > 0
            );

            EmitRequestAndReturn(w, method.ResponseTypeName);
        }

        if (definition.BodyRequired)
        {
            EmitBodyAndReturn();
            return;
        }

        w.Open("if (body is not null)");
        EmitBodyAndReturn();
        w.Close().Open("else");

        EmitBuildOpts(w,
            definition.HttpMethod,
            method.PathExpression,
            hasQueryType,
            includeBody: false,
            bodyRequired: false,
            bodyEncoding: "multipart",
            method.IsSearch,
            includeByteFields: false,
            includeJsonObj: false
        );

        EmitRequestAndReturn(w, method.ResponseTypeName);
        w.Close();
    }

    /// <summary>Emit <c>var __opts = new RequestOptions { … };</c>.</summary>
    private static void EmitBuildOpts(
        CodeWriter w,
        string httpMethod, string pathExpr,
        bool hasQueryType, bool includeBody, bool bodyRequired,
        string bodyEncoding, bool isSearch,
        bool includeByteFields, bool includeJsonObj)
    {
        w.Open("var __opts = new RequestOptions")
            .Line($"Method = \"{httpMethod}\",")
            .Line($"Path = {pathExpr},");

        if (hasQueryType)
            w.Line("Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,");

        string? bodyLine = !includeBody ? null
            : includeJsonObj ? "Body = JsonSerializer.SerializeToElement(jsonObj),"
            : bodyRequired ? "Body = JsonSerializer.SerializeToElement(body),"
            : "Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,";

        if (bodyLine is not null)
        {
            w.Line(bodyLine);
        }

        if (includeBody || bodyEncoding != "form")
        {
            w.Line($"BodyEncoding = {BodyEncodingLiteral(bodyEncoding)},");
        }

        if (includeByteFields)
            w.Line("ByteArrayFields = byteFields,");

        w.LineIf(isSearch, "IsSearch = true,").Close(";");
    }

    private static void EmitRequestAndReturn(CodeWriter w, string responseTypeName)
    {
        w.Line(
            $"return await _http.RequestAsync(__opts, {responseTypeName}.ReadFrom, cancellationToken).ConfigureAwait(false);"
        );
    }

    private static string BuildPathExpression(string path, List<ParsedParameter> pathParams)
    {
        if (!path.Contains('{')) return $"\"{path}\"";

        var result = Regex.Replace(path, @"\{([^}]+)\}", m =>
        {
            var paramName = m.Groups[1].Value;
            var csharpName = Naming.SnakeToPascal(paramName);
            foreach (var p in pathParams)
            {
                if (Naming.SanitizeName(p.Name) != paramName && p.Name != paramName)
                    continue;

                csharpName = Naming.SnakeToPascal(Naming.SanitizeName(p.Name));
                break;
            }

            return $"{{{csharpName}}}";
        });

        return $"$\"{result}\"";
    }

    private static string BodyEncodingLiteral(string encoding) => encoding switch
    {
        "json" => "BodyEncoding.Json",
        "multipart" => "BodyEncoding.Multipart",
        _ => "BodyEncoding.Form",
    };
}
