using System.Text;
using System.Text.RegularExpressions;

namespace Lolzteam.Codegen;

/// <summary>Converts OpenAPI markdown descriptions to C# XML doc comment lines.</summary>
/// <remarks>
/// <list type="table">
///   <listheader>
///     <term>Markdown</term>
///     <description>XML doc output</description>
///   </listheader>
///   <item><term>blank line</term>       <description><c>&lt;para/&gt;</c></description></item>
///   <item><term><c>- x</c> / <c>+ x</c></term> <description><c>&lt;list type="bullet"&gt;</c></description></item>
///   <item><term><c>**x**</c></term>     <description><c>&lt;b&gt;x&lt;/b&gt;</c></description></item>
///   <item><term><c>`x`</c></term>       <description><c>&lt;c&gt;x&lt;/c&gt;</c></description></item>
///   <item><term><c>[x](url)</c></term>  <description><c>&lt;see href="url"&gt;</c></description></item>
///   <item><term><c>_x_</c></term>       <description><c>&lt;i&gt;x&lt;/i&gt;</c></description></item>
/// </list>
/// </remarks>
internal static partial class DescriptionDoc
{
    /// <summary>
    /// Converts a raw OpenAPI description string to XML doc comment content lines
    /// (without the leading <c>///</c> prefix).
    /// </summary>
    internal static List<string> ToXmlDocLines(string description)
    {
        var rawLines = description
            .Replace("\r\n", "\n")
            .Replace("\r", "\n")
            .Split('\n');

        var lines = rawLines
            .Select(ClassifyLine)
            .ToList();

        var result = new List<string>();
        EmitLines(lines, result);

        while (result.Count > 0 && result[0] == "<para/>") result.RemoveAt(0);
        while (result.Count > 0 && result[^1] == "<para/>") result.RemoveAt(result.Count - 1);

        return result;
    }

    private static void EmitLines(List<Line> lines, List<string> result)
    {
        var i = 0;
        while (i < lines.Count)
        {
            if (lines[i] is Line.Bullet)
            {
                var bulletEnd = lines.FindIndex(i, l => l is not Line.Bullet);
                if (bulletEnd == -1) bulletEnd = lines.Count;

                result.Add("<list type=\"bullet\">");
                result.AddRange(lines[i..bulletEnd].Cast<Line.Bullet>()
                    .Select(b => $"<item><description>{b.Content}</description></item>"));
                result.Add("</list>");

                i = bulletEnd;
            }
            else
            {
                result.Add(lines[i].Content);
                i++;
            }
        }
    }

    private abstract record Line(string Content)
    {
        internal sealed record Blank() : Line("<para/>");

        internal sealed record Text(string Content) : Line(Content);

        internal sealed record Bullet(string Content) : Line(Content);
    }

    private static Line ClassifyLine(string raw) => raw switch
    {
        _ when string.IsNullOrWhiteSpace(raw) => new Line.Blank(),
        _ when raw.StartsWith("- ") || raw.StartsWith("+ ") => new Line.Bullet(ProcessInline(raw[2..])),
        _ => new Line.Text(ProcessInline(raw)),
    };

    private static string ProcessInline(string rawText)
    {
        var sb = new StringBuilder();
        var pos = 0;

        foreach (Match m in MarkdownSpanRegex().Matches(rawText))
        {
            if (m.Index > pos)
                sb.Append(XmlEscapeText(rawText[pos..m.Index]));

            sb.Append(RenderSpan(m.Value));
            pos = m.Index + m.Length;
        }

        if (pos < rawText.Length)
            sb.Append(XmlEscapeText(rawText[pos..]));

        return sb.ToString();
    }

    private static string RenderSpan(string span) => span switch
    {
        _ when span[0] == '`' => $"<c>{XmlEscapeText(span[1..^1])}</c>",
        _ when span.StartsWith("**") => $"<b>{ProcessInline(span[2..^2])}</b>",
        _ when span[0] == '_' => $"<i>{ProcessInline(span[1..^1])}</i>",
        _ => RenderLink(LinkRegex().Match(span)),
    };

    private static string RenderLink(Match m)
    {
        return $"<see href=\"{XmlEscapeAttr(m.Groups[2].Value)}\">{ProcessInline(m.Groups[1].Value)}</see>";
    }

    private static string XmlEscapeText(string text)
    {
        return text.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
    }

    private static string XmlEscapeAttr(string text) => XmlEscapeText(text).Replace("\"", "&quot;");

    [GeneratedRegex(@"`[^`]+`|\*\*[^*]+\*\*|_[^_]+_|\[[^\]]+\]\([^)]+\)")]
    private static partial Regex MarkdownSpanRegex();

    [GeneratedRegex(@"\[([^\]]+)\]\(([^)]+)\)")]
    private static partial Regex LinkRegex();
}
