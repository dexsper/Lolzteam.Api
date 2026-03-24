namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    /// <summary>
    /// Emit a <c>sealed record FooParams { … }</c> for query parameters.
    /// Does nothing when the method has no query params.
    /// </summary>
    private static void EmitQueryParamsRecord(
        CodeWriter w, string group, MethodDefinition method,
        Dictionary<string, string> paramToEnumType, List<EnumDefinition>? enumDefs)
    {
        if (method.Params.QueryParams.Count == 0) return;

        var typeName = Naming.BuildTypeName(group, method.MethodName) + "Params";
        w.Open($"public sealed record {typeName}");

        foreach (var param in method.Params.QueryParams)
        {
            var csharpType = ResolvePropCSharpType(param.Name, param.Type, method.OperationId, paramToEnumType);
            var propName = Naming.SafeCSharpName(param.Name);
            var defaultLiteral = param.DefaultValue is not null
                ? FormatDefaultLiteral(param.DefaultValue, csharpType, enumDefs, propName)
                : null;

            EmitPropertyDecl(w, csharpType, propName, param.Name, param.Required, defaultLiteral,
                docComment: param.DefaultValue is not null ? $"Default: {FormatDefaultValue(param.DefaultValue)}" : null
            );
        }

        w.Close().Line();
    }

    /// <summary>
    /// Emit a <c>sealed record FooBody { … }</c> (or a discriminated-union hierarchy) for the request body.
    /// Does nothing when the method has nobody, or when the body is a raw array (method accepts <c>List&lt;T&gt;</c> directly).
    /// </summary>
    private static void EmitBodyRecord(
        CodeWriter w, string group, MethodDefinition method,
        Dictionary<string, string> paramToEnumType, List<EnumDefinition>? enumDefs)
    {
        if (!method.HasBody || method.BodyIsArray) return;

        if (method.BodyOneOfVariants is { Count: > 0 } variants)
        {
            EmitSealedBodyRecords(w, group, method, variants, paramToEnumType, enumDefs);
            return;
        }

        if (method.BodyProperties.Count == 0) return;

        var typeName = Naming.BuildTypeName(group, method.MethodName) + "Body";
        w.Open($"public sealed record {typeName}");

        foreach (var prop in method.BodyProperties)
        {
            var csharpType = ResolvePropCSharpType(prop.Name, prop.Type, method.OperationId, paramToEnumType);
            var propName = Naming.SafeCSharpName(prop.Name);
            var defaultLiteral = prop.DefaultValue is not null
                ? FormatDefaultLiteral(prop.DefaultValue, csharpType, enumDefs, propName)
                : null;

            EmitPropertyDecl(w, csharpType, propName, prop.Name, prop.Required, defaultLiteral,
                docComment: prop.DefaultValue is not null ? $"Default: {FormatDefaultValue(prop.DefaultValue)}" : null
            );
        }

        w.Close().Line();
    }

    /// <summary>Emit an abstract base record plus sealed variant records for a discriminated-union body.</summary>
    private static void EmitSealedBodyRecords(
        CodeWriter w, string group, MethodDefinition method,
        List<OneOfVariant> variants,
        Dictionary<string, string> paramToEnumType, List<EnumDefinition>? enumDefs)
    {
        var baseName = Naming.BuildTypeName(group, method.MethodName) + "Body";

        w.Line("#if NET7_0_OR_GREATER");
        foreach (var variant in variants)
        {
            w.Line(
                $"[JsonDerivedType(typeof({VariantClassName(baseName, variant.Title)}), \"{variant.DiscriminatorValue}\")]");
        }

        w.Line("#endif");
        w.Line($"public abstract record {baseName};");

        foreach (var variant in variants)
        {
            var variantName = VariantClassName(baseName, variant.Title);
            w.Line().Open($"public sealed record {variantName} : {baseName}");

            var discPropName = Naming.SafeCSharpName(variant.DiscriminatorField);
            w.Line($"[JsonPropertyName(\"{variant.DiscriminatorField}\")]");

            w.Line(long.TryParse(variant.DiscriminatorValue, out var intDisc)
                ? $"public long {discPropName} => {intDisc};"
                : $"public string {discPropName} => \"{variant.DiscriminatorValue}\";"
            );

            foreach (var prop in variant.Properties)
            {
                var csharpType = ResolvePropCSharpType(prop.Name, prop.Type, method.OperationId, paramToEnumType);
                var propName = Naming.SafeCSharpName(prop.Name);
                var defaultLiteral = prop.DefaultValue is not null
                    ? FormatDefaultLiteral(prop.DefaultValue, csharpType, enumDefs, propName)
                    : null;

                EmitPropertyDecl(w, csharpType, propName, prop.Name, prop.Required, defaultLiteral,
                    docComment: prop.DefaultValue is not null
                        ? $"Default: {FormatDefaultValue(prop.DefaultValue)}"
                        : null
                );
            }

            w.Close();
        }

        w.Line();
    }

    /// <summary>
    /// Emit a single <c>{ get; init; }</c> property with optional XML doc comment,
    /// <c>[JsonPropertyName]</c> attribute, and default initializer.
    /// Handles required/optional and default-value combinations.
    /// </summary>
    private static void EmitPropertyDecl(
        CodeWriter w, string csharpType, string propName, string jsonName,
        bool required, string? defaultLiteral, string? docComment = null)
    {
        if (docComment is not null)
            w.Line($"/// <summary>{docComment}</summary>");

        if (Naming.NeedsJsonPropertyName(jsonName))
            w.Line($"[JsonPropertyName(\"{jsonName}\")]");

        if (required && defaultLiteral is null)
        {
            w.Line($"public required {csharpType} {propName} {{ get; init; }}");
            return;
        }

        if (defaultLiteral is not null)
        {
            w.Line($"public {(required ? csharpType : MakeNullable(csharpType))} {propName} {{ get; init; }} = {defaultLiteral};");
            return;
        }

        w.Line($"public {MakeNullable(csharpType)} {propName} {{ get; init; }}");
    }

    /// <summary>
    /// Resolve the C# type for a query or body property,
    /// substituting an enum type when one was collected by <see cref="EnumCollector"/>.
    /// </summary>
    private static string ResolvePropCSharpType(
        string propName, string propType, string operationId,
        Dictionary<string, string> paramToEnumType)
    {
        if (propType == "Blob") return "byte[]";
        var enumKey = $"{operationId}:{propName}";

        if (paramToEnumType.TryGetValue(enumKey, out var enumTypeName))
            return propType.StartsWith("Array<") ? $"List<{enumTypeName}>" : enumTypeName;

        return Transforms.ToCSharpType(propType);
    }

    private static string VariantClassName(string baseName, string title)
    {
        var parts = title.Split([' ', '_', '-'], StringSplitOptions.RemoveEmptyEntries);
        return baseName + string.Join("", parts.Select(p => char.ToUpperInvariant(p[0]) + p[1..]));
    }
}
