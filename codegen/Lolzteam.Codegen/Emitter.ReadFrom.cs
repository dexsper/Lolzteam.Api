namespace Lolzteam.Codegen;

internal static partial class Emitter
{
	/// <summary>
	/// Emit <c>ReadFrom(ReadOnlyMemory&lt;byte&gt;)</c> and <c>ReadFromReader(ref Utf8JsonReader)</c>
	/// inside an already-opened record body.
	/// Zero reflection, no <c>JsonDocument</c> in the happy path.
	/// </summary>
	private static void EmitReadFromMethods(
		CodeWriter w, string typeName,
		List<(string jsonName, string csharpType)> props)
	{
		w.Line()
		 .Line("/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>")
		 .Open($"public static {typeName} ReadFrom(ReadOnlyMemory<byte> json)")
		 .Line("var reader = new Utf8JsonReader(json.Span);")
		 .Line("reader.Read(); // advance to StartObject")
		 .Line("return ReadFromReader(ref reader);")
		 .Close()
		 .Line()
		 .Open($"internal static {typeName} ReadFromReader(ref Utf8JsonReader reader)");

		// One local variable per property.
		// Index prefix (v0, v1, …) guarantees uniqueness even when SafeCSharpName produces collisions.
		for (var pi = 0; pi < props.Count; pi++)
		{
			var (_, csharpType) = props[pi];
			var baseType = csharpType.TrimEnd('?');
			var isValueType = baseType is "long" or "int" or "double" or "float" or "bool" or "JsonElement" or "Lolzteam.Api.Runtime.StringOrLong" or "StringOrLong";

			var decl = (csharpType.EndsWith('?') || isValueType)
				? $"{csharpType} v{pi} = default;"
				: $"{csharpType} v{pi} = null!;";

			w.Line(decl);
		}

		w.Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)")
		 .Line("if (reader.TokenType != JsonTokenType.PropertyName) continue;")
		 .Line();

		var first = true;
		for (var pi = 0; pi < props.Count; pi++)
		{
			var (jsonName, csharpType) = props[pi];
			var keyword = first ? "if" : "else if";
			w.Open($"{keyword} (reader.ValueTextEquals(\"{jsonName}\"u8))")
			 .Line("reader.Read();");

			EmitReadValueInto(w, $"v{pi}", csharpType);
			w.Close();
			first = false;
		}

		if (!first) // at least one property matched — add skip-unknown fallback
		{
			w.Open("else")
			 .Line("reader.Read();")
			 .Line("reader.Skip();")
			 .Close();
		}

		w.Close();
		var args = string.Join(", ", Enumerable.Range(0, props.Count).Select(i => "v" + i));
		w.Line($"return new {typeName}({args});").Close();
	}

	/// <summary>
	/// Emit <c>localName = &lt;read expression&gt;;</c> for the given C# type,
	/// handling nullability, primitives, <c>StringOrLong</c>, nested records, and <c>List&lt;T&gt;</c>.
	/// </summary>
	private static void EmitReadValueInto(CodeWriter w, string localName, string csharpType)
	{
		var baseType = csharpType.TrimEnd('?');
		var nullable = csharpType.EndsWith('?');
		var nullLiteral = nullable ? "null" : "null!";

		// Scalar and well-known types resolved to a single expression
		string? scalarExpr = baseType switch
		{
			"long" or "int"     => "reader.GetInt64()",
			"double" or "float" => "reader.GetDouble()",
			"bool"              => "reader.GetBoolean()",
			"string"            => nullable ? "reader.GetString()" : "reader.GetString()!",
			"Lolzteam.Api.Runtime.StringOrLong" or "StringOrLong" => "Lolzteam.Api.Runtime.StringOrLong.ReadFrom(ref reader)",
			"JsonElement"       => "JsonDocument.ParseValue(ref reader).RootElement.Clone()",
			_                   => null,
		};

		if (scalarExpr is not null)
		{
			if (nullable && baseType is not ("string" or "JsonElement"))
				// Nullable value type: guard against JSON null before casting
				w.Line($"{localName} = reader.TokenType == JsonTokenType.Null ? null : ({MakeNullable(baseType)}){scalarExpr};");
			else if (nullable)
				// Nullable reference type: guard without cast
				w.Line($"{localName} = reader.TokenType == JsonTokenType.Null ? null : {scalarExpr};");
			else
				// Non-nullable: assign directly (scalarExpr already includes ! for string)
				w.Line($"{localName} = {scalarExpr};");
			return;
		}

		if (baseType.StartsWith("List<") && baseType.EndsWith('>'))
		{
			var itemType = baseType[5..^1];
			w.Open("if (reader.TokenType == JsonTokenType.StartArray)")
			 .Line($"var __lst = new {baseType}();")
			 .Open("while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)");

			EmitInlineListItem(w, itemType);

			w.Line("__lst.Add(__item);")
			 .Close() // while
			 .Line($"{localName} = __lst;")
			 .Close(); // if
			return;
		}

		w.Line($"{localName} = reader.TokenType == JsonTokenType.Null ? {nullLiteral} : {baseType}.ReadFromReader(ref reader);");
	}

	/// <summary>Emit <c>var __item = &lt;read expression&gt;;</c> for a single list element.</summary>
	private static void EmitInlineListItem(CodeWriter w, string itemType)
	{
		var baseItem = itemType.TrimEnd('?');
		var expr = baseItem switch
		{
			"long" or "int"     => "reader.GetInt64()",
			"double" or "float" => "reader.GetDouble()",
			"bool"              => "reader.GetBoolean()",
			"string"            => "reader.GetString()!",
			"Lolzteam.Api.Runtime.StringOrLong" or "StringOrLong" => "Lolzteam.Api.Runtime.StringOrLong.ReadFrom(ref reader)",
			"JsonElement"       => "JsonDocument.ParseValue(ref reader).RootElement.Clone()",
			_                   => $"{baseItem}.ReadFromReader(ref reader)",
		};

		w.Line($"var __item = {expr};");
	}
}
