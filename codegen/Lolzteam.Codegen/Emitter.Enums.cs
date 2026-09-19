using System.Text;

namespace Lolzteam.Codegen;

internal static partial class Emitter
{
    private static readonly Dictionary<string, string> WellKnownEnumNames = new()
    {
        ["*"] = "All",
    };

    private static readonly Dictionary<long, string> WellKnownIntEnumNames = new()
    {
        [440] = "TF2",
        [570] = "Dota2",
        [730] = "CS2",
        [753] = "Steam",
        [232090] = "KillingFloor2",
        [252490] = "Rust",
        [304930] = "Unturned",
        [322330] = "DontStarveTogether",
        [578080] = "Pubg",
    };

    private static void EmitEnumDefinition(CodeWriter w, EnumDefinition def)
    {
        var seenMembers = new HashSet<string>();
        if (def.IsIntEnum)
        {
            w.Open($"public enum {def.TypeName} : long");
            foreach (var variant in def.Values)
            {
                if (variant is not EnumVariant.IntVariant iv)
                    continue;

                var name = DeduplicateName(IntEnumMemberName(iv.Value), seenMembers);
                EmitEnumMemberDoc(w, iv.Description);
                w.Line($"{name} = {iv.Value},");
            }

            w.Close();
            return;
        }

        w.Line($"[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<{def.TypeName}>))]")
            .Open($"public enum {def.TypeName}");

        var members = new List<(string name, string jsonValue)>();
        foreach (var variant in def.Values)
        {
            if (variant is not EnumVariant.StringVariant sv)
                continue;

            var name = DeduplicateName(StringEnumMemberName(sv.Value), seenMembers);
            var escaped = sv.Value.Replace("\\", "\\\\").Replace("\"", "\\\"");
            EmitEnumMemberDoc(w, sv.Description);
            w.Line($"[Lolzteam.Api.Runtime.EnumValue(\"{escaped}\")] {name},");
            members.Add((name, escaped));
        }

        w.Close();

        if (members.Count == 0) return;

        // Lets WriteTo write the JSON string for this enum without going through StringEnumConverter<T>
        // (which resolves via JsonSerializer and needs reflection-based type metadata).
        w.Line()
            .Line($"/// <summary>Zero-reflection JSON string mapping for <see cref=\"{def.TypeName}\"/>.</summary>")
            .Open($"internal static class {def.TypeName}Extensions")
            .Open($"public static string ToJsonValue(this {def.TypeName} value)")
            .Open("return value switch");

        foreach (var (name, jsonValue) in members)
            w.Line($"{def.TypeName}.{name} => \"{jsonValue}\",");

        w.Line("_ => value.ToString(),");

        w.Close(";")
            .Close()
            .Close();
    }

    /// <summary>Emit an XML doc <c>&lt;summary&gt;</c> for an enum member, if a description is present.</summary>
    private static void EmitEnumMemberDoc(CodeWriter w, string? description)
    {
        if (description is null)
            return;

        w.Line("/// <summary>");
        foreach (var line in DescriptionDoc.ToXmlDocLines(description))
            w.Line(string.IsNullOrEmpty(line) ? "///" : $"/// {line}");
        w.Line("/// </summary>");
    }

    /// <summary>Generate a valid C# identifier for an integer enum variant.</summary>
    private static string IntEnumMemberName(long value)
    {
        if (WellKnownIntEnumNames.TryGetValue(value, out var known)) return known;
        
        return value < 0 ? "Neg" + -value : "V" + value;
    }

    /// <summary>Generate a PascalCase C# identifier from a string enum variant value.</summary>
    private static string StringEnumMemberName(string value)
    {
        if (string.IsNullOrEmpty(value)) return "None";
        if (WellKnownEnumNames.TryGetValue(value, out var known)) return known;

        var sb = new StringBuilder();
        var capitalizeNext = true;
        foreach (var ch in value)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                capitalizeNext = true;
                continue;
            }

            sb.Append(capitalizeNext ? char.ToUpperInvariant(ch) : ch);
            capitalizeNext = false;
        }

        var result = sb.ToString();
        if (result.Length > 0 && char.IsDigit(result[0])) result = "V" + result;
        if (result.Length == 0) result = "Value" + Math.Abs(value.GetHashCode());
        
        return result;
    }
}
