namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    /// <summary>
    /// Emit a <c>sealed record FooParams { … }</c> for query parameters.
    /// Does nothing when the method has no query params.
    /// </summary>
    private static void EmitQueryParamsRecord(CodeWriter w, string group, MethodDefinition method, EnumCatalog enums)
    {
        if (method.Params.QueryParams.Count == 0) return;

        var typeName = Naming.BuildTypeName(group, method.MethodName) + "Params";
        w.Open($"public sealed record {typeName}");

        var writeProps = new List<WriteProperty>();
        foreach (var param in method.Params.QueryParams)
        {
            writeProps.Add(EmitInputProperty(
                w,
                new InputProperty(param.Name, param.Type, param.Required, param.DefaultValue, param.Description),
                method.OperationId,
                enums
            ));
        }

        EmitWriteToMethod(w, writeProps, BuildEnumIsIntLookup(enums.Definitions));

        w.Close().Line();
    }

    /// <summary>
    /// Emit a <c>sealed record FooBody { … }</c> (or a discriminated-union hierarchy) for the request body.
    /// Does nothing when the method has nobody, or when the body is a raw array (method accepts <c>List&lt;T&gt;</c> directly).
    /// </summary>
    private static void EmitBodyRecord(CodeWriter w, string group, MethodDefinition method, EnumCatalog enums)
    {
        if (!method.HasBody || method.BodyIsArray) return;

        if (method.BodyOneOfVariants is { Count: > 0 } variants)
        {
            EmitSealedBodyRecords(w, group, method, variants, enums);
            return;
        }

        if (method.BodyProperties.Count == 0) return;

        var typeName = Naming.BuildTypeName(group, method.MethodName) + "Body";
        w.Open($"public sealed record {typeName}");

        var writeProps = new List<WriteProperty>();
        foreach (var prop in method.BodyProperties)
        {
            writeProps.Add(EmitInputProperty(
                w,
                new InputProperty(prop.Name, prop.Type, prop.Required, prop.DefaultValue, prop.Description),
                method.OperationId,
                enums
            ));
        }

        EmitWriteToMethod(w, writeProps, BuildEnumIsIntLookup(enums.Definitions));

        w.Close().Line();
    }

    /// <summary>Emit an abstract base record plus sealed variant records for a discriminated-union body.</summary>
    private static void EmitSealedBodyRecords(
        CodeWriter w, string group, MethodDefinition method, List<OneOfVariant> variants, EnumCatalog enums)
    {
        var baseName = Naming.BuildTypeName(group, method.MethodName) + "Body";
        var enumIsInt = BuildEnumIsIntLookup(enums.Definitions);

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
                writeProps.Add(EmitInputProperty(
                    w,
                    new InputProperty(prop.Name, prop.Type, prop.Required, prop.DefaultValue, prop.Description),
                    method.OperationId,
                    enums
                ));
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
    private static WriteProperty EmitInputProperty(
        CodeWriter w, InputProperty property, string operationId, EnumCatalog enums)
    {
        var csharpType = ResolvePropCSharpType(property.Name, property.IntermediateType, operationId, enums.ParamToType);
        var propName = Naming.SafeCSharpName(property.Name);
        var defaultLiteral = property.DefaultValue is not null
            ? FormatDefaultLiteral(property.DefaultValue, csharpType, enums.Definitions, propName)
            : null;

        EmitPropertyDecl(w, new PropertyDecl(
            csharpType,
            propName,
            property.Name,
            property.Required,
            defaultLiteral,
            property.Description,
            property.DefaultValue is not null ? FormatDefaultValue(property.DefaultValue) : null
        ));

        return new WriteProperty(property.Name, propName, ComputeDeclaredType(csharpType, property.Required));
    }

    private static void EmitPropertyDecl(CodeWriter w, PropertyDecl property)
    {
        if (property.Description is not null || property.DefaultNote is not null)
        {
            w.Line("/// <summary>");
            if (property.Description is not null)
                foreach (var line in DescriptionDoc.ToXmlDocLines(property.Description))
                    w.Line(string.IsNullOrEmpty(line) ? "///" : $"/// {line}");
            if (property.DefaultNote is not null)
            {
                if (property.Description is not null) w.Line("/// <para/>");
                w.Line($"/// Default: <c>{property.DefaultNote}</c>");
            }
            w.Line("/// </summary>");
        }

        if (Naming.NeedsJsonPropertyName(property.JsonName))
            w.Line($"[JsonPropertyName(\"{property.JsonName}\")]");

        if (property.Required && property.DefaultLiteral is null)
        {
            w.Line($"public required {property.CSharpType} {property.PropName} {{ get; init; }}");
            return;
        }

        if (property.DefaultLiteral is not null)
        {
            var typeName = property.Required ? property.CSharpType : MakeNullable(property.CSharpType);
            w.Line($"public {typeName} {property.PropName} {{ get; init; }} = {property.DefaultLiteral};");
            return;
        }

        w.Line($"public {MakeNullable(property.CSharpType)} {property.PropName} {{ get; init; }}");
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
