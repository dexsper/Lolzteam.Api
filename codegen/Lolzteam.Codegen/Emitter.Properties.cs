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

        var writeProps = new List<WriteProperty>();

        foreach (var param in method.Params.QueryParams)
        {
            var csharpType = ResolvePropCSharpType(param.Name, param.Type, method.OperationId, paramToEnumType);
            var propName = Naming.SafeCSharpName(param.Name);
            var defaultLiteral = param.DefaultValue is not null
                ? FormatDefaultLiteral(param.DefaultValue, csharpType, enumDefs, propName)
                : null;

            EmitPropertyDecl(w, csharpType, propName, param.Name, param.Required, defaultLiteral,
                description: param.Description,
                defaultNote: param.DefaultValue is not null ? FormatDefaultValue(param.DefaultValue) : null
            );

            writeProps.Add(new WriteProperty(param.Name, propName, ComputeDeclaredType(csharpType, param.Required, defaultLiteral)));
        }

        EmitWriteToMethod(w, writeProps, BuildEnumIsIntLookup(enumDefs));

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

        var writeProps = new List<WriteProperty>();

        foreach (var prop in method.BodyProperties)
        {
            var csharpType = ResolvePropCSharpType(prop.Name, prop.Type, method.OperationId, paramToEnumType);
            var propName = Naming.SafeCSharpName(prop.Name);
            var defaultLiteral = prop.DefaultValue is not null
                ? FormatDefaultLiteral(prop.DefaultValue, csharpType, enumDefs, propName)
                : null;

            EmitPropertyDecl(w, csharpType, propName, prop.Name, prop.Required, defaultLiteral,
                description: prop.Description,
                defaultNote: prop.DefaultValue is not null ? FormatDefaultValue(prop.DefaultValue) : null
            );

            writeProps.Add(new WriteProperty(prop.Name, propName, ComputeDeclaredType(csharpType, prop.Required, defaultLiteral)));
        }

        EmitWriteToMethod(w, writeProps, BuildEnumIsIntLookup(enumDefs));

        w.Close().Line();
    }

    /// <summary>Emit an abstract base record plus sealed variant records for a discriminated-union body.</summary>
    private static void EmitSealedBodyRecords(
        CodeWriter w, string group, MethodDefinition method,
        List<OneOfVariant> variants,
        Dictionary<string, string> paramToEnumType, List<EnumDefinition>? enumDefs)
    {
        var baseName = Naming.BuildTypeName(group, method.MethodName) + "Body";
        var enumIsInt = BuildEnumIsIntLookup(enumDefs);

        w.Line("#if NET7_0_OR_GREATER");
        foreach (var variant in variants)
        {
            w.Line(
                $"[JsonDerivedType(typeof({VariantClassName(baseName, variant.Title)}), \"{variant.DiscriminatorValue}\")]");
        }

        w.Line("#endif");
        w.Open($"public abstract record {baseName}")
            .Line("/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>")
            .Line("public abstract void WriteTo(Utf8JsonWriter writer);")
            .Close();

        foreach (var variant in variants)
        {
            var variantName = VariantClassName(baseName, variant.Title);
            w.Line().Open($"public sealed record {variantName} : {baseName}");

            var discPropName = Naming.SafeCSharpName(variant.DiscriminatorField);
            w.Line($"[JsonPropertyName(\"{variant.DiscriminatorField}\")]");

            var isIntDisc = long.TryParse(variant.DiscriminatorValue, out var intDisc);
            w.Line(isIntDisc
                ? $"public long {discPropName} => {intDisc};"
                : $"public string {discPropName} => \"{variant.DiscriminatorValue}\";"
            );

            var writeProps = new List<WriteProperty>();
            foreach (var prop in variant.Properties)
            {
                var csharpType = ResolvePropCSharpType(prop.Name, prop.Type, method.OperationId, paramToEnumType);
                var propName = Naming.SafeCSharpName(prop.Name);
                var defaultLiteral = prop.DefaultValue is not null
                    ? FormatDefaultLiteral(prop.DefaultValue, csharpType, enumDefs, propName)
                    : null;

                EmitPropertyDecl(w, csharpType, propName, prop.Name, prop.Required, defaultLiteral,
                    description: prop.Description,
                    defaultNote: prop.DefaultValue is not null ? FormatDefaultValue(prop.DefaultValue) : null
                );

                writeProps.Add(new WriteProperty(prop.Name, propName, ComputeDeclaredType(csharpType, prop.Required, defaultLiteral)));
            }

            w.Line()
                .Line("/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>")
                .Open("public override void WriteTo(Utf8JsonWriter writer)")
                .Line("writer.WriteStartObject();")
                .Line($"writer.WritePropertyName(\"{variant.DiscriminatorField}\"u8);")
                .Line(isIntDisc ? $"writer.WriteNumberValue({discPropName});" : $"writer.WriteStringValue({discPropName});");

            EmitWritePropertyLoop(w, writeProps, enumIsInt);

            w.Line("writer.WriteEndObject();").Close();

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
        bool required, string? defaultLiteral,
        string? description = null, string? defaultNote = null)
    {
        if (description is not null || defaultNote is not null)
        {
            w.Line("/// <summary>");
            if (description is not null)
                foreach (var line in DescriptionDoc.ToXmlDocLines(description))
                    w.Line(string.IsNullOrEmpty(line) ? "///" : $"/// {line}");
            if (defaultNote is not null)
            {
                if (description is not null) w.Line("/// <para/>");
                w.Line($"/// Default: <c>{defaultNote}</c>");
            }
            w.Line("/// </summary>");
        }

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
