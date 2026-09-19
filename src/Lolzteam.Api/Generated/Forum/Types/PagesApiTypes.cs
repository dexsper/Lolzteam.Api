// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class PagesApiTypes
{
	public sealed record PagesListParams
	{
		/// <summary>
		/// Id of parent page. If exists, filter pages that are direct children of that page.
		/// </summary>
		[JsonPropertyName("parent_page_id")]
		public long? ParentPageId { get; init; }
		/// <summary>
		/// Ordering of pages.
		/// </summary>
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (ParentPageId is not null)
			{
				writer.WritePropertyName("parent_page_id"u8);
				writer.WriteNumberValue(ParentPageId.Value);
			}
			if (Order is not null)
			{
				writer.WritePropertyName("order"u8);
				writer.WriteStringValue(Order.Value.ToJsonValue());
			}
			writer.WriteEndObject();
		}
	}

	public sealed record PagesListResponse(
		[property: JsonPropertyName("pages")] List<PageModel> Pages,
		[property: JsonPropertyName("pages_total")] long PagesTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PagesListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PagesListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<PageModel> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("pages"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<PageModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = PageModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("pages_total"u8))
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
			return new PagesListResponse(v0, v1, v2);
		}
	}

	public sealed record PagesGetResponse(
		[property: JsonPropertyName("page")] PageModel Page,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PagesGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PagesGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			PageModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("page"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : PageModel.ReadFromReader(ref reader);
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
			return new PagesGetResponse(v0, v1);
		}
	}

}
