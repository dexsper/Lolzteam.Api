using System.Text.Json.Nodes;

namespace Lolzteam.Codegen;

/// <summary>Generates C# source files from parsed API definitions.</summary>
internal static partial class Emitter
{
	/// <summary>
	/// Generate the <c>Types.cs</c> file: enums, component-schema records,
	/// and per-method query-param / body / response records.
	/// </summary>
	internal static string EmitCSharpTypesFile(
		List<ParsedGroup> groups, string subPackage,
		SortedDictionary<string, JsonObject> componentSchemas, JsonNode rawSpec,
		List<EnumDefinition> enumDefs, Dictionary<string, string> paramToEnumType)
	{
		var w = new CodeWriter();
		var ns = "Lolzteam.Api.Generated." + Naming.CapitalizeFirst(subPackage);
		var componentSchemaNames = new HashSet<string>(componentSchemas.Keys);

		w.Line("// Auto-generated. Do not edit manually.")
		 .Line("#nullable enable")
		 .Line("#pragma warning disable CS1591, CA1707")
		 .Line()
		 .Line("using System.Collections.Generic;")
		 .Line("using System.Text.Json;")
		 .Line("using System.Text.Json.Serialization;")
		 .Line()
		 .Line($"namespace {ns};")
		 .Line();

		if (enumDefs.Count > 0)
		{
			w.Line("// ─── Enums ────────────────────────────────────────────────────").Line();
			foreach (var def in enumDefs)
			{
				EmitEnumDefinition(w, def);
				w.Line();
			}
		}

		if (componentSchemas.Count > 0)
		{
			w.Line("// ─── Component Schemas ────────────────────────────────────────").Line();
			foreach (var kvp in componentSchemas)
			{
				EmitComponentSchemaRecord(w, kvp.Key, kvp.Value, rawSpec, componentSchemaNames);
				w.Line();
			}
		}

		foreach (var group in groups)
		{
			var className = Naming.GroupToClassName(group.GroupName);

			w.Line($"// ─── {className} Types ────────────────────────────────────────")
			 .Line()
			 .Open($"public static class {className}Types");

			foreach (var method in group.Methods)
			{
				EmitQueryParamsRecord(w, group.GroupName, method, paramToEnumType, enumDefs);
				EmitBodyRecord(w, group.GroupName, method, paramToEnumType, enumDefs);
				EmitResponseRecord(w, group.GroupName, method, rawSpec, componentSchemaNames);
			}

			w.Close().Line();
		}

		return w.ToString();
	}

	/// <summary>
	/// Generate the <c>Client.cs</c> and <c>Interface.cs</c> files.
	/// </summary>
	internal static (string clientFile, string interfaceFile) EmitCSharpClientFile(
		List<ParsedGroup> groups,
		string clientName, string interfaceName,
		string defaultBaseUrl, int defaultRateLimit,
		string subPackage, int defaultSearchRateLimit)
	{
		var ns = "Lolzteam.Api.Generated." + Naming.CapitalizeFirst(subPackage);
		var w = new CodeWriter();

		w.Line("// Auto-generated. Do not edit manually.")
		 .Line("#nullable enable")
		 .Line("#pragma warning disable CS1591, CA1707")
		 .Line()
		 .Line("using System.Text.Json;")
		 .Line("using Lolzteam.Api.Runtime;")
		 .Line()
		 .Line($"namespace {ns};")
		 .Line();

		foreach (var group in groups)
		{
			EmitGroupClass(w, group);
			w.Line();
		}

		EmitClientClass(w, groups, clientName, interfaceName,
			defaultBaseUrl, defaultRateLimit, defaultSearchRateLimit);

		var interfaceFile = EmitClientInterface(groups, interfaceName, subPackage);
		return (w.ToString(), interfaceFile);
	}

	/// <summary>Ensure a property name is unique within its record by appending a numeric suffix.</summary>
	private static string DeduplicateName(string name, HashSet<string> seen)
	{
		if (seen.Add(name)) return name;
		var suffix = 2;
		while (!seen.Add(name + suffix)) suffix++;
		return name + suffix;
	}

	/// <summary>Make a C# type nullable if it isn't already (avoids <c>int??</c> etc.).</summary>
	private static string MakeNullable(string type) => type.EndsWith('?') ? type : type + "?";

	/// <summary>
	/// Map a path-parameter intermediate type to a native C# type.
	/// Falls back to <c>string</c> for complex types that cannot be interpolated into a URL.
	/// </summary>
	private static string PathParamToCSharpType(string intermediateType)
	{
		var csharp = Transforms.ToCSharpType(intermediateType).TrimEnd('?');
		return csharp == "JsonElement" ? "string" : csharp;
	}
}
