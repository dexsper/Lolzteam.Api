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
		[property: JsonPropertyName("payments")] Dictionary<string, AutoPaymentsListResponsePayments> Payments,
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
			Dictionary<string, AutoPaymentsListResponsePayments> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("payments"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartObject)
					{
						var __dict = new Dictionary<string, AutoPaymentsListResponsePayments>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
						{
							if (reader.TokenType != JsonTokenType.PropertyName) continue;
							var __key = reader.GetString()!;
							reader.Read();
							var __val = AutoPaymentsListResponsePayments.ReadFromReader(ref reader);
							__dict[__key] = __val;
						}
						v0 = __dict;
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
			return new AutoPaymentsListResponse(v0, v1);
		}
	}

public sealed record AutoPaymentsListResponsePaymentsReceiverLinks(
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
	public static AutoPaymentsListResponsePaymentsReceiverLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePaymentsReceiverLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new AutoPaymentsListResponsePaymentsReceiverLinks(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record AutoPaymentsListResponsePaymentsReceiverPermissions(
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("follow")] bool Follow,
	[property: JsonPropertyName("ignore")] bool Ignore,
	[property: JsonPropertyName("profile_post")] bool ProfilePost
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePaymentsReceiverPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePaymentsReceiverPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new AutoPaymentsListResponsePaymentsReceiverPermissions(v0, v1, v2, v3);
	}
}

public sealed record AutoPaymentsListResponsePaymentsReceiverFields(
	[property: JsonPropertyName("id")] string Id,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("position")] string Position,
	[property: JsonPropertyName("is_required")] bool IsRequired,
	[property: JsonPropertyName("value")] string Value
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePaymentsReceiverFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePaymentsReceiverFields ReadFromReader(ref Utf8JsonReader reader)
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
		return new AutoPaymentsListResponsePaymentsReceiverFields(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record AutoPaymentsListResponsePaymentsReceiver(
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
	[property: JsonPropertyName("links")] AutoPaymentsListResponsePaymentsReceiverLinks Links,
	[property: JsonPropertyName("permissions")] AutoPaymentsListResponsePaymentsReceiverPermissions Permissions,
	[property: JsonPropertyName("user_is_ignored")] bool UserIsIgnored,
	[property: JsonPropertyName("user_is_visitor")] bool UserIsVisitor,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("fields")] List<AutoPaymentsListResponsePaymentsReceiverFields> Fields
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static AutoPaymentsListResponsePaymentsReceiver ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static AutoPaymentsListResponsePaymentsReceiver ReadFromReader(ref Utf8JsonReader reader)
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
		AutoPaymentsListResponsePaymentsReceiverLinks v18 = null!;
		AutoPaymentsListResponsePaymentsReceiverPermissions v19 = null!;
		bool v20 = default;
		bool v21 = default;
		long v22 = default;
		List<AutoPaymentsListResponsePaymentsReceiverFields> v23 = null!;
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
				v18 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePaymentsReceiverLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePaymentsReceiverPermissions.ReadFromReader(ref reader);
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
					var __lst = new List<AutoPaymentsListResponsePaymentsReceiverFields>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = AutoPaymentsListResponsePaymentsReceiverFields.ReadFromReader(ref reader);
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
		return new AutoPaymentsListResponsePaymentsReceiver(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23);
	}
}

public sealed record AutoPaymentsListResponsePayments(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("receiver_id")] long ReceiverId,
	[property: JsonPropertyName("amount")] string Amount,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("next_payment")] long NextPayment,
	[property: JsonPropertyName("next_alert_date")] long NextAlertDate,
	[property: JsonPropertyName("auto_payment_id")] long AutoPaymentId,
	[property: JsonPropertyName("day")] string Day,
	[property: JsonPropertyName("receiver")] AutoPaymentsListResponsePaymentsReceiver Receiver
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
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		string v7 = null!;
		AutoPaymentsListResponsePaymentsReceiver v8 = null!;
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
				v8 = reader.TokenType == JsonTokenType.Null ? null! : AutoPaymentsListResponsePaymentsReceiver.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new AutoPaymentsListResponsePayments(v0, v1, v2, v3, v4, v5, v6, v7, v8);
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

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (SecretAnswer is not null)
			{
				writer.WritePropertyName("secret_answer"u8);
				writer.WriteStringValue(SecretAnswer);
			}
			writer.WritePropertyName("username_receiver"u8);
			writer.WriteStringValue(UsernameReceiver);
			writer.WritePropertyName("day"u8);
			writer.WriteNumberValue((long)Day);
			if (Amount is not null)
			{
				writer.WritePropertyName("amount"u8);
				writer.WriteNumberValue(Amount.Value);
			}
			if (Currency is not null)
			{
				writer.WritePropertyName("currency"u8);
				writer.WriteStringValue(Currency.Value.ToJsonValue());
			}
			if (Description is not null)
			{
				writer.WritePropertyName("description"u8);
				writer.WriteStringValue(Description);
			}
			writer.WriteEndObject();
		}
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

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (AutoPaymentId is not null)
			{
				writer.WritePropertyName("auto_payment_id"u8);
				writer.WriteNumberValue(AutoPaymentId.Value);
			}
			writer.WriteEndObject();
		}
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
