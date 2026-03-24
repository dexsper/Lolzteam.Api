using System.Text;
using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

internal static partial class Naming
{
    private static readonly HashSet<string> CSharpKeywords =
    [
        "abstract","as","base","bool","break","byte","case","catch","char",
        "checked","class","const","continue","decimal","default","delegate","do",
        "double","else","enum","event","explicit","extern","false","finally",
        "fixed","float","for","foreach","goto","if","implicit","in","int",
        "interface","internal","is","lock","long","namespace","new","null",
        "object","operator","out","override","params","private","protected",
        "public","readonly","ref","return","sbyte","sealed","short","sizeof",
        "stackalloc","static","string","struct","switch","this","throw","true",
        "try","typeof","uint","ulong","unchecked","unsafe","ushort","using",
        "virtual","void","volatile","while",
    ];

    [GeneratedRegex("_([a-z])")]
    private static partial Regex SnakePattern();

    [GeneratedRegex(@"[^a-zA-Z0-9_]")]
    private static partial Regex InvalidIdentifierChars();

    internal static string OperationIdToMethod(string operationId)
    {
        var parts = operationId.Split('.');
        if (parts.Length < 2) return CapitalizeFirst(LowercaseFirst(operationId));

        var sb = new StringBuilder();
        for (var i = 1; i < parts.Length; i++)
        {
            var part = parts[i];
            if (i == 1)
                sb.Append(IsAllUppercase(part) ? part.ToLowerInvariant() : LowercaseFirst(part));
            else
            {
                var p = IsAllUppercase(part) ? part.ToLowerInvariant() : part;
                sb.Append(CapitalizeFirst(p));
            }
        }
        return CapitalizeFirst(sb.ToString());
    }

    internal static string OperationIdToGroup(string operationId)
    {
        var first = operationId.Split('.')[0];
        var group = LowercaseFirst(first);

        return group == "manging" ? "managing" : group;
    }

    internal static string GroupToPropertyName(string tag) => CapitalizeFirst(tag);

    internal static string GroupToClassName(string tag) => CapitalizeFirst(tag) + "Api";

    internal static string BuildTypeName(string group, string method) => CapitalizeFirst(group) + CapitalizeFirst(method);

    internal static string SnakeToPascal(string name)
    {
        var normalized = name.Replace('-', '_');
        var camel = SnakePattern().Replace(normalized, m => m.Groups[1].Value.ToUpperInvariant());

        return CapitalizeFirst(camel);
    }

    internal static string SanitizeName(string name)
    {
        if (name.EndsWith("[]")) name = name[..^2];
        if (!InvalidIdentifierChars().IsMatch(name))
            return name;

        return InvalidIdentifierChars().Replace(name, "_");
    }

    internal static string SafeCSharpName(string name)
    {
        var pascal = SnakeToPascal(SanitizeName(name));
        if (pascal.Length > 0 && char.IsDigit(pascal[0])) return "_" + pascal;
        if (CSharpKeywords.Contains(pascal)) return "@" + pascal;

        return pascal;
    }

    internal static bool NeedsJsonPropertyName(string name)
    {
        var sanitized = SanitizeName(name);
        var pascal = SnakeToPascal(sanitized);
        return name != pascal || name != sanitized || (pascal.Length > 0 && char.IsDigit(pascal[0]));
    }

    private static string LowercaseFirst(string s) => s.Length == 0 ? s : char.ToLowerInvariant(s[0]) + s[1..];

    internal static string CapitalizeFirst(string s) => s.Length == 0 ? s : char.ToUpperInvariant(s[0]) + s[1..];

    private static bool IsAllUppercase(string s) => s.Length > 1 && s == s.ToUpperInvariant();
}
