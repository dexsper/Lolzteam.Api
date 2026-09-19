// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class CategoriesApiTypes
{
	public sealed record CategoriesListParams
	{
		/// <summary>
		/// Id of parent category. If exists, filter categories that are direct children of that category.
		/// </summary>
		[JsonPropertyName("parent_category_id")]
		public long? ParentCategoryId { get; init; }
		/// <summary>
		/// Id of parent forum. If exists, filter categories that are direct children of that forum.
		/// </summary>
		[JsonPropertyName("parent_forum_id")]
		public long? ParentForumId { get; init; }
		/// <summary>
		/// Ordering of categories.
		/// </summary>
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (ParentCategoryId is not null)
			{
				writer.WritePropertyName("parent_category_id"u8);
				writer.WriteNumberValue(ParentCategoryId.Value);
			}
			if (ParentForumId is not null)
			{
				writer.WritePropertyName("parent_forum_id"u8);
				writer.WriteNumberValue(ParentForumId.Value);
			}
			if (Order is not null)
			{
				writer.WritePropertyName("order"u8);
				writer.WriteStringValue(Order.Value.ToJsonValue());
			}
			writer.WriteEndObject();
		}
	}

	public sealed record CategoriesListResponse(
		[property: JsonPropertyName("categories")] List<CategoryModel> Categories,
		[property: JsonPropertyName("categories_total")] long CategoriesTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CategoriesListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CategoriesListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<CategoryModel> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("categories"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<CategoryModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = CategoryModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("categories_total"u8))
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
			return new CategoriesListResponse(v0, v1, v2);
		}
	}

	public sealed record CategoriesGetResponse(
		[property: JsonPropertyName("category")] CategoryModel Category,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CategoriesGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CategoriesGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			CategoryModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("category"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : CategoryModel.ReadFromReader(ref reader);
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
			return new CategoriesGetResponse(v0, v1);
		}
	}

}
