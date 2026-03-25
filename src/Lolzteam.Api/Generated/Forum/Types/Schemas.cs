// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public sealed record Resp_ChatboxMessageModel(
	[property: JsonPropertyName("can_report")] bool CanReport,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("is_deleted")] bool IsDeleted,
	[property: JsonPropertyName("message")] string Message,
	[property: JsonPropertyName("message_id")] long MessageId,
	[property: JsonPropertyName("messageJson")] string MessageJson,
	[property: JsonPropertyName("messageRaw")] string MessageRaw,
	[property: JsonPropertyName("room")] Resp_ChatboxMessageModelRoom Room,
	[property: JsonPropertyName("user")] Resp_ChatboxMessageModelUser User
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ChatboxMessageModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ChatboxMessageModel ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		long v1 = default;
		bool v2 = default;
		string v3 = null!;
		long v4 = default;
		string v5 = null!;
		string v6 = null!;
		Resp_ChatboxMessageModelRoom v7 = null!;
		Resp_ChatboxMessageModelUser v8 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("can_report"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_deleted"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("message"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("messageJson"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("messageRaw"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("room"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ChatboxMessageModelRoom.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ChatboxMessageModelUser.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ChatboxMessageModel(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record Resp_ChatboxMessageModelRoom(
	[property: JsonPropertyName("can_report")] bool CanReport,
	[property: JsonPropertyName("eng")] bool Eng,
	[property: JsonPropertyName("market")] bool Market,
	[property: JsonPropertyName("room_id")] long RoomId,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ChatboxMessageModelRoom ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ChatboxMessageModelRoom ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		long v3 = default;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("can_report"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("eng"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("market"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("room_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
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
		return new Resp_ChatboxMessageModelRoom(v0, v1, v2, v3, v4);
	}
}

public sealed record Resp_ChatboxMessageModelUserRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ChatboxMessageModelUserRenderedAvatars ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ChatboxMessageModelUserRenderedAvatars ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("l"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("m"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("s"u8))
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
		return new Resp_ChatboxMessageModelUserRenderedAvatars(v0, v1, v2);
	}
}

public sealed record Resp_ChatboxMessageModelUserRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] Resp_ChatboxMessageModelUserRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ChatboxMessageModelUserRendered ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ChatboxMessageModelUserRendered ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		Resp_ChatboxMessageModelUserRenderedAvatars v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatars"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ChatboxMessageModelUserRenderedAvatars.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("link"u8))
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
		return new Resp_ChatboxMessageModelUserRendered(v0, v1, v2);
	}
}

public sealed record Resp_ChatboxMessageModelUserUniqBanner(
	[property: JsonPropertyName("banner_css")] string BannerCss,
	[property: JsonPropertyName("banner_text")] string BannerText,
	[property: JsonPropertyName("banner_icon")] string BannerIcon,
	[property: JsonPropertyName("username_icon")] string UsernameIcon
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ChatboxMessageModelUserUniqBanner ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ChatboxMessageModelUserUniqBanner ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("banner_css"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("banner_text"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("banner_icon"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username_icon"u8))
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
		return new Resp_ChatboxMessageModelUserUniqBanner(v0, v1, v2, v3);
	}
}

public sealed record Resp_ChatboxMessageModelUser(
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] Resp_ChatboxMessageModelUserRendered Rendered,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] Resp_ChatboxMessageModelUserUniqBanner UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ChatboxMessageModelUser ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ChatboxMessageModelUser ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		bool v7 = default;
		bool v8 = default;
		bool v9 = default;
		bool v10 = default;
		long v11 = default;
		long v12 = default;
		long v13 = default;
		long v14 = default;
		long v15 = default;
		Resp_ChatboxMessageModelUserRendered v16 = null!;
		string v17 = null!;
		long v18 = default;
		Resp_ChatboxMessageModelUserUniqBanner v19 = null!;
		string v20 = null!;
		long v21 = default;
		string v22 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("background_date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("contest_count"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("display_banner_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_icon_group_id"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_admin"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_moderator"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_staff"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like2_count"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_count"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("message_count"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("register_date"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rendered"u8))
			{
				reader.Read();
				v16 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ChatboxMessageModelUserRendered.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("trophy_points"u8))
			{
				reader.Read();
				v18 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("uniq_banner"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ChatboxMessageModelUserUniqBanner.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v21 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v22 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ChatboxMessageModelUser(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22);
	}
}

public sealed record Resp_ConversationMessageModel(
	[property: JsonPropertyName("message_id")] long MessageId,
	[property: JsonPropertyName("conversation_id")] long ConversationId,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("message_create_date")] long MessageCreateDate,
	[property: JsonPropertyName("message_is_unread")] long MessageIsUnread,
	[property: JsonPropertyName("message_need_translate")] bool MessageNeedTranslate,
	[property: JsonPropertyName("message_is_system")] bool MessageIsSystem,
	[property: JsonPropertyName("message_edit_date")] long MessageEditDate,
	[property: JsonPropertyName("message_body")] string MessageBody,
	[property: JsonPropertyName("message_body_html")] string MessageBodyHtml,
	[property: JsonPropertyName("message_body_plain_text")] string MessageBodyPlainText,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("links")] Resp_ConversationMessageModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ConversationMessageModelPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationMessageModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationMessageModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		long v6 = default;
		bool v7 = default;
		bool v8 = default;
		long v9 = default;
		string v10 = null!;
		string v11 = null!;
		string v12 = null!;
		bool v13 = default;
		Resp_ConversationMessageModelLinks v14 = null!;
		Resp_ConversationMessageModelPermissions v15 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("message_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conversation_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("creator_user_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("creator_username"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("creator_username_html"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_create_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("message_is_unread"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("message_need_translate"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("message_is_system"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("message_edit_date"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("message_body"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_body_html"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_body_plain_text"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v14 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ConversationMessageModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v15 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ConversationMessageModelPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ConversationMessageModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
	}
}

public sealed record Resp_ConversationMessageModelLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("conversation")] string Conversation,
	[property: JsonPropertyName("creator")] string Creator,
	[property: JsonPropertyName("creator_avatar")] string CreatorAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationMessageModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationMessageModelLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("conversation"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("creator"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("creator_avatar"u8))
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
		return new Resp_ConversationMessageModelLinks(v0, v1, v2, v3);
	}
}

public sealed record Resp_ConversationMessageModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("stick-unstick")] bool StickUnstick
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationMessageModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationMessageModelPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
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
			else if (reader.ValueTextEquals("stick-unstick"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ConversationMessageModelPermissions(v0, v1, v2, v3);
	}
}

public sealed record Resp_ConversationModel(
	[property: JsonPropertyName("conversation_id")] long ConversationId,
	[property: JsonPropertyName("conversation_title")] string ConversationTitle,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("conversation_create_date")] long ConversationCreateDate,
	[property: JsonPropertyName("conversation_update_date")] long ConversationUpdateDate,
	[property: JsonPropertyName("conversation_last_read_date")] long ConversationLastReadDate,
	[property: JsonPropertyName("conversation_online_count")] long ConversationOnlineCount,
	[property: JsonPropertyName("is_starred")] long IsStarred,
	[property: JsonPropertyName("is_group")] long IsGroup,
	[property: JsonPropertyName("is_unread")] long IsUnread,
	[property: JsonPropertyName("alerts")] long Alerts,
	[property: JsonPropertyName("permissions")] Resp_ConversationModelPermissions Permissions,
	[property: JsonPropertyName("conversation_message_count")] long ConversationMessageCount,
	[property: JsonPropertyName("conversation_is_new")] bool ConversationIsNew,
	[property: JsonPropertyName("creator_is_ignored")] bool CreatorIsIgnored,
	[property: JsonPropertyName("conversation_is_open")] bool ConversationIsOpen,
	[property: JsonPropertyName("conversation_is_deleted")] bool ConversationIsDeleted,
	[property: JsonPropertyName("recipient")] Resp_ConversationModelRecipient Recipient,
	[property: JsonPropertyName("recipients")] List<Resp_ConversationModelRecipients> Recipients,
	[property: JsonPropertyName("links")] Resp_ConversationModelLinks Links
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		long v9 = default;
		long v10 = default;
		long v11 = default;
		long v12 = default;
		Resp_ConversationModelPermissions v13 = null!;
		long v14 = default;
		bool v15 = default;
		bool v16 = default;
		bool v17 = default;
		bool v18 = default;
		Resp_ConversationModelRecipient v19 = null!;
		List<Resp_ConversationModelRecipients> v20 = null!;
		Resp_ConversationModelLinks v21 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("conversation_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conversation_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("creator_user_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("creator_username"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("creator_username_html"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("conversation_create_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conversation_update_date"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conversation_last_read_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conversation_online_count"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_starred"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_group"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_unread"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("alerts"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ConversationModelPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("conversation_message_count"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conversation_is_new"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("creator_is_ignored"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("conversation_is_open"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("conversation_is_deleted"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("recipient"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ConversationModelRecipient.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("recipients"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<Resp_ConversationModelRecipients>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = Resp_ConversationModelRecipients.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v20 = __lst;
				}
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v21 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ConversationModelLinks.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ConversationModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21);
	}
}

public sealed record Resp_ConversationModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("invite")] bool Invite,
	[property: JsonPropertyName("manage_invite_links")] bool ManageInviteLinks,
	[property: JsonPropertyName("kick")] bool Kick,
	[property: JsonPropertyName("upload_avatar")] bool UploadAvatar,
	[property: JsonPropertyName("editOwnPost")] bool EditOwnPost,
	[property: JsonPropertyName("stickyMessages")] bool StickyMessages
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationModelPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
		bool v7 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("reply"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("invite"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("manage_invite_links"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("kick"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("upload_avatar"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("editOwnPost"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("stickyMessages"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ConversationModelPermissions(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record Resp_ConversationModelRecipient(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("is_online")] bool IsOnline,
	[property: JsonPropertyName("contacts_changed")] bool ContactsChanged,
	[property: JsonPropertyName("avatar")] string Avatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationModelRecipient ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationModelRecipient ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		bool v4 = default;
		bool v5 = default;
		string v6 = null!;
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
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_online"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("contacts_changed"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("avatar"u8))
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
		return new Resp_ConversationModelRecipient(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record Resp_ConversationModelRecipients(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("is_online")] bool IsOnline,
	[property: JsonPropertyName("contacts_changed")] bool ContactsChanged,
	[property: JsonPropertyName("avatar")] string Avatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationModelRecipients ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationModelRecipients ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		bool v4 = default;
		bool v5 = default;
		string v6 = null!;
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
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_online"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("contacts_changed"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("avatar"u8))
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
		return new Resp_ConversationModelRecipients(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record Resp_ConversationModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("messages")] string Messages,
	[property: JsonPropertyName("avatar")] string Avatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ConversationModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ConversationModelLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("messages"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar"u8))
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
		return new Resp_ConversationModelLinks(v0, v1, v2, v3);
	}
}

public sealed record Resp_LinkModel(
	[property: JsonPropertyName("link_id")] long LinkId,
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("link_description")] string LinkDescription,
	[property: JsonPropertyName("links")] Resp_LinkModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_LinkModelPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_LinkModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_LinkModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		Resp_LinkModelLinks v3 = null!;
		Resp_LinkModelPermissions v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("link_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("link_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("link_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : Resp_LinkModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : Resp_LinkModelPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_LinkModel(v0, v1, v2, v3, v4);
	}
}

public sealed record Resp_LinkModelLinks(
	[property: JsonPropertyName("target")] string Target,
	[property: JsonPropertyName("detail")] string Detail
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_LinkModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_LinkModelLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("target"u8))
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
		return new Resp_LinkModelLinks(v0, v1);
	}
}

public sealed record Resp_LinkModelPermissions(
	[property: JsonPropertyName("view")] bool View
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_LinkModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_LinkModelPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_LinkModelPermissions(v0);
	}
}

public sealed record Resp_NotificationModel(
	[property: JsonPropertyName("notification_id")] long NotificationId,
	[property: JsonPropertyName("notification_create_date")] long NotificationCreateDate,
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("content_action")] string ContentAction,
	[property: JsonPropertyName("notification_is_unread")] bool NotificationIsUnread,
	[property: JsonPropertyName("creator_user_id")] long CreatorUserId,
	[property: JsonPropertyName("creator_username")] string CreatorUsername,
	[property: JsonPropertyName("creator_username_html")] string CreatorUsernameHtml,
	[property: JsonPropertyName("notification_type")] string NotificationType,
	[property: JsonPropertyName("links")] Resp_NotificationModelLinks Links,
	[property: JsonPropertyName("notification_html")] string NotificationHtml
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_NotificationModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_NotificationModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		long v3 = default;
		string v4 = null!;
		bool v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		Resp_NotificationModelLinks v10 = null!;
		string v11 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("notification_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("notification_create_date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("content_type"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("content_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("content_action"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("notification_is_unread"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
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
			else if (reader.ValueTextEquals("notification_type"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : Resp_NotificationModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("notification_html"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_NotificationModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
	}
}

public sealed record Resp_NotificationModelLinks(
	[property: JsonPropertyName("content")] string Content,
	[property: JsonPropertyName("creator_avatar")] string CreatorAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_NotificationModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_NotificationModelLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("content"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("creator_avatar"u8))
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
		return new Resp_NotificationModelLinks(v0, v1);
	}
}

public sealed record Resp_PostCommentModel(
	[property: JsonPropertyName("post_comment_id")] long PostCommentId,
	[property: JsonPropertyName("post_id")] long PostId,
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_comment_create_date")] long PostCommentCreateDate,
	[property: JsonPropertyName("post_comment_body")] string PostCommentBody,
	[property: JsonPropertyName("post_comment_body_html")] string PostCommentBodyHtml,
	[property: JsonPropertyName("post_comment_body_plain_text")] string PostCommentBodyPlainText,
	[property: JsonPropertyName("post_comment_like_count")] long PostCommentLikeCount,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_comment_is_published")] bool PostCommentIsPublished,
	[property: JsonPropertyName("post_comment_is_deleted")] bool PostCommentIsDeleted,
	[property: JsonPropertyName("post_comment_update_date")] long PostCommentUpdateDate,
	[property: JsonPropertyName("links")] Resp_PostCommentModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_PostCommentModelPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_PostCommentModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_PostCommentModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		string v4 = null!;
		string v5 = null!;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		long v10 = default;
		bool v11 = default;
		bool v12 = default;
		bool v13 = default;
		long v14 = default;
		Resp_PostCommentModelLinks v15 = null!;
		Resp_PostCommentModelPermissions v16 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("post_comment_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poster_user_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poster_username"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_username_html"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_comment_create_date"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_comment_body"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_comment_body_html"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_comment_body_plain_text"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_comment_like_count"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_comment_is_published"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_comment_is_deleted"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_comment_update_date"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v15 = reader.TokenType == JsonTokenType.Null ? null! : Resp_PostCommentModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v16 = reader.TokenType == JsonTokenType.Null ? null! : Resp_PostCommentModelPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_PostCommentModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);
	}
}

public sealed record Resp_PostCommentModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("post")] string Post,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_PostCommentModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_PostCommentModelLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("post"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("thread"u8))
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
			else if (reader.ValueTextEquals("report"u8))
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
		return new Resp_PostCommentModelLinks(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record Resp_PostCommentModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_PostCommentModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_PostCommentModelPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_PostCommentModelPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record Resp_PostModel(
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
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] Resp_PostModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_PostModelPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_PostModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_PostModel ReadFromReader(ref Utf8JsonReader reader)
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
		bool v13 = default;
		bool v14 = default;
		bool v15 = default;
		long v16 = default;
		bool v17 = default;
		Resp_PostModelLinks v18 = null!;
		Resp_PostModelPermissions v19 = null!;
		bool v20 = default;
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
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_update_date"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_is_first_post"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v18 = reader.TokenType == JsonTokenType.Null ? null! : Resp_PostModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : Resp_PostModelPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("thread_is_deleted"u8))
			{
				reader.Read();
				v20 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_PostModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
	}
}

public sealed record Resp_PostModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_PostModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_PostModelLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
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
			else if (reader.ValueTextEquals("poster_avatar"u8))
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
		return new Resp_PostModelLinks(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record Resp_PostModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_PostModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_PostModelPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_PostModelPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record Resp_ProfilePostCommentModel(
	[property: JsonPropertyName("comment_id")] long CommentId,
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("comment_user_id")] long CommentUserId,
	[property: JsonPropertyName("comment_username")] string CommentUsername,
	[property: JsonPropertyName("comment_username_html")] string CommentUsernameHtml,
	[property: JsonPropertyName("comment_create_date")] long CommentCreateDate,
	[property: JsonPropertyName("comment_body")] string CommentBody,
	[property: JsonPropertyName("comment_body_html")] string CommentBodyHtml,
	[property: JsonPropertyName("comment_body_plain_text")] string CommentBodyPlainText,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("links")] Resp_ProfilePostCommentModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ProfilePostCommentModelPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ProfilePostCommentModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ProfilePostCommentModel ReadFromReader(ref Utf8JsonReader reader)
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
		bool v9 = default;
		long v10 = default;
		Resp_ProfilePostCommentModelLinks v11 = null!;
		Resp_ProfilePostCommentModelPermissions v12 = null!;
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
			else if (reader.ValueTextEquals("comment_body_html"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comment_body_plain_text"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("timeline_user_id"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v11 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ProfilePostCommentModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v12 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ProfilePostCommentModelPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ProfilePostCommentModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12);
	}
}

public sealed record Resp_ProfilePostCommentModelLinks(
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("profile_post")] string ProfilePost,
	[property: JsonPropertyName("timeline")] string Timeline,
	[property: JsonPropertyName("timeline_user")] string TimelineUser,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ProfilePostCommentModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ProfilePostCommentModelLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new Resp_ProfilePostCommentModelLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record Resp_ProfilePostCommentModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ProfilePostCommentModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ProfilePostCommentModelPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new Resp_ProfilePostCommentModelPermissions(v0, v1);
	}
}

public sealed record Resp_ProfilePostModel(
	[property: JsonPropertyName("profile_post_id")] long ProfilePostId,
	[property: JsonPropertyName("timeline_user_id")] long TimelineUserId,
	[property: JsonPropertyName("poster_user_id")] long PosterUserId,
	[property: JsonPropertyName("poster_username")] string PosterUsername,
	[property: JsonPropertyName("poster_username_html")] string PosterUsernameHtml,
	[property: JsonPropertyName("post_create_date")] long PostCreateDate,
	[property: JsonPropertyName("post_body")] string PostBody,
	[property: JsonPropertyName("post_body_html")] string PostBodyHtml,
	[property: JsonPropertyName("post_body_plain_text")] string PostBodyPlainText,
	[property: JsonPropertyName("post_like_count")] long PostLikeCount,
	[property: JsonPropertyName("post_comment_count")] long PostCommentCount,
	[property: JsonPropertyName("post_comments_is_disabled")] long PostCommentsIsDisabled,
	[property: JsonPropertyName("timeline_username")] string TimelineUsername,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("post_is_sticked")] bool PostIsSticked,
	[property: JsonPropertyName("links")] Resp_ProfilePostModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ProfilePostModelPermissions Permissions,
	[property: JsonPropertyName("timeline_user")] Resp_UserModel TimelineUser
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ProfilePostModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ProfilePostModel ReadFromReader(ref Utf8JsonReader reader)
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
		long v9 = default;
		long v10 = default;
		long v11 = default;
		string v12 = null!;
		bool v13 = default;
		bool v14 = default;
		bool v15 = default;
		bool v16 = default;
		bool v17 = default;
		Resp_ProfilePostModelLinks v18 = null!;
		Resp_ProfilePostModelPermissions v19 = null!;
		Resp_UserModel v20 = null!;
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
			else if (reader.ValueTextEquals("post_like_count"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_comment_count"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_comments_is_disabled"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeline_username"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_liked"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_sticked"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v18 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ProfilePostModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ProfilePostModelPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("timeline_user"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ProfilePostModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
	}
}

public sealed record Resp_ProfilePostModelLinks(
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
	public static Resp_ProfilePostModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ProfilePostModelLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new Resp_ProfilePostModelLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record Resp_ProfilePostModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("comment")] bool Comment,
	[property: JsonPropertyName("report")] bool Report,
	[property: JsonPropertyName("stick")] bool Stick
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ProfilePostModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ProfilePostModelPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("stick"u8))
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
		return new Resp_ProfilePostModelPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record Resp_SystemInfo(
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_SystemInfo ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_SystemInfo ReadFromReader(ref Utf8JsonReader reader)
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
		return new Resp_SystemInfo(v0, v1);
	}
}

public sealed record Resp_ThreadModel(
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
	[property: JsonPropertyName("thread_is_closed")] bool ThreadIsClosed,
	[property: JsonPropertyName("thread_is_followed")] bool ThreadIsFollowed,
	[property: JsonPropertyName("thread_is_starred")] bool ThreadIsStarred,
	[property: JsonPropertyName("first_post")] Resp_ThreadModelFirstPost FirstPost,
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] Resp_ThreadModelThreadTags ThreadTags,
	[property: JsonPropertyName("links")] Resp_ThreadModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelPermissions Permissions,
	[property: JsonPropertyName("node_title")] string NodeTitle,
	[property: JsonPropertyName("restrictions")] Resp_ThreadModelRestrictions Restrictions,
	[property: JsonPropertyName("last_post")] Resp_ThreadModelLastPost LastPost,
	[property: JsonPropertyName("contest")] Resp_ThreadModelContest Contest
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		string v5 = null!;
		string v6 = null!;
		long v7 = default;
		long v8 = default;
		bool v9 = default;
		long v10 = default;
		bool v11 = default;
		bool v12 = default;
		bool v13 = default;
		bool v14 = default;
		bool v15 = default;
		bool v16 = default;
		Resp_ThreadModelFirstPost v17 = null!;
		List<JsonElement> v18 = null!;
		Resp_ThreadModelThreadTags v19 = null!;
		Resp_ThreadModelLinks v20 = null!;
		Resp_ThreadModelPermissions v21 = null!;
		string v22 = null!;
		Resp_ThreadModelRestrictions v23 = null!;
		Resp_ThreadModelLastPost v24 = null!;
		Resp_ThreadModelContest v25 = null!;
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
			else if (reader.ValueTextEquals("creator_username_html"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("thread_create_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_update_date"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_post_count"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_is_published"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_deleted"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_sticky"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_closed"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_followed"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("thread_is_starred"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("first_post"u8))
			{
				reader.Read();
				v17 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelFirstPost.ReadFromReader(ref reader);
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
					v18 = __lst;
				}
			}
			else if (reader.ValueTextEquals("thread_tags"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelThreadTags.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v21 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("node_title"u8))
			{
				reader.Read();
				v22 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("restrictions"u8))
			{
				reader.Read();
				v23 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelRestrictions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("last_post"u8))
			{
				reader.Read();
				v24 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelLastPost.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("contest"u8))
			{
				reader.Read();
				v25 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelContest.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25);
	}
}

public sealed record Resp_ThreadModelFirstPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelFirstPostLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelFirstPostLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
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
			else if (reader.ValueTextEquals("poster_avatar"u8))
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
		return new Resp_ThreadModelFirstPostLinks(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record Resp_ThreadModelFirstPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelFirstPostPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelFirstPostPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelFirstPostPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record Resp_ThreadModelFirstPost(
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
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("links")] Resp_ThreadModelFirstPostLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelFirstPostPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelFirstPost ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelFirstPost ReadFromReader(ref Utf8JsonReader reader)
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
		bool v13 = default;
		bool v14 = default;
		bool v15 = default;
		long v16 = default;
		bool v17 = default;
		bool v18 = default;
		Resp_ThreadModelFirstPostLinks v19 = null!;
		Resp_ThreadModelFirstPostPermissions v20 = null!;
		bool v21 = default;
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
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_update_date"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_is_first_post"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_liked"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelFirstPostLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelFirstPostPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("thread_is_deleted"u8))
			{
				reader.Read();
				v21 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelFirstPost(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21);
	}
}

public sealed record Resp_ThreadModelThreadTags(
	[property: JsonPropertyName("97491")] string _97491,
	[property: JsonPropertyName("193431")] string _193431,
	[property: JsonPropertyName("206")] string _206
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelThreadTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelThreadTags ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("97491"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("193431"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("206"u8))
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
		return new Resp_ThreadModelThreadTags(v0, v1, v2);
	}
}

public sealed record Resp_ThreadModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("forum")] string Forum,
	[property: JsonPropertyName("posts")] string Posts,
	[property: JsonPropertyName("first_poster")] string FirstPoster,
	[property: JsonPropertyName("first_poster_avatar")] string FirstPosterAvatar,
	[property: JsonPropertyName("first_post")] string FirstPost,
	[property: JsonPropertyName("last_post")] string LastPost
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("last_post"u8))
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
		return new Resp_ThreadModelLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record Resp_ThreadModelPermissionsBump(
	[property: JsonPropertyName("can")] bool Can,
	[property: JsonPropertyName("available_count")] long AvailableCount,
	[property: JsonPropertyName("error")] JsonElement Error,
	[property: JsonPropertyName("next_available_time")] JsonElement NextAvailableTime
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelPermissionsBump ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelPermissionsBump ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		long v1 = default;
		JsonElement v2 = default;
		JsonElement v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("can"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("available_count"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("error"u8))
			{
				reader.Read();
				v2 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("next_available_time"u8))
			{
				reader.Read();
				v3 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelPermissionsBump(v0, v1, v2, v3);
	}
}

public sealed record Resp_ThreadModelPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("edit_title")] bool EditTitle,
	[property: JsonPropertyName("edit_tags")] bool EditTags,
	[property: JsonPropertyName("bump")] Resp_ThreadModelPermissionsBump Bump
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
		Resp_ThreadModelPermissionsBump v7 = null!;
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
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit_title"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit_tags"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bump"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelPermissionsBump.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelPermissions(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record Resp_ThreadModelRestrictions(
	[property: JsonPropertyName("reply_delay")] long ReplyDelay,
	[property: JsonPropertyName("max_reply_count")] long MaxReplyCount
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelRestrictions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelRestrictions ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("reply_delay"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("max_reply_count"u8))
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
		return new Resp_ThreadModelRestrictions(v0, v1);
	}
}

public sealed record Resp_ThreadModelLastPostLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("thread")] string Thread,
	[property: JsonPropertyName("poster")] string Poster,
	[property: JsonPropertyName("likes")] string Likes,
	[property: JsonPropertyName("report")] string Report,
	[property: JsonPropertyName("poster_avatar")] string PosterAvatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelLastPostLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelLastPostLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
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
			else if (reader.ValueTextEquals("poster_avatar"u8))
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
		return new Resp_ThreadModelLastPostLinks(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record Resp_ThreadModelLastPostPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("reply")] bool Reply,
	[property: JsonPropertyName("like")] bool Like,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelLastPostPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelLastPostPermissions ReadFromReader(ref Utf8JsonReader reader)
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelLastPostPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record Resp_ThreadModelLastPost(
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
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("post_is_liked")] bool PostIsLiked,
	[property: JsonPropertyName("links")] Resp_ThreadModelLastPostLinks Links,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelLastPostPermissions Permissions,
	[property: JsonPropertyName("thread_is_deleted")] bool ThreadIsDeleted
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelLastPost ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelLastPost ReadFromReader(ref Utf8JsonReader reader)
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
		bool v13 = default;
		bool v14 = default;
		bool v15 = default;
		long v16 = default;
		bool v17 = default;
		bool v18 = default;
		Resp_ThreadModelLastPostLinks v19 = null!;
		Resp_ThreadModelLastPostPermissions v20 = null!;
		bool v21 = default;
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
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_update_date"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_is_first_post"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_liked"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelLastPostLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelLastPostPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("thread_is_deleted"u8))
			{
				reader.Read();
				v21 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelLastPost(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21);
	}
}

public sealed record Resp_ThreadModelContestPermissions(
	[property: JsonPropertyName("can_finish")] bool CanFinish,
	[property: JsonPropertyName("can_participate")] bool CanParticipate,
	[property: JsonPropertyName("can_participate_error")] string CanParticipateError,
	[property: JsonPropertyName("can_view_user_list")] bool CanViewUserList
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelContestPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelContestPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		string v2 = null!;
		bool v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("can_finish"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_participate"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_participate_error"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("can_view_user_list"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelContestPermissions(v0, v1, v2, v3);
	}
}

public sealed record Resp_ThreadModelContest(
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("finish_date")] long FinishDate,
	[property: JsonPropertyName("now_count_members")] long NowCountMembers,
	[property: JsonPropertyName("needed_members")] long NeededMembers,
	[property: JsonPropertyName("is_finished")] long IsFinished,
	[property: JsonPropertyName("count_winners")] long CountWinners,
	[property: JsonPropertyName("require_like_count")] long RequireLikeCount,
	[property: JsonPropertyName("require_total_like_count")] long RequireTotalLikeCount,
	[property: JsonPropertyName("prize_type")] string PrizeType,
	[property: JsonPropertyName("prize_type_phrase")] string PrizeTypePhrase,
	[property: JsonPropertyName("prize_data")] long PrizeData,
	[property: JsonPropertyName("is_money_places")] long IsMoneyPlaces,
	[property: JsonPropertyName("chance_to_win")] double ChanceToWin,
	[property: JsonPropertyName("winners")] List<long> Winners,
	[property: JsonPropertyName("already_participate")] bool AlreadyParticipate,
	[property: JsonPropertyName("permissions")] Resp_ThreadModelContestPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_ThreadModelContest ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_ThreadModelContest ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		string v8 = null!;
		string v9 = null!;
		long v10 = default;
		long v11 = default;
		double v12 = default;
		List<long> v13 = null!;
		bool v14 = default;
		Resp_ThreadModelContestPermissions v15 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("type"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("finish_date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("now_count_members"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("needed_members"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_finished"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("count_winners"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("require_like_count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("require_total_like_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("prize_type"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("prize_type_phrase"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("prize_data"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_money_places"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("chance_to_win"u8))
			{
				reader.Read();
				v12 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("winners"u8))
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
					v13 = __lst;
				}
			}
			else if (reader.ValueTextEquals("already_participate"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v15 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModelContestPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_ThreadModelContest(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
	}
}

public sealed record Resp_UserModel(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("user_message_count")] long UserMessageCount,
	[property: JsonPropertyName("user_register_date")] long UserRegisterDate,
	[property: JsonPropertyName("user_like_count")] long UserLikeCount,
	[property: JsonPropertyName("user_like2_count")] long UserLike2Count,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("trophy_count")] long TrophyCount,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("hold")] string Hold,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("user_email")] string UserEmail,
	[property: JsonPropertyName("user_unread_notification_count")] long UserUnreadNotificationCount,
	[property: JsonPropertyName("user_unread_conversation_count")] long UserUnreadConversationCount,
	[property: JsonPropertyName("conv_welcome_message")] string ConvWelcomeMessage,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("user_deposit")] long UserDeposit,
	[property: JsonPropertyName("user_is_valid")] bool UserIsValid,
	[property: JsonPropertyName("user_is_verified")] bool UserIsVerified,
	[property: JsonPropertyName("user_is_followed")] bool UserIsFollowed,
	[property: JsonPropertyName("user_last_seen_date")] long UserLastSeenDate,
	[property: JsonPropertyName("links")] Resp_UserModelLinks Links,
	[property: JsonPropertyName("permissions")] Resp_UserModelPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("curator_titles")] List<string> CuratorTitles,
	[property: JsonPropertyName("user_groups")] List<Resp_UserModelUserGroups> UserGroups,
	[property: JsonPropertyName("fields")] List<Resp_UserModelFields> Fields,
	[property: JsonPropertyName("user_timezone_offset")] long UserTimezoneOffset,
	[property: JsonPropertyName("user_external_authentications")] List<Resp_UserModelUserExternalAuthentications> UserExternalAuthentications,
	[property: JsonPropertyName("self_permissions")] Resp_UserModelSelfPermissions SelfPermissions,
	[property: JsonPropertyName("edit_permissions")] Resp_UserModelEditPermissions EditPermissions,
	[property: JsonPropertyName("birthday")] Resp_UserModelBirthday Birthday,
	[property: JsonPropertyName("secret_answer_rendered")] string SecretAnswerRendered,
	[property: JsonPropertyName("secret_answer_first_letter")] string SecretAnswerFirstLetter,
	[property: JsonPropertyName("user_following")] Resp_UserModelUserFollowing UserFollowing,
	[property: JsonPropertyName("user_followers")] Resp_UserModelUserFollowers UserFollowers,
	[property: JsonPropertyName("banner")] string Banner
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		string v9 = null!;
		string v10 = null!;
		long v11 = default;
		long v12 = default;
		long v13 = default;
		string v14 = null!;
		string v15 = null!;
		string v16 = null!;
		string v17 = null!;
		long v18 = default;
		long v19 = default;
		string v20 = null!;
		string v21 = null!;
		long v22 = default;
		bool v23 = default;
		bool v24 = default;
		bool v25 = default;
		long v26 = default;
		Resp_UserModelLinks v27 = null!;
		Resp_UserModelPermissions v28 = null!;
		bool v29 = default;
		bool v30 = default;
		long v31 = default;
		List<string> v32 = null!;
		List<Resp_UserModelUserGroups> v33 = null!;
		List<Resp_UserModelFields> v34 = null!;
		long v35 = default;
		List<Resp_UserModelUserExternalAuthentications> v36 = null!;
		Resp_UserModelSelfPermissions v37 = null!;
		Resp_UserModelEditPermissions v38 = null!;
		Resp_UserModelBirthday v39 = null!;
		string v40 = null!;
		string v41 = null!;
		Resp_UserModelUserFollowing v42 = null!;
		Resp_UserModelUserFollowers v43 = null!;
		string v44 = null!;
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
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_message_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_register_date"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_like_count"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_like2_count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("contest_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("trophy_count"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_banner_id"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_icon_group_id"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("hold"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("currency"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_email"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_unread_notification_count"u8))
			{
				reader.Read();
				v18 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_unread_conversation_count"u8))
			{
				reader.Read();
				v19 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conv_welcome_message"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v21 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_deposit"u8))
			{
				reader.Read();
				v22 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_is_valid"u8))
			{
				reader.Read();
				v23 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_verified"u8))
			{
				reader.Read();
				v24 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_followed"u8))
			{
				reader.Read();
				v25 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_last_seen_date"u8))
			{
				reader.Read();
				v26 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v27 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v28 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v29 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_visitor"u8))
			{
				reader.Read();
				v30 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v31 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("curator_titles"u8))
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
					v32 = __lst;
				}
			}
			else if (reader.ValueTextEquals("user_groups"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<Resp_UserModelUserGroups>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = Resp_UserModelUserGroups.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v33 = __lst;
				}
			}
			else if (reader.ValueTextEquals("fields"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<Resp_UserModelFields>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = Resp_UserModelFields.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v34 = __lst;
				}
			}
			else if (reader.ValueTextEquals("user_timezone_offset"u8))
			{
				reader.Read();
				v35 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_external_authentications"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<Resp_UserModelUserExternalAuthentications>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = Resp_UserModelUserExternalAuthentications.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v36 = __lst;
				}
			}
			else if (reader.ValueTextEquals("self_permissions"u8))
			{
				reader.Read();
				v37 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelSelfPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("edit_permissions"u8))
			{
				reader.Read();
				v38 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelEditPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("birthday"u8))
			{
				reader.Read();
				v39 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelBirthday.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("secret_answer_rendered"u8))
			{
				reader.Read();
				v40 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("secret_answer_first_letter"u8))
			{
				reader.Read();
				v41 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_following"u8))
			{
				reader.Read();
				v42 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelUserFollowing.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user_followers"u8))
			{
				reader.Read();
				v43 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelUserFollowers.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("banner"u8))
			{
				reader.Read();
				v44 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_UserModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);
	}
}

public sealed record Resp_UserModelLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("avatar")] string Avatar,
	[property: JsonPropertyName("avatar_big")] string AvatarBig,
	[property: JsonPropertyName("avatar_small")] string AvatarSmall,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("followings")] string Followings,
	[property: JsonPropertyName("ignore")] string Ignore,
	[property: JsonPropertyName("background_l")] string BackgroundL,
	[property: JsonPropertyName("background_m")] string BackgroundM,
	[property: JsonPropertyName("status")] string Status,
	[property: JsonPropertyName("timeline")] string Timeline
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("avatar"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar_big"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar_small"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followings"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("ignore"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("background_l"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("background_m"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("status"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timeline"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_UserModelLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
	}
}

public sealed record Resp_UserModelPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("ignore"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("profile_post"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_UserModelPermissions(v0, v1, v2, v3);
	}
}

public sealed record Resp_UserModelUserGroups(
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("user_group_title")] string UserGroupTitle,
	[property: JsonPropertyName("user_group_title_en")] string UserGroupTitleEn,
	[property: JsonPropertyName("user_group_banner_css_class")] string UserGroupBannerCssClass,
	[property: JsonPropertyName("user_group_banner_text")] string UserGroupBannerText,
	[property: JsonPropertyName("user_group_banner_text_en")] string UserGroupBannerTextEn,
	[property: JsonPropertyName("display_group_selectable")] bool DisplayGroupSelectable,
	[property: JsonPropertyName("display_banner_selectable")] bool DisplayBannerSelectable,
	[property: JsonPropertyName("display_icon_selectable")] bool DisplayIconSelectable,
	[property: JsonPropertyName("is_primary_group")] bool IsPrimaryGroup,
	[property: JsonPropertyName("user_group_icon_class")] string UserGroupIconClass
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelUserGroups ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelUserGroups ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		bool v6 = default;
		bool v7 = default;
		bool v8 = default;
		bool v9 = default;
		string v10 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_group_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_group_title_en"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_group_banner_css_class"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_group_banner_text"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_group_banner_text_en"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("display_group_selectable"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("display_banner_selectable"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("display_icon_selectable"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_primary_group"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_group_icon_class"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_UserModelUserGroups(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record Resp_UserModelFieldsChoices(
	[property: JsonPropertyName("key")] string Key,
	[property: JsonPropertyName("value")] string Value
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelFieldsChoices ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelFieldsChoices ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("key"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("value"u8))
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
		return new Resp_UserModelFieldsChoices(v0, v1);
	}
}

public sealed record Resp_UserModelFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired,
	[property: JsonPropertyName("value")] string? Value,
	[property: JsonPropertyName("is_multi_choice")] bool IsMultiChoice,
	[property: JsonPropertyName("choices")] List<Resp_UserModelFieldsChoices> Choices,
	[property: JsonPropertyName("values")] List<JsonElement> Values
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelFields ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		bool v4 = default;
		string v5 = null!;
		bool v6 = default;
		List<Resp_UserModelFieldsChoices> v7 = null!;
		List<JsonElement> v8 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("id"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("position"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_required"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("value"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_multi_choice"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("choices"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<Resp_UserModelFieldsChoices>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = Resp_UserModelFieldsChoices.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v7 = __lst;
				}
			}
			else if (reader.ValueTextEquals("values"u8))
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
					v8 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_UserModelFields(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record Resp_UserModelUserExternalAuthentications(
	[property: JsonPropertyName("provider")] string Provider,
	[property: JsonPropertyName("provider_key")] string ProviderKey
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelUserExternalAuthentications ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelUserExternalAuthentications ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("provider"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("provider_key"u8))
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
		return new Resp_UserModelUserExternalAuthentications(v0, v1);
	}
}

public sealed record Resp_UserModelSelfPermissions(
	[property: JsonPropertyName("create_conversation")] bool CreateConversation
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelSelfPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelSelfPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("create_conversation"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_UserModelSelfPermissions(v0);
	}
}

public sealed record Resp_UserModelEditPermissions(
	[property: JsonPropertyName("password")] bool Password,
	[property: JsonPropertyName("user_email")] bool UserEmail,
	[property: JsonPropertyName("username")] bool Username,
	[property: JsonPropertyName("user_title")] bool UserTitle,
	[property: JsonPropertyName("short_link")] bool ShortLink,
	[property: JsonPropertyName("hide_username_logs")] bool HideUsernameLogs,
	[property: JsonPropertyName("primary_group_id")] bool PrimaryGroupId,
	[property: JsonPropertyName("secondary_group_ids")] bool SecondaryGroupIds,
	[property: JsonPropertyName("user_dob_day")] bool UserDobDay,
	[property: JsonPropertyName("user_dob_month")] bool UserDobMonth,
	[property: JsonPropertyName("user_dob_year")] bool UserDobYear,
	[property: JsonPropertyName("fields")] bool Fields
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelEditPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelEditPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
		bool v7 = default;
		bool v8 = default;
		bool v9 = default;
		bool v10 = default;
		bool v11 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("password"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_email"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("hide_username_logs"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("primary_group_id"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("secondary_group_ids"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_dob_day"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_dob_month"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_dob_year"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("fields"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new Resp_UserModelEditPermissions(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
	}
}

public sealed record Resp_UserModelBirthdayTimeStamp(
	[property: JsonPropertyName("date")] string Date,
	[property: JsonPropertyName("timezone_type")] long TimezoneType,
	[property: JsonPropertyName("timezone")] string Timezone
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelBirthdayTimeStamp ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelBirthdayTimeStamp ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("date"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("timezone_type"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timezone"u8))
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
		return new Resp_UserModelBirthdayTimeStamp(v0, v1, v2);
	}
}

public sealed record Resp_UserModelBirthday(
	[property: JsonPropertyName("age")] long Age,
	[property: JsonPropertyName("timeStamp")] Resp_UserModelBirthdayTimeStamp TimeStamp,
	[property: JsonPropertyName("format")] string Format
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelBirthday ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelBirthday ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		Resp_UserModelBirthdayTimeStamp v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("age"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("timeStamp"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModelBirthdayTimeStamp.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("format"u8))
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
		return new Resp_UserModelBirthday(v0, v1, v2);
	}
}

public sealed record Resp_UserModelUserFollowingUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("avatar")] string Avatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelUserFollowingUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelUserFollowingUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
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
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar"u8))
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
		return new Resp_UserModelUserFollowingUsers(v0, v1, v2, v3);
	}
}

public sealed record Resp_UserModelUserFollowing(
	[property: JsonPropertyName("users")] List<Resp_UserModelUserFollowingUsers> Users,
	[property: JsonPropertyName("count")] long Count
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelUserFollowing ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelUserFollowing ReadFromReader(ref Utf8JsonReader reader)
	{
		List<Resp_UserModelUserFollowingUsers> v0 = null!;
		long v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("users"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<Resp_UserModelUserFollowingUsers>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = Resp_UserModelUserFollowingUsers.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v0 = __lst;
				}
			}
			else if (reader.ValueTextEquals("count"u8))
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
		return new Resp_UserModelUserFollowing(v0, v1);
	}
}

public sealed record Resp_UserModelUserFollowersUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("avatar")] string Avatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelUserFollowersUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelUserFollowersUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
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
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar"u8))
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
		return new Resp_UserModelUserFollowersUsers(v0, v1, v2, v3);
	}
}

public sealed record Resp_UserModelUserFollowers(
	[property: JsonPropertyName("users")] List<Resp_UserModelUserFollowersUsers> Users,
	[property: JsonPropertyName("count")] long Count
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_UserModelUserFollowers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_UserModelUserFollowers ReadFromReader(ref Utf8JsonReader reader)
	{
		List<Resp_UserModelUserFollowersUsers> v0 = null!;
		long v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("users"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<Resp_UserModelUserFollowersUsers>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = Resp_UserModelUserFollowersUsers.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v0 = __lst;
				}
			}
			else if (reader.ValueTextEquals("count"u8))
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
		return new Resp_UserModelUserFollowers(v0, v1);
	}
}

