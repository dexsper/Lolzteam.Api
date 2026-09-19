// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class ChatboxApiTypes
{
	public sealed record ChatboxIndexParams
	{
		/// <summary>
		/// Room id.
		/// </summary>
		[JsonPropertyName("room_id")]
		public RoomId? RoomId { get; init; }
	}

	public sealed record ChatboxIndexResponse(
		[property: JsonPropertyName("rooms")] List<ChatboxIndexResponseRooms> Rooms,
		[property: JsonPropertyName("ban")] JsonElement Ban,
		[property: JsonPropertyName("ignore")] List<ChatboxIndexResponseIgnore> Ignore,
		[property: JsonPropertyName("permissions")] ChatboxIndexResponsePermissions Permissions,
		[property: JsonPropertyName("commands")] List<string> Commands,
		[property: JsonPropertyName("roomsOnline")] ChatboxIndexResponseRoomsOnline RoomsOnline,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxIndexResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxIndexResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ChatboxIndexResponseRooms> v0 = null!;
			JsonElement v1 = default;
			List<ChatboxIndexResponseIgnore> v2 = null!;
			ChatboxIndexResponsePermissions v3 = null!;
			List<string> v4 = null!;
			ChatboxIndexResponseRoomsOnline v5 = null!;
			Resp_SystemInfo v6 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("rooms"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ChatboxIndexResponseRooms>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ChatboxIndexResponseRooms.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("ban"u8))
				{
					reader.Read();
					v1 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
				}
				else if (reader.ValueTextEquals("ignore"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ChatboxIndexResponseIgnore>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ChatboxIndexResponseIgnore.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v2 = __lst;
					}
				}
				else if (reader.ValueTextEquals("permissions"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxIndexResponsePermissions.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("commands"u8))
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
						v4 = __lst;
					}
				}
				else if (reader.ValueTextEquals("roomsOnline"u8))
				{
					reader.Read();
					v5 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxIndexResponseRoomsOnline.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v6 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ChatboxIndexResponse(v0, v1, v2, v3, v4, v5, v6);
		}
	}

public sealed record ChatboxIndexResponseRooms(
	[property: JsonPropertyName("can_report")] bool CanReport,
	[property: JsonPropertyName("deal_id")] JsonElement DealId,
	[property: JsonPropertyName("eng")] bool Eng,
	[property: JsonPropertyName("market")] bool Market,
	[property: JsonPropertyName("room_id")] long RoomId,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxIndexResponseRooms ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxIndexResponseRooms ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		JsonElement v1 = default;
		bool v2 = default;
		bool v3 = default;
		long v4 = default;
		string v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("can_report"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("deal_id"u8))
			{
				reader.Read();
				v1 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("eng"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("market"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("room_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
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
		return new ChatboxIndexResponseRooms(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ChatboxIndexResponseIgnoreCustomFields(
	[property: JsonPropertyName("_4")] JsonElement _4,
	[property: JsonPropertyName("scamURL")] JsonElement ScamURL,
	[property: JsonPropertyName("favoritePorn")] JsonElement FavoritePorn,
	[property: JsonPropertyName("favoriteVape")] JsonElement FavoriteVape,
	[property: JsonPropertyName("favoriteAnime")] JsonElement FavoriteAnime,
	[property: JsonPropertyName("lztLikesZeroing")] JsonElement LztLikesZeroing,
	[property: JsonPropertyName("lztLikesIncreasing")] JsonElement LztLikesIncreasing,
	[property: JsonPropertyName("lztSympathyZeroing")] JsonElement LztSympathyZeroing,
	[property: JsonPropertyName("lztSympathyIncreasing")] JsonElement LztSympathyIncreasing,
	[property: JsonPropertyName("telegram")] JsonElement Telegram,
	[property: JsonPropertyName("vk")] JsonElement Vk,
	[property: JsonPropertyName("discord")] JsonElement Discord,
	[property: JsonPropertyName("steam")] JsonElement Steam,
	[property: JsonPropertyName("matrix")] JsonElement Matrix,
	[property: JsonPropertyName("jabber")] JsonElement Jabber,
	[property: JsonPropertyName("github")] JsonElement Github
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxIndexResponseIgnoreCustomFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxIndexResponseIgnoreCustomFields ReadFromReader(ref Utf8JsonReader reader)
	{
		JsonElement v0 = default;
		JsonElement v1 = default;
		JsonElement v2 = default;
		JsonElement v3 = default;
		JsonElement v4 = default;
		JsonElement v5 = default;
		JsonElement v6 = default;
		JsonElement v7 = default;
		JsonElement v8 = default;
		JsonElement v9 = default;
		JsonElement v10 = default;
		JsonElement v11 = default;
		JsonElement v12 = default;
		JsonElement v13 = default;
		JsonElement v14 = default;
		JsonElement v15 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("_4"u8))
			{
				reader.Read();
				v0 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("scamURL"u8))
			{
				reader.Read();
				v1 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("favoritePorn"u8))
			{
				reader.Read();
				v2 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("favoriteVape"u8))
			{
				reader.Read();
				v3 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("favoriteAnime"u8))
			{
				reader.Read();
				v4 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztLikesZeroing"u8))
			{
				reader.Read();
				v5 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztLikesIncreasing"u8))
			{
				reader.Read();
				v6 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztSympathyZeroing"u8))
			{
				reader.Read();
				v7 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztSympathyIncreasing"u8))
			{
				reader.Read();
				v8 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("telegram"u8))
			{
				reader.Read();
				v9 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("vk"u8))
			{
				reader.Read();
				v10 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("discord"u8))
			{
				reader.Read();
				v11 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("steam"u8))
			{
				reader.Read();
				v12 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("matrix"u8))
			{
				reader.Read();
				v13 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("jabber"u8))
			{
				reader.Read();
				v14 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("github"u8))
			{
				reader.Read();
				v15 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ChatboxIndexResponseIgnoreCustomFields(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
	}
}

public sealed record ChatboxIndexResponseIgnoreRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxIndexResponseIgnoreRenderedAvatars ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxIndexResponseIgnoreRenderedAvatars ReadFromReader(ref Utf8JsonReader reader)
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
		return new ChatboxIndexResponseIgnoreRenderedAvatars(v0, v1, v2);
	}
}

public sealed record ChatboxIndexResponseIgnoreRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxIndexResponseIgnoreRenderedAvatars Avatars,
	[property: JsonPropertyName("backgrounds")] List<JsonElement> Backgrounds,
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("status")] string Status
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxIndexResponseIgnoreRendered ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxIndexResponseIgnoreRendered ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		ChatboxIndexResponseIgnoreRenderedAvatars v1 = null!;
		List<JsonElement> v2 = null!;
		string v3 = null!;
		string v4 = null!;
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
				v1 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxIndexResponseIgnoreRenderedAvatars.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("backgrounds"u8))
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
					v2 = __lst;
				}
			}
			else if (reader.ValueTextEquals("link"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("status"u8))
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
		return new ChatboxIndexResponseIgnoreRendered(v0, v1, v2, v3, v4);
	}
}

public sealed record ChatboxIndexResponseIgnore(
	[property: JsonPropertyName("can_edit")] bool CanEdit,
	[property: JsonPropertyName("can_follow")] bool CanFollow,
	[property: JsonPropertyName("can_ignore")] bool CanIgnore,
	[property: JsonPropertyName("can_post_profile")] bool CanPostProfile,
	[property: JsonPropertyName("can_view_profile")] bool CanViewProfile,
	[property: JsonPropertyName("can_view_profile_posts")] bool CanViewProfilePosts,
	[property: JsonPropertyName("can_warn")] bool CanWarn,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("conv_auto_reply_message")] string ConvAutoReplyMessage,
	[property: JsonPropertyName("conv_welcome_message")] string ConvWelcomeMessage,
	[property: JsonPropertyName("convertedDeposit")] long ConvertedDeposit,
	[property: JsonPropertyName("custom_fields")] ChatboxIndexResponseIgnoreCustomFields CustomFields,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("gender")] string Gender,
	[property: JsonPropertyName("homepage")] string Homepage,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_followed")] bool IsFollowed,
	[property: JsonPropertyName("is_ignored")] bool IsIgnored,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("location")] string Location,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("occupation")] string Occupation,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] ChatboxIndexResponseIgnoreRendered Rendered,
	[property: JsonPropertyName("short_link")] JsonElement ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("view_url")] string ViewUrl,
	[property: JsonPropertyName("warning_points")] long WarningPoints
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxIndexResponseIgnore ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxIndexResponseIgnore ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
		long v7 = default;
		string v8 = null!;
		string v9 = null!;
		long v10 = default;
		ChatboxIndexResponseIgnoreCustomFields v11 = null!;
		long v12 = default;
		long v13 = default;
		long v14 = default;
		string v15 = null!;
		string v16 = null!;
		bool v17 = default;
		bool v18 = default;
		bool v19 = default;
		bool v20 = default;
		bool v21 = default;
		bool v22 = default;
		long v23 = default;
		long v24 = default;
		long v25 = default;
		string v26 = null!;
		long v27 = default;
		string v28 = null!;
		long v29 = default;
		ChatboxIndexResponseIgnoreRendered v30 = null!;
		JsonElement v31 = default;
		long v32 = default;
		long v33 = default;
		string v34 = null!;
		string v35 = null!;
		string v36 = null!;
		long v37 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("can_edit"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_follow"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_ignore"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_post_profile"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_view_profile"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_view_profile_posts"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_warn"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("contest_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conv_auto_reply_message"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("conv_welcome_message"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("convertedDeposit"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_fields"u8))
			{
				reader.Read();
				v11 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxIndexResponseIgnoreCustomFields.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("deposit"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_banner_id"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_icon_group_id"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("gender"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("homepage"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_admin"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_followed"u8))
			{
				reader.Read();
				v19 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_ignored"u8))
			{
				reader.Read();
				v20 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_moderator"u8))
			{
				reader.Read();
				v21 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_staff"u8))
			{
				reader.Read();
				v22 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v23 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like2_count"u8))
			{
				reader.Read();
				v24 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_count"u8))
			{
				reader.Read();
				v25 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("location"u8))
			{
				reader.Read();
				v26 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_count"u8))
			{
				reader.Read();
				v27 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("occupation"u8))
			{
				reader.Read();
				v28 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("register_date"u8))
			{
				reader.Read();
				v29 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rendered"u8))
			{
				reader.Read();
				v30 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxIndexResponseIgnoreRendered.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v31 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("trophy_points"u8))
			{
				reader.Read();
				v32 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v33 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v34 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v35 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("view_url"u8))
			{
				reader.Read();
				v36 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("warning_points"u8))
			{
				reader.Read();
				v37 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ChatboxIndexResponseIgnore(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37);
	}
}

public sealed record ChatboxIndexResponsePermissions(
	[property: JsonPropertyName("viewMessages")] bool ViewMessages,
	[property: JsonPropertyName("viewAnyMessage")] bool ViewAnyMessage,
	[property: JsonPropertyName("editAnyMessage")] bool EditAnyMessage,
	[property: JsonPropertyName("deleteAnyMessage")] bool DeleteAnyMessage,
	[property: JsonPropertyName("ban")] bool Ban,
	[property: JsonPropertyName("postMessage")] bool PostMessage,
	[property: JsonPropertyName("report")] bool Report
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxIndexResponsePermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxIndexResponsePermissions ReadFromReader(ref Utf8JsonReader reader)
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

			if (reader.ValueTextEquals("viewMessages"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("viewAnyMessage"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("editAnyMessage"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("deleteAnyMessage"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("ban"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("postMessage"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("report"u8))
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
		return new ChatboxIndexResponsePermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ChatboxIndexResponseRoomsOnline(
	[property: JsonPropertyName("chat:1")] long Chat_1,
	[property: JsonPropertyName("chat:2")] long Chat_2,
	[property: JsonPropertyName("chat:3")] long Chat_3,
	[property: JsonPropertyName("chat:4")] long Chat_4
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxIndexResponseRoomsOnline ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxIndexResponseRoomsOnline ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("chat:1"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("chat:2"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("chat:3"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("chat:4"u8))
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
		return new ChatboxIndexResponseRoomsOnline(v0, v1, v2, v3);
	}
}

	public sealed record ChatboxGetMessagesParams
	{
		/// <summary>
		/// Room id.
		/// </summary>
		[JsonPropertyName("room_id")]
		public required RoomId RoomId { get; init; }
		/// <summary>
		/// Message id to get older chat messages.
		/// </summary>
		[JsonPropertyName("before_message_id")]
		public long? BeforeMessageId { get; init; }
	}

	public sealed record ChatboxGetMessagesResponse(
		[property: JsonPropertyName("messages")] List<Resp_ChatboxMessageModel> Messages,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxGetMessagesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxGetMessagesResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ChatboxMessageModel> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("messages"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_ChatboxMessageModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_ChatboxMessageModel.ReadFromReader(ref reader);
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
			return new ChatboxGetMessagesResponse(v0, v1);
		}
	}

	public sealed record ChatboxPostMessageBody
	{
		/// <summary>
		/// Room ID.
		/// </summary>
		[JsonPropertyName("room_id")]
		public required RoomId RoomId { get; init; }
		/// <summary>
		/// ID of the message being replied to.
		/// </summary>
		[JsonPropertyName("reply_message_id")]
		public long? ReplyMessageId { get; init; }
		/// <summary>
		/// Content of the chat message.
		/// </summary>
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ChatboxPostMessageResponse(
		[property: JsonPropertyName("message")] Resp_ChatboxMessageModel Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxPostMessageResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxPostMessageResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ChatboxMessageModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ChatboxMessageModel.ReadFromReader(ref reader);
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
			return new ChatboxPostMessageResponse(v0, v1);
		}
	}

	public sealed record ChatboxEditMessageBody
	{
		/// <summary>
		/// Message id.
		/// </summary>
		[JsonPropertyName("message_id")]
		public required long? MessageId { get; init; }
		/// <summary>
		/// New content of the chat message.
		/// </summary>
		[JsonPropertyName("message")]
		public required string Message { get; init; }
	}

	public sealed record ChatboxEditMessageResponse(
		[property: JsonPropertyName("message")] Resp_ChatboxMessageModel Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxEditMessageResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxEditMessageResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ChatboxMessageModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ChatboxMessageModel.ReadFromReader(ref reader);
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
			return new ChatboxEditMessageResponse(v0, v1);
		}
	}

	public sealed record ChatboxDeleteMessageBody
	{
		/// <summary>
		/// Message id.
		/// </summary>
		[JsonPropertyName("message_id")]
		public required long? MessageId { get; init; }
	}

	public sealed record ChatboxDeleteMessageResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxDeleteMessageResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxDeleteMessageResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ChatboxDeleteMessageResponse(v0, v1, v2);
		}
	}

	public sealed record ChatboxOnlineParams
	{
		/// <summary>
		/// Room id.
		/// </summary>
		[JsonPropertyName("room_id")]
		public required RoomId RoomId { get; init; }
	}

	public sealed record ChatboxOnlineResponse(
		[property: JsonPropertyName("users")] List<ChatboxOnlineResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxOnlineResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxOnlineResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ChatboxOnlineResponseUsers> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ChatboxOnlineResponseUsers>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ChatboxOnlineResponseUsers.ReadFromReader(ref reader);
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
			return new ChatboxOnlineResponse(v0, v1);
		}
	}

public sealed record ChatboxOnlineResponseUsersRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxOnlineResponseUsersRenderedAvatars ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxOnlineResponseUsersRenderedAvatars ReadFromReader(ref Utf8JsonReader reader)
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
		return new ChatboxOnlineResponseUsersRenderedAvatars(v0, v1, v2);
	}
}

public sealed record ChatboxOnlineResponseUsersRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxOnlineResponseUsersRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxOnlineResponseUsersRendered ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxOnlineResponseUsersRendered ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		ChatboxOnlineResponseUsersRenderedAvatars v1 = null!;
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
				v1 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxOnlineResponseUsersRenderedAvatars.ReadFromReader(ref reader);
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
		return new ChatboxOnlineResponseUsersRendered(v0, v1, v2);
	}
}

public sealed record ChatboxOnlineResponseUsersUniqBanner(
	[property: JsonPropertyName("banner_css")] string BannerCss,
	[property: JsonPropertyName("banner_text")] string BannerText,
	[property: JsonPropertyName("banner_icon")] string BannerIcon,
	[property: JsonPropertyName("username_icon")] string UsernameIcon
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxOnlineResponseUsersUniqBanner ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxOnlineResponseUsersUniqBanner ReadFromReader(ref Utf8JsonReader reader)
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
		return new ChatboxOnlineResponseUsersUniqBanner(v0, v1, v2, v3);
	}
}

public sealed record ChatboxOnlineResponseUsers(
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
	[property: JsonPropertyName("rendered")] ChatboxOnlineResponseUsersRendered Rendered,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] ChatboxOnlineResponseUsersUniqBanner UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxOnlineResponseUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxOnlineResponseUsers ReadFromReader(ref Utf8JsonReader reader)
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
		ChatboxOnlineResponseUsersRendered v16 = null!;
		string v17 = null!;
		long v18 = default;
		ChatboxOnlineResponseUsersUniqBanner v19 = null!;
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
				v16 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxOnlineResponseUsersRendered.ReadFromReader(ref reader);
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
				v19 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxOnlineResponseUsersUniqBanner.ReadFromReader(ref reader);
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
		return new ChatboxOnlineResponseUsers(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22);
	}
}

	public sealed record ChatboxReportReasonsParams
	{
		/// <summary>
		/// Message id.
		/// </summary>
		[JsonPropertyName("message_id")]
		public required long? MessageId { get; init; }
	}

	public sealed record ChatboxReportReasonsResponse(
		[property: JsonPropertyName("reasons")] List<string> Reasons,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxReportReasonsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxReportReasonsResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ChatboxReportReasonsResponse(v0, v1);
		}
	}

	public sealed record ChatboxReportBody
	{
		/// <summary>
		/// Message id.
		/// </summary>
		[JsonPropertyName("message_id")]
		public required long? MessageId { get; init; }
		/// <summary>
		/// Report reason.
		/// </summary>
		[JsonPropertyName("reason")]
		public required string Reason { get; init; }
	}

	public sealed record ChatboxReportResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxReportResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxReportResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ChatboxReportResponse(v0, v1, v2);
		}
	}

	public sealed record ChatboxGetLeaderboardParams
	{
		/// <summary>
		/// Duration.
		/// </summary>
		[JsonPropertyName("duration")]
		public Duration? Duration { get; init; }
	}

	public sealed record ChatboxGetLeaderboardResponse(
		[property: JsonPropertyName("leaderboard")] List<ChatboxGetLeaderboardResponseLeaderboard> Leaderboard,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxGetLeaderboardResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxGetLeaderboardResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ChatboxGetLeaderboardResponseLeaderboard> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("leaderboard"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ChatboxGetLeaderboardResponseLeaderboard>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ChatboxGetLeaderboardResponseLeaderboard.ReadFromReader(ref reader);
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
			return new ChatboxGetLeaderboardResponse(v0, v1);
		}
	}

public sealed record ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars ReadFromReader(ref Utf8JsonReader reader)
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
		return new ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars(v0, v1, v2);
	}
}

public sealed record ChatboxGetLeaderboardResponseLeaderboardRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxGetLeaderboardResponseLeaderboardRendered ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxGetLeaderboardResponseLeaderboardRendered ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars v1 = null!;
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
				v1 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxGetLeaderboardResponseLeaderboardRenderedAvatars.ReadFromReader(ref reader);
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
		return new ChatboxGetLeaderboardResponseLeaderboardRendered(v0, v1, v2);
	}
}

public sealed record ChatboxGetLeaderboardResponseLeaderboardUniqBanner(
	[property: JsonPropertyName("banner_css")] string BannerCss,
	[property: JsonPropertyName("banner_text")] string BannerText,
	[property: JsonPropertyName("banner_icon")] string BannerIcon
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxGetLeaderboardResponseLeaderboardUniqBanner ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxGetLeaderboardResponseLeaderboardUniqBanner ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ChatboxGetLeaderboardResponseLeaderboardUniqBanner(v0, v1, v2);
	}
}

public sealed record ChatboxGetLeaderboardResponseLeaderboard(
	[property: JsonPropertyName("count")] long Count,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] ChatboxGetLeaderboardResponseLeaderboardRendered Rendered,
	[property: JsonPropertyName("short_link")] JsonElement ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] ChatboxGetLeaderboardResponseLeaderboardUniqBanner UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("username")] string Username
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxGetLeaderboardResponseLeaderboard ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxGetLeaderboardResponseLeaderboard ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		string v5 = null!;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		bool v9 = default;
		long v10 = default;
		long v11 = default;
		long v12 = default;
		long v13 = default;
		long v14 = default;
		ChatboxGetLeaderboardResponseLeaderboardRendered v15 = null!;
		JsonElement v16 = default;
		long v17 = default;
		ChatboxGetLeaderboardResponseLeaderboardUniqBanner v18 = null!;
		string v19 = null!;
		string v20 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("count"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("background_date"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("contest_count"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("display_banner_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_icon_group_id"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like2_count"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_count"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("message_count"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("register_date"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rendered"u8))
			{
				reader.Read();
				v15 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxGetLeaderboardResponseLeaderboardRendered.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v16 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("trophy_points"u8))
			{
				reader.Read();
				v17 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("uniq_banner"u8))
			{
				reader.Read();
				v18 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxGetLeaderboardResponseLeaderboardUniqBanner.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ChatboxGetLeaderboardResponseLeaderboard(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
	}
}

	public sealed record ChatboxGetIgnoreResponse(
		[property: JsonPropertyName("ignored")] List<ChatboxGetIgnoreResponseIgnored> Ignored,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxGetIgnoreResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxGetIgnoreResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ChatboxGetIgnoreResponseIgnored> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("ignored"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ChatboxGetIgnoreResponseIgnored>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ChatboxGetIgnoreResponseIgnored.ReadFromReader(ref reader);
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
			return new ChatboxGetIgnoreResponse(v0, v1);
		}
	}

public sealed record ChatboxGetIgnoreResponseIgnoredRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxGetIgnoreResponseIgnoredRenderedAvatars ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxGetIgnoreResponseIgnoredRenderedAvatars ReadFromReader(ref Utf8JsonReader reader)
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
		return new ChatboxGetIgnoreResponseIgnoredRenderedAvatars(v0, v1, v2);
	}
}

public sealed record ChatboxGetIgnoreResponseIgnoredRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] ChatboxGetIgnoreResponseIgnoredRenderedAvatars Avatars,
	[property: JsonPropertyName("link")] string Link
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxGetIgnoreResponseIgnoredRendered ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxGetIgnoreResponseIgnoredRendered ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		ChatboxGetIgnoreResponseIgnoredRenderedAvatars v1 = null!;
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
				v1 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxGetIgnoreResponseIgnoredRenderedAvatars.ReadFromReader(ref reader);
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
		return new ChatboxGetIgnoreResponseIgnoredRendered(v0, v1, v2);
	}
}

public sealed record ChatboxGetIgnoreResponseIgnored(
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("background_date")] long BackgroundDate,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("display_banner_id")] long DisplayBannerId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] ChatboxGetIgnoreResponseIgnoredRendered Rendered,
	[property: JsonPropertyName("short_link")] JsonElement ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("uniq_banner")] JsonElement UniqBanner,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ChatboxGetIgnoreResponseIgnored ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ChatboxGetIgnoreResponseIgnored ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		bool v7 = default;
		long v8 = default;
		long v9 = default;
		long v10 = default;
		long v11 = default;
		long v12 = default;
		ChatboxGetIgnoreResponseIgnoredRendered v13 = null!;
		JsonElement v14 = default;
		long v15 = default;
		JsonElement v16 = default;
		string v17 = null!;
		long v18 = default;
		string v19 = null!;
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
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like2_count"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_count"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("message_count"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("register_date"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rendered"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : ChatboxGetIgnoreResponseIgnoredRendered.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v14 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("trophy_points"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("uniq_banner"u8))
			{
				reader.Read();
				v16 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v18 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ChatboxGetIgnoreResponseIgnored(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
	}
}

	public sealed record ChatboxPostIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required Lolzteam.Api.Runtime.StringOrLong UserId { get; init; }
	}

	public sealed record ChatboxPostIgnoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxPostIgnoreResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxPostIgnoreResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ChatboxPostIgnoreResponse(v0, v1, v2);
		}
	}

	public sealed record ChatboxDeleteIgnoreBody
	{
		[JsonPropertyName("user_id")]
		public required Lolzteam.Api.Runtime.StringOrLong UserId { get; init; }
	}

	public sealed record ChatboxDeleteIgnoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ChatboxDeleteIgnoreResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ChatboxDeleteIgnoreResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ChatboxDeleteIgnoreResponse(v0, v1, v2);
		}
	}

}
