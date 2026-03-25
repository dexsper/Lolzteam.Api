// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class ManagingApiTypes
{
	public sealed record ManagingGetParams
	{
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record ManagingGetResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("canStickItem")] bool CanStickItem,
		[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
		[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
		[property: JsonPropertyName("cannotBuyItemError")] string CannotBuyItemError,
		[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
		[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
		[property: JsonPropertyName("canReportItem")] bool CanReportItem,
		[property: JsonPropertyName("canEditItem")] bool CanEditItem,
		[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
		[property: JsonPropertyName("canCancelConfirmedBuy")] bool CanCancelConfirmedBuy,
		[property: JsonPropertyName("canViewItemHistory")] bool CanViewItemHistory,
		[property: JsonPropertyName("faveCount")] bool FaveCount,
		[property: JsonPropertyName("isVisibleItem")] bool IsVisibleItem,
		[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
		[property: JsonPropertyName("showToFavouritesButton")] bool ShowToFavouritesButton,
		[property: JsonPropertyName("itemLink")] string ItemLink,
		[property: JsonPropertyName("canChangeOwner")] bool CanChangeOwner,
		[property: JsonPropertyName("sameItemsIds")] List<long> SameItemsIds,
		[property: JsonPropertyName("sameItemsCount")] long SameItemsCount,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ItemModel v0 = null!;
			bool v1 = default;
			bool v2 = default;
			bool v3 = default;
			string v4 = null!;
			bool v5 = default;
			bool v6 = default;
			bool v7 = default;
			bool v8 = default;
			bool v9 = default;
			bool v10 = default;
			bool v11 = default;
			bool v12 = default;
			bool v13 = default;
			bool v14 = default;
			bool v15 = default;
			string v16 = null!;
			bool v17 = default;
			List<long> v18 = null!;
			long v19 = default;
			Resp_SystemInfo v20 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("canStickItem"u8))
				{
					reader.Read();
					v1 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canUnstickItem"u8))
				{
					reader.Read();
					v2 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canBuyItem"u8))
				{
					reader.Read();
					v3 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("cannotBuyItemError"u8))
				{
					reader.Read();
					v4 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("canCloseItem"u8))
				{
					reader.Read();
					v5 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canOpenItem"u8))
				{
					reader.Read();
					v6 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canReportItem"u8))
				{
					reader.Read();
					v7 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canEditItem"u8))
				{
					reader.Read();
					v8 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canDeleteItem"u8))
				{
					reader.Read();
					v9 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canCancelConfirmedBuy"u8))
				{
					reader.Read();
					v10 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canViewItemHistory"u8))
				{
					reader.Read();
					v11 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("faveCount"u8))
				{
					reader.Read();
					v12 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("isVisibleItem"u8))
				{
					reader.Read();
					v13 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("canViewLoginData"u8))
				{
					reader.Read();
					v14 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("showToFavouritesButton"u8))
				{
					reader.Read();
					v15 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("itemLink"u8))
				{
					reader.Read();
					v16 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("canChangeOwner"u8))
				{
					reader.Read();
					v17 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("sameItemsIds"u8))
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
						v18 = __lst;
					}
				}
				else if (reader.ValueTextEquals("sameItemsCount"u8))
				{
					reader.Read();
					v19 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v20 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ManagingGetResponse(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
		}
	}

	public sealed record ManagingDeleteBody
	{
		[JsonPropertyName("reason")]
		public required string Reason { get; init; }
	}

	public sealed record ManagingDeleteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingDeleteResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingCreateClaimBody
	{
		[JsonPropertyName("item_id")]
		public required long? ItemId { get; init; }
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ManagingCreateClaimResponse(
		[property: JsonPropertyName("thread")] ManagingCreateClaimResponseThread Thread,
		[property: JsonPropertyName("system_info")] ManagingCreateClaimResponseSystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingCreateClaimResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingCreateClaimResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ManagingCreateClaimResponseThread v0 = null!;
			ManagingCreateClaimResponseSystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("thread"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThread.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseSystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ManagingCreateClaimResponse(v0, v1);
		}
	}

public sealed record ManagingCreateClaimResponseThreadFirstPostLikeUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("display_style_group_id")] long? DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] long? IsBanned,
	[property: JsonPropertyName("uniq_username_css")] string? UniqUsernameCss
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThreadFirstPostLikeUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadFirstPostLikeUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		string v4 = null!;
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
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingCreateClaimResponseThreadFirstPostLikeUsers(v0, v1, v2, v3, v4);
	}
}

public sealed record ManagingCreateClaimResponseThreadFirstPostLinks(
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
	public static ManagingCreateClaimResponseThreadFirstPostLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadFirstPostLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ManagingCreateClaimResponseThreadFirstPostLinks(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record ManagingCreateClaimResponseThreadFirstPostPermissions(
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
	public static ManagingCreateClaimResponseThreadFirstPostPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadFirstPostPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new ManagingCreateClaimResponseThreadFirstPostPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ManagingCreateClaimResponseThreadFirstPost(
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_body_html")] string PostBodyHtml,
	[property: JsonPropertyName("post_body_plain_text")] string PostBodyPlainText,
	[property: JsonPropertyName("signature")] string Signature,
	[property: JsonPropertyName("signature_html")] string SignatureHtml,
	[property: JsonPropertyName("signature_plain_text")] string SignaturePlainText,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_attachment_count")] long PostAttachmentCount,
	[property: JsonPropertyName("like_users")] List<ManagingCreateClaimResponseThreadFirstPostLikeUsers> LikeUsers,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] ManagingCreateClaimResponseThreadFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] ManagingCreateClaimResponseThreadFirstPostPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThreadFirstPost ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadFirstPost ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		long v4 = default;
		string v5 = null!;
		string v6 = null!;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		string v10 = null!;
		long v11 = default;
		long v12 = default;
		List<ManagingCreateClaimResponseThreadFirstPostLikeUsers> v13 = null!;
		bool v14 = default;
		bool v15 = default;
		bool v16 = default;
		long v17 = default;
		bool v18 = default;
		ManagingCreateClaimResponseThreadFirstPostLinks v19 = null!;
		ManagingCreateClaimResponseThreadFirstPostPermissions v20 = null!;
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
			else if (reader.ValueTextEquals("post_create_date"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_body"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_body_html"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_body_plain_text"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature_html"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature_plain_text"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_like_count"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_attachment_count"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_users"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ManagingCreateClaimResponseThreadFirstPostLikeUsers>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ManagingCreateClaimResponseThreadFirstPostLikeUsers.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v13 = __lst;
				}
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
				v19 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadFirstPostLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadFirstPostPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingCreateClaimResponseThreadFirstPost(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
	}
}

public sealed record ManagingCreateClaimResponseThreadLinks(
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
	public static ManagingCreateClaimResponseThreadLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ManagingCreateClaimResponseThreadLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
	}
}

public sealed record ManagingCreateClaimResponseThreadPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("edit")] bool Edit
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThreadPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new ManagingCreateClaimResponseThreadPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes ReadFromReader(ref Utf8JsonReader reader)
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
		return new ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes(v0, v1);
	}
}

public sealed record ManagingCreateClaimResponseThreadForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes> GroupPrefixes
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThreadForumForumPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadForumForumPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		List<ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes> v1 = null!;
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
					var __lst = new List<ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ManagingCreateClaimResponseThreadForumForumPrefixesGroupPrefixes.ReadFromReader(ref reader);
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
		return new ManagingCreateClaimResponseThreadForumForumPrefixes(v0, v1);
	}
}

public sealed record ManagingCreateClaimResponseThreadForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThreadForumLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadForumLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ManagingCreateClaimResponseThreadForumLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ManagingCreateClaimResponseThreadForumPermissions(
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
	public static ManagingCreateClaimResponseThreadForumPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadForumPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new ManagingCreateClaimResponseThreadForumPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ManagingCreateClaimResponseThreadForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ManagingCreateClaimResponseThreadForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ManagingCreateClaimResponseThreadForumLinks Links,
	[property: JsonPropertyName("permissions")] ManagingCreateClaimResponseThreadForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThreadForum ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThreadForum ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		List<ManagingCreateClaimResponseThreadForumForumPrefixes> v5 = null!;
		long v6 = default;
		bool v7 = default;
		ManagingCreateClaimResponseThreadForumLinks v8 = null!;
		ManagingCreateClaimResponseThreadForumPermissions v9 = null!;
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
					var __lst = new List<ManagingCreateClaimResponseThreadForumForumPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ManagingCreateClaimResponseThreadForumForumPrefixes.ReadFromReader(ref reader);
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
				v8 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadForumLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadForumPermissions.ReadFromReader(ref reader);
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
		return new ManagingCreateClaimResponseThreadForum(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record ManagingCreateClaimResponseThread(
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("thread_title")] string ThreadTitle,
	[property: JsonPropertyName("thread_view_count")] long ThreadViewCount,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("thread_create_date")] long ThreadCreateDate,
	[property: JsonPropertyName("thread_update_date")] long ThreadUpdateDate,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("thread_post_count")] long ThreadPostCount,
	[property: JsonPropertyName("thread_is_published")] bool ThreadIsPublished,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted,
	[property: JsonPropertyName("thread_is_sticky")] bool ThreadIsSticky,
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("first_post")] ManagingCreateClaimResponseThreadFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] ManagingCreateClaimResponseThreadLinks Links,
	[property: JsonPropertyName("permissions")] ManagingCreateClaimResponseThreadPermissions Permissions,
	[property: JsonPropertyName("forum")] ManagingCreateClaimResponseThreadForum Forum
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseThread ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseThread ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		string v5 = null!;
		long v6 = default;
		long v7 = default;
		bool v8 = default;
		long v9 = default;
		bool v10 = default;
		bool v11 = default;
		bool v12 = default;
		bool v13 = default;
		ManagingCreateClaimResponseThreadFirstPost v14 = null!;
		List<JsonElement> v15 = null!;
		List<JsonElement> v16 = null!;
		ManagingCreateClaimResponseThreadLinks v17 = null!;
		ManagingCreateClaimResponseThreadPermissions v18 = null!;
		ManagingCreateClaimResponseThreadForum v19 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_title"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("thread_view_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("creator_user_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("creator_username"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("thread_create_date"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_update_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_post_count"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_is_published"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_deleted"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_sticky"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_followed"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("first_post"u8))
			{
				reader.Read();
				v14 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadFirstPost.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("thread_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<JsonElement>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = JsonDocument.ParseValue(ref reader).RootElement.Clone();
						__lst.Add(__item);
					}
					v15 = __lst;
				}
			}
			else if (reader.ValueTextEquals("thread_tags"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<JsonElement>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = JsonDocument.ParseValue(ref reader).RootElement.Clone();
						__lst.Add(__item);
					}
					v16 = __lst;
				}
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v17 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v18 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : ManagingCreateClaimResponseThreadForum.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingCreateClaimResponseThread(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
	}
}

public sealed record ManagingCreateClaimResponseSystemInfo(
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingCreateClaimResponseSystemInfo ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingCreateClaimResponseSystemInfo ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("visitor_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("time"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingCreateClaimResponseSystemInfo(v0, v1);
	}
}

	public sealed record ManagingBulkGetBody
	{
		[JsonPropertyName("item_id")]
		public List<long?>? ItemId { get; init; }
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record ManagingBulkGetResponse(
		[property: JsonPropertyName("items")] List<ManagingBulkGetResponseItems> Items,
		[property: JsonPropertyName("left_item_id")] List<long> LeftItemId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingBulkGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingBulkGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ManagingBulkGetResponseItems> v0 = null!;
			List<long> v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("items"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ManagingBulkGetResponseItems>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ManagingBulkGetResponseItems.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("left_item_id"u8))
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
			return new ManagingBulkGetResponse(v0, v1, v2);
		}
	}

public sealed record ManagingBulkGetResponseItems(
	[property: JsonPropertyName("0")] ItemModel? _0
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingBulkGetResponseItems ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingBulkGetResponseItems ReadFromReader(ref Utf8JsonReader reader)
	{
		ItemModel v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("0"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingBulkGetResponseItems(v0);
	}
}

	public sealed record ManagingSteamInventoryValueParams
	{
		[JsonPropertyName("app_id")]
		public AppId? AppId { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("ignore_cache")]
		public bool? IgnoreCache { get; init; }
	}

	public sealed record ManagingSteamInventoryValueResponse(
		[property: JsonPropertyName("query")] string? Query,
		[property: JsonPropertyName("data")] ManagingSteamInventoryValueResponseData? Data,
		[property: JsonPropertyName("appId")] long? AppId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamInventoryValueResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamInventoryValueResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			ManagingSteamInventoryValueResponseData v1 = null!;
			long v2 = default;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("query"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("data"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamInventoryValueResponseData.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("appId"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
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
			return new ManagingSteamInventoryValueResponse(v0, v1, v2, v3);
		}
	}

public sealed record ManagingSteamInventoryValueResponseDataItems0Stickers(
	[property: JsonPropertyName("stickerCount")] long StickerCount,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("images")] List<string> Images,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamInventoryValueResponseDataItems0Stickers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamInventoryValueResponseDataItems0Stickers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		List<string> v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("stickerCount"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("count"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("images"u8))
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
					v2 = __lst;
				}
			}
			else if (reader.ValueTextEquals("title"u8))
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
		return new ManagingSteamInventoryValueResponseDataItems0Stickers(v0, v1, v2, v3);
	}
}

public sealed record ManagingSteamInventoryValueResponseDataItems0(
	[property: JsonPropertyName("classid")] string Classid,
	[property: JsonPropertyName("tradable")] long Tradable,
	[property: JsonPropertyName("marketable")] long Marketable,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("price")] double Price,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("market_hash_name")] string MarketHashName,
	[property: JsonPropertyName("fraudwarnings")] JsonElement Fraudwarnings,
	[property: JsonPropertyName("stickers")] ManagingSteamInventoryValueResponseDataItems0Stickers Stickers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamInventoryValueResponseDataItems0 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamInventoryValueResponseDataItems0 ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		double v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		JsonElement v9 = default;
		ManagingSteamInventoryValueResponseDataItems0Stickers v10 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("classid"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("tradable"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("marketable"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("image_url"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("price"u8))
			{
				reader.Read();
				v5 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("type"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("market_hash_name"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("fraudwarnings"u8))
			{
				reader.Read();
				v9 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("stickers"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamInventoryValueResponseDataItems0Stickers.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamInventoryValueResponseDataItems0(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record ManagingSteamInventoryValueResponseDataItems(
	[property: JsonPropertyName("0")] ManagingSteamInventoryValueResponseDataItems0? _0
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamInventoryValueResponseDataItems ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamInventoryValueResponseDataItems ReadFromReader(ref Utf8JsonReader reader)
	{
		ManagingSteamInventoryValueResponseDataItems0 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("0"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamInventoryValueResponseDataItems0.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamInventoryValueResponseDataItems(v0);
	}
}

public sealed record ManagingSteamInventoryValueResponseData(
	[property: JsonPropertyName("items")] ManagingSteamInventoryValueResponseDataItems Items,
	[property: JsonPropertyName("steam_id")] string SteamId,
	[property: JsonPropertyName("appId")] long AppId,
	[property: JsonPropertyName("appTitle")] string AppTitle,
	[property: JsonPropertyName("totalValue")] double TotalValue,
	[property: JsonPropertyName("itemCount")] long ItemCount,
	[property: JsonPropertyName("marketableItemCount")] long MarketableItemCount,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("currencyIcon")] string CurrencyIcon,
	[property: JsonPropertyName("language")] string Language,
	[property: JsonPropertyName("time")] long Time
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamInventoryValueResponseData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamInventoryValueResponseData ReadFromReader(ref Utf8JsonReader reader)
	{
		ManagingSteamInventoryValueResponseDataItems v0 = null!;
		string v1 = null!;
		long v2 = default;
		string v3 = null!;
		double v4 = default;
		long v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		long v10 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("items"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamInventoryValueResponseDataItems.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("steam_id"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("appId"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("appTitle"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("totalValue"u8))
			{
				reader.Read();
				v4 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("itemCount"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("marketableItemCount"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("currency"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("currencyIcon"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("language"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("time"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamInventoryValueResponseData(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

	public sealed record ManagingSteamValueParams
	{
		[JsonPropertyName("link")]
		public required string Link { get; init; }
		[JsonPropertyName("app_id")]
		public AppId? AppId { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("ignore_cache")]
		public bool? IgnoreCache { get; init; }
	}

	public sealed record ManagingSteamValueResponse(
		[property: JsonPropertyName("query")] string? Query,
		[property: JsonPropertyName("data")] ManagingSteamValueResponseData? Data,
		[property: JsonPropertyName("appId")] long? AppId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamValueResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamValueResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			ManagingSteamValueResponseData v1 = null!;
			long v2 = default;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("query"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("data"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamValueResponseData.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("appId"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
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
			return new ManagingSteamValueResponse(v0, v1, v2, v3);
		}
	}

public sealed record ManagingSteamValueResponseDataItems0Stickers(
	[property: JsonPropertyName("stickerCount")] long StickerCount,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("images")] List<string> Images,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamValueResponseDataItems0Stickers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamValueResponseDataItems0Stickers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		List<string> v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("stickerCount"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("count"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("images"u8))
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
					v2 = __lst;
				}
			}
			else if (reader.ValueTextEquals("title"u8))
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
		return new ManagingSteamValueResponseDataItems0Stickers(v0, v1, v2, v3);
	}
}

public sealed record ManagingSteamValueResponseDataItems0(
	[property: JsonPropertyName("classid")] string Classid,
	[property: JsonPropertyName("tradable")] long Tradable,
	[property: JsonPropertyName("marketable")] long Marketable,
	[property: JsonPropertyName("image_url")] string ImageUrl,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("price")] double Price,
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("market_hash_name")] string MarketHashName,
	[property: JsonPropertyName("fraudwarnings")] JsonElement Fraudwarnings,
	[property: JsonPropertyName("stickers")] ManagingSteamValueResponseDataItems0Stickers Stickers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamValueResponseDataItems0 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamValueResponseDataItems0 ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		double v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		JsonElement v9 = default;
		ManagingSteamValueResponseDataItems0Stickers v10 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("classid"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("tradable"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("marketable"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("image_url"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("price"u8))
			{
				reader.Read();
				v5 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("type"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("market_hash_name"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("fraudwarnings"u8))
			{
				reader.Read();
				v9 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("stickers"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamValueResponseDataItems0Stickers.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamValueResponseDataItems0(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record ManagingSteamValueResponseDataItems(
	[property: JsonPropertyName("0")] ManagingSteamValueResponseDataItems0? _0
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamValueResponseDataItems ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamValueResponseDataItems ReadFromReader(ref Utf8JsonReader reader)
	{
		ManagingSteamValueResponseDataItems0 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("0"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamValueResponseDataItems0.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamValueResponseDataItems(v0);
	}
}

public sealed record ManagingSteamValueResponseData(
	[property: JsonPropertyName("items")] ManagingSteamValueResponseDataItems Items,
	[property: JsonPropertyName("steam_id")] string SteamId,
	[property: JsonPropertyName("appId")] long AppId,
	[property: JsonPropertyName("appTitle")] string AppTitle,
	[property: JsonPropertyName("totalValue")] double TotalValue,
	[property: JsonPropertyName("itemCount")] long ItemCount,
	[property: JsonPropertyName("marketableItemCount")] long MarketableItemCount,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("currencyIcon")] string CurrencyIcon,
	[property: JsonPropertyName("language")] string Language,
	[property: JsonPropertyName("time")] long Time
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamValueResponseData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamValueResponseData ReadFromReader(ref Utf8JsonReader reader)
	{
		ManagingSteamValueResponseDataItems v0 = null!;
		string v1 = null!;
		long v2 = default;
		string v3 = null!;
		double v4 = default;
		long v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		long v10 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("items"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamValueResponseDataItems.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("steam_id"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("appId"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("appTitle"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("totalValue"u8))
			{
				reader.Read();
				v4 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("itemCount"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("marketableItemCount"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("currency"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("currencyIcon"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("language"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("time"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamValueResponseData(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

	public sealed record ManagingSteamPreviewParams
	{
		[JsonPropertyName("type")]
		public ManagingType? Type { get; init; }
	}

	public sealed record ManagingSteamPreviewResponse(string Data);

	public sealed record ManagingEditBody
	{
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		[JsonPropertyName("price")]
		public long? Price { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("item_origin")]
		public ManagingItemOrigin? ItemOrigin { get; init; }
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		[JsonPropertyName("email_type")]
		public EmailType? EmailType { get; init; }
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		[JsonPropertyName("proxy_id")]
		public long? ProxyId { get; init; }
		[JsonPropertyName("description")]
		public string? Description { get; init; }
		[JsonPropertyName("information")]
		public string? Information { get; init; }
	}

	public sealed record ManagingEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingEditResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingEditResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingAIPriceResponse(
		[property: JsonPropertyName("price")] long Price,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingAIPriceResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingAIPriceResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("price"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
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
			return new ManagingAIPriceResponse(v0, v1);
		}
	}

	public sealed record ManagingAutoBuyPriceResponse(
		[property: JsonPropertyName("price")] long Price,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingAutoBuyPriceResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingAutoBuyPriceResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("price"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
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
			return new ManagingAutoBuyPriceResponse(v0, v1);
		}
	}

	public sealed record ManagingNoteBody
	{
		[JsonPropertyName("text")]
		public string? Text { get; init; }
	}

	public sealed record ManagingNoteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingNoteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingNoteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingNoteResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingSteamUpdateValueBody
	{
		[JsonPropertyName("all")]
		public bool? All { get; init; }
		[JsonPropertyName("app_id")]
		public AppId? AppId { get; init; }
		[JsonPropertyName("authorize")]
		public bool? Authorize { get; init; }
	}

	public sealed record ManagingSteamUpdateValueResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamUpdateValueResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamUpdateValueResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			ItemModel v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("status"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
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
			return new ManagingSteamUpdateValueResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingBumpResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingBumpResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingBumpResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingBumpResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingAutoBumpBody
	{
		[JsonPropertyName("hour")]
		public required long? Hour { get; init; }
	}

	public sealed record ManagingAutoBumpResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingAutoBumpResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingAutoBumpResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingAutoBumpResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingAutoBumpDisableResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingAutoBumpDisableResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingAutoBumpDisableResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingAutoBumpDisableResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingOpenResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingOpenResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingOpenResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingOpenResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingCloseResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingCloseResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingCloseResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingCloseResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingImageParams
	{
		[JsonPropertyName("type")]
		public required ManagingType2 Type { get; init; }
	}

	public sealed record ManagingImageResponse(
		[property: JsonPropertyName("base64")] string Base64,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingImageResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingImageResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("base64"u8))
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
			return new ManagingImageResponse(v0, v1);
		}
	}

	public sealed record ManagingEmailCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codeData")] ManagingEmailCodeResponseCodeData CodeData
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingEmailCodeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingEmailCodeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ItemModel v0 = null!;
			ManagingEmailCodeResponseCodeData v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("codeData"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingEmailCodeResponseCodeData.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ManagingEmailCodeResponse(v0, v1);
		}
	}

public sealed record ManagingEmailCodeResponseCodeData(
	[property: JsonPropertyName("code")] string Code,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("textPlain")] string TextPlain
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingEmailCodeResponseCodeData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingEmailCodeResponseCodeData ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("code"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("textPlain"u8))
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
		return new ManagingEmailCodeResponseCodeData(v0, v1, v2);
	}
}

	public sealed record ManagingGetLetters2Params
	{
		[JsonPropertyName("email_password")]
		public string? EmailPassword { get; init; }
		[JsonPropertyName("email")]
		public string? Email { get; init; }
		[JsonPropertyName("password")]
		public string? Password { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record ManagingGetLetters2Response(
		[property: JsonPropertyName("email")] string Email,
		[property: JsonPropertyName("letters")] List<ManagingGetLetters2ResponseLetters> Letters,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingGetLetters2Response ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingGetLetters2Response ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			List<ManagingGetLetters2ResponseLetters> v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("email"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("letters"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ManagingGetLetters2ResponseLetters>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ManagingGetLetters2ResponseLetters.ReadFromReader(ref reader);
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
			return new ManagingGetLetters2Response(v0, v1, v2);
		}
	}

public sealed record ManagingGetLetters2ResponseLetters(
	[property: JsonPropertyName("textHtml")] string TextHtml,
	[property: JsonPropertyName("textPlain")] string TextPlain,
	[property: JsonPropertyName("from")] string From,
	[property: JsonPropertyName("date")] long Date
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingGetLetters2ResponseLetters ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingGetLetters2ResponseLetters ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("textHtml"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("textPlain"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("from"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("date"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingGetLetters2ResponseLetters(v0, v1, v2, v3);
	}
}

	public sealed record ManagingSteamGetMafileResponse(
		[property: JsonPropertyName("maFile")] ManagingSteamGetMafileResponseMaFile MaFile,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamGetMafileResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamGetMafileResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ManagingSteamGetMafileResponseMaFile v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("maFile"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamGetMafileResponseMaFile.ReadFromReader(ref reader);
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
			return new ManagingSteamGetMafileResponse(v0, v1);
		}
	}

public sealed record ManagingSteamGetMafileResponseMaFileSession(
	[property: JsonPropertyName("SessionID")] string SessionID,
	[property: JsonPropertyName("AccessToken")] string AccessToken,
	[property: JsonPropertyName("RefreshToken")] string RefreshToken,
	[property: JsonPropertyName("SteamID")] string SteamID,
	[property: JsonPropertyName("SteamLoginSecure")] string SteamLoginSecure
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamGetMafileResponseMaFileSession ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamGetMafileResponseMaFileSession ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("SessionID"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("AccessToken"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("RefreshToken"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("SteamID"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("SteamLoginSecure"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamGetMafileResponseMaFileSession(v0, v1, v2, v3, v4);
	}
}

public sealed record ManagingSteamGetMafileResponseMaFile(
	[property: JsonPropertyName("shared_secret")] string SharedSecret,
	[property: JsonPropertyName("serial_number")] long SerialNumber,
	[property: JsonPropertyName("revocation_code")] string RevocationCode,
	[property: JsonPropertyName("uri")] string Uri,
	[property: JsonPropertyName("account_name")] string AccountName,
	[property: JsonPropertyName("token_gid")] string TokenGid,
	[property: JsonPropertyName("identity_secret")] string IdentitySecret,
	[property: JsonPropertyName("secret_1")] string Secret_1,
	[property: JsonPropertyName("device_id")] string DeviceId,
	[property: JsonPropertyName("fully_enrolled")] bool FullyEnrolled,
	[property: JsonPropertyName("Session")] ManagingSteamGetMafileResponseMaFileSession Session
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamGetMafileResponseMaFile ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamGetMafileResponseMaFile ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		string v7 = null!;
		string v8 = null!;
		bool v9 = default;
		ManagingSteamGetMafileResponseMaFileSession v10 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("shared_secret"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("serial_number"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("revocation_code"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("uri"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("account_name"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("token_gid"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("identity_secret"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("secret_1"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("device_id"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("fully_enrolled"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("Session"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamGetMafileResponseMaFileSession.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingSteamGetMafileResponseMaFile(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

	public sealed record ManagingSteamAddMafileResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamAddMafileResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamAddMafileResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			ItemModel v2 = null!;
			Resp_SystemInfo v3 = null!;
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
				else if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
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
			return new ManagingSteamAddMafileResponse(v0, v1, v2, v3);
		}
	}

	public sealed record ManagingSteamRemoveMafileResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamRemoveMafileResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamRemoveMafileResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			ItemModel v2 = null!;
			Resp_SystemInfo v3 = null!;
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
				else if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
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
			return new ManagingSteamRemoveMafileResponse(v0, v1, v2, v3);
		}
	}

	public sealed record ManagingSteamMafileCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codeData")] ManagingSteamMafileCodeResponseCodeData CodeData
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamMafileCodeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamMafileCodeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ItemModel v0 = null!;
			ManagingSteamMafileCodeResponseCodeData v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("codeData"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingSteamMafileCodeResponseCodeData.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ManagingSteamMafileCodeResponse(v0, v1);
		}
	}

public sealed record ManagingSteamMafileCodeResponseCodeData(
	[property: JsonPropertyName("code")] string Code,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("textPlain")] string TextPlain
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingSteamMafileCodeResponseCodeData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingSteamMafileCodeResponseCodeData ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("code"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("textPlain"u8))
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
		return new ManagingSteamMafileCodeResponseCodeData(v0, v1, v2);
	}
}

	public sealed record ManagingSteamSDABody
	{
		[JsonPropertyName("id")]
		public long? Id { get; init; }
		[JsonPropertyName("nonce")]
		public long? Nonce { get; init; }
	}

	public sealed record ManagingSteamSDAResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingSteamSDAResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingSteamSDAResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingSteamSDAResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingTelegramCodeResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("codes")] ManagingTelegramCodeResponseCodes Codes
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingTelegramCodeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingTelegramCodeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ItemModel v0 = null!;
			ManagingTelegramCodeResponseCodes v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("codes"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingTelegramCodeResponseCodes.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ManagingTelegramCodeResponse(v0, v1);
		}
	}

public sealed record ManagingTelegramCodeResponseCodes(
	[property: JsonPropertyName("code")] string? Code,
	[property: JsonPropertyName("date")] long? Date
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingTelegramCodeResponseCodes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingTelegramCodeResponseCodes ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("code"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingTelegramCodeResponseCodes(v0, v1);
	}
}

	public sealed record ManagingTelegramResetAuthResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingTelegramResetAuthResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingTelegramResetAuthResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingTelegramResetAuthResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingRefuseGuaranteeResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingRefuseGuaranteeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingRefuseGuaranteeResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingRefuseGuaranteeResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingDeclineVideoRecordingBody
	{
		[JsonPropertyName("i_voluntarily_and_with_full_awareness_of_my_actions_waive_any_claims_regarding_this_item")]
		public required bool? IVoluntarilyAndWithFullAwarenessOfMyActionsWaiveAnyClaimsRegardingThisItem { get; init; }
	}

	public sealed record ManagingDeclineVideoRecordingResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingDeclineVideoRecordingResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingDeclineVideoRecordingResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingDeclineVideoRecordingResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingCheckGuaranteeResponse(
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingCheckGuaranteeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingCheckGuaranteeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("message"u8))
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
			return new ManagingCheckGuaranteeResponse(v0, v1);
		}
	}

	public sealed record ManagingChangePasswordBody
	{
		[JsonPropertyName("_cancel")]
		public Cancel? Cancel { get; init; }
	}

	public sealed record ManagingChangePasswordResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("new_password")] string NewPassword
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingChangePasswordResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingChangePasswordResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			string v2 = null!;
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
				else if (reader.ValueTextEquals("new_password"u8))
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
			return new ManagingChangePasswordResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingTempEmailPasswordResponse(
		[property: JsonPropertyName("item")] ManagingTempEmailPasswordResponseItem Item
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingTempEmailPasswordResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingTempEmailPasswordResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ManagingTempEmailPasswordResponseItem v0 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ManagingTempEmailPasswordResponseItem.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ManagingTempEmailPasswordResponse(v0);
		}
	}

public sealed record ManagingTempEmailPasswordResponseItem(
	[property: JsonPropertyName("account")] string Account
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingTempEmailPasswordResponseItem ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingTempEmailPasswordResponseItem ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("account"u8))
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
		return new ManagingTempEmailPasswordResponseItem(v0);
	}
}

	public sealed record ManagingTagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingTagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingTagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingTagResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingTagResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			ManagingTagResponseTag v1 = null!;
			long v2 = default;
			List<long> v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("itemId"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("tag"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingTagResponseTag.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("addedTagId"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("deleteTags"u8))
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
						v3 = __lst;
					}
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
			return new ManagingTagResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record ManagingTagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingTagResponseTag ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingTagResponseTag ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		bool v2 = default;
		bool v3 = default;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("tag_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isDefault"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("forOwnedAccountsOnly"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bc"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingTagResponseTag(v0, v1, v2, v3, v4);
	}
}

	public sealed record ManagingUntagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingUntagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingUntagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingUntagResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingUntagResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			ManagingUntagResponseTag v1 = null!;
			long v2 = default;
			List<long> v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("itemId"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("tag"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingUntagResponseTag.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("addedTagId"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("deleteTags"u8))
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
						v3 = __lst;
					}
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
			return new ManagingUntagResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record ManagingUntagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingUntagResponseTag ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingUntagResponseTag ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		bool v2 = default;
		bool v3 = default;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("tag_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isDefault"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("forOwnedAccountsOnly"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bc"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingUntagResponseTag(v0, v1, v2, v3, v4);
	}
}

	public sealed record ManagingPublicTagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingPublicTagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingPublicTagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingPublicTagResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingPublicTagResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			ManagingPublicTagResponseTag v1 = null!;
			long v2 = default;
			List<long> v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("itemId"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("tag"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingPublicTagResponseTag.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("addedTagId"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("deleteTags"u8))
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
						v3 = __lst;
					}
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
			return new ManagingPublicTagResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record ManagingPublicTagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingPublicTagResponseTag ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingPublicTagResponseTag ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		bool v2 = default;
		bool v3 = default;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("tag_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isDefault"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("forOwnedAccountsOnly"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bc"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingPublicTagResponseTag(v0, v1, v2, v3, v4);
	}
}

	public sealed record ManagingPublicUntagBody
	{
		[JsonPropertyName("tag_id")]
		public required long? TagId { get; init; }
	}

	public sealed record ManagingPublicUntagResponse(
		[property: JsonPropertyName("itemId")] long ItemId,
		[property: JsonPropertyName("tag")] ManagingPublicUntagResponseTag Tag,
		[property: JsonPropertyName("addedTagId")] long AddedTagId,
		[property: JsonPropertyName("deleteTags")] List<long> DeleteTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingPublicUntagResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingPublicUntagResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			ManagingPublicUntagResponseTag v1 = null!;
			long v2 = default;
			List<long> v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("itemId"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("tag"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ManagingPublicUntagResponseTag.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("addedTagId"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("deleteTags"u8))
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
						v3 = __lst;
					}
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
			return new ManagingPublicUntagResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record ManagingPublicUntagResponseTag(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ManagingPublicUntagResponseTag ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ManagingPublicUntagResponseTag ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		bool v2 = default;
		bool v3 = default;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("tag_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isDefault"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("forOwnedAccountsOnly"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bc"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ManagingPublicUntagResponseTag(v0, v1, v2, v3, v4);
	}
}

	public sealed record ManagingFavoriteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingFavoriteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingFavoriteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingFavoriteResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingUnfavoriteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingUnfavoriteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingUnfavoriteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingUnfavoriteResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingStickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingStickResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingStickResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingStickResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingUnstickResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingUnstickResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingUnstickResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingUnstickResponse(v0, v1, v2);
		}
	}

	public sealed record ManagingTransferBody
	{
		[JsonPropertyName("username")]
		public required string Username { get; init; }
		[JsonPropertyName("secret_answer")]
		public required string SecretAnswer { get; init; }
	}

	public sealed record ManagingTransferResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ManagingTransferResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ManagingTransferResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ManagingTransferResponse(v0, v1, v2);
		}
	}

}
