// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class UsersApiTypes
{
	public sealed record UsersListParams
	{
		/// <summary>
		/// Page number of users.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of users in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// List of fields to include.
		/// </summary>
		[JsonPropertyName("fields_include")]
		public List<UsersFieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record UsersListResponse(
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("links")] UsersListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_UserModel> v0 = null!;
			long v1 = default;
			UsersListResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_UserModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_UserModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("users_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : UsersListResponseLinks.ReadFromReader(ref reader);
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
			return new UsersListResponse(v0, v1, v2, v3);
		}
	}

public sealed record UsersListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersListResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersListResponseLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersListResponseLinks(v0, v1, v2);
	}
}

	public sealed record UsersFieldsResponse(
		[property: JsonPropertyName("fields")] List<UsersFieldsResponseFields> Fields,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersFieldsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersFieldsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersFieldsResponseFields> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("fields"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersFieldsResponseFields>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersFieldsResponseFields.ReadFromReader(ref reader);
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
			return new UsersFieldsResponse(v0, v1);
		}
	}

public sealed record UsersFieldsResponseFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFieldsResponseFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFieldsResponseFields ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersFieldsResponseFields(v0, v1, v2, v3, v4);
	}
}

	public sealed record UsersFindParams
	{
		/// <summary>
		/// Username to filter. Usernames start with the query will be returned.
		/// </summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		/// <summary>
		/// Custom fields to filter. Example: <b>custom_fields[telegram]=telegramLogin</b>.
		/// </summary>
		[JsonPropertyName("custom_fields")]
		public JsonElement? CustomFields { get; init; }
		/// <summary>
		/// List of fields to include.
		/// </summary>
		[JsonPropertyName("fields_include")]
		public List<UsersFieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record UsersFindResponse(
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersFindResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersFindResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_UserModel> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_UserModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_UserModel.ReadFromReader(ref reader);
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
			return new UsersFindResponse(v0, v1);
		}
	}

	public sealed record UsersGetParams
	{
		/// <summary>
		/// List of fields to include.
		/// </summary>
		[JsonPropertyName("fields_include")]
		public List<UsersFieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record UsersGetResponse(
		[property: JsonPropertyName("user")] Resp_UserModel User,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_UserModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("user"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
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
			return new UsersGetResponse(v0, v1);
		}
	}

	public sealed record UsersEditBody
	{
		/// <summary>
		/// New username.
		/// </summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		/// <summary>
		/// New custom title of the user.
		/// </summary>
		[JsonPropertyName("user_title")]
		public string? UserTitle { get; init; }
		/// <summary>
		/// Id of the group you want to display.
		/// </summary>
		[JsonPropertyName("display_group_id")]
		public long? DisplayGroupId { get; init; }
		/// <summary>
		/// Id of the icon group you want to display.
		/// </summary>
		[JsonPropertyName("display_icon_group_id")]
		public long? DisplayIconGroupId { get; init; }
		/// <summary>
		/// Id of the banner you want to display.
		/// </summary>
		[JsonPropertyName("display_banner_id")]
		public long? DisplayBannerId { get; init; }
		/// <summary>
		/// This message is shown when someone wants to write to you.
		/// </summary>
		[JsonPropertyName("conv_welcome_message")]
		public string? ConvWelcomeMessage { get; init; }
		/// <summary>
		/// Your date of birth (day).
		/// </summary>
		[JsonPropertyName("user_dob_day")]
		public long? UserDobDay { get; init; }
		/// <summary>
		/// Your date of birth (month).
		/// </summary>
		[JsonPropertyName("user_dob_month")]
		public long? UserDobMonth { get; init; }
		/// <summary>
		/// Your date of birth (year).
		/// </summary>
		[JsonPropertyName("user_dob_year")]
		public long? UserDobYear { get; init; }
		/// <summary>
		/// Secret answer.
		/// </summary>
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		/// <summary>
		/// Secret answer type.
		/// </summary>
		[JsonPropertyName("secret_answer_type")]
		public long? SecretAnswerType { get; init; }
		/// <summary>
		/// Profile short link.
		/// </summary>
		[JsonPropertyName("short_link")]
		public string? ShortLink { get; init; }
		/// <summary>
		/// User interface language ID.
		/// </summary>
		[JsonPropertyName("language_id")]
		public LanguageId? LanguageId { get; init; }
		/// <summary>
		/// User gender.
		/// </summary>
		[JsonPropertyName("gender")]
		public Gender? Gender { get; init; }
		/// <summary>
		/// User timezone.
		/// </summary>
		[JsonPropertyName("timezone")]
		public Timezone? Timezone { get; init; }
		/// <summary>
		/// Whether to receive admin emails.
		/// </summary>
		[JsonPropertyName("receive_admin_email")]
		public bool? ReceiveAdminEmail { get; init; }
		/// <summary>
		/// Whether user activity is visible.
		/// </summary>
		[JsonPropertyName("activity_visible")]
		public bool? ActivityVisible { get; init; }
		/// <summary>
		/// Show date of birth (day and month).
		/// </summary>
		[JsonPropertyName("show_dob_date")]
		public bool? ShowDobDate { get; init; }
		/// <summary>
		/// Show year of birth.
		/// </summary>
		[JsonPropertyName("show_dob_year")]
		public bool? ShowDobYear { get; init; }
		/// <summary>
		/// Hide username change logs.
		/// </summary>
		[JsonPropertyName("hide_username_change_logs")]
		public bool? HideUsernameChangeLogs { get; init; }
		/// <summary>
		/// Who can view your profile.
		/// </summary>
		[JsonPropertyName("allow_view_profile")]
		public AllowViewProfile? AllowViewProfile { get; init; }
		/// <summary>
		/// Who can post on your profile.
		/// </summary>
		[JsonPropertyName("allow_post_profile")]
		public AllowPostProfile? AllowPostProfile { get; init; }
		/// <summary>
		/// Who can send you personal conversations.
		/// </summary>
		[JsonPropertyName("allow_send_personal_conversation")]
		public AllowSendPersonalConversation? AllowSendPersonalConversation { get; init; }
		/// <summary>
		/// Who can invite you to groups.
		/// </summary>
		[JsonPropertyName("allow_invite_group")]
		public AllowInviteGroup? AllowInviteGroup { get; init; }
		/// <summary>
		/// Who can see your news feed.
		/// </summary>
		[JsonPropertyName("allow_receive_news_feed")]
		public AllowReceiveNewsFeed? AllowReceiveNewsFeed { get; init; }
		/// <summary>
		/// Alert settings.
		/// </summary>
		[JsonPropertyName("alert")]
		public JsonElement? Alert { get; init; }
		/// <summary>
		/// Custom user profile fields.
		/// </summary>
		[JsonPropertyName("fields")]
		public JsonElement? Fields { get; init; }
	}

	public sealed record UsersEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersEditResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersEditResponse(v0, v1, v2);
		}
	}

	public sealed record UsersClaimsParams
	{
		/// <summary>
		/// Filter claims by their type.
		/// </summary>
		[JsonPropertyName("type")]
		public NotificationsType? Type { get; init; }
		/// <summary>
		/// Filter claims by their state.
		/// </summary>
		[JsonPropertyName("claim_state")]
		public ClaimState? ClaimState { get; init; }
	}

	public sealed record UsersClaimsResponse(
		[property: JsonPropertyName("claims")] List<UsersClaimsResponseClaims> Claims,
		[property: JsonPropertyName("stats")] UsersClaimsResponseStats Stats,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersClaimsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersClaimsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersClaimsResponseClaims> v0 = null!;
			UsersClaimsResponseStats v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("claims"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersClaimsResponseClaims>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersClaimsResponseClaims.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("stats"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : UsersClaimsResponseStats.ReadFromReader(ref reader);
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
			return new UsersClaimsResponse(v0, v1, v2);
		}
	}

public sealed record UsersClaimsResponseClaims(
	[property: JsonPropertyName("thread_id")] long ThreadId,
	[property: JsonPropertyName("claim_date")] long ClaimDate,
	[property: JsonPropertyName("claim_state")] string ClaimState,
	[property: JsonPropertyName("message_body")] string MessageBody,
	[property: JsonPropertyName("message_body_html")] string MessageBodyHtml,
	[property: JsonPropertyName("message_body_plain_text")] string MessageBodyPlainText,
	[property: JsonPropertyName("amount")] long Amount,
	[property: JsonPropertyName("amount_formatted")] string AmountFormatted,
	[property: JsonPropertyName("author")] Resp_UserModel Author
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersClaimsResponseClaims ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersClaimsResponseClaims ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		long v6 = default;
		string v7 = null!;
		Resp_UserModel v8 = null!;
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
			else if (reader.ValueTextEquals("message_body_html"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_body_plain_text"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("amount"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("amount_formatted"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("author"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersClaimsResponseClaims(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record UsersClaimsResponseStatsMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersClaimsResponseStatsMarket ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersClaimsResponseStatsMarket ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersClaimsResponseStatsMarket(v0, v1, v2, v3);
	}
}

public sealed record UsersClaimsResponseStatsNoMarket(
	[property: JsonPropertyName("total")] long Total,
	[property: JsonPropertyName("solved")] long Solved,
	[property: JsonPropertyName("settled")] long Settled,
	[property: JsonPropertyName("rejected")] long Rejected
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersClaimsResponseStatsNoMarket ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersClaimsResponseStatsNoMarket ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersClaimsResponseStatsNoMarket(v0, v1, v2, v3);
	}
}

public sealed record UsersClaimsResponseStats(
	[property: JsonPropertyName("market")] UsersClaimsResponseStatsMarket Market,
	[property: JsonPropertyName("noMarket")] UsersClaimsResponseStatsNoMarket NoMarket
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersClaimsResponseStats ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersClaimsResponseStats ReadFromReader(ref Utf8JsonReader reader)
	{
		UsersClaimsResponseStatsMarket v0 = null!;
		UsersClaimsResponseStatsNoMarket v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("market"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : UsersClaimsResponseStatsMarket.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("noMarket"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : UsersClaimsResponseStatsNoMarket.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersClaimsResponseStats(v0, v1);
	}
}

	public sealed record UsersAvatarUploadBody
	{
		/// <summary>
		/// Binary data of the avatar.
		/// </summary>
		[JsonPropertyName("avatar")]
		public required byte[] Avatar { get; init; }
		/// <summary>
		/// The starting point of the selection by width. Default value - 0
		/// </summary>
		[JsonPropertyName("x")]
		public long? X { get; init; }
		/// <summary>
		/// The starting point of the selection by height. Default value - 0
		/// </summary>
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		/// <summary>
		/// Selection size.
		/// </summary>
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
	}

	public sealed record UsersAvatarUploadResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersAvatarUploadResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersAvatarUploadResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersAvatarUploadResponse(v0, v1, v2);
		}
	}

	public sealed record UsersAvatarDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersAvatarDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersAvatarDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersAvatarDeleteResponse(v0, v1, v2);
		}
	}

	public sealed record UsersAvatarCropBody
	{
		/// <summary>
		/// The starting point of the selection by width. Default value - 0
		/// </summary>
		[JsonPropertyName("x")]
		public long? X { get; init; }
		/// <summary>
		/// The starting point of the selection by height. Default value - 0
		/// </summary>
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		/// <summary>
		/// Selection size.
		/// </summary>
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
	}

	public sealed record UsersAvatarCropResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersAvatarCropResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersAvatarCropResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersAvatarCropResponse(v0, v1, v2);
		}
	}

	public sealed record UsersBackgroundUploadBody
	{
		/// <summary>
		/// Binary data of the background. Background image must be 1920x1080 pixels
		/// </summary>
		[JsonPropertyName("background")]
		public required byte[] Background { get; init; }
		/// <summary>
		/// The starting point of the selection by width. Default value - 0
		/// </summary>
		[JsonPropertyName("x")]
		public long? X { get; init; }
		/// <summary>
		/// The starting point of the selection by height. Default value - 0
		/// </summary>
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		/// <summary>
		/// Selection size.
		/// </summary>
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
	}

	public sealed record UsersBackgroundUploadResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersBackgroundUploadResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersBackgroundUploadResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersBackgroundUploadResponse(v0, v1, v2);
		}
	}

	public sealed record UsersBackgroundDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersBackgroundDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersBackgroundDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersBackgroundDeleteResponse(v0, v1, v2);
		}
	}

	public sealed record UsersBackgroundCropBody
	{
		/// <summary>
		/// The starting point of the selection by width. Default value - 0
		/// </summary>
		[JsonPropertyName("x")]
		public long? X { get; init; }
		/// <summary>
		/// The starting point of the selection by height. Default value - 0
		/// </summary>
		[JsonPropertyName("y")]
		public long? Y { get; init; }
		/// <summary>
		/// Selection size.
		/// </summary>
		[JsonPropertyName("crop")]
		public long? Crop { get; init; }
	}

	public sealed record UsersBackgroundCropResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersBackgroundCropResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersBackgroundCropResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersBackgroundCropResponse(v0, v1, v2);
		}
	}

	public sealed record UsersFollowersParams
	{
		/// <summary>
		/// Ordering of followers.
		/// </summary>
		[JsonPropertyName("order")]
		public UsersOrder? Order { get; init; }
		/// <summary>
		/// Page number of followers.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of followers in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record UsersFollowersResponse(
		[property: JsonPropertyName("users")] List<UsersFollowersResponseUsers> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("links")] UsersFollowersResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersFollowersResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersFollowersResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersFollowersResponseUsers> v0 = null!;
			long v1 = default;
			UsersFollowersResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersFollowersResponseUsers>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersFollowersResponseUsers.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("users_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : UsersFollowersResponseLinks.ReadFromReader(ref reader);
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
			return new UsersFollowersResponse(v0, v1, v2, v3);
		}
	}

public sealed record UsersFollowersResponseUsersLinks(
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
	public static UsersFollowersResponseUsersLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowersResponseUsersLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersFollowersResponseUsersLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record UsersFollowersResponseUsersPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFollowersResponseUsersPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowersResponseUsersPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersFollowersResponseUsersPermissions(v0, v1, v2, v3);
	}
}

public sealed record UsersFollowersResponseUsersCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("lztInnovation20Link")] string LztInnovation20Link,
	[property: JsonPropertyName("lztInnovation30Link")] string LztInnovation30Link,
	[property: JsonPropertyName("lztInnovationLink")] string LztInnovationLink
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFollowersResponseUsersCustomFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowersResponseUsersCustomFields ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("_4"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztInnovation20Link"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztInnovation30Link"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztInnovationLink"u8))
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
		return new UsersFollowersResponseUsersCustomFields(v0, v1, v2, v3);
	}
}

public sealed record UsersFollowersResponseUsers(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("follow_date")] long FollowDate,
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
	[property: JsonPropertyName("user_following_count")] long UserFollowingCount,
	[property: JsonPropertyName("user_followers_count")] long UserFollowersCount,
	[property: JsonPropertyName("links")] UsersFollowersResponseUsersLinks Links,
	[property: JsonPropertyName("permissions")] UsersFollowersResponseUsersPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("custom_fields")] UsersFollowersResponseUsersCustomFields CustomFields
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFollowersResponseUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowersResponseUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		string v4 = null!;
		string v5 = null!;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		long v9 = default;
		long v10 = default;
		long v11 = default;
		string v12 = null!;
		long v13 = default;
		string v14 = null!;
		bool v15 = default;
		bool v16 = default;
		bool v17 = default;
		long v18 = default;
		long v19 = default;
		long v20 = default;
		UsersFollowersResponseUsersLinks v21 = null!;
		UsersFollowersResponseUsersPermissions v22 = null!;
		bool v23 = default;
		bool v24 = default;
		long v25 = default;
		UsersFollowersResponseUsersCustomFields v26 = null!;
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
			else if (reader.ValueTextEquals("follow_date"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_message_count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_register_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_like_count"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_like2_count"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("contest_count"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("trophy_count"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_valid"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_verified"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_followed"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_last_seen_date"u8))
			{
				reader.Read();
				v18 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_following_count"u8))
			{
				reader.Read();
				v19 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_followers_count"u8))
			{
				reader.Read();
				v20 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v21 = reader.TokenType == JsonTokenType.Null ? null! : UsersFollowersResponseUsersLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v22 = reader.TokenType == JsonTokenType.Null ? null! : UsersFollowersResponseUsersPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v23 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_visitor"u8))
			{
				reader.Read();
				v24 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v25 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_fields"u8))
			{
				reader.Read();
				v26 = reader.TokenType == JsonTokenType.Null ? null! : UsersFollowersResponseUsersCustomFields.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersFollowersResponseUsers(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);
	}
}

public sealed record UsersFollowersResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFollowersResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowersResponseLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersFollowersResponseLinks(v0, v1, v2);
	}
}

	public sealed record UsersFollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersFollowResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersFollowResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersFollowResponse(v0, v1, v2);
		}
	}

	public sealed record UsersUnfollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersUnfollowResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersUnfollowResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersUnfollowResponse(v0, v1, v2);
		}
	}

	public sealed record UsersFollowingsParams
	{
		/// <summary>
		/// Ordering of users.
		/// </summary>
		[JsonPropertyName("order")]
		public UsersOrder? Order { get; init; }
		/// <summary>
		/// Page number of users.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of users in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record UsersFollowingsResponse(
		[property: JsonPropertyName("users")] List<UsersFollowingsResponseUsers> Users,
		[property: JsonPropertyName("users_total")] long UsersTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersFollowingsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersFollowingsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersFollowingsResponseUsers> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersFollowingsResponseUsers>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersFollowingsResponseUsers.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("users_total"u8))
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
			return new UsersFollowingsResponse(v0, v1, v2);
		}
	}

public sealed record UsersFollowingsResponseUsersLinks(
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
	public static UsersFollowingsResponseUsersLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowingsResponseUsersLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersFollowingsResponseUsersLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record UsersFollowingsResponseUsersPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFollowingsResponseUsersPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowingsResponseUsersPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersFollowingsResponseUsersPermissions(v0, v1, v2, v3);
	}
}

public sealed record UsersFollowingsResponseUsersCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("allowSelfUnban")] List<JsonElement> AllowSelfUnban,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("github")] string Github,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("lztAwardUserTrophy")] string LztAwardUserTrophy,
	[property: JsonPropertyName("lztCuratorNodeTitle")] string LztCuratorNodeTitle,
	[property: JsonPropertyName("lztCuratorNodeTitleEn")] string LztCuratorNodeTitleEn,
	[property: JsonPropertyName("lztDeposit")] string LztDeposit,
	[property: JsonPropertyName("lztInnovation20Link")] string LztInnovation20Link,
	[property: JsonPropertyName("lztInnovation30Link")] string LztInnovation30Link,
	[property: JsonPropertyName("lztInnovationLink")] string LztInnovationLink,
	[property: JsonPropertyName("lztLikesIncreasing")] string LztLikesIncreasing,
	[property: JsonPropertyName("lztLikesZeroing")] string LztLikesZeroing,
	[property: JsonPropertyName("lztSympathyIncreasing")] string LztSympathyIncreasing,
	[property: JsonPropertyName("lztSympathyZeroing")] string LztSympathyZeroing,
	[property: JsonPropertyName("maecenasValue")] string MaecenasValue,
	[property: JsonPropertyName("scamURL")] string ScamURL,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("telegram")] string Telegram,
	[property: JsonPropertyName("vk")] string Vk
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFollowingsResponseUsersCustomFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowingsResponseUsersCustomFields ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		List<JsonElement> v1 = null!;
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
		string v19 = null!;
		string v20 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("_4"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("allowSelfUnban"u8))
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
					v1 = __lst;
				}
			}
			else if (reader.ValueTextEquals("discord"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("github"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("jabber"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztAwardUserTrophy"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztCuratorNodeTitle"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztCuratorNodeTitleEn"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztDeposit"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztInnovation20Link"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztInnovation30Link"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztInnovationLink"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztLikesIncreasing"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztLikesZeroing"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztSympathyIncreasing"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztSympathyZeroing"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("maecenasValue"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("scamURL"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("steam"u8))
			{
				reader.Read();
				v18 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("vk"u8))
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
		return new UsersFollowingsResponseUsersCustomFields(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
	}
}

public sealed record UsersFollowingsResponseUsers(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("follow_date")] long FollowDate,
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
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("user_is_valid")] bool UserIsValid,
	[property: JsonPropertyName("user_is_verified")] bool UserIsVerified,
	[property: JsonPropertyName("user_is_followed")] bool UserIsFollowed,
	[property: JsonPropertyName("user_last_seen_date")] long UserLastSeenDate,
	[property: JsonPropertyName("user_following_count")] long UserFollowingCount,
	[property: JsonPropertyName("user_followers_count")] long UserFollowersCount,
	[property: JsonPropertyName("links")] UsersFollowingsResponseUsersLinks Links,
	[property: JsonPropertyName("permissions")] UsersFollowingsResponseUsersPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("custom_fields")] UsersFollowingsResponseUsersCustomFields CustomFields
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersFollowingsResponseUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersFollowingsResponseUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		string v4 = null!;
		string v5 = null!;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		long v9 = default;
		long v10 = default;
		long v11 = default;
		string v12 = null!;
		string v13 = null!;
		long v14 = default;
		string v15 = null!;
		bool v16 = default;
		bool v17 = default;
		bool v18 = default;
		long v19 = default;
		long v20 = default;
		long v21 = default;
		UsersFollowingsResponseUsersLinks v22 = null!;
		UsersFollowingsResponseUsersPermissions v23 = null!;
		bool v24 = default;
		bool v25 = default;
		long v26 = default;
		UsersFollowingsResponseUsersCustomFields v27 = null!;
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
			else if (reader.ValueTextEquals("follow_date"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_message_count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_register_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_like_count"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_like2_count"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("contest_count"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("trophy_count"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_is_valid"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_verified"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_followed"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_last_seen_date"u8))
			{
				reader.Read();
				v19 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_following_count"u8))
			{
				reader.Read();
				v20 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_followers_count"u8))
			{
				reader.Read();
				v21 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v22 = reader.TokenType == JsonTokenType.Null ? null! : UsersFollowingsResponseUsersLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v23 = reader.TokenType == JsonTokenType.Null ? null! : UsersFollowingsResponseUsersPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v24 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_visitor"u8))
			{
				reader.Read();
				v25 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v26 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_fields"u8))
			{
				reader.Read();
				v27 = reader.TokenType == JsonTokenType.Null ? null! : UsersFollowingsResponseUsersCustomFields.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersFollowingsResponseUsers(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27);
	}
}

	public sealed record UsersLikesParams
	{
		/// <summary>
		/// Filter by forum section.
		/// </summary>
		[JsonPropertyName("node_id")]
		public long? NodeId { get; init; }
		/// <summary>
		/// Like type.
		/// </summary>
		[JsonPropertyName("like_type")]
		public LikeType? LikeType { get; init; }
		/// <summary>
		/// Likes type.
		/// <para/>
		/// Default: <c>gotten</c>
		/// </summary>
		[JsonPropertyName("type")]
		public UsersType? Type { get; init; } = UsersType.Gotten;
		/// <summary>
		/// Page number.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Content type.
		/// <para/>
		/// Default: <c>post</c>
		/// </summary>
		[JsonPropertyName("content_type")]
		public ContentType? ContentType { get; init; }
		/// <summary>
		/// Get only likes from specified user.
		/// </summary>
		[JsonPropertyName("search_user_id")]
		public long? SearchUserId { get; init; }
		/// <summary>
		/// Show weekly statistics.
		/// </summary>
		[JsonPropertyName("stats")]
		public bool? Stats { get; init; }
	}

	public sealed record UsersLikesResponse(
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("contentType")] string ContentType,
		[property: JsonPropertyName("totalLikes")] long TotalLikes,
		[property: JsonPropertyName("likes")] UsersLikesResponseLikes Likes,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersLikesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersLikesResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			long v1 = default;
			string v2 = null!;
			long v3 = default;
			UsersLikesResponseLikes v4 = null!;
			Resp_SystemInfo v5 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("page"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("perPage"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("contentType"u8))
				{
					reader.Read();
					v2 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("totalLikes"u8))
				{
					reader.Read();
					v3 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("likes"u8))
				{
					reader.Read();
					v4 = reader.TokenType == JsonTokenType.Null ? null! : UsersLikesResponseLikes.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v5 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new UsersLikesResponse(v0, v1, v2, v3, v4, v5);
		}
	}

public sealed record UsersLikesResponseLikes1234567890(
	[property: JsonPropertyName("like_id")] long LikeId,
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
	[property: JsonPropertyName("like_user_id")] long LikeUserId,
	[property: JsonPropertyName("like_date")] long LikeDate,
	[property: JsonPropertyName("content_user_id")] long ContentUserId,
	[property: JsonPropertyName("content_state")] string ContentState,
	[property: JsonPropertyName("user")] Resp_UserModel User,
	[property: JsonPropertyName("actionUser")] Resp_UserModel ActionUser,
	[property: JsonPropertyName("messageHtml")] string MessageHtml,
	[property: JsonPropertyName("post_date")] long PostDate
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersLikesResponseLikes1234567890 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersLikesResponseLikes1234567890 ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		string v6 = null!;
		Resp_UserModel v7 = null!;
		Resp_UserModel v8 = null!;
		string v9 = null!;
		long v10 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("like_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("content_type"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("content_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_user_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_date"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("content_user_id"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("content_state"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("actionUser"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("messageHtml"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_date"u8))
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
		return new UsersLikesResponseLikes1234567890(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record UsersLikesResponseLikes(
	[property: JsonPropertyName("1234567890")] UsersLikesResponseLikes1234567890 _1234567890
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersLikesResponseLikes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersLikesResponseLikes ReadFromReader(ref Utf8JsonReader reader)
	{
		UsersLikesResponseLikes1234567890 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1234567890"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : UsersLikesResponseLikes1234567890.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersLikesResponseLikes(v0);
	}
}

	public sealed record UsersIgnoredParams
	{
		/// <summary>
		/// If included in the request, only the user count is returned as <b>users_total</b>.
		/// </summary>
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
	}

	public sealed record UsersIgnoredResponse(
		[property: JsonPropertyName("users")] List<UsersIgnoredResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersIgnoredResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersIgnoredResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersIgnoredResponseUsers> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersIgnoredResponseUsers>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersIgnoredResponseUsers.ReadFromReader(ref reader);
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
			return new UsersIgnoredResponse(v0, v1);
		}
	}

public sealed record UsersIgnoredResponseUsersCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("scamURL")] JsonElement ScamURL,
	[property: JsonPropertyName("lztLikesZeroing")] JsonElement LztLikesZeroing,
	[property: JsonPropertyName("lztLikesIncreasing")] JsonElement LztLikesIncreasing,
	[property: JsonPropertyName("lztSympathyZeroing")] JsonElement LztSympathyZeroing,
	[property: JsonPropertyName("lztSympathyIncreasing")] JsonElement LztSympathyIncreasing,
	[property: JsonPropertyName("telegram")] JsonElement Telegram,
	[property: JsonPropertyName("vk")] string Vk,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("matrix")] JsonElement Matrix,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("github")] string Github
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersIgnoredResponseUsersCustomFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersIgnoredResponseUsersCustomFields ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		JsonElement v1 = default;
		JsonElement v2 = default;
		JsonElement v3 = default;
		JsonElement v4 = default;
		JsonElement v5 = default;
		JsonElement v6 = default;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		JsonElement v10 = default;
		string v11 = null!;
		string v12 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("_4"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("scamURL"u8))
			{
				reader.Read();
				v1 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztLikesZeroing"u8))
			{
				reader.Read();
				v2 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztLikesIncreasing"u8))
			{
				reader.Read();
				v3 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztSympathyZeroing"u8))
			{
				reader.Read();
				v4 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("lztSympathyIncreasing"u8))
			{
				reader.Read();
				v5 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("telegram"u8))
			{
				reader.Read();
				v6 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("vk"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("discord"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("steam"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("matrix"u8))
			{
				reader.Read();
				v10 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("jabber"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("github"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersIgnoredResponseUsersCustomFields(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12);
	}
}

public sealed record UsersIgnoredResponseUsersIgnoredInfo(
	[property: JsonPropertyName("ignore_content")] long IgnoreContent,
	[property: JsonPropertyName("ignore_conversations")] long IgnoreConversations,
	[property: JsonPropertyName("restrict_view_profile")] long RestrictViewProfile
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersIgnoredResponseUsersIgnoredInfo ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersIgnoredResponseUsersIgnoredInfo ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("ignore_content"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("ignore_conversations"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restrict_view_profile"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersIgnoredResponseUsersIgnoredInfo(v0, v1, v2);
	}
}

public sealed record UsersIgnoredResponseUsersRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersIgnoredResponseUsersRenderedAvatars ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersIgnoredResponseUsersRenderedAvatars ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersIgnoredResponseUsersRenderedAvatars(v0, v1, v2);
	}
}

public sealed record UsersIgnoredResponseUsersRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] UsersIgnoredResponseUsersRenderedAvatars Avatars,
	[property: JsonPropertyName("backgrounds")] List<JsonElement> Backgrounds,
	[property: JsonPropertyName("link")] string Link
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersIgnoredResponseUsersRendered ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersIgnoredResponseUsersRendered ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		UsersIgnoredResponseUsersRenderedAvatars v1 = null!;
		List<JsonElement> v2 = null!;
		string v3 = null!;
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
				v1 = reader.TokenType == JsonTokenType.Null ? null! : UsersIgnoredResponseUsersRenderedAvatars.ReadFromReader(ref reader);
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersIgnoredResponseUsersRendered(v0, v1, v2, v3);
	}
}

public sealed record UsersIgnoredResponseUsers(
	[property: JsonPropertyName("can_edit")] bool CanEdit,
	[property: JsonPropertyName("can_follow")] bool CanFollow,
	[property: JsonPropertyName("can_ignore")] bool CanIgnore,
	[property: JsonPropertyName("can_post_profile")] bool CanPostProfile,
	[property: JsonPropertyName("can_view_profile")] bool CanViewProfile,
	[property: JsonPropertyName("can_view_profile_posts")] bool CanViewProfilePosts,
	[property: JsonPropertyName("can_warn")] bool CanWarn,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("conv_welcome_message")] string ConvWelcomeMessage,
	[property: JsonPropertyName("convertedDeposit")] long ConvertedDeposit,
	[property: JsonPropertyName("custom_fields")] UsersIgnoredResponseUsersCustomFields CustomFields,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("homepage")] string Homepage,
	[property: JsonPropertyName("ignored_info")] UsersIgnoredResponseUsersIgnoredInfo IgnoredInfo,
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
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] UsersIgnoredResponseUsersRendered Rendered,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("view_url")] string ViewUrl,
	[property: JsonPropertyName("warning_points")] long WarningPoints
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersIgnoredResponseUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersIgnoredResponseUsers ReadFromReader(ref Utf8JsonReader reader)
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
		long v9 = default;
		UsersIgnoredResponseUsersCustomFields v10 = null!;
		long v11 = default;
		string v12 = null!;
		UsersIgnoredResponseUsersIgnoredInfo v13 = null!;
		bool v14 = default;
		bool v15 = default;
		bool v16 = default;
		bool v17 = default;
		bool v18 = default;
		bool v19 = default;
		long v20 = default;
		long v21 = default;
		long v22 = default;
		string v23 = null!;
		long v24 = default;
		long v25 = default;
		UsersIgnoredResponseUsersRendered v26 = null!;
		string v27 = null!;
		long v28 = default;
		long v29 = default;
		string v30 = null!;
		string v31 = null!;
		string v32 = null!;
		long v33 = default;
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
			else if (reader.ValueTextEquals("conv_welcome_message"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("convertedDeposit"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_fields"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : UsersIgnoredResponseUsersCustomFields.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("deposit"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("homepage"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("ignored_info"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : UsersIgnoredResponseUsersIgnoredInfo.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("is_admin"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_followed"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_ignored"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_moderator"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_staff"u8))
			{
				reader.Read();
				v19 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v20 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like2_count"u8))
			{
				reader.Read();
				v21 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_count"u8))
			{
				reader.Read();
				v22 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("location"u8))
			{
				reader.Read();
				v23 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("message_count"u8))
			{
				reader.Read();
				v24 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("register_date"u8))
			{
				reader.Read();
				v25 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rendered"u8))
			{
				reader.Read();
				v26 = reader.TokenType == JsonTokenType.Null ? null! : UsersIgnoredResponseUsersRendered.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v27 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("trophy_points"u8))
			{
				reader.Read();
				v28 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v29 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v30 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v31 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("view_url"u8))
			{
				reader.Read();
				v32 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("warning_points"u8))
			{
				reader.Read();
				v33 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersIgnoredResponseUsers(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33);
	}
}

	public sealed record UsersIgnoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersIgnoreResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersIgnoreResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersIgnoreResponse(v0, v1, v2);
		}
	}

	public sealed record UsersIgnoreEditParams
	{
		/// <summary>
		/// Ignore user's conversations.
		/// </summary>
		[JsonPropertyName("ignore_conversations")]
		public bool? IgnoreConversations { get; init; }
		/// <summary>
		/// Ignore user's content.
		/// </summary>
		[JsonPropertyName("ignore_content")]
		public bool? IgnoreContent { get; init; }
		/// <summary>
		/// Restrict user from viewing your profile.
		/// </summary>
		[JsonPropertyName("restrict_view_profile")]
		public bool? RestrictViewProfile { get; init; }
	}

	public sealed record UsersIgnoreEditResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersIgnoreEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersIgnoreEditResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersIgnoreEditResponse(v0, v1, v2);
		}
	}

	public sealed record UsersUnignoreResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersUnignoreResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersUnignoreResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersUnignoreResponse(v0, v1, v2);
		}
	}

	public sealed record UsersContentsParams
	{
		/// <summary>
		/// Page number of contents.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of contents in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record UsersContentsResponse(
		[property: JsonPropertyName("data")] List<UsersContentsResponseData> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("user")] Resp_UserModel User,
		[property: JsonPropertyName("links")] UsersContentsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersContentsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersContentsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersContentsResponseData> v0 = null!;
			long v1 = default;
			Resp_UserModel v2 = null!;
			UsersContentsResponseLinks v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersContentsResponseData>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersContentsResponseData.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("user"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : UsersContentsResponseLinks.ReadFromReader(ref reader);
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
			return new UsersContentsResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record UsersContentsResponseDataLikeUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersContentsResponseDataLikeUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseDataLikeUsers ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersContentsResponseDataLikeUsers(v0, v1, v2, v3, v4);
	}
}

public sealed record UsersContentsResponseDataLinks(
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
	public static UsersContentsResponseDataLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseDataLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersContentsResponseDataLinks(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record UsersContentsResponseDataPermissions(
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
	public static UsersContentsResponseDataPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseDataPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersContentsResponseDataPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record UsersContentsResponseDataThreadLinks(
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
	public static UsersContentsResponseDataThreadLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseDataThreadLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersContentsResponseDataThreadLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
	}
}

public sealed record UsersContentsResponseDataThreadPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersContentsResponseDataThreadPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseDataThreadPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersContentsResponseDataThreadPermissions(v0, v1, v2, v3, v4);
	}
}

public sealed record UsersContentsResponseDataThread(
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
	[property: JsonPropertyName("thread_prefixes")] List<JsonElement> ThreadPrefixes,
	[property: JsonPropertyName("thread_tags")] List<JsonElement> ThreadTags,
	[property: JsonPropertyName("links")] UsersContentsResponseDataThreadLinks Links,
	[property: JsonPropertyName("permissions")] UsersContentsResponseDataThreadPermissions Permissions
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersContentsResponseDataThread ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseDataThread ReadFromReader(ref Utf8JsonReader reader)
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
		List<JsonElement> v15 = null!;
		List<JsonElement> v16 = null!;
		UsersContentsResponseDataThreadLinks v17 = null!;
		UsersContentsResponseDataThreadPermissions v18 = null!;
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
			else if (reader.ValueTextEquals("thread_is_followed"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
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
				v17 = reader.TokenType == JsonTokenType.Null ? null! : UsersContentsResponseDataThreadLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v18 = reader.TokenType == JsonTokenType.Null ? null! : UsersContentsResponseDataThreadPermissions.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersContentsResponseDataThread(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
	}
}

public sealed record UsersContentsResponseData(
	[property: JsonPropertyName("content_type")] string ContentType,
	[property: JsonPropertyName("content_id")] long ContentId,
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
	[property: JsonPropertyName("like_users")] List<UsersContentsResponseDataLikeUsers> LikeUsers,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("post_is_published")] bool PostIsPublished,
	[property: JsonPropertyName("post_is_deleted")] bool PostIsDeleted,
	[property: JsonPropertyName("post_update_date")] long PostUpdateDate,
	[property: JsonPropertyName("post_is_first_post")] bool PostIsFirstPost,
	[property: JsonPropertyName("links")] UsersContentsResponseDataLinks Links,
	[property: JsonPropertyName("permissions")] UsersContentsResponseDataPermissions Permissions,
	[property: JsonPropertyName("thread")] UsersContentsResponseDataThread Thread
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersContentsResponseData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseData ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		string v5 = null!;
		string v6 = null!;
		long v7 = default;
		string v8 = null!;
		string v9 = null!;
		string v10 = null!;
		string v11 = null!;
		string v12 = null!;
		string v13 = null!;
		long v14 = default;
		long v15 = default;
		List<UsersContentsResponseDataLikeUsers> v16 = null!;
		bool v17 = default;
		bool v18 = default;
		bool v19 = default;
		long v20 = default;
		bool v21 = default;
		UsersContentsResponseDataLinks v22 = null!;
		UsersContentsResponseDataPermissions v23 = null!;
		UsersContentsResponseDataThread v24 = null!;
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
			else if (reader.ValueTextEquals("post_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poster_user_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poster_username"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poster_username_html"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_create_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_body"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_body_html"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_body_plain_text"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature_html"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("signature_plain_text"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("post_like_count"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_attachment_count"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_users"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<UsersContentsResponseDataLikeUsers>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = UsersContentsResponseDataLikeUsers.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v16 = __lst;
				}
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_published"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_is_deleted"u8))
			{
				reader.Read();
				v19 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("post_update_date"u8))
			{
				reader.Read();
				v20 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("post_is_first_post"u8))
			{
				reader.Read();
				v21 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v22 = reader.TokenType == JsonTokenType.Null ? null! : UsersContentsResponseDataLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v23 = reader.TokenType == JsonTokenType.Null ? null! : UsersContentsResponseDataPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("thread"u8))
			{
				reader.Read();
				v24 = reader.TokenType == JsonTokenType.Null ? null! : UsersContentsResponseDataThread.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UsersContentsResponseData(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24);
	}
}

public sealed record UsersContentsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersContentsResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersContentsResponseLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new UsersContentsResponseLinks(v0, v1, v2);
	}
}

	public sealed record UsersTrophiesResponse(
		[property: JsonPropertyName("trophies")] List<UsersTrophiesResponseTrophies> Trophies,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersTrophiesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersTrophiesResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersTrophiesResponseTrophies> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("trophies"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersTrophiesResponseTrophies>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersTrophiesResponseTrophies.ReadFromReader(ref reader);
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
			return new UsersTrophiesResponse(v0, v1);
		}
	}

public sealed record UsersTrophiesResponseTrophies(
	[property: JsonPropertyName("trophy_id")] long TrophyId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("trophy_url")] string TrophyUrl
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersTrophiesResponseTrophies ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersTrophiesResponseTrophies ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("trophy_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
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
			else if (reader.ValueTextEquals("trophy_url"u8))
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
		return new UsersTrophiesResponseTrophies(v0, v1, v2, v3);
	}
}

	public sealed record UsersSecretAnswerTypesResponse(
		[property: JsonPropertyName("data")] List<UsersSecretAnswerTypesResponseData> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersSecretAnswerTypesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersSecretAnswerTypesResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<UsersSecretAnswerTypesResponseData> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UsersSecretAnswerTypesResponseData>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UsersSecretAnswerTypesResponseData.ReadFromReader(ref reader);
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
			return new UsersSecretAnswerTypesResponse(v0, v1);
		}
	}

public sealed record UsersSecretAnswerTypesResponseData(
	[property: JsonPropertyName("sa_id")] long SaId,
	[property: JsonPropertyName("renderedPhrase")] string RenderedPhrase
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UsersSecretAnswerTypesResponseData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UsersSecretAnswerTypesResponseData ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("sa_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("renderedPhrase"u8))
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
		return new UsersSecretAnswerTypesResponseData(v0, v1);
	}
}

	public sealed record UsersSaResetResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("waiting_time")] string WaitingTime,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersSaResetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersSaResetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			bool v0 = default;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("success"u8))
				{
					reader.Read();
					v0 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("waiting_time"u8))
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
			return new UsersSaResetResponse(v0, v1, v2);
		}
	}

	public sealed record UsersSaCancelResetResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UsersSaCancelResetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UsersSaCancelResetResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new UsersSaCancelResetResponse(v0, v1, v2);
		}
	}

}
