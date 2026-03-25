// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class AutoPaymentsApiTypes
{
	public sealed record AutoPaymentsListResponse(
		[property: JsonPropertyName("payments")] AutoPaymentsListResponsePayments Payments,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static AutoPaymentsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static AutoPaymentsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			AutoPaymentsListResponsePayments v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("payments"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePayments.ReadFromReader(ref reader);
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
			return new AutoPaymentsListResponse(v0, v1);
		}
	}

public sealed record AutoPaymentsListResponsePayments1234567890ReceiverLinks(
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
	public static AutoPaymentsListResponsePayments1234567890ReceiverLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePayments1234567890ReceiverLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new AutoPaymentsListResponsePayments1234567890ReceiverLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record AutoPaymentsListResponsePayments1234567890ReceiverPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePayments1234567890ReceiverPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePayments1234567890ReceiverPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new AutoPaymentsListResponsePayments1234567890ReceiverPermissions(v0, v1, v2, v3);
	}
}

public sealed record AutoPaymentsListResponsePayments1234567890ReceiverFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired,
	[property: JsonPropertyName("value")] string Value
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePayments1234567890ReceiverFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePayments1234567890ReceiverFields ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		bool v4 = default;
		string v5 = null!;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new AutoPaymentsListResponsePayments1234567890ReceiverFields(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record AutoPaymentsListResponsePayments1234567890Receiver(
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
	[property: JsonPropertyName("links")] AutoPaymentsListResponsePayments1234567890ReceiverLinks Links,
	[property: JsonPropertyName("permissions")] AutoPaymentsListResponsePayments1234567890ReceiverPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("fields")] List<AutoPaymentsListResponsePayments1234567890ReceiverFields> Fields
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePayments1234567890Receiver ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePayments1234567890Receiver ReadFromReader(ref Utf8JsonReader reader)
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
		long v16 = default;
		long v17 = default;
		AutoPaymentsListResponsePayments1234567890ReceiverLinks v18 = null!;
		AutoPaymentsListResponsePayments1234567890ReceiverPermissions v19 = null!;
		bool v20 = default;
		bool v21 = default;
		long v22 = default;
		List<AutoPaymentsListResponsePayments1234567890ReceiverFields> v23 = null!;
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
			else if (reader.ValueTextEquals("user_following_count"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_followers_count"u8))
			{
				reader.Read();
				v17 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v18 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePayments1234567890ReceiverLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePayments1234567890ReceiverPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user_is_ignored"u8))
			{
				reader.Read();
				v20 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_is_visitor"u8))
			{
				reader.Read();
				v21 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v22 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("fields"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<AutoPaymentsListResponsePayments1234567890ReceiverFields>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = AutoPaymentsListResponsePayments1234567890ReceiverFields.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v23 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new AutoPaymentsListResponsePayments1234567890Receiver(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23);
	}
}

public sealed record AutoPaymentsListResponsePayments1234567890(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("receiver_id")] long ReceiverId,
	[property: JsonPropertyName("amount")] string Amount,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("next_payment")] long NextPayment,
	[property: JsonPropertyName("next_alert_date")] long NextAlertDate,
	[property: JsonPropertyName("auto_payment_id")] long AutoPaymentId,
	[property: JsonPropertyName("day")] string Day,
	[property: JsonPropertyName("receiver")] AutoPaymentsListResponsePayments1234567890Receiver Receiver
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePayments1234567890 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePayments1234567890 ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		string v7 = null!;
		AutoPaymentsListResponsePayments1234567890Receiver v8 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("receiver_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("amount"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("next_payment"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next_alert_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("auto_payment_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("day"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("receiver"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePayments1234567890Receiver.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new AutoPaymentsListResponsePayments1234567890(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record AutoPaymentsListResponsePayments(
	[property: JsonPropertyName("1234567890")] AutoPaymentsListResponsePayments1234567890 _1234567890
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePayments ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePayments ReadFromReader(ref Utf8JsonReader reader)
	{
		AutoPaymentsListResponsePayments1234567890 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1234567890"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePayments1234567890.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new AutoPaymentsListResponsePayments(v0);
	}
}

	public sealed record AutoPaymentsCreateBody
	{
		/// <summary>
		/// Secret answer.
		/// </summary>
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		/// <summary>
		/// Username of the payment receiver.
		/// </summary>
		[JsonPropertyName("username_receiver")]
		public required string UsernameReceiver { get; init; }
		/// <summary>
		/// Day of the month for the payment. (Use "0" for the last day of the month)
		/// </summary>
		[JsonPropertyName("day")]
		public required Day Day { get; init; }
		/// <summary>
		/// Amount to be transferred.
		/// </summary>
		[JsonPropertyName("amount")]
		public required double? Amount { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		/// <summary>
		/// Payment description.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }
	}

	public sealed record AutoPaymentsCreateResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("auto_payment_id")] long AutoPaymentId,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static AutoPaymentsCreateResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static AutoPaymentsCreateResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			long v2 = default;
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
				else if (reader.ValueTextEquals("auto_payment_id"u8))
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
			return new AutoPaymentsCreateResponse(v0, v1, v2, v3);
		}
	}

	public sealed record AutoPaymentsDeleteBody
	{
		/// <summary>
		/// Auto payment ID.
		/// </summary>
		[JsonPropertyName("auto_payment_id")]
		public required long? AutoPaymentId { get; init; }
	}

	public sealed record AutoPaymentsDeleteResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static AutoPaymentsDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static AutoPaymentsDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new AutoPaymentsDeleteResponse(v0, v1, v2);
		}
	}

}
