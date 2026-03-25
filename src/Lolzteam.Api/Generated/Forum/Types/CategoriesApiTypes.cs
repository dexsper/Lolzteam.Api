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
		[JsonPropertyName("parent_category_id")]
		public long? ParentCategoryId { get; init; }
		[JsonPropertyName("parent_forum_id")]
		public long? ParentForumId { get; init; }
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }
	}

	public sealed record CategoriesListResponse(
		[property: JsonPropertyName("categories")] List<CategoriesListResponseCategories> Categories,
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
			List<CategoriesListResponseCategories> v0 = null!;
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
						var __lst = new List<CategoriesListResponseCategories>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = CategoriesListResponseCategories.ReadFromReader(ref reader);
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

public sealed record CategoriesListResponseCategoriesLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static CategoriesListResponseCategoriesLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static CategoriesListResponseCategoriesLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("permalink"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-categories"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-forums"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new CategoriesListResponseCategoriesLinks(v0, v1, v2, v3);
	}
}

public sealed record CategoriesListResponseCategoriesPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static CategoriesListResponseCategoriesPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static CategoriesListResponseCategoriesPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new CategoriesListResponseCategoriesPermissions(v0, v1, v2);
	}
}

public sealed record CategoriesListResponseCategories(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] CategoriesListResponseCategoriesLinks Links,
	[property: JsonPropertyName("permissions")] CategoriesListResponseCategoriesPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static CategoriesListResponseCategories ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static CategoriesListResponseCategories ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		CategoriesListResponseCategoriesLinks v3 = null!;
		CategoriesListResponseCategoriesPermissions v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("category_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : CategoriesListResponseCategoriesLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : CategoriesListResponseCategoriesPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new CategoriesListResponseCategories(v0, v1, v2, v3, v4);
	}
}

	public sealed record CategoriesGetResponse(
		[property: JsonPropertyName("category")] CategoriesGetResponseCategory Category,
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
			CategoriesGetResponseCategory v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("category"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : CategoriesGetResponseCategory.ReadFromReader(ref reader);
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

public sealed record CategoriesGetResponseCategoryLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static CategoriesGetResponseCategoryLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static CategoriesGetResponseCategoryLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("permalink"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-categories"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-forums"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new CategoriesGetResponseCategoryLinks(v0, v1, v2, v3);
	}
}

public sealed record CategoriesGetResponseCategoryPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static CategoriesGetResponseCategoryPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static CategoriesGetResponseCategoryPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new CategoriesGetResponseCategoryPermissions(v0, v1, v2);
	}
}

public sealed record CategoriesGetResponseCategory(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] CategoriesGetResponseCategoryLinks Links,
	[property: JsonPropertyName("permissions")] CategoriesGetResponseCategoryPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static CategoriesGetResponseCategory ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static CategoriesGetResponseCategory ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		CategoriesGetResponseCategoryLinks v3 = null!;
		CategoriesGetResponseCategoryPermissions v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("category_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : CategoriesGetResponseCategoryLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : CategoriesGetResponseCategoryPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new CategoriesGetResponseCategory(v0, v1, v2, v3, v4);
	}
}

}
