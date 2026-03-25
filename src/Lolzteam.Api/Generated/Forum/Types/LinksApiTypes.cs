// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class LinksApiTypes
{
	public sealed record LinksListResponse(
		[property: JsonPropertyName("link-forums")] List<Resp_LinkModel> LinkForums,
		[property: JsonPropertyName("link-forums_total")] long LinkForumsTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static LinksListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static LinksListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_LinkModel> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("link-forums"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_LinkModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_LinkModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("link-forums_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new LinksListResponse(v0, v1, v2);
		}
	}

	public sealed record LinksGetResponse(
		[property: JsonPropertyName("link-forum")] Resp_LinkModel LinkForum,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static LinksGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static LinksGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_LinkModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("link-forum"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_LinkModel.ReadFromReader(ref reader);
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
			return new LinksGetResponse(v0, v1);
		}
	}

}
