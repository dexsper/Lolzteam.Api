// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class ProfileApiTypes
{
	public sealed record ProfileClaimsParams
	{
		/// <summary>
		/// Filter claims by their type.
		/// </summary>
		[JsonPropertyName("type")]
		public ProfileType? Type { get; init; }
		/// <summary>
		/// Filter claims by their state.
		/// </summary>
		[JsonPropertyName("claim_state")]
		public ClaimState? ClaimState { get; init; }
	}

	public sealed record ProfileClaimsResponse(
		[property: JsonPropertyName("claims")] List<ProfileClaimsResponseClaims> Claims,
		[property: JsonPropertyName("stats")] ProfileClaimsResponseStats Stats,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfileClaimsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfileClaimsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ProfileClaimsResponseClaims> v0 = null!;
			ProfileClaimsResponseStats v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("claims"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ProfileClaimsResponseClaims>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ProfileClaimsResponseClaims.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("stats"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ProfileClaimsResponseStats.ReadFromReader(ref reader);
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
			return new ProfileClaimsResponse(v0, v1, v2);
		}
	}

public sealed record ProfileClaimsResponseClaimsAuthorLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("avatar")] string Avatar,
	[property: JsonPropertyName("avatar_big")] string AvatarBig,
	[property: JsonPropertyName("avatar_small")] string AvatarSmall,
	[property: JsonPropertyName("followers")] string Followers,
	[property: JsonPropertyName("followings")] string Followings,
	[property: JsonPropertyName("ignore")] string Ignore,
	[property: JsonPropertyName("timeline")] string Timeline
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseClaimsAuthorLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseClaimsAuthorLinks ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("timeline"u8))
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
		return new ProfileClaimsResponseClaimsAuthorLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record ProfileClaimsResponseClaimsAuthorPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseClaimsAuthorPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseClaimsAuthorPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfileClaimsResponseClaimsAuthorPermissions(v0, v1, v2);
	}
}

public sealed record ProfileClaimsResponseClaimsAuthorFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseClaimsAuthorFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseClaimsAuthorFields ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		bool v4 = default;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfileClaimsResponseClaimsAuthorFields(v0, v1, v2, v3, v4);
	}
}

public sealed record ProfileClaimsResponseClaimsAuthor(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("user_message_count")] long UserMessageCount,
	[property: JsonPropertyName("user_register_date")] long UserRegisterDate,
	[property: JsonPropertyName("user_like_count")] long UserLikeCount,
	[property: JsonPropertyName("user_like2_count")] long UserLike2Count,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("trophy_count")] long TrophyCount,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("user_is_valid")] bool UserIsValid,
	[property: JsonPropertyName("user_is_verified")] bool UserIsVerified,
	[property: JsonPropertyName("user_is_followed")] bool UserIsFollowed,
	[property: JsonPropertyName("user_last_seen_date")] long UserLastSeenDate,
	[property: JsonPropertyName("links")] ProfileClaimsResponseClaimsAuthorLinks Links,
	[property: JsonPropertyName("permissions")] ProfileClaimsResponseClaimsAuthorPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("fields")] List<ProfileClaimsResponseClaimsAuthorFields> Fields
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseClaimsAuthor ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseClaimsAuthor ReadFromReader(ref Utf8JsonReader reader)
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
		long v10 = default;
		string v11 = null!;
		bool v12 = default;
		bool v13 = default;
		bool v14 = default;
		long v15 = default;
		ProfileClaimsResponseClaimsAuthorLinks v16 = null!;
		ProfileClaimsResponseClaimsAuthorPermissions v17 = null!;
		bool v18 = default;
		bool v19 = default;
		long v20 = default;
		string v21 = null!;
		List<ProfileClaimsResponseClaimsAuthorFields> v22 = null!;
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
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_valid"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_verified"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_followed"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_last_seen_date"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v16 = reader.TokenType == JsonTokenType.Null ? null! : ProfileClaimsResponseClaimsAuthorLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v17 = reader.TokenType == JsonTokenType.Null ? null! : ProfileClaimsResponseClaimsAuthorPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_visitor"u8))
			{
				reader.Read();
				v19 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v20 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("ban_reason"u8))
			{
				reader.Read();
				v21 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("fields"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ProfileClaimsResponseClaimsAuthorFields>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ProfileClaimsResponseClaimsAuthorFields.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v22 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfileClaimsResponseClaimsAuthor(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22);
	}
}

public sealed record ProfileClaimsResponseClaims(
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("claim_date")] long ClaimDate,
	[property: JsonPropertyName("claim_state")] string ClaimState,
	[property: JsonPropertyName("message_body")] string MessageBody,
	[property: JsonPropertyName("amount_formatted")] string AmountFormatted,
	[property: JsonPropertyName("author")] ProfileClaimsResponseClaimsAuthor Author
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseClaims ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseClaims ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		ProfileClaimsResponseClaimsAuthor v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("claim_date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("claim_state"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_body"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("amount_formatted"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("author"u8))
			{
				reader.Read();
				v5 = reader.TokenType == JsonTokenType.Null ? null! : ProfileClaimsResponseClaimsAuthor.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfileClaimsResponseClaims(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ProfileClaimsResponseStatsMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseStatsMarket ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseStatsMarket ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("total"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("solved"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("settled"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rejected"u8))
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
		return new ProfileClaimsResponseStatsMarket(v0, v1, v2, v3);
	}
}

public sealed record ProfileClaimsResponseStatsNoMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseStatsNoMarket ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseStatsNoMarket ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("total"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("solved"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("settled"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rejected"u8))
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
		return new ProfileClaimsResponseStatsNoMarket(v0, v1, v2, v3);
	}
}

public sealed record ProfileClaimsResponseStats(
	[property: JsonPropertyName("market")] ProfileClaimsResponseStatsMarket Market,
	[property: JsonPropertyName("noMarket")] ProfileClaimsResponseStatsNoMarket NoMarket
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProfileClaimsResponseStats ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProfileClaimsResponseStats ReadFromReader(ref Utf8JsonReader reader)
	{
		ProfileClaimsResponseStatsMarket v0 = null!;
		ProfileClaimsResponseStatsNoMarket v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("market"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ProfileClaimsResponseStatsMarket.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("noMarket"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : ProfileClaimsResponseStatsNoMarket.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProfileClaimsResponseStats(v0, v1);
	}
}

	public sealed record ProfileGetParams
	{
		/// <summary>
		/// List of hidden fields to include.
		/// </summary>
		[JsonPropertyName("fields_include")]
		public List<FieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record ProfileGetResponse(
		[property: JsonPropertyName("user")] UserModel User,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfileGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfileGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			UserModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("user"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : UserModel.ReadFromReader(ref reader);
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
			return new ProfileGetResponse(v0, v1);
		}
	}

	public sealed record ProfileEditBody
	{
		[JsonPropertyName("user")]
		public JsonElement? User { get; init; }
		[JsonPropertyName("option")]
		public JsonElement? Option { get; init; }
		/// <summary>
		/// Usernames who can transfer market accounts to you. Separate values with a comma.
		/// </summary>
		[JsonPropertyName("allow_accept_accounts")]
		public List<string>? AllowAcceptAccounts { get; init; }
		/// <summary>
		/// Telegram api id.
		/// </summary>
		[JsonPropertyName("telegram_api_id")]
		public string? TelegramApiId { get; init; }
		/// <summary>
		/// Telegram api hash.
		/// </summary>
		[JsonPropertyName("telegram_api_hash")]
		public string? TelegramApiHash { get; init; }
		/// <summary>
		/// Telegram device model.
		/// </summary>
		[JsonPropertyName("telegram_device_model")]
		public string? TelegramDeviceModel { get; init; }
		/// <summary>
		/// Telegram system version.
		/// </summary>
		[JsonPropertyName("telegram_system_version")]
		public string? TelegramSystemVersion { get; init; }
		/// <summary>
		/// Telegram app version.
		/// </summary>
		[JsonPropertyName("telegram_app_version")]
		public string? TelegramAppVersion { get; init; }
		/// <summary>
		/// Telegram lang pack.
		/// </summary>
		[JsonPropertyName("telegram_lang_pack")]
		public string? TelegramLangPack { get; init; }
		/// <summary>
		/// Telegram lang code.
		/// </summary>
		[JsonPropertyName("telegram_lang_code")]
		public string? TelegramLangCode { get; init; }
		/// <summary>
		/// Telegram system lang code.
		/// </summary>
		[JsonPropertyName("telegram_system_lang_code")]
		public string? TelegramSystemLangCode { get; init; }
		/// <summary>
		/// Clear Telegram data.
		/// </summary>
		[JsonPropertyName("clear_telegram_client")]
		public bool? ClearTelegramClient { get; init; }
	}

	public sealed record ProfileEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProfileEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProfileEditResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ProfileEditResponse(v0, v1, v2);
		}
	}

}
