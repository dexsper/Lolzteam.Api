using System.Text;

namespace Lolzteam.Codegen;

internal static partial class Emitter
{
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
                w.Line($"{name} = {iv.Value},");
            }

            w.Close();
            return;
        }

        w.Line($"[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<{def.TypeName}>))]")
            .Open($"public enum {def.TypeName}");

        foreach (var variant in def.Values)
        {
            if (variant is not EnumVariant.StringVariant sv)
                continue;

            var name = DeduplicateName(StringEnumMemberName(sv.Value), seenMembers);
            var escaped = sv.Value.Replace("\\", "\\\\").Replace("\"", "\\\"");
            w.Line($"[Lolzteam.Api.Runtime.EnumValue(\"{escaped}\")] {name},");
        }

        w.Close();
    }

    /// <summary>Generate a valid C# identifier for an integer enum variant.</summary>
    private static string IntEnumMemberName(long value) => value < 0 ? "Neg" + -value : "V" + value;

    /// <summary>Generate a PascalCase C# identifier from a string enum variant value.</summary>
    private static string StringEnumMemberName(string value)
    {
        if (string.IsNullOrEmpty(value)) return "None";

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
