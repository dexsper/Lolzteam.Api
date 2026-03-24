using System.Text.Json.Nodes;

namespace Lolzteam.Codegen;

internal static class Parser
{
	private static readonly string[] HttpMethods = ["get", "post", "put", "delete", "patch"];

	internal static ParseResult ParseSpec(JsonNode rawSpec)
	{
		var componentSchemas = ExtractComponentSchemas(rawSpec);
		var componentSchemaNames = new HashSet<string>(componentSchemas.Keys);

		var spec = Transforms.DerefDeep(rawSpec, rawSpec, []);
		var paths = (spec as JsonObject)?["paths"];

		if (paths is not JsonObject pathsObj)
			return new ParseResult([], "https://localhost", componentSchemas);

		var groupMap = new SortedDictionary<string, List<MethodDefinition>>();
		foreach (var pathEntry in pathsObj)
		{
			var path = pathEntry.Key;
			var pathItem = pathEntry.Value;
			if (pathItem is not JsonObject pathItemObj) continue;

			foreach (var method in HttpMethods)
			{
				var operation = pathItemObj[method];
				if (operation is not JsonObject operationObj) continue;

				var operationIdNode = operationObj["operationId"];
				if (operationIdNode is not JsonValue opIdVal || !opIdVal.TryGetValue<string>(out var operationId))
					continue;

				var group = Naming.OperationIdToGroup(operationId);
				var methodName = Naming.OperationIdToMethod(operationId);

				var rawOperation = GetRawOperation(rawSpec, path, method);
				var methodDef = Transforms.ExtractMethodDefinition(
					operationId, methodName, method, path, operation,
					rawOperation, rawSpec, componentSchemaNames
				);

				if (!groupMap.TryGetValue(group, out var methods))
				{
					methods = [];
					groupMap[group] = methods;
				}
				methods.Add(methodDef);
			}
		}

		var groups = new List<ParsedGroup>();
		foreach (var entry in groupMap)
		{
			groups.Add(new ParsedGroup(entry.Key, entry.Value));
		}

		var servers = (spec as JsonObject)?["servers"];
		var baseUrl = "https://localhost";

        if (servers is not JsonArray { Count: > 0 } serversArr)
            return new ParseResult(groups, baseUrl, componentSchemas);

        var firstServer = serversArr[0];
        if (firstServer is not JsonObject serverObj)
            return new ParseResult(groups, baseUrl, componentSchemas);

        var urlNode = serverObj["url"];
        if (urlNode is JsonValue uv && uv.TryGetValue<string>(out var url))
        {
            baseUrl = url;
        }

        return new ParseResult(groups, baseUrl, componentSchemas);
	}

	private static SortedDictionary<string, JsonObject> ExtractComponentSchemas(JsonNode rawSpec)
	{
		var result = new SortedDictionary<string, JsonObject>();
		if (rawSpec is not JsonObject root)
            return result;

		var components = root["components"];
		if (components is not JsonObject compObj)
            return result;

		var schemas = compObj["schemas"];
		if (schemas is not JsonObject schemasObj)
            return result;

		foreach (var kvp in schemasObj)
        {
            if (kvp.Value is not JsonObject schemaObj)
                continue;

            var typeNode = schemaObj["type"];
            var hasProperties = schemaObj["properties"] is JsonObject { Count: > 0 };
            var isObject = typeNode is JsonValue tv && tv.TryGetValue<string>(out var t) && t == "object";

            if (!hasProperties && !isObject)
                continue;

            var cloned = JsonNode.Parse(schemaObj.ToJsonString());
            if (cloned is not JsonObject clonedObj)
                continue;

            result[kvp.Key] = clonedObj;
        }
		return result;
	}

	private static JsonNode? GetRawOperation(JsonNode rawSpec, string path, string method)
	{
		if (rawSpec is not JsonObject root)
            return null;

		var paths = root["paths"];
		if (paths is not JsonObject pathsObj)
            return null;

		var pathItem = pathsObj[path];
		return pathItem is not JsonObject pathItemObj ? null : pathItemObj[method];
    }
}
