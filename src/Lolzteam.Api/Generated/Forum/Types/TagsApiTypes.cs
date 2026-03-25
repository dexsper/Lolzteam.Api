// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class TagsApiTypes
{
	public sealed record TagsPopularResponse(
		[property: JsonPropertyName("tags")] TagsPopularResponseTags Tags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static TagsPopularResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static TagsPopularResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			TagsPopularResponseTags v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("tags"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : TagsPopularResponseTags.ReadFromReader(ref reader);
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
			return new TagsPopularResponse(v0, v1);
		}
	}

public sealed record TagsPopularResponseTags(
	[property: JsonPropertyName("000")] string _000
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsPopularResponseTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsPopularResponseTags ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("000"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsPopularResponseTags(v0);
	}
}

	public sealed record TagsListParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record TagsListResponse(
		[property: JsonPropertyName("tags")] TagsListResponseTags Tags,
		[property: JsonPropertyName("tags_total")] long TagsTotal,
		[property: JsonPropertyName("links")] TagsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static TagsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static TagsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			TagsListResponseTags v0 = null!;
			long v1 = default;
			TagsListResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("tags"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : TagsListResponseTags.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("tags_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : TagsListResponseLinks.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new TagsListResponse(v0, v1, v2, v3);
		}
	}

public sealed record TagsListResponseTags(
	[property: JsonPropertyName("1")] string _1,
	[property: JsonPropertyName("2")] string _2,
	[property: JsonPropertyName("3")] string _3,
	[property: JsonPropertyName("4")] string _4,
	[property: JsonPropertyName("5")] string _5,
	[property: JsonPropertyName("6")] string _6,
	[property: JsonPropertyName("7")] string _7,
	[property: JsonPropertyName("8")] string _8,
	[property: JsonPropertyName("9")] string _9,
	[property: JsonPropertyName("10")] string _10,
	[property: JsonPropertyName("11")] string _11,
	[property: JsonPropertyName("12")] string _12,
	[property: JsonPropertyName("14")] string _14,
	[property: JsonPropertyName("15")] string _15,
	[property: JsonPropertyName("16")] string _16,
	[property: JsonPropertyName("17")] string _17,
	[property: JsonPropertyName("18")] string _18,
	[property: JsonPropertyName("19")] string _19,
	[property: JsonPropertyName("20")] string _20
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsListResponseTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsListResponseTags ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		string v10 = null!;
		string v11 = null!;
		string v12 = null!;
		string v13 = null!;
		string v14 = null!;
		string v15 = null!;
		string v16 = null!;
		string v17 = null!;
		string v18 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("2"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("3"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("4"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("5"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("6"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("7"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("8"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("9"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("10"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("11"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("12"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("14"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("15"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("16"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("17"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("18"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("19"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("20"u8))
			{
				reader.Read();
				v18 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsListResponseTags(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
	}
}

public sealed record TagsListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsListResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsListResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new TagsListResponseLinks(v0, v1, v2);
	}
}

	public sealed record TagsGetParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record TagsGetResponse(
		[property: JsonPropertyName("tag")] TagsGetResponseTag Tag,
		[property: JsonPropertyName("tagged")] List<TagsGetResponseTagged> Tagged,
		[property: JsonPropertyName("tagged_total")] long TaggedTotal,
		[property: JsonPropertyName("links")] TagsGetResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static TagsGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static TagsGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			TagsGetResponseTag v0 = null!;
			List<TagsGetResponseTagged> v1 = null!;
			long v2 = default;
			TagsGetResponseLinks v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("tag"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTag.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("tagged"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<TagsGetResponseTagged>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = TagsGetResponseTagged.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v1 = __lst;
					}
				}
				else if (reader.ValueTextEquals("tagged_total"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseLinks.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v4 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new TagsGetResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record TagsGetResponseTagLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTagLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTagLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTagLinks(v0, v1);
	}
}

public sealed record TagsGetResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("tag_text")] string TagText,
	[property: JsonPropertyName("tag_use_count")] long TagUseCount,
	[property: JsonPropertyName("links")] TagsGetResponseTagLinks Links
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTag ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTag ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		TagsGetResponseTagLinks v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("tag_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("tag_text"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("tag_use_count"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTagLinks.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTag(v0, v1, v2, v3);
	}
}

public sealed record TagsGetResponseTaggedFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("attachments")] string Attachments,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedFirstPostLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedFirstPostLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		string v7 = null!;
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
			else if (reader.ValueTextEquals("thread"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("likes"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("report"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("attachments"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_avatar"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedFirstPostLinks(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record TagsGetResponseTaggedFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedFirstPostPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedFirstPostPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
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
			else if (reader.ValueTextEquals("reply"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("like"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("report"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("upload_attachment"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedFirstPostPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record TagsGetResponseTaggedFirstPost(
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_body_html")] string PostBodyHtml,
	[property: JsonPropertyName("post_body_plain_text")] string PostBodyPlainText,
	[property: JsonPropertyName("signature")] string Signature,
	[property: JsonPropertyName("signature_html")] string SignatureHtml,
	[property: JsonPropertyName("signature_plain_text")] string SignaturePlainText,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] TagsGetResponseTaggedFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] TagsGetResponseTaggedFirstPostPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedFirstPost ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedFirstPost ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		string v10 = null!;
		string v11 = null!;
		long v12 = default;
		long v13 = default;
		bool v14 = default;
		bool v15 = default;
		bool v16 = default;
		long v17 = default;
		bool v18 = default;
		TagsGetResponseTaggedFirstPostLinks v19 = null!;
		TagsGetResponseTaggedFirstPostPermissions v20 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("post_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poster_user_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poster_username"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_username_html"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_create_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_body"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_body_html"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_body_plain_text"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature_html"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature_plain_text"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_like_count"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_attachment_count"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_update_date"u8))
			{
				reader.Read();
				v17 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_is_first_post"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedFirstPostLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedFirstPostPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedFirstPost(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
	}
}

public sealed record TagsGetResponseTaggedThreadPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedThreadPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedThreadPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("prefix_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("prefix_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedThreadPrefixes(v0, v1);
	}
}

public sealed record TagsGetResponseTaggedThreadTags(
	[property: JsonPropertyName("1")] string _1,
	[property: JsonPropertyName("654")] string _654
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedThreadTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedThreadTags ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("654"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedThreadTags(v0, v1);
	}
}

public sealed record TagsGetResponseTaggedLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_poster")] string LastPoster,
	[property: JsonPropertyName("last_post")] string LastPost
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
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
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("posts"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("first_poster"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("first_poster_avatar"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("first_post"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("last_poster"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("last_post"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
	}
}

public sealed record TagsGetResponseTaggedPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("upload_attachment"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record TagsGetResponseTaggedForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedForumForumPrefixesGroupPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedForumForumPrefixesGroupPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("prefix_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("prefix_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedForumForumPrefixesGroupPrefixes(v0, v1);
	}
}

public sealed record TagsGetResponseTaggedForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<TagsGetResponseTaggedForumForumPrefixesGroupPrefixes> GroupPrefixes
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedForumForumPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedForumForumPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		List<TagsGetResponseTaggedForumForumPrefixesGroupPrefixes> v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("group_title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("group_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<TagsGetResponseTaggedForumForumPrefixesGroupPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = TagsGetResponseTaggedForumForumPrefixesGroupPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v1 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedForumForumPrefixes(v0, v1);
	}
}

public sealed record TagsGetResponseTaggedForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedForumLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedForumLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
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
			else if (reader.ValueTextEquals("threads"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedForumLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record TagsGetResponseTaggedForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedForumPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedForumPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
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
			else if (reader.ValueTextEquals("create_thread"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("upload_attachment"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tag_thread"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedForumPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record TagsGetResponseTaggedForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<TagsGetResponseTaggedForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] TagsGetResponseTaggedForumLinks Links,
	[property: JsonPropertyName("permissions")] TagsGetResponseTaggedForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTaggedForum ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTaggedForum ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		List<TagsGetResponseTaggedForumForumPrefixes> v5 = null!;
		long v6 = default;
		bool v7 = default;
		TagsGetResponseTaggedForumLinks v8 = null!;
		TagsGetResponseTaggedForumPermissions v9 = null!;
		bool v10 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_thread_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_post_count"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<TagsGetResponseTaggedForumForumPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = TagsGetResponseTaggedForumForumPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v5 = __lst;
				}
			}
			else if (reader.ValueTextEquals("thread_default_prefix_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_prefix_is_required"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedForumLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedForumPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum_is_followed"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTaggedForum(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record TagsGetResponseTagged(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("thread_title")] string ThreadTitle,
	[property: JsonPropertyName("thread_view_count")] long ThreadViewCount,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("thread_create_date")] long ThreadCreateDate,
	[property: JsonPropertyName("thread_update_date")] long ThreadUpdateDate,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("thread_post_count")] long ThreadPostCount,
	[property: JsonPropertyName("thread_is_published")] bool ThreadIsPublished,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted,
	[property: JsonPropertyName("thread_is_sticky")] bool ThreadIsSticky,
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] TagsGetResponseTaggedFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<TagsGetResponseTaggedThreadPrefixes> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] TagsGetResponseTaggedThreadTags ThreadTags,
	[property: JsonPropertyName("links")] TagsGetResponseTaggedLinks Links,
	[property: JsonPropertyName("permissions")] TagsGetResponseTaggedPermissions Permissions,
	[property: JsonPropertyName("forum")] TagsGetResponseTaggedForum Forum
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseTagged ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseTagged ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		string v4 = null!;
		long v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		long v9 = default;
		long v10 = default;
		bool v11 = default;
		long v12 = default;
		bool v13 = default;
		bool v14 = default;
		bool v15 = default;
		bool v16 = default;
		TagsGetResponseTaggedFirstPost v17 = null!;
		List<TagsGetResponseTaggedThreadPrefixes> v18 = null!;
		TagsGetResponseTaggedThreadTags v19 = null!;
		TagsGetResponseTaggedLinks v20 = null!;
		TagsGetResponseTaggedPermissions v21 = null!;
		TagsGetResponseTaggedForum v22 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("content_type"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("content_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_title"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("thread_view_count"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("creator_user_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("creator_username"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("creator_username_html"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("thread_create_date"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_update_date"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_post_count"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_is_published"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_deleted"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_sticky"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_followed"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("first_post"u8))
			{
				reader.Read();
				v17 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedFirstPost.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("thread_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<TagsGetResponseTaggedThreadPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = TagsGetResponseTaggedThreadPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v18 = __lst;
				}
			}
			else if (reader.ValueTextEquals("thread_tags"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedThreadTags.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v21 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum"u8))
			{
				reader.Read();
				v22 = reader.TokenType == JsonTokenType.Null ? null! : TagsGetResponseTaggedForum.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new TagsGetResponseTagged(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22);
	}
}

public sealed record TagsGetResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagsGetResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagsGetResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new TagsGetResponseLinks(v0, v1, v2);
	}
}

	public sealed record TagsFindParams
	{
		[JsonPropertyName("tag")]
		public required string Tag { get; init; }
	}

	public sealed record TagsFindResponse(
		[property: JsonPropertyName("tags")] List<string> Tags,
		[property: JsonPropertyName("ids")] List<long> Ids,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static TagsFindResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static TagsFindResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<string> v0 = null!;
			List<long> v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("tags"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<string>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = reader.GetString()!;
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("ids"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<long>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = reader.GetInt64();
							__lst.Add(__item);
						}
						v1 = __lst;
					}
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
			return new TagsFindResponse(v0, v1, v2);
		}
	}

}
