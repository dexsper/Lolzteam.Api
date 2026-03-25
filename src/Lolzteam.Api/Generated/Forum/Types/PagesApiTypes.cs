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
		[JsonPropertyName("parent_page_id")]
		public long? ParentPageId { get; init; }
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }
	}

	public sealed record PagesListResponse(
		[property: JsonPropertyName("pages")] List<PagesListResponsePages> Pages,
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
			List<PagesListResponsePages> v0 = null!;
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
						var __lst = new List<PagesListResponsePages>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = PagesListResponsePages.ReadFromReader(ref reader);
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

public sealed record PagesListResponsePagesLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-pages")] string SubPages
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PagesListResponsePagesLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PagesListResponsePagesLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
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
			else if (reader.ValueTextEquals("sub-pages"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PagesListResponsePagesLinks(v0, v1, v2);
	}
}

public sealed record PagesListResponsePagesPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PagesListResponsePagesPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PagesListResponsePagesPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new PagesListResponsePagesPermissions(v0, v1, v2);
	}
}

public sealed record PagesListResponsePages(
	[property: JsonPropertyName("page_id")] long PageId,
	[property: JsonPropertyName("page_title")] string PageTitle,
	[property: JsonPropertyName("page_description")] string PageDescription,
	[property: JsonPropertyName("links")] PagesListResponsePagesLinks Links,
	[property: JsonPropertyName("permissions")] PagesListResponsePagesPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PagesListResponsePages ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PagesListResponsePages ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		PagesListResponsePagesLinks v3 = null!;
		PagesListResponsePagesPermissions v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("page_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("page_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : PagesListResponsePagesLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : PagesListResponsePagesPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PagesListResponsePages(v0, v1, v2, v3, v4);
	}
}

	public sealed record PagesGetResponse(
		[property: JsonPropertyName("page")] PagesGetResponsePage Page,
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
			PagesGetResponsePage v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("page"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : PagesGetResponsePage.ReadFromReader(ref reader);
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

public sealed record PagesGetResponsePageLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-pages")] string SubPages
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PagesGetResponsePageLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PagesGetResponsePageLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
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
			else if (reader.ValueTextEquals("sub-pages"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PagesGetResponsePageLinks(v0, v1, v2);
	}
}

public sealed record PagesGetResponsePagePermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PagesGetResponsePagePermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PagesGetResponsePagePermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new PagesGetResponsePagePermissions(v0, v1, v2);
	}
}

public sealed record PagesGetResponsePage(
	[property: JsonPropertyName("page_id")] long PageId,
	[property: JsonPropertyName("page_title")] string PageTitle,
	[property: JsonPropertyName("page_description")] string PageDescription,
	[property: JsonPropertyName("page_view_count")] long PageViewCount,
	[property: JsonPropertyName("links")] PagesGetResponsePageLinks Links,
	[property: JsonPropertyName("permissions")] PagesGetResponsePagePermissions Permissions,
	[property: JsonPropertyName("page_html")] string PageHtml
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PagesGetResponsePage ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PagesGetResponsePage ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		PagesGetResponsePageLinks v4 = null!;
		PagesGetResponsePagePermissions v5 = null!;
		string v6 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("page_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("page_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("page_view_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : PagesGetResponsePageLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v5 = reader.TokenType == JsonTokenType.Null ? null! : PagesGetResponsePagePermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("page_html"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PagesGetResponsePage(v0, v1, v2, v3, v4, v5, v6);
	}
}

}
