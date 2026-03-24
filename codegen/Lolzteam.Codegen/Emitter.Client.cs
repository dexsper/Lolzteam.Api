using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Emitter
{
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
        w.Line(
                "/// <summary>Create a new client. For DI / IHttpClientFactory use the Lolzteam.Api.DependencyInjection package.</summary>")
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
            w.Line(
                $"{Naming.GroupToPropertyName(group.GroupName)} = new {Naming.GroupToClassName(group.GroupName)}(_http);");

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
            .Line(
                $"/// <summary>Interface for the {interfaceName[1..]} — enables mocking and DI substitution.</summary>")
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

    private static void EmitCSharpMethod(CodeWriter w, string group, MethodDefinition method)
    {
        var typeName = Naming.BuildTypeName(group, method.MethodName);
        var className = Naming.GroupToClassName(group);
        var responseTypeName = $"{className}Types.{typeName}Response";
        var pathExpr = BuildPathExpression(method.Path, method.Params.PathParams);
        var isSearch = group.Equals("category", StringComparison.OrdinalIgnoreCase);
        var hasQueryType = method.Params.QueryParams.Count > 0;

        var args = new List<string>();
        foreach (var p in method.Params.PathParams)
            args.Add($"{PathParamToCSharpType(p.Type)} {Naming.SnakeToPascal(Naming.SanitizeName(p.Name))}");

        var bodyTypeName = $"{className}Types.{typeName}Body";
        var hasBodyType = method.HasBody && (method.BodyProperties.Count > 0 || method.BodyIsArray);
        if (hasBodyType)
        {
            if (method.BodyIsArray)
            {
                bodyTypeName = $"List<{Transforms.ToCSharpType(method.BodyArrayItemType ?? "unknown")}>";
            }

            args.Add(method.BodyRequired ? $"{bodyTypeName} body" : $"{bodyTypeName}? body = null");
        }

        if (hasQueryType)
            args.Add($"{className}Types.{typeName}Params? @params = null");

        args.Add("CancellationToken cancellationToken = default");
        w.Open($"public async Task<{responseTypeName}> {method.MethodName}Async({string.Join(", ", args)})");

        if (method.ReturnsHtml)
            EmitHtmlMethodBody(w, method.HttpMethod, pathExpr, hasQueryType, isSearch, responseTypeName);
        else if (method.BodyEncoding == "multipart" && method.BodyProperties.Exists(p => p.Type == "Blob"))
            EmitMultipartByteArrayMethodBody(w, method, pathExpr, hasQueryType, isSearch, responseTypeName);
        else
            EmitStandardMethodBody(w, method, pathExpr, hasQueryType, hasBodyType, isSearch, responseTypeName);

        w.Close();
    }

    /// <summary>Body for text/html endpoints: use <c>RequestRawAsync</c> and wrap the result.</summary>
    private static void EmitHtmlMethodBody(
        CodeWriter w, string httpMethod, string pathExpr,
        bool hasQueryType, bool isSearch, string responseTypeName)
    {
        EmitBuildOpts(w, httpMethod, pathExpr, hasQueryType,
            includeBody: false, bodyRequired: false, bodyEncoding: "form",
            isSearch, includeByteFields: false, includeJsonObj: false
        );

        w.Line("var __raw = await _http.RequestRawAsync(__opts, cancellationToken).ConfigureAwait(false);");
        w.Line($"return new {responseTypeName}(__raw);");
    }

    /// <summary>Body for standard JSON/form endpoints.</summary>
    private static void EmitStandardMethodBody(
        CodeWriter w, MethodDefinition method, string pathExpr,
        bool hasQueryType, bool hasBodyType, bool isSearch, string responseTypeName)
    {
        EmitBuildOpts(w, method.HttpMethod, pathExpr, hasQueryType,
            includeBody: hasBodyType, bodyRequired: method.BodyRequired,
            bodyEncoding: method.BodyEncoding, isSearch,
            includeByteFields: false, includeJsonObj: false
        );

        EmitRequestAndReturn(w, responseTypeName);
    }

    /// <summary>Body for multipart endpoints that include raw byte-array (file upload) fields.</summary>
    private static void EmitMultipartByteArrayMethodBody(
        CodeWriter w, MethodDefinition method, string pathExpr,
        bool hasQueryType, bool isSearch, string responseTypeName)
    {
        var serializableProps = method.BodyProperties.FindAll(p => p.Type != "Blob");
        var blobFields = method.BodyProperties.FindAll(p => p.Type == "Blob");

        // Local function builds jsonObj + byteFields, then emits __opts and return
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

            EmitBuildOpts(w, method.HttpMethod, pathExpr, hasQueryType, includeBody: serializableProps.Count > 0,
                bodyRequired: true, bodyEncoding: "multipart", isSearch,
                includeByteFields: true, includeJsonObj: serializableProps.Count > 0
            );

            EmitRequestAndReturn(w, responseTypeName);
        }

        if (method.BodyRequired)
        {
            EmitBodyAndReturn();
        }
        else
        {
            // body is optional: send multipart only when provided, otherwise send without fields
            w.Open("if (body is not null)");
            EmitBodyAndReturn();
            w.Close().Open("else");

            EmitBuildOpts(w, method.HttpMethod, pathExpr, hasQueryType, includeBody: false,
                bodyRequired: false, bodyEncoding: "multipart", isSearch,
                includeByteFields: false, includeJsonObj: false
            );
            EmitRequestAndReturn(w, responseTypeName);
            w.Close(); // else
        }
    }

    /// <summary>Emit <c>var __opts = new RequestOptions { … };</c>.</summary>
    private static void EmitBuildOpts(
        CodeWriter w,
        string httpMethod, string pathExpr,
        bool hasQueryType, bool includeBody, bool bodyRequired,
        string bodyEncoding, bool isSearch,
        bool includeByteFields, bool includeJsonObj)
    {
        w.Line("var __opts = new RequestOptions")
            .Open("{")
            .Line($"Method = \"{httpMethod}\",")
            .Line($"Path = {pathExpr},");

        if (hasQueryType)
            w.Line("Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,");

        if (includeBody)
        {
            if (includeJsonObj)
                w.Line("Body = JsonSerializer.SerializeToElement(jsonObj),");
            else if (bodyRequired)
                w.Line("Body = JsonSerializer.SerializeToElement(body),");
            else
                w.Line("Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,");
            w.Line($"BodyEncoding = {BodyEncodingLiteral(bodyEncoding)},");
        }
        else if (bodyEncoding != "form")
        {
            w.Line($"BodyEncoding = {BodyEncodingLiteral(bodyEncoding)},");
        }

        if (includeByteFields)
            w.Line("ByteArrayFields = byteFields,");

        w.LineIf(isSearch, "IsSearch = true,")
            .Close(";");
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
