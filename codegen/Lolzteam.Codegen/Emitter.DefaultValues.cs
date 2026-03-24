namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    /// <summary>Escape a default value for safe embedding in an XML doc comment.</summary>
    private static string FormatDefaultValue(string value) =>
        value.Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;");

    /// <summary>
    /// Format a default value as a C# literal for use in a property initializer.
    /// Returns <see langword="null"/> when the default cannot be represented as a compile-time constant.
    /// </summary>
    private static string? FormatDefaultLiteral(
        string defaultValue, string csharpType,
        List<EnumDefinition>? enumDefs, string? propName = null)
    {
        var baseType = csharpType.TrimEnd('?');

        switch (baseType)
        {
            case "string": return "\"" + defaultValue.Replace("\\", "\\\\").Replace("\"", "\\\"") + "\"";
            case "long": return long.TryParse(defaultValue, out _) ? defaultValue : null;
            case "double":
            {
                var style = System.Globalization.NumberStyles.Float;
                var culture = System.Globalization.CultureInfo.InvariantCulture;
                return double.TryParse(defaultValue, style, culture, out var d) ? d.ToString(culture) : null;
            }
            case "bool":
            {
                return defaultValue switch
                {
                    "true" or "1" => "true",
                    "false" or "0" => "false",
                    _ => null
                };
            }
            default:
            {
                if (baseType.StartsWith("Lolzteam.Api.Runtime.StringOrLong"))
                {
                    return long.TryParse(defaultValue, out var lv)
                        ? $"(Lolzteam.Api.Runtime.StringOrLong){lv}"
                        : $"(Lolzteam.Api.Runtime.StringOrLong)\"{defaultValue.Replace("\\", "\\\\").Replace("\"", "\\\"")}\"";
                }

                if (enumDefs is null) return null;
                var enumDef = enumDefs.Find(e => e.TypeName == baseType);
                return enumDef is not null ? FindEnumDefaultLiteral(enumDef, defaultValue, propName) : null;
            }
        }
    }

    private static string? FindEnumDefaultLiteral(EnumDefinition enumDef, string defaultValue, string? propName = null)
    {
        string? memberName = null;

        if (enumDef.IsIntEnum)
        {
            if (long.TryParse(defaultValue, out var longVal))
                foreach (var v in enumDef.Values)
                    if (v is EnumVariant.IntVariant iv && iv.Value == longVal)
                    {
                        memberName = IntEnumMemberName(iv.Value);
                        break;
                    }
        }
        else
        {
            foreach (var v in enumDef.Values)
            {
                if (v is not EnumVariant.StringVariant sv || sv.Value != defaultValue)
                    continue;

                memberName = StringEnumMemberName(sv.Value);
                break;
            }
        }

        if (memberName is null) return null;
        if (propName is not null && propName == enumDef.TypeName) return null;

        return $"{enumDef.TypeName}.{memberName}";
    }
}
