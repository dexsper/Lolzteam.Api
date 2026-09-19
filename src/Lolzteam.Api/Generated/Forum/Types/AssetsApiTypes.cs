// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class AssetsApiTypes
{
	public sealed record AssetsCssParams
	{
		/// <summary>
		/// The names or identifiers of the CSS selectors to retrieve.
		/// </summary>
		[JsonPropertyName("css")]
		public List<string>? Css { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Css is not null)
			{
				writer.WritePropertyName("css"u8);
				writer.WriteStartArray();
				foreach (var __w in Css)
				{
					writer.WriteStringValue(__w);
				}
				writer.WriteEndArray();
			}
			writer.WriteEndObject();
		}
	}

	public sealed record AssetsCssResponse(
		[property: JsonPropertyName("contents")] string Contents,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static AssetsCssResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static AssetsCssResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("contents"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new AssetsCssResponse(v0, v1);
		}
	}

}
