using System.Text;

namespace Lolzteam.Codegen;

/// <summary>
/// Indentation-aware writer for C# code generation.
/// Eliminates manual tab-counting in <see cref="StringBuilder"/> append chains.
/// </summary>
internal sealed class CodeWriter
{
	private readonly StringBuilder _sb = new();
	private int _depth;

	/// <summary>
	/// Write a line at the current indentation level.
	/// When <paramref name="text"/> is empty, write a blank line with no leading whitespace.
	/// </summary>
	public CodeWriter Line(string text = "")
	{
		if (text.Length > 0)
		{
			for (var i = 0; i < _depth; i++) _sb.Append('\t');
			_sb.Append(text);
		}
		_sb.Append('\n');
		return this;
	}

	/// <summary>Write <paramref name="text"/> only when <paramref name="condition"/> is <see langword="true"/>.</summary>
	public CodeWriter LineIf(bool condition, string text) => condition ? Line(text) : this;

	/// <summary>Write <paramref name="header"/>, then a <c>{</c>, and increase indentation.</summary>
	public CodeWriter Open(string header)
	{
		Line(header);
		Line("{");
		_depth++;
		return this;
	}

	/// <summary>Decrease indentation and write <c>}</c> followed by an optional <paramref name="suffix"/>.</summary>
	public CodeWriter Close(string suffix = "")
	{
		_depth--;
		Line("}" + suffix);
		return this;
	}

	/// <summary>Increase indentation without emitting characters (for multi-line parameter lists).</summary>
	public CodeWriter Push() { _depth++; return this; }

	/// <summary>Decrease indentation without emitting characters.</summary>
	public CodeWriter Pop() { _depth--; return this; }

	/// <summary>Append pre-rendered text verbatim without any indentation management.</summary>
	public CodeWriter Raw(string text) { _sb.Append(text); return this; }

	public override string ToString() => _sb.ToString();
}
