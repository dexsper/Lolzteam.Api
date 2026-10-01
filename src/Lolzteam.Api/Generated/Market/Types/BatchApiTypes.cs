// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class BatchApiTypes
{
	public sealed record BatchBatchResponse(
		[property: JsonPropertyName("jobs")] Dictionary<string, JsonElement> Jobs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static BatchBatchResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static BatchBatchResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Dictionary<string, JsonElement> v0 = null!;
			Resp_SystemInfo? v1 = default;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("jobs"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartObject)
					{
						var __dict = new Dictionary<string, JsonElement>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
						{
							if (reader.TokenType != JsonTokenType.PropertyName) continue;
							var __key = reader.GetString()!;
							reader.Read();
							var __val = JsonDocument.ParseValue(ref reader).RootElement.Clone();
							__dict[__key] = __val;
						}
						v0 = __dict;
					}
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new BatchBatchResponse(v0, v1);
		}
	}

}
