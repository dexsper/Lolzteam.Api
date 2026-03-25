// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class ProfilePostsApiTypes
{
	public sealed record ProfilePostsListParams
	{
		[JsonPropertyName("posts_user_id")]
		public long? PostsUserId { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		[JsonPropertyName("fields_include")]
		public List<ProfilePostsFieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record ProfilePostsListResponse(
		[property: JsonPropertyName("profile_posts")] List<Resp_ProfilePostModel> ProfilePosts,
		[property: JsonPropertyName("totalProfilePosts")] long TotalProfilePosts,
		[property: JsonPropertyName("canPostOnProfile")] bool CanPostOnProfile,
		[property: JsonPropertyName("links")] ProfilePostsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ProfilePostModel> v0 = null!;
			long v1 = default;
			bool v2 = default;
			ProfilePostsListResponseLinks v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("profile_posts"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_ProfilePostModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_ProfilePostModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("totalProfilePosts"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("canPostOnProfile"u8))
				{
					reader.Read();
					v2 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsListResponseLinks.ReadFromReader(ref reader);
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
			return new ProfilePostsListResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record ProfilePostsListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsListResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsListResponseLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ProfilePostsListResponseLinks(v0, v1, v2);
	}
}

	public sealed record ProfilePostsGetResponse(
		[property: JsonPropertyName("profile_post")] Resp_ProfilePostModel ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ProfilePostModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("profile_post"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ProfilePostModel.ReadFromReader(ref reader);
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
			return new ProfilePostsGetResponse(v0, v1);
		}
	}

	public sealed record ProfilePostsEditBody
	{
		[JsonPropertyName("post_body")]
		public string? PostBody { get; init; }
		[JsonPropertyName("disable_comments")]
		public bool? DisableComments { get; init; }
	}

	public sealed record ProfilePostsEditResponse(
		[property: JsonPropertyName("profile_post")] ProfilePostsEditResponseProfilePost ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsEditResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ProfilePostsEditResponseProfilePost v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("profile_post"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsEditResponseProfilePost.ReadFromReader(ref reader);
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
			return new ProfilePostsEditResponse(v0, v1);
		}
	}

public sealed record ProfilePostsEditResponseProfilePostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsEditResponseProfilePostLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsEditResponseProfilePostLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("timeline"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline_user"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("likes"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comments"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("report"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_avatar"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsEditResponseProfilePostLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record ProfilePostsEditResponseProfilePostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsEditResponseProfilePostPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsEditResponseProfilePostPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("like"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("comment"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("report"u8))
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
		return new ProfilePostsEditResponseProfilePostPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ProfilePostsEditResponseProfilePost(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("links")] ProfilePostsEditResponseProfilePostLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsEditResponseProfilePostPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsEditResponseProfilePost ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsEditResponseProfilePost ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		long v7 = default;
		long v8 = default;
		string v9 = null!;
		bool v10 = default;
		bool v11 = default;
		bool v12 = default;
		ProfilePostsEditResponseProfilePostLinks v13 = null!;
		ProfilePostsEditResponseProfilePostPermissions v14 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("profile_post_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeline_user_id"u8))
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
			else if (reader.ValueTextEquals("post_like_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_comment_count"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeline_username"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsEditResponseProfilePostLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v14 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsEditResponseProfilePostPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsEditResponseProfilePost(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);
	}
}

	public sealed record ProfilePostsDeleteParams
	{
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record ProfilePostsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsDeleteResponse(v0, v1, v2);
		}
	}

	public sealed record ProfilePostsReportReasonsResponse(
		[property: JsonPropertyName("reasons")] List<string> Reasons,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsReportReasonsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsReportReasonsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<string> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("reasons"u8))
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
			return new ProfilePostsReportReasonsResponse(v0, v1);
		}
	}

	public sealed record ProfilePostsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ProfilePostsReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsReportResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsReportResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsReportResponse(v0, v1, v2);
		}
	}

	public sealed record ProfilePostsCreateBody
	{
		[JsonPropertyName("user_id")]
		public required Lolzteam.Api.Runtime.StringOrLong UserId { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ProfilePostsCreateResponse(
		[property: JsonPropertyName("profile_post")] ProfilePostsCreateResponseProfilePost ProfilePost,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsCreateResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsCreateResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ProfilePostsCreateResponseProfilePost v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("profile_post"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCreateResponseProfilePost.ReadFromReader(ref reader);
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
			return new ProfilePostsCreateResponse(v0, v1);
		}
	}

public sealed record ProfilePostsCreateResponseProfilePostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCreateResponseProfilePostLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCreateResponseProfilePostLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("timeline"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline_user"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("likes"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comments"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("report"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_avatar"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCreateResponseProfilePostLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record ProfilePostsCreateResponseProfilePostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCreateResponseProfilePostPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCreateResponseProfilePostPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("like"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("comment"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("report"u8))
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
		return new ProfilePostsCreateResponseProfilePostPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ProfilePostsCreateResponseProfilePost(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("links")] ProfilePostsCreateResponseProfilePostLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCreateResponseProfilePostPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCreateResponseProfilePost ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCreateResponseProfilePost ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		long v7 = default;
		long v8 = default;
		string v9 = null!;
		bool v10 = default;
		bool v11 = default;
		bool v12 = default;
		ProfilePostsCreateResponseProfilePostLinks v13 = null!;
		ProfilePostsCreateResponseProfilePostPermissions v14 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("profile_post_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeline_user_id"u8))
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
			else if (reader.ValueTextEquals("post_like_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_comment_count"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeline_username"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCreateResponseProfilePostLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v14 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCreateResponseProfilePostPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCreateResponseProfilePost(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);
	}
}

	public sealed record ProfilePostsStickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsStickResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsStickResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsStickResponse(v0, v1, v2);
		}
	}

	public sealed record ProfilePostsUnstickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsUnstickResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsUnstickResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsUnstickResponse(v0, v1, v2);
		}
	}

	public sealed record ProfilePostsLikesResponse(
		[property: JsonPropertyName("users")] List<ProfilePostsLikesResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsLikesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsLikesResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ProfilePostsLikesResponseUsers> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ProfilePostsLikesResponseUsers>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ProfilePostsLikesResponseUsers.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
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
			return new ProfilePostsLikesResponse(v0, v1);
		}
	}

public sealed record ProfilePostsLikesResponseUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsLikesResponseUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsLikesResponseUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("username"u8))
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
		return new ProfilePostsLikesResponseUsers(v0, v1);
	}
}

	public sealed record ProfilePostsLikeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsLikeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsLikeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsLikeResponse(v0, v1, v2);
		}
	}

	public sealed record ProfilePostsUnlikeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsUnlikeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsUnlikeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsUnlikeResponse(v0, v1, v2);
		}
	}

	public sealed record ProfilePostsCommentsListParams
	{
		[JsonPropertyName("profile_post_id")]
		public required long? ProfilePostId { get; init; }
		[JsonPropertyName("before")]
		public long? Before { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record ProfilePostsCommentsListResponse(
		[property: JsonPropertyName("comments")] List<Resp_ProfilePostCommentModel> Comments,
		[property: JsonPropertyName("comments_total")] long CommentsTotal,
		[property: JsonPropertyName("profile_post")] ProfilePostsCommentsListResponseProfilePost ProfilePost,
		[property: JsonPropertyName("timeline_user")] Resp_UserModel TimelineUser,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsCommentsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsCommentsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ProfilePostCommentModel> v0 = null!;
			long v1 = default;
			ProfilePostsCommentsListResponseProfilePost v2 = null!;
			Resp_UserModel v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("comments"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_ProfilePostCommentModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_ProfilePostCommentModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("comments_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("profile_post"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsListResponseProfilePost.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("timeline_user"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
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
			return new ProfilePostsCommentsListResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record ProfilePostsCommentsListResponseProfilePostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("comments")] string Comments,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsListResponseProfilePostLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsListResponseProfilePostLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("timeline"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline_user"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("likes"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comments"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("report"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_avatar"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCommentsListResponseProfilePostLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record ProfilePostsCommentsListResponseProfilePostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsListResponseProfilePostPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsListResponseProfilePostPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("like"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("comment"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("report"u8))
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
		return new ProfilePostsCommentsListResponseProfilePostPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ProfilePostsCommentsListResponseProfilePost(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("links")] ProfilePostsCommentsListResponseProfilePostLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCommentsListResponseProfilePostPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsListResponseProfilePost ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsListResponseProfilePost ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		long v7 = default;
		long v8 = default;
		string v9 = null!;
		bool v10 = default;
		bool v11 = default;
		bool v12 = default;
		ProfilePostsCommentsListResponseProfilePostLinks v13 = null!;
		ProfilePostsCommentsListResponseProfilePostPermissions v14 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("profile_post_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeline_user_id"u8))
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
			else if (reader.ValueTextEquals("post_like_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_comment_count"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeline_username"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsListResponseProfilePostLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v14 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsListResponseProfilePostPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCommentsListResponseProfilePost(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);
	}
}

	public sealed record ProfilePostsCommentsCreateBody
	{
		[JsonPropertyName("profile_post_id")]
		public required long? ProfilePostId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsCreateResponse(
		[property: JsonPropertyName("comment")] ProfilePostsCommentsCreateResponseComment Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsCommentsCreateResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsCommentsCreateResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ProfilePostsCommentsCreateResponseComment v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("comment"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsCreateResponseComment.ReadFromReader(ref reader);
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
			return new ProfilePostsCommentsCreateResponse(v0, v1);
		}
	}

public sealed record ProfilePostsCommentsCreateResponseCommentLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("profile_post")] string ProfilePost,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsCreateResponseCommentLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsCreateResponseCommentLinks ReadFromReader(ref Utf8JsonReader reader)
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

			if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("profile_post"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline_user"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_avatar"u8))
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
		return new ProfilePostsCommentsCreateResponseCommentLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ProfilePostsCommentsCreateResponseCommentPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsCreateResponseCommentPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsCreateResponseCommentPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCommentsCreateResponseCommentPermissions(v0, v1);
	}
}

public sealed record ProfilePostsCommentsCreateResponseComment(
	[property: JsonPropertyName("comment_id")] long CommentId,
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("comment_user_id")] long CommentUserId,
	[property: JsonPropertyName("comment_username")] string CommentUsername,
	[property: JsonPropertyName("comment_username_html")] string CommentUsernameHtml,
	[property: JsonPropertyName("comment_create_date")] long CommentCreateDate,
	[property: JsonPropertyName("comment_body")] string CommentBody,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("links")] ProfilePostsCommentsCreateResponseCommentLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCommentsCreateResponseCommentPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsCreateResponseComment ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsCreateResponseComment ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		bool v7 = default;
		long v8 = default;
		ProfilePostsCommentsCreateResponseCommentLinks v9 = null!;
		ProfilePostsCommentsCreateResponseCommentPermissions v10 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("comment_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("profile_post_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("comment_user_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("comment_username"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comment_username_html"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comment_create_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("comment_body"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("timeline_user_id"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsCreateResponseCommentLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsCreateResponseCommentPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCommentsCreateResponseComment(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

	public sealed record ProfilePostsCommentsEditBody
	{
		[JsonPropertyName("comment_id")]
		public required long? CommentId { get; init; }
		[JsonPropertyName("comment_body")]
		public required string CommentBody { get; init; }
	}

	public sealed record ProfilePostsCommentsEditResponse(
		[property: JsonPropertyName("comment")] ProfilePostsCommentsEditResponseComment Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsCommentsEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsCommentsEditResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ProfilePostsCommentsEditResponseComment v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("comment"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsEditResponseComment.ReadFromReader(ref reader);
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
			return new ProfilePostsCommentsEditResponse(v0, v1);
		}
	}

public sealed record ProfilePostsCommentsEditResponseCommentLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("profile_post")] string ProfilePost,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsEditResponseCommentLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsEditResponseCommentLinks ReadFromReader(ref Utf8JsonReader reader)
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

			if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("profile_post"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline_user"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_avatar"u8))
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
		return new ProfilePostsCommentsEditResponseCommentLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ProfilePostsCommentsEditResponseCommentPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsEditResponseCommentPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsEditResponseCommentPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCommentsEditResponseCommentPermissions(v0, v1);
	}
}

public sealed record ProfilePostsCommentsEditResponseComment(
	[property: JsonPropertyName("comment_id")] long CommentId,
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("comment_user_id")] long CommentUserId,
	[property: JsonPropertyName("comment_username")] string CommentUsername,
	[property: JsonPropertyName("comment_username_html")] string CommentUsernameHtml,
	[property: JsonPropertyName("comment_create_date")] long CommentCreateDate,
	[property: JsonPropertyName("comment_body")] string CommentBody,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("links")] ProfilePostsCommentsEditResponseCommentLinks Links,
	[property: JsonPropertyName("permissions")] ProfilePostsCommentsEditResponseCommentPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfilePostsCommentsEditResponseComment ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfilePostsCommentsEditResponseComment ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		bool v7 = default;
		long v8 = default;
		ProfilePostsCommentsEditResponseCommentLinks v9 = null!;
		ProfilePostsCommentsEditResponseCommentPermissions v10 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("comment_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("profile_post_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("comment_user_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("comment_username"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comment_username_html"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comment_create_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("comment_body"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("timeline_user_id"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsEditResponseCommentLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : ProfilePostsCommentsEditResponseCommentPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfilePostsCommentsEditResponseComment(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

	public sealed record ProfilePostsCommentsDeleteBody
	{
		[JsonPropertyName("comment_id")]
		public required long? CommentId { get; init; }
	}

	public sealed record ProfilePostsCommentsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsCommentsDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsCommentsDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsCommentsDeleteResponse(v0, v1, v2);
		}
	}

	public sealed record ProfilePostsCommentsGetResponse(
		[property: JsonPropertyName("comment")] Resp_ProfilePostCommentModel Comment,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsCommentsGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsCommentsGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ProfilePostCommentModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("comment"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ProfilePostCommentModel.ReadFromReader(ref reader);
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
			return new ProfilePostsCommentsGetResponse(v0, v1);
		}
	}

	public sealed record ProfilePostsCommentsReportBody
	{
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ProfilePostsCommentsReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfilePostsCommentsReportResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfilePostsCommentsReportResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
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
			return new ProfilePostsCommentsReportResponse(v0, v1, v2);
		}
	}

}
