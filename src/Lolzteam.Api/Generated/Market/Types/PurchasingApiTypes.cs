// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class PurchasingApiTypes
{
	public sealed record PurchasingFastBuyBody
	{
		[JsonPropertyName("price")]
		public double? Price { get; init; }
		[JsonPropertyName("balance_id")]
		public long? BalanceId { get; init; }
	}

	public sealed record PurchasingFastBuyResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] PurchasingFastBuyResponseItem Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PurchasingFastBuyResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PurchasingFastBuyResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			PurchasingFastBuyResponseItem v1 = null!;
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
					v1 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItem.ReadFromReader(ref reader);
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
			return new PurchasingFastBuyResponse(v0, v1, v2);
		}
	}

public sealed record PurchasingFastBuyResponseItemGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] long EndDate,
	[property: JsonPropertyName("active")] bool Active,
	[property: JsonPropertyName("cancelled")] bool Cancelled,
	[property: JsonPropertyName("remainingTime")] long RemainingTime,
	[property: JsonPropertyName("remainingTimePhrase")] string RemainingTimePhrase
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemGuarantee ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemGuarantee ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		bool v4 = default;
		bool v5 = default;
		long v6 = default;
		string v7 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("duration"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("class"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("durationPhrase"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("endDate"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("active"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("cancelled"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("remainingTime"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("remainingTimePhrase"u8))
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
		return new PurchasingFastBuyResponseItemGuarantee(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record PurchasingFastBuyResponseItemLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] JsonElement EncodedOldPassword
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemLoginData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemLoginData ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		JsonElement v6 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("raw"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedRaw"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("login"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("password"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedPassword"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("oldPassword"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedOldPassword"u8))
			{
				reader.Read();
				v6 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PurchasingFastBuyResponseItemLoginData(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record PurchasingFastBuyResponseItemEmailLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] string EncodedOldPassword
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemEmailLoginData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemEmailLoginData ReadFromReader(ref Utf8JsonReader reader)
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

			if (reader.ValueTextEquals("raw"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedRaw"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("login"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("password"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedPassword"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("oldPassword"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedOldPassword"u8))
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
		return new PurchasingFastBuyResponseItemEmailLoginData(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record PurchasingFastBuyResponseItemBuyer(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("visitorIsBuyer")] bool VisitorIsBuyer,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("user_group_id")] long UserGroupId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemBuyer ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemBuyer ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		bool v2 = default;
		string v3 = null!;
		long v4 = default;
		long v5 = default;
		string v6 = null!;
		long v7 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("operation_date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("visitorIsBuyer"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PurchasingFastBuyResponseItemBuyer(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record PurchasingFastBuyResponseItemAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemAccountLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemAccountLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("link"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("text"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("iconClass"u8))
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
		return new PurchasingFastBuyResponseItemAccountLinks(v0, v1, v2);
	}
}

public sealed record PurchasingFastBuyResponseItemTags1(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemTags1 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemTags1 ReadFromReader(ref Utf8JsonReader reader)
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
		return new PurchasingFastBuyResponseItemTags1(v0, v1, v2, v3, v4);
	}
}

public sealed record PurchasingFastBuyResponseItemTags(
	[property: JsonPropertyName("1")] PurchasingFastBuyResponseItemTags1 _1
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemTags ReadFromReader(ref Utf8JsonReader reader)
	{
		PurchasingFastBuyResponseItemTags1 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemTags1.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PurchasingFastBuyResponseItemTags(v0);
	}
}

public sealed record PurchasingFastBuyResponseItemExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemExtraPrices ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemExtraPrices ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("currency"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("price"u8))
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
		return new PurchasingFastBuyResponseItemExtraPrices(v0, v1);
	}
}

public sealed record PurchasingFastBuyResponseItemBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemBumpSettings ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemBumpSettings ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		JsonElement v2 = default;
		JsonElement v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("canBumpItem"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canBumpItemGlobally"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("shortErrorPhrase"u8))
			{
				reader.Read();
				v2 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("errorPhrase"u8))
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
		return new PurchasingFastBuyResponseItemBumpSettings(v0, v1, v2, v3);
	}
}

public sealed record PurchasingFastBuyResponseItemSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("restore_percents")] long RestorePercents,
	[property: JsonPropertyName("isOnline")] bool IsOnline
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItemSeller ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItemSeller ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		string v8 = null!;
		long v9 = default;
		bool v10 = default;
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
			else if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("joined_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("sold_items_count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("active_items_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_data"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("restore_percents"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("isOnline"u8))
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
		return new PurchasingFastBuyResponseItemSeller(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record PurchasingFastBuyResponseItem(
	[property: JsonPropertyName("item_id")] long ItemId,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("published_date")] long PublishedDate,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("price")] long Price,
	[property: JsonPropertyName("update_stat_date")] long UpdateStatDate,
	[property: JsonPropertyName("refreshed_date")] long RefreshedDate,
	[property: JsonPropertyName("edit_date")] long EditDate,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("temp_email")] string TempEmail,
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("information")] string Information,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("information_en")] string InformationEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("user_allow_ask_discount")] long UserAllowAskDiscount,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("buyer_avatar_date")] long BuyerAvatarDate,
	[property: JsonPropertyName("buyer_user_group_id")] long BuyerUserGroupId,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] PurchasingFastBuyResponseItemGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("loginData")] PurchasingFastBuyResponseItemLoginData LoginData,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("emailLoginData")] PurchasingFastBuyResponseItemEmailLoginData EmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("getEmailCodeDisplayLogin")] string GetEmailCodeDisplayLogin,
	[property: JsonPropertyName("buyer")] PurchasingFastBuyResponseItemBuyer Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("displayConvertedBalance")] bool DisplayConvertedBalance,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<PurchasingFastBuyResponseItemAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] PurchasingFastBuyResponseItemTags Tags,
	[property: JsonPropertyName("customFields")] List<JsonElement> CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<PurchasingFastBuyResponseItemExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] PurchasingFastBuyResponseItemBumpSettings BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] PurchasingFastBuyResponseItemSeller Seller
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingFastBuyResponseItem ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingFastBuyResponseItem ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		string v4 = null!;
		string v5 = null!;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		long v9 = default;
		string v10 = null!;
		string v11 = null!;
		long v12 = default;
		long v13 = default;
		string v14 = null!;
		string v15 = null!;
		long v16 = default;
		long v17 = default;
		long v18 = default;
		string v19 = null!;
		string v20 = null!;
		string v21 = null!;
		string v22 = null!;
		string v23 = null!;
		string v24 = null!;
		string v25 = null!;
		long v26 = default;
		long v27 = default;
		string v28 = null!;
		string v29 = null!;
		long v30 = default;
		long v31 = default;
		long v32 = default;
		PurchasingFastBuyResponseItemGuarantee v33 = null!;
		bool v34 = default;
		bool v35 = default;
		bool v36 = default;
		PurchasingFastBuyResponseItemLoginData v37 = null!;
		bool v38 = default;
		PurchasingFastBuyResponseItemEmailLoginData v39 = null!;
		bool v40 = default;
		string v41 = null!;
		PurchasingFastBuyResponseItemBuyer v42 = null!;
		bool v43 = default;
		long v44 = default;
		long v45 = default;
		long v46 = default;
		string v47 = null!;
		bool v48 = default;
		bool v49 = default;
		long v50 = default;
		bool v51 = default;
		bool v52 = default;
		List<PurchasingFastBuyResponseItemAccountLinks> v53 = null!;
		string v54 = null!;
		string v55 = null!;
		bool v56 = default;
		string v57 = null!;
		bool v58 = default;
		bool v59 = default;
		PurchasingFastBuyResponseItemTags v60 = null!;
		List<JsonElement> v61 = null!;
		List<JsonElement> v62 = null!;
		bool v63 = default;
		bool v64 = default;
		bool v65 = default;
		long v66 = default;
		List<PurchasingFastBuyResponseItemExtraPrices> v67 = null!;
		bool v68 = default;
		PurchasingFastBuyResponseItemBumpSettings v69 = null!;
		bool v70 = default;
		bool v71 = default;
		string v72 = null!;
		string v73 = null!;
		string v74 = null!;
		string v75 = null!;
		PurchasingFastBuyResponseItemSeller v76 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("published_date"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("price"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("update_stat_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("refreshed_date"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("edit_date"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("login"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("temp_email"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("view_count"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_sticky"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("information"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_origin"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("extended_guarantee"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("nsb"u8))
			{
				reader.Read();
				v17 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("allow_ask_discount"u8))
			{
				reader.Read();
				v18 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title_en"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description_en"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("information_en"u8))
			{
				reader.Read();
				v21 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_type"u8))
			{
				reader.Read();
				v22 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_provider"u8))
			{
				reader.Read();
				v23 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_domain"u8))
			{
				reader.Read();
				v24 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("resale_item_origin"u8))
			{
				reader.Read();
				v25 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_allow_ask_discount"u8))
			{
				reader.Read();
				v26 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("max_discount_percent"u8))
			{
				reader.Read();
				v27 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("market_custom_title"u8))
			{
				reader.Read();
				v28 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("feedback_data"u8))
			{
				reader.Read();
				v29 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("buyer_avatar_date"u8))
			{
				reader.Read();
				v30 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("buyer_user_group_id"u8))
			{
				reader.Read();
				v31 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("priceWithSellerFee"u8))
			{
				reader.Read();
				v32 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("guarantee"u8))
			{
				reader.Read();
				v33 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemGuarantee.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canViewLoginData"u8))
			{
				reader.Read();
				v34 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canUpdateItemStats"u8))
			{
				reader.Read();
				v35 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canReportItem"u8))
			{
				reader.Read();
				v36 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("loginData"u8))
			{
				reader.Read();
				v37 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemLoginData.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canViewEmailLoginData"u8))
			{
				reader.Read();
				v38 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("emailLoginData"u8))
			{
				reader.Read();
				v39 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemEmailLoginData.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("showGetEmailCodeButton"u8))
			{
				reader.Read();
				v40 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("getEmailCodeDisplayLogin"u8))
			{
				reader.Read();
				v41 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("buyer"u8))
			{
				reader.Read();
				v42 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemBuyer.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("isPersonalAccount"u8))
			{
				reader.Read();
				v43 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("sold_items_category_count"u8))
			{
				reader.Read();
				v44 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_items_category_count"u8))
			{
				reader.Read();
				v45 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rub_price"u8))
			{
				reader.Read();
				v46 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("price_currency"u8))
			{
				reader.Read();
				v47 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canValidateAccount"u8))
			{
				reader.Read();
				v48 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canResellItemAfterPurchase"u8))
			{
				reader.Read();
				v49 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("account_last_activity"u8))
			{
				reader.Read();
				v50 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("displayConvertedBalance"u8))
			{
				reader.Read();
				v51 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewAccountLink"u8))
			{
				reader.Read();
				v52 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("accountLinks"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<PurchasingFastBuyResponseItemAccountLinks>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = PurchasingFastBuyResponseItemAccountLinks.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v53 = __lst;
				}
			}
			else if (reader.ValueTextEquals("accountLink"u8))
			{
				reader.Read();
				v54 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("emailLoginUrl"u8))
			{
				reader.Read();
				v55 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canChangePassword"u8))
			{
				reader.Read();
				v56 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("itemOriginPhrase"u8))
			{
				reader.Read();
				v57 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("visitorIsAuthor"u8))
			{
				reader.Read();
				v58 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canAskDiscount"u8))
			{
				reader.Read();
				v59 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tags"u8))
			{
				reader.Read();
				v60 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemTags.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("customFields"u8))
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
					v61 = __lst;
				}
			}
			else if (reader.ValueTextEquals("externalAuth"u8))
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
					v62 = __lst;
				}
			}
			else if (reader.ValueTextEquals("isTrusted"u8))
			{
				reader.Read();
				v63 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isBirthdayToday"u8))
			{
				reader.Read();
				v64 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isIgnored"u8))
			{
				reader.Read();
				v65 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("deposit"u8))
			{
				reader.Read();
				v66 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("extraPrices"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<PurchasingFastBuyResponseItemExtraPrices>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = PurchasingFastBuyResponseItemExtraPrices.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v67 = __lst;
				}
			}
			else if (reader.ValueTextEquals("canViewAccountLoginAndTempEmail"u8))
			{
				reader.Read();
				v68 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bumpSettings"u8))
			{
				reader.Read();
				v69 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemBumpSettings.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canCheckGuarantee"u8))
			{
				reader.Read();
				v70 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("needToRequireVideoToViewLoginData"u8))
			{
				reader.Read();
				v71 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("descriptionHtml"u8))
			{
				reader.Read();
				v72 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnHtml"u8))
			{
				reader.Read();
				v73 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionPlain"u8))
			{
				reader.Read();
				v74 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnPlain"u8))
			{
				reader.Read();
				v75 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("seller"u8))
			{
				reader.Read();
				v76 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingFastBuyResponseItemSeller.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PurchasingFastBuyResponseItem(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76);
	}
}

	public sealed record PurchasingCheckResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] PurchasingCheckResponseItem Item,
		[property: JsonPropertyName("requireVideoRecording")] bool RequireVideoRecording,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PurchasingCheckResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PurchasingCheckResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			PurchasingCheckResponseItem v1 = null!;
			bool v2 = default;
			Resp_SystemInfo v3 = null!;
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
					v1 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingCheckResponseItem.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("requireVideoRecording"u8))
				{
					reader.Read();
					v2 = reader.GetBoolean();
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
			return new PurchasingCheckResponse(v0, v1, v2, v3);
		}
	}

public sealed record PurchasingCheckResponseItemGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] JsonElement EndDate,
	[property: JsonPropertyName("active")] JsonElement Active,
	[property: JsonPropertyName("cancelled")] JsonElement Cancelled,
	[property: JsonPropertyName("remainingTime")] JsonElement RemainingTime
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingCheckResponseItemGuarantee ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingCheckResponseItemGuarantee ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		JsonElement v3 = default;
		JsonElement v4 = default;
		JsonElement v5 = default;
		JsonElement v6 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("duration"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("class"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("durationPhrase"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("endDate"u8))
			{
				reader.Read();
				v3 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("active"u8))
			{
				reader.Read();
				v4 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("cancelled"u8))
			{
				reader.Read();
				v5 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("remainingTime"u8))
			{
				reader.Read();
				v6 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PurchasingCheckResponseItemGuarantee(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record PurchasingCheckResponseItemAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingCheckResponseItemAccountLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingCheckResponseItemAccountLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("link"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("text"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("iconClass"u8))
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
		return new PurchasingCheckResponseItemAccountLinks(v0, v1, v2);
	}
}

public sealed record PurchasingCheckResponseItemExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingCheckResponseItemExtraPrices ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingCheckResponseItemExtraPrices ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("currency"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("price"u8))
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
		return new PurchasingCheckResponseItemExtraPrices(v0, v1);
	}
}

public sealed record PurchasingCheckResponseItemBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingCheckResponseItemBumpSettings ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingCheckResponseItemBumpSettings ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		JsonElement v2 = default;
		JsonElement v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("canBumpItem"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canBumpItemGlobally"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("shortErrorPhrase"u8))
			{
				reader.Read();
				v2 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("errorPhrase"u8))
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
		return new PurchasingCheckResponseItemBumpSettings(v0, v1, v2, v3);
	}
}

public sealed record PurchasingCheckResponseItemSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents,
	[property: JsonPropertyName("isOnline")] bool IsOnline
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingCheckResponseItemSeller ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingCheckResponseItemSeller ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		string v8 = null!;
		JsonElement v9 = default;
		bool v10 = default;
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
			else if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("joined_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("sold_items_count"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("active_items_count"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_data"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("restore_percents"u8))
			{
				reader.Read();
				v9 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("isOnline"u8))
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
		return new PurchasingCheckResponseItemSeller(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record PurchasingCheckResponseItem(
	[property: JsonPropertyName("item_id")] long ItemId,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("published_date")] long PublishedDate,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("price")] long Price,
	[property: JsonPropertyName("update_stat_date")] long UpdateStatDate,
	[property: JsonPropertyName("refreshed_date")] long RefreshedDate,
	[property: JsonPropertyName("edit_date")] long EditDate,
	[property: JsonPropertyName("view_count")] long ViewCount,
	[property: JsonPropertyName("is_sticky")] long IsSticky,
	[property: JsonPropertyName("item_origin")] string ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string TitleEn,
	[property: JsonPropertyName("description_en")] string DescriptionEn,
	[property: JsonPropertyName("email_type")] string EmailType,
	[property: JsonPropertyName("email_provider")] string EmailProvider,
	[property: JsonPropertyName("item_domain")] string ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string ResaleItemOrigin,
	[property: JsonPropertyName("user_allow_ask_discount")] long UserAllowAskDiscount,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_url")] string CategoryUrl,
	[property: JsonPropertyName("require_temp_email")] long RequireTempEmail,
	[property: JsonPropertyName("available_temp_email")] long AvailableTempEmail,
	[property: JsonPropertyName("check_button_enabled")] long CheckButtonEnabled,
	[property: JsonPropertyName("checker_enabled")] long CheckerEnabled,
	[property: JsonPropertyName("buy_without_validation")] long BuyWithoutValidation,
	[property: JsonPropertyName("has_guarantee")] long HasGuarantee,
	[property: JsonPropertyName("require_video_recording")] long RequireVideoRecording,
	[property: JsonPropertyName("can_be_resold")] long CanBeResold,
	[property: JsonPropertyName("login_type")] string LoginType,
	[property: JsonPropertyName("require_email_login_data")] long RequireEmailLoginData,
	[property: JsonPropertyName("category_prefix_id")] long CategoryPrefixId,
	[property: JsonPropertyName("ask_user_id")] JsonElement AskUserId,
	[property: JsonPropertyName("ask_item_id")] JsonElement AskItemId,
	[property: JsonPropertyName("ask_date")] JsonElement AskDate,
	[property: JsonPropertyName("discount_price")] JsonElement DiscountPrice,
	[property: JsonPropertyName("discount_accepted")] JsonElement DiscountAccepted,
	[property: JsonPropertyName("user_alerted")] JsonElement UserAlerted,
	[property: JsonPropertyName("message")] JsonElement Message,
	[property: JsonPropertyName("min_price")] long MinPrice,
	[property: JsonPropertyName("priceWithSellerFee")] long PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] PurchasingCheckResponseItemGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<PurchasingCheckResponseItemAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("customFields")] List<JsonElement> CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<PurchasingCheckResponseItemExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] PurchasingCheckResponseItemBumpSettings BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] PurchasingCheckResponseItemSeller Seller
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingCheckResponseItem ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingCheckResponseItem ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
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
		long v14 = default;
		long v15 = default;
		string v16 = null!;
		string v17 = null!;
		string v18 = null!;
		string v19 = null!;
		string v20 = null!;
		string v21 = null!;
		long v22 = default;
		long v23 = default;
		string v24 = null!;
		string v25 = null!;
		string v26 = null!;
		string v27 = null!;
		long v28 = default;
		long v29 = default;
		long v30 = default;
		long v31 = default;
		long v32 = default;
		long v33 = default;
		long v34 = default;
		long v35 = default;
		string v36 = null!;
		long v37 = default;
		long v38 = default;
		JsonElement v39 = default;
		JsonElement v40 = default;
		JsonElement v41 = default;
		JsonElement v42 = default;
		JsonElement v43 = default;
		JsonElement v44 = default;
		JsonElement v45 = default;
		long v46 = default;
		long v47 = default;
		PurchasingCheckResponseItemGuarantee v48 = null!;
		bool v49 = default;
		bool v50 = default;
		bool v51 = default;
		bool v52 = default;
		bool v53 = default;
		bool v54 = default;
		long v55 = default;
		string v56 = null!;
		bool v57 = default;
		bool v58 = default;
		bool v59 = default;
		long v60 = default;
		bool v61 = default;
		List<PurchasingCheckResponseItemAccountLinks> v62 = null!;
		string v63 = null!;
		string v64 = null!;
		bool v65 = default;
		string v66 = null!;
		bool v67 = default;
		bool v68 = default;
		List<JsonElement> v69 = null!;
		List<JsonElement> v70 = null!;
		List<JsonElement> v71 = null!;
		bool v72 = default;
		bool v73 = default;
		bool v74 = default;
		long v75 = default;
		List<PurchasingCheckResponseItemExtraPrices> v76 = null!;
		bool v77 = default;
		PurchasingCheckResponseItemBumpSettings v78 = null!;
		bool v79 = default;
		bool v80 = default;
		string v81 = null!;
		string v82 = null!;
		string v83 = null!;
		string v84 = null!;
		PurchasingCheckResponseItemSeller v85 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("published_date"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("price"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("update_stat_date"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("refreshed_date"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("edit_date"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("view_count"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_sticky"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_origin"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("extended_guarantee"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("nsb"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("allow_ask_discount"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title_en"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description_en"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_type"u8))
			{
				reader.Read();
				v18 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_provider"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_domain"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("resale_item_origin"u8))
			{
				reader.Read();
				v21 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_allow_ask_discount"u8))
			{
				reader.Read();
				v22 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("max_discount_percent"u8))
			{
				reader.Read();
				v23 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("market_custom_title"u8))
			{
				reader.Read();
				v24 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("feedback_data"u8))
			{
				reader.Read();
				v25 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_title"u8))
			{
				reader.Read();
				v26 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_url"u8))
			{
				reader.Read();
				v27 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("require_temp_email"u8))
			{
				reader.Read();
				v28 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("available_temp_email"u8))
			{
				reader.Read();
				v29 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("check_button_enabled"u8))
			{
				reader.Read();
				v30 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("checker_enabled"u8))
			{
				reader.Read();
				v31 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("buy_without_validation"u8))
			{
				reader.Read();
				v32 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("has_guarantee"u8))
			{
				reader.Read();
				v33 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("require_video_recording"u8))
			{
				reader.Read();
				v34 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("can_be_resold"u8))
			{
				reader.Read();
				v35 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("login_type"u8))
			{
				reader.Read();
				v36 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("require_email_login_data"u8))
			{
				reader.Read();
				v37 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("category_prefix_id"u8))
			{
				reader.Read();
				v38 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("ask_user_id"u8))
			{
				reader.Read();
				v39 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("ask_item_id"u8))
			{
				reader.Read();
				v40 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("ask_date"u8))
			{
				reader.Read();
				v41 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("discount_price"u8))
			{
				reader.Read();
				v42 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("discount_accepted"u8))
			{
				reader.Read();
				v43 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("user_alerted"u8))
			{
				reader.Read();
				v44 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("message"u8))
			{
				reader.Read();
				v45 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("min_price"u8))
			{
				reader.Read();
				v46 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("priceWithSellerFee"u8))
			{
				reader.Read();
				v47 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("guarantee"u8))
			{
				reader.Read();
				v48 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingCheckResponseItemGuarantee.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canViewLoginData"u8))
			{
				reader.Read();
				v49 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canUpdateItemStats"u8))
			{
				reader.Read();
				v50 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canReportItem"u8))
			{
				reader.Read();
				v51 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewEmailLoginData"u8))
			{
				reader.Read();
				v52 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("showGetEmailCodeButton"u8))
			{
				reader.Read();
				v53 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isPersonalAccount"u8))
			{
				reader.Read();
				v54 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("rub_price"u8))
			{
				reader.Read();
				v55 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("price_currency"u8))
			{
				reader.Read();
				v56 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canValidateAccount"u8))
			{
				reader.Read();
				v57 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canResellItemAfterPurchase"u8))
			{
				reader.Read();
				v58 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isSmallExf"u8))
			{
				reader.Read();
				v59 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("account_last_activity"u8))
			{
				reader.Read();
				v60 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("canViewAccountLink"u8))
			{
				reader.Read();
				v61 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("accountLinks"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<PurchasingCheckResponseItemAccountLinks>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = PurchasingCheckResponseItemAccountLinks.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v62 = __lst;
				}
			}
			else if (reader.ValueTextEquals("accountLink"u8))
			{
				reader.Read();
				v63 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("emailLoginUrl"u8))
			{
				reader.Read();
				v64 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canChangePassword"u8))
			{
				reader.Read();
				v65 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("itemOriginPhrase"u8))
			{
				reader.Read();
				v66 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("visitorIsAuthor"u8))
			{
				reader.Read();
				v67 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canAskDiscount"u8))
			{
				reader.Read();
				v68 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tags"u8))
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
					v69 = __lst;
				}
			}
			else if (reader.ValueTextEquals("customFields"u8))
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
					v70 = __lst;
				}
			}
			else if (reader.ValueTextEquals("externalAuth"u8))
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
					v71 = __lst;
				}
			}
			else if (reader.ValueTextEquals("isTrusted"u8))
			{
				reader.Read();
				v72 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isBirthdayToday"u8))
			{
				reader.Read();
				v73 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isIgnored"u8))
			{
				reader.Read();
				v74 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("deposit"u8))
			{
				reader.Read();
				v75 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("extraPrices"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<PurchasingCheckResponseItemExtraPrices>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = PurchasingCheckResponseItemExtraPrices.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v76 = __lst;
				}
			}
			else if (reader.ValueTextEquals("canViewAccountLoginAndTempEmail"u8))
			{
				reader.Read();
				v77 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bumpSettings"u8))
			{
				reader.Read();
				v78 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingCheckResponseItemBumpSettings.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canCheckGuarantee"u8))
			{
				reader.Read();
				v79 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("needToRequireVideoToViewLoginData"u8))
			{
				reader.Read();
				v80 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("descriptionHtml"u8))
			{
				reader.Read();
				v81 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnHtml"u8))
			{
				reader.Read();
				v82 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionPlain"u8))
			{
				reader.Read();
				v83 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnPlain"u8))
			{
				reader.Read();
				v84 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("seller"u8))
			{
				reader.Read();
				v85 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingCheckResponseItemSeller.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PurchasingCheckResponseItem(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85);
	}
}

	public sealed record PurchasingConfirmBody
	{
		[JsonPropertyName("price")]
		public long? Price { get; init; }
		[JsonPropertyName("balance_id")]
		public long? BalanceId { get; init; }
	}

	public sealed record PurchasingConfirmResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("item")] PurchasingConfirmResponseItem Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PurchasingConfirmResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PurchasingConfirmResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			PurchasingConfirmResponseItem v1 = null!;
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
					v1 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingConfirmResponseItem.ReadFromReader(ref reader);
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
			return new PurchasingConfirmResponse(v0, v1, v2);
		}
	}

public sealed record PurchasingConfirmResponseItemLoginData(
	[property: JsonPropertyName("raw")] string Raw,
	[property: JsonPropertyName("encodedRaw")] string EncodedRaw,
	[property: JsonPropertyName("login")] string Login,
	[property: JsonPropertyName("password")] string Password,
	[property: JsonPropertyName("encodedPassword")] string EncodedPassword,
	[property: JsonPropertyName("oldPassword")] string OldPassword,
	[property: JsonPropertyName("encodedOldPassword")] string EncodedOldPassword,
	[property: JsonPropertyName("adviceToChangePassword")] bool AdviceToChangePassword
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingConfirmResponseItemLoginData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingConfirmResponseItemLoginData ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		bool v7 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("raw"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedRaw"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("login"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("password"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedPassword"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("oldPassword"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("encodedOldPassword"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("adviceToChangePassword"u8))
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
		return new PurchasingConfirmResponseItemLoginData(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record PurchasingConfirmResponseItem(
	[property: JsonPropertyName("loginData")] PurchasingConfirmResponseItemLoginData LoginData
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PurchasingConfirmResponseItem ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PurchasingConfirmResponseItem ReadFromReader(ref Utf8JsonReader reader)
	{
		PurchasingConfirmResponseItemLoginData v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("loginData"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PurchasingConfirmResponseItemLoginData.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PurchasingConfirmResponseItem(v0);
	}
}

	public sealed record PurchasingDiscountRequestBody
	{
		[JsonPropertyName("discount_price")]
		public required double? DiscountPrice { get; init; }
		[JsonPropertyName("message")]
		public string? Message { get; init; }
	}

	public sealed record PurchasingDiscountRequestResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PurchasingDiscountRequestResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PurchasingDiscountRequestResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new PurchasingDiscountRequestResponse(v0, v1, v2);
		}
	}

	public sealed record PurchasingDiscountCancelResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PurchasingDiscountCancelResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PurchasingDiscountCancelResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new PurchasingDiscountCancelResponse(v0, v1, v2);
		}
	}

}
