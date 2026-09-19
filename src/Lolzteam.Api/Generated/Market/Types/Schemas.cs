// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public sealed record BalanceModel(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("balance_id")] long BalanceId,
	[property: JsonPropertyName("custom_title")] JsonElement CustomTitle,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("user_id")] long UserId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static BalanceModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static BalanceModel ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		JsonElement v2 = default;
		string v3 = null!;
		long v4 = default;
		string v5 = null!;
		string v6 = null!;
		long v7 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("balance_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v2 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("fullTitle"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("merchant_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("type"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_id"u8))
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
		return new BalanceModel(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record ConfirmationCodeModel(
	[property: JsonPropertyName("item")] ItemModel Item,
	[property: JsonPropertyName("codeData")] ConfirmationCodeModelCodeData CodeData
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ConfirmationCodeModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ConfirmationCodeModel ReadFromReader(ref Utf8JsonReader reader)
	{
		ItemModel v0 = null!;
		ConfirmationCodeModelCodeData v1 = null!;
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
				v1 = reader.TokenType == JsonTokenType.Null ? null! : ConfirmationCodeModelCodeData.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ConfirmationCodeModel(v0, v1);
	}
}

public sealed record ConfirmationCodeModelCodeData(
	[property: JsonPropertyName("code")] string Code,
	[property: JsonPropertyName("date")] long Date,
	[property: JsonPropertyName("textPlain")] string TextPlain
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ConfirmationCodeModelCodeData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ConfirmationCodeModelCodeData ReadFromReader(ref Utf8JsonReader reader)
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
		return new ConfirmationCodeModelCodeData(v0, v1, v2);
	}
}

public sealed record DiscountModel(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("discount_id")] long DiscountId,
	[property: JsonPropertyName("discount_percent")] long DiscountPercent,
	[property: JsonPropertyName("discount_user_id")] long DiscountUserId,
	[property: JsonPropertyName("max_price")] long MaxPrice,
	[property: JsonPropertyName("min_price")] long MinPrice,
	[property: JsonPropertyName("user_id")] long UserId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static DiscountModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static DiscountModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("discount_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("discount_percent"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("discount_user_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("max_price"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("min_price"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new DiscountModel(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ErrorModel(
	[property: JsonPropertyName("errors")] List<string>? Errors,
	[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ErrorModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ErrorModel ReadFromReader(ref Utf8JsonReader reader)
	{
		List<string> v0 = null!;
		Resp_SystemInfo v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("errors"u8))
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
		return new ErrorModel(v0, v1);
	}
}

public sealed record ExtraModel(
	[property: JsonPropertyName("proxy")] string? Proxy,
	[property: JsonPropertyName("close_item")] bool? CloseItem,
	[property: JsonPropertyName("region")] string? Region,
	[property: JsonPropertyName("service")] string? Service,
	[property: JsonPropertyName("system")] string? System,
	[property: JsonPropertyName("confirmationCode")] string? ConfirmationCode,
	[property: JsonPropertyName("cookies")] string? Cookies,
	[property: JsonPropertyName("login_without_cookies")] bool? LoginWithoutCookies,
	[property: JsonPropertyName("cookie_login")] bool? CookieLogin,
	[property: JsonPropertyName("mfa_file")] string? MfaFile,
	[property: JsonPropertyName("parse_dota2")] bool? ParseDota2,
	[property: JsonPropertyName("uplay_games")] bool? UplayGames,
	[property: JsonPropertyName("ea_games")] bool? EaGames,
	[property: JsonPropertyName("ark")] bool? Ark,
	[property: JsonPropertyName("ark_ascended")] bool? ArkAscended,
	[property: JsonPropertyName("warframe")] bool? Warframe,
	[property: JsonPropertyName("the_quarry")] bool? TheQuarry,
	[property: JsonPropertyName("brawlhalla")] bool? Brawlhalla,
	[property: JsonPropertyName("genshin_currency")] long? GenshinCurrency,
	[property: JsonPropertyName("honkai_currency")] long? HonkaiCurrency,
	[property: JsonPropertyName("zenless_currency")] long? ZenlessCurrency,
	[property: JsonPropertyName("password")] string? Password,
	[property: JsonPropertyName("telegramClient")] string? TelegramClient,
	[property: JsonPropertyName("telegramJson")] string? TelegramJson,
	[property: JsonPropertyName("checkChannels")] bool? CheckChannels,
	[property: JsonPropertyName("checkSpam")] bool? CheckSpam,
	[property: JsonPropertyName("checkHypixelBan")] bool? CheckHypixelBan
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ExtraModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ExtraModel ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		bool v7 = default;
		bool v8 = default;
		string v9 = null!;
		bool v10 = default;
		bool v11 = default;
		bool v12 = default;
		bool v13 = default;
		bool v14 = default;
		bool v15 = default;
		bool v16 = default;
		bool v17 = default;
		long v18 = default;
		long v19 = default;
		long v20 = default;
		string v21 = null!;
		string v22 = null!;
		string v23 = null!;
		bool v24 = default;
		bool v25 = default;
		bool v26 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("proxy"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("close_item"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("region"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("service"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("system"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("confirmationCode"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("cookies"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("login_without_cookies"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("cookie_login"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("mfa_file"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("parse_dota2"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("uplay_games"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("ea_games"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("ark"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("ark_ascended"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("warframe"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("the_quarry"u8))
			{
				reader.Read();
				v16 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("brawlhalla"u8))
			{
				reader.Read();
				v17 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("genshin_currency"u8))
			{
				reader.Read();
				v18 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("honkai_currency"u8))
			{
				reader.Read();
				v19 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("zenless_currency"u8))
			{
				reader.Read();
				v20 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("password"u8))
			{
				reader.Read();
				v21 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegramClient"u8))
			{
				reader.Read();
				v22 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegramJson"u8))
			{
				reader.Read();
				v23 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("checkChannels"u8))
			{
				reader.Read();
				v24 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("checkSpam"u8))
			{
				reader.Read();
				v25 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("checkHypixelBan"u8))
			{
				reader.Read();
				v26 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ExtraModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);
	}
}

public sealed record InvoiceModel(
	[property: JsonPropertyName("additional_data")] string AdditionalData,
	[property: JsonPropertyName("amount")] long Amount,
	[property: JsonPropertyName("comment")] string Comment,
	[property: JsonPropertyName("expires_at")] long ExpiresAt,
	[property: JsonPropertyName("invoice_date")] long InvoiceDate,
	[property: JsonPropertyName("invoice_id")] long InvoiceId,
	[property: JsonPropertyName("is_test")] bool IsTest,
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("paid_date")] long PaidDate,
	[property: JsonPropertyName("payer_user_id")] long PayerUserId,
	[property: JsonPropertyName("payment_id")] string PaymentId,
	[property: JsonPropertyName("resend_attempts")] long ResendAttempts,
	[property: JsonPropertyName("status")] string Status,
	[property: JsonPropertyName("url")] string Url,
	[property: JsonPropertyName("url_callback")] string UrlCallback,
	[property: JsonPropertyName("url_success")] string UrlSuccess,
	[property: JsonPropertyName("user_id")] long UserId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static InvoiceModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static InvoiceModel ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		bool v6 = default;
		long v7 = default;
		long v8 = default;
		long v9 = default;
		string v10 = null!;
		long v11 = default;
		string v12 = null!;
		string v13 = null!;
		string v14 = null!;
		string v15 = null!;
		long v16 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("additional_data"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("amount"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("comment"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("expires_at"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("invoice_date"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("invoice_id"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_test"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("merchant_id"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("paid_date"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("payer_user_id"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("payment_id"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("resend_attempts"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("status"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("url"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("url_callback"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("url_success"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new InvoiceModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);
	}
}

public sealed record ItemFromListModel(
	[property: JsonPropertyName("item_id")] long? ItemId,
	[property: JsonPropertyName("item_state")] string? ItemState,
	[property: JsonPropertyName("category_id")] long? CategoryId,
	[property: JsonPropertyName("published_date")] long? PublishedDate,
	[property: JsonPropertyName("title")] string? Title,
	[property: JsonPropertyName("description")] string? Description,
	[property: JsonPropertyName("price")] long? Price,
	[property: JsonPropertyName("update_stat_date")] long? UpdateStatDate,
	[property: JsonPropertyName("refreshed_date")] long? RefreshedDate,
	[property: JsonPropertyName("view_count")] long? ViewCount,
	[property: JsonPropertyName("is_sticky")] long? IsSticky,
	[property: JsonPropertyName("item_origin")] string? ItemOrigin,
	[property: JsonPropertyName("extended_guarantee")] long? ExtendedGuarantee,
	[property: JsonPropertyName("nsb")] long? Nsb,
	[property: JsonPropertyName("allow_ask_discount")] long? AllowAskDiscount,
	[property: JsonPropertyName("title_en")] string? TitleEn,
	[property: JsonPropertyName("description_en")] string? DescriptionEn,
	[property: JsonPropertyName("item_domain")] string? ItemDomain,
	[property: JsonPropertyName("resale_item_origin")] string? ResaleItemOrigin,
	[property: JsonPropertyName("isIgnored")] long? IsIgnored,
	[property: JsonPropertyName("guarantee")] bool? Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool? CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool? CanUpdateItemStats,
	[property: JsonPropertyName("canViewEmailLoginData")] bool? CanViewEmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool? ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool? CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool? CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool? CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool? CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool? CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool? CanUnstickItem,
	[property: JsonPropertyName("bumpSettings")] ItemFromListModelBumpSettings? BumpSettings,
	[property: JsonPropertyName("canBumpItem")] bool? CanBumpItem,
	[property: JsonPropertyName("canBuyItem")] bool? CanBuyItem,
	[property: JsonPropertyName("rub_price")] long? RubPrice,
	[property: JsonPropertyName("price_currency")] string? PriceCurrency,
	[property: JsonPropertyName("canValidateAccount")] bool? CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool? CanResellItemAfterPurchase,
	[property: JsonPropertyName("canViewAccountLink")] bool? CanViewAccountLink,
	[property: JsonPropertyName("itemOriginPhrase")] string? ItemOriginPhrase,
	[property: JsonPropertyName("tags")] List<string>? Tags,
	[property: JsonPropertyName("note_text")] string? NoteText,
	[property: JsonPropertyName("description_html")] string? DescriptionHtml,
	[property: JsonPropertyName("description_html_en")] string? DescriptionHtmlEn,
	[property: JsonPropertyName("seller")] ItemFromListModelSeller? Seller
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemFromListModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemFromListModel ReadFromReader(ref Utf8JsonReader reader)
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
		string v11 = null!;
		long v12 = default;
		long v13 = default;
		long v14 = default;
		string v15 = null!;
		string v16 = null!;
		string v17 = null!;
		string v18 = null!;
		long v19 = default;
		bool v20 = default;
		bool v21 = default;
		bool v22 = default;
		bool v23 = default;
		bool v24 = default;
		bool v25 = default;
		bool v26 = default;
		bool v27 = default;
		bool v28 = default;
		bool v29 = default;
		bool v30 = default;
		ItemFromListModelBumpSettings v31 = null!;
		bool v32 = default;
		bool v33 = default;
		long v34 = default;
		string v35 = null!;
		bool v36 = default;
		bool v37 = default;
		bool v38 = default;
		string v39 = null!;
		List<string> v40 = null!;
		string v41 = null!;
		string v42 = null!;
		string v43 = null!;
		ItemFromListModelSeller v44 = null!;
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
			else if (reader.ValueTextEquals("view_count"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_sticky"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_origin"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("extended_guarantee"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("nsb"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("allow_ask_discount"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title_en"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description_en"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_domain"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("resale_item_origin"u8))
			{
				reader.Read();
				v18 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isIgnored"u8))
			{
				reader.Read();
				v19 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("guarantee"u8))
			{
				reader.Read();
				v20 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewLoginData"u8))
			{
				reader.Read();
				v21 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canUpdateItemStats"u8))
			{
				reader.Read();
				v22 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewEmailLoginData"u8))
			{
				reader.Read();
				v23 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("showGetEmailCodeButton"u8))
			{
				reader.Read();
				v24 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canOpenItem"u8))
			{
				reader.Read();
				v25 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canCloseItem"u8))
			{
				reader.Read();
				v26 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canEditItem"u8))
			{
				reader.Read();
				v27 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canDeleteItem"u8))
			{
				reader.Read();
				v28 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canStickItem"u8))
			{
				reader.Read();
				v29 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canUnstickItem"u8))
			{
				reader.Read();
				v30 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bumpSettings"u8))
			{
				reader.Read();
				v31 = reader.TokenType == JsonTokenType.Null ? null! : ItemFromListModelBumpSettings.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canBumpItem"u8))
			{
				reader.Read();
				v32 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canBuyItem"u8))
			{
				reader.Read();
				v33 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("rub_price"u8))
			{
				reader.Read();
				v34 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("price_currency"u8))
			{
				reader.Read();
				v35 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canValidateAccount"u8))
			{
				reader.Read();
				v36 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canResellItemAfterPurchase"u8))
			{
				reader.Read();
				v37 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewAccountLink"u8))
			{
				reader.Read();
				v38 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("itemOriginPhrase"u8))
			{
				reader.Read();
				v39 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("tags"u8))
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
					v40 = __lst;
				}
			}
			else if (reader.ValueTextEquals("note_text"u8))
			{
				reader.Read();
				v41 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description_html"u8))
			{
				reader.Read();
				v42 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description_html_en"u8))
			{
				reader.Read();
				v43 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("seller"u8))
			{
				reader.Read();
				v44 = reader.TokenType == JsonTokenType.Null ? null! : ItemFromListModelSeller.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemFromListModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);
	}
}

public sealed record ItemFromListModelBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool? CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool? CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] string? ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] string? ErrorPhrase
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemFromListModelBumpSettings ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemFromListModelBumpSettings ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		string v2 = null!;
		string v3 = null!;
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
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("errorPhrase"u8))
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
		return new ItemFromListModelBumpSettings(v0, v1, v2, v3);
	}
}

public sealed record ItemFromListModelSeller(
	[property: JsonPropertyName("user_id")] long? UserId,
	[property: JsonPropertyName("sold_items_count")] long? SoldItemsCount,
	[property: JsonPropertyName("active_item_count")] long? ActiveItemCount,
	[property: JsonPropertyName("restore_data")] string? RestoreData,
	[property: JsonPropertyName("username")] string? Username,
	[property: JsonPropertyName("avatar_date")] long? AvatarDate,
	[property: JsonPropertyName("is_banned")] long? IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long? DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long? RestorePercents
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemFromListModelSeller ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemFromListModelSeller ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("sold_items_count"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("active_item_count"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_data"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_percents"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemFromListModelSeller(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record ItemListModel(
	[property: JsonPropertyName("items")] List<ItemFromListModel> Items,
	[property: JsonPropertyName("totalItems")] long TotalItems,
	[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
	[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
	[property: JsonPropertyName("perPage")] long PerPage,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("searchUrl")] string SearchUrl,
	[property: JsonPropertyName("stickyItems")] List<ItemFromListModel> StickyItems,
	[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemListModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemListModel ReadFromReader(ref Utf8JsonReader reader)
	{
		List<ItemFromListModel> v0 = null!;
		long v1 = default;
		JsonElement v2 = default;
		bool v3 = default;
		long v4 = default;
		long v5 = default;
		string v6 = null!;
		List<ItemFromListModel> v7 = null!;
		Resp_SystemInfo v8 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("items"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ItemFromListModel>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ItemFromListModel.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v0 = __lst;
				}
			}
			else if (reader.ValueTextEquals("totalItems"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("totalItemsPrice"u8))
			{
				reader.Read();
				v2 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("hasNextPage"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("perPage"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("searchUrl"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("stickyItems"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ItemFromListModel>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ItemFromListModel.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v7 = __lst;
				}
			}
			else if (reader.ValueTextEquals("system_info"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemListModel(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record ItemModel(
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
	[property: JsonPropertyName("pending_deletion_date")] long PendingDeletionDate,
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
	[property: JsonPropertyName("auto_bump_period")] long AutoBumpPeriod,
	[property: JsonPropertyName("guarantee_duration")] long GuaranteeDuration,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("discount")] bool Discount,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("priceWithSellerFee")] double PriceWithSellerFee,
	[property: JsonPropertyName("category")] ItemModelCategory Category,
	[property: JsonPropertyName("guarantee")] ItemModelGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canViewTempEmail")] bool CanViewTempEmail,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewItemViews")] bool CanViewItemViews,
	[property: JsonPropertyName("canManagePublicTag")] bool CanManagePublicTag,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("copyFormatData")] ItemModelCopyFormatData CopyFormatData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("canOpenItem")] bool CanOpenItem,
	[property: JsonPropertyName("canCloseItem")] bool CanCloseItem,
	[property: JsonPropertyName("canEditItem")] bool CanEditItem,
	[property: JsonPropertyName("canDeleteItem")] bool CanDeleteItem,
	[property: JsonPropertyName("canStickItem")] bool CanStickItem,
	[property: JsonPropertyName("canUnstickItem")] bool CanUnstickItem,
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canNotBumpItemReason")] string CanNotBumpItemReason,
	[property: JsonPropertyName("canAutoBump")] bool CanAutoBump,
	[property: JsonPropertyName("buyer")] ItemModelBuyer Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("canBuyItem")] bool CanBuyItem,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("priceWithSellerFeeLabel")] string PriceWithSellerFeeLabel,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItem")] bool CanResellItem,
	[property: JsonPropertyName("canViewAccountLink")] bool? CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<ItemModelAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("imagePreviewLinks")] ItemModelImagePreviewLinks ImagePreviewLinks,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("canChangeEmailPassword")] bool CanChangeEmailPassword,
	[property: JsonPropertyName("uniqueKeyExists")] bool UniqueKeyExists,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("sold_items_category_count")] long SoldItemsCategoryCount,
	[property: JsonPropertyName("restore_items_category_count")] long RestoreItemsCategoryCount,
	[property: JsonPropertyName("tags")] List<JsonElement> Tags,
	[property: JsonPropertyName("public_tag")] ItemModelPublicTag PublicTag,
	[property: JsonPropertyName("note_text")] string NoteText,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] ItemModelSeller Seller
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModel ReadFromReader(ref Utf8JsonReader reader)
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
		long v12 = default;
		string v13 = null!;
		long v14 = default;
		long v15 = default;
		long v16 = default;
		string v17 = null!;
		string v18 = null!;
		string v19 = null!;
		string v20 = null!;
		string v21 = null!;
		string v22 = null!;
		long v23 = default;
		long v24 = default;
		long v25 = default;
		bool v26 = default;
		string v27 = null!;
		long v28 = default;
		double v29 = default;
		ItemModelCategory v30 = null!;
		ItemModelGuarantee v31 = null!;
		bool v32 = default;
		bool v33 = default;
		bool v34 = default;
		bool v35 = default;
		bool v36 = default;
		bool v37 = default;
		bool v38 = default;
		ItemModelCopyFormatData v39 = null!;
		bool v40 = default;
		bool v41 = default;
		bool v42 = default;
		bool v43 = default;
		bool v44 = default;
		bool v45 = default;
		bool v46 = default;
		bool v47 = default;
		string v48 = null!;
		bool v49 = default;
		ItemModelBuyer v50 = null!;
		bool v51 = default;
		bool v52 = default;
		string v53 = null!;
		string v54 = null!;
		bool v55 = default;
		bool v56 = default;
		bool v57 = default;
		List<ItemModelAccountLinks> v58 = null!;
		string v59 = null!;
		ItemModelImagePreviewLinks v60 = null!;
		string v61 = null!;
		bool v62 = default;
		bool v63 = default;
		bool v64 = default;
		string v65 = null!;
		long v66 = default;
		long v67 = default;
		List<JsonElement> v68 = null!;
		ItemModelPublicTag v69 = null!;
		string v70 = null!;
		string v71 = null!;
		string v72 = null!;
		string v73 = null!;
		string v74 = null!;
		ItemModelSeller v75 = null!;
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
			else if (reader.ValueTextEquals("pending_deletion_date"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("view_count"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_sticky"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_origin"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("extended_guarantee"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("nsb"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("allow_ask_discount"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title_en"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description_en"u8))
			{
				reader.Read();
				v18 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_type"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_provider"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_domain"u8))
			{
				reader.Read();
				v21 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("resale_item_origin"u8))
			{
				reader.Read();
				v22 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("auto_bump_period"u8))
			{
				reader.Read();
				v23 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("guarantee_duration"u8))
			{
				reader.Read();
				v24 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rub_price"u8))
			{
				reader.Read();
				v25 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("discount"u8))
			{
				reader.Read();
				v26 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("feedback_data"u8))
			{
				reader.Read();
				v27 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("max_discount_percent"u8))
			{
				reader.Read();
				v28 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("priceWithSellerFee"u8))
			{
				reader.Read();
				v29 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("category"u8))
			{
				reader.Read();
				v30 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelCategory.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("guarantee"u8))
			{
				reader.Read();
				v31 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelGuarantee.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canViewLoginData"u8))
			{
				reader.Read();
				v32 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewTempEmail"u8))
			{
				reader.Read();
				v33 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canUpdateItemStats"u8))
			{
				reader.Read();
				v34 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canReportItem"u8))
			{
				reader.Read();
				v35 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewItemViews"u8))
			{
				reader.Read();
				v36 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canManagePublicTag"u8))
			{
				reader.Read();
				v37 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewEmailLoginData"u8))
			{
				reader.Read();
				v38 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("copyFormatData"u8))
			{
				reader.Read();
				v39 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelCopyFormatData.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("showGetEmailCodeButton"u8))
			{
				reader.Read();
				v40 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canOpenItem"u8))
			{
				reader.Read();
				v41 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canCloseItem"u8))
			{
				reader.Read();
				v42 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canEditItem"u8))
			{
				reader.Read();
				v43 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canDeleteItem"u8))
			{
				reader.Read();
				v44 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canStickItem"u8))
			{
				reader.Read();
				v45 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canUnstickItem"u8))
			{
				reader.Read();
				v46 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canBumpItem"u8))
			{
				reader.Read();
				v47 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canNotBumpItemReason"u8))
			{
				reader.Read();
				v48 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canAutoBump"u8))
			{
				reader.Read();
				v49 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("buyer"u8))
			{
				reader.Read();
				v50 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelBuyer.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("isPersonalAccount"u8))
			{
				reader.Read();
				v51 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canBuyItem"u8))
			{
				reader.Read();
				v52 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("price_currency"u8))
			{
				reader.Read();
				v53 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("priceWithSellerFeeLabel"u8))
			{
				reader.Read();
				v54 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canValidateAccount"u8))
			{
				reader.Read();
				v55 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canResellItem"u8))
			{
				reader.Read();
				v56 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewAccountLink"u8))
			{
				reader.Read();
				v57 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("accountLinks"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ItemModelAccountLinks>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ItemModelAccountLinks.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v58 = __lst;
				}
			}
			else if (reader.ValueTextEquals("accountLink"u8))
			{
				reader.Read();
				v59 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("imagePreviewLinks"u8))
			{
				reader.Read();
				v60 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelImagePreviewLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("emailLoginUrl"u8))
			{
				reader.Read();
				v61 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canChangePassword"u8))
			{
				reader.Read();
				v62 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canChangeEmailPassword"u8))
			{
				reader.Read();
				v63 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("uniqueKeyExists"u8))
			{
				reader.Read();
				v64 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("itemOriginPhrase"u8))
			{
				reader.Read();
				v65 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sold_items_category_count"u8))
			{
				reader.Read();
				v66 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_items_category_count"u8))
			{
				reader.Read();
				v67 = reader.GetInt64();
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
					v68 = __lst;
				}
			}
			else if (reader.ValueTextEquals("public_tag"u8))
			{
				reader.Read();
				v69 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelPublicTag.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("note_text"u8))
			{
				reader.Read();
				v70 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionHtml"u8))
			{
				reader.Read();
				v71 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnHtml"u8))
			{
				reader.Read();
				v72 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionPlain"u8))
			{
				reader.Read();
				v73 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnPlain"u8))
			{
				reader.Read();
				v74 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("seller"u8))
			{
				reader.Read();
				v75 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelSeller.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75);
	}
}

public sealed record ItemModelCategory(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_name")] string CategoryName,
	[property: JsonPropertyName("category_url")] string CategoryUrl
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelCategory ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelCategory ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("category_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_name"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_url"u8))
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
		return new ItemModelCategory(v0, v1, v2, v3);
	}
}

public sealed record ItemModelGuarantee(
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
	public static ItemModelGuarantee ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelGuarantee ReadFromReader(ref Utf8JsonReader reader)
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
		return new ItemModelGuarantee(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ItemModelCopyFormatData(
	[property: JsonPropertyName("title_link")] string TitleLink
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelCopyFormatData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelCopyFormatData ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title_link"u8))
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
		return new ItemModelCopyFormatData(v0);
	}
}

public sealed record ItemModelBuyer(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("visitorIsBuyer")] bool VisitorIsBuyer
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelBuyer ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelBuyer ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		bool v2 = default;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelBuyer(v0, v1, v2);
	}
}

public sealed record ItemModelAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelAccountLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelAccountLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ItemModelAccountLinks(v0, v1, v2);
	}
}

public sealed record ItemModelImagePreviewLinksDownload(
	[property: JsonPropertyName("games")] string Games
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelImagePreviewLinksDownload ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelImagePreviewLinksDownload ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("games"u8))
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
		return new ItemModelImagePreviewLinksDownload(v0);
	}
}

public sealed record ItemModelImagePreviewLinks(
	[property: JsonPropertyName("download")] ItemModelImagePreviewLinksDownload Download
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelImagePreviewLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelImagePreviewLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		ItemModelImagePreviewLinksDownload v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("download"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelImagePreviewLinksDownload.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelImagePreviewLinks(v0);
	}
}

public sealed record ItemModelPublicTag(
	[property: JsonPropertyName("background_color")] string BackgroundColor,
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelPublicTag ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelPublicTag ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("background_color"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("tag_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
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
		return new ItemModelPublicTag(v0, v1, v2);
	}
}

public sealed record ItemModelSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("restore_percents")] long RestorePercents
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelSeller ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelSeller ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("sold_items_count"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("active_items_count"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_data"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_percents"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelSeller(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record Resp_SystemInfo(
	[property: JsonPropertyName("rate_limit")] Resp_SystemInfoRateLimit RateLimit,
	[property: JsonPropertyName("visitor_id")] long VisitorId,
	[property: JsonPropertyName("time")] long Time,
	[property: JsonPropertyName("log_id")] long LogId
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
		Resp_SystemInfoRateLimit v0 = null!;
		long v1 = default;
		long v2 = default;
		long v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("rate_limit"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfoRateLimit.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("visitor_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("time"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("log_id"u8))
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
		return new Resp_SystemInfo(v0, v1, v2, v3);
	}
}

public sealed record Resp_SystemInfoRateLimit(
	[property: JsonPropertyName("limit")] long Limit,
	[property: JsonPropertyName("remaining")] long Remaining,
	[property: JsonPropertyName("reset")] long Reset,
	[property: JsonPropertyName("bucket")] string? Bucket
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static Resp_SystemInfoRateLimit ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static Resp_SystemInfoRateLimit ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("limit"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("remaining"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("reset"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("bucket"u8))
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
		return new Resp_SystemInfoRateLimit(v0, v1, v2, v3);
	}
}

public sealed record StatusModel(
	[property: JsonPropertyName("status")] string Status,
	[property: JsonPropertyName("message")] string Message,
	[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static StatusModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static StatusModel ReadFromReader(ref Utf8JsonReader reader)
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
		return new StatusModel(v0, v1, v2);
	}
}

public sealed record TagModel(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static TagModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static TagModel ReadFromReader(ref Utf8JsonReader reader)
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
		return new TagModel(v0, v1, v2, v3, v4);
	}
}

public sealed record UserModel(
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("activity_visible")] bool ActivityVisible,
	[property: JsonPropertyName("age")] long Age,
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("balances")] List<UserModelBalances> Balances,
	[property: JsonPropertyName("bump_item_period")] long BumpItemPeriod,
	[property: JsonPropertyName("can_edit")] bool CanEdit,
	[property: JsonPropertyName("can_follow")] bool CanFollow,
	[property: JsonPropertyName("can_ignore")] bool CanIgnore,
	[property: JsonPropertyName("can_post_profile")] bool CanPostProfile,
	[property: JsonPropertyName("can_view_profile")] bool CanViewProfile,
	[property: JsonPropertyName("can_view_profile_posts")] bool CanViewProfilePosts,
	[property: JsonPropertyName("can_warn")] bool CanWarn,
	[property: JsonPropertyName("contest_count")] long ContestCount,
	[property: JsonPropertyName("conv_welcome_message")] string ConvWelcomeMessage,
	[property: JsonPropertyName("convertedBalance")] long ConvertedBalance,
	[property: JsonPropertyName("convertedDeposit")] long ConvertedDeposit,
	[property: JsonPropertyName("convertedHold")] long ConvertedHold,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("currencyPhrase")] string CurrencyPhrase,
	[property: JsonPropertyName("custom_account_download_format")] string CustomAccountDownloadFormat,
	[property: JsonPropertyName("custom_fields")] UserModelCustomFields CustomFields,
	[property: JsonPropertyName("custom_title")] string CustomTitle,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("dob")] UserModelDob Dob,
	[property: JsonPropertyName("feedback_data")] Dictionary<string, UserModelFeedbackData> FeedbackData,
	[property: JsonPropertyName("hold")] string Hold,
	[property: JsonPropertyName("homepage")] string Homepage,
	[property: JsonPropertyName("imap_data")] UserModelImapData ImapData,
	[property: JsonPropertyName("is_admin")] bool IsAdmin,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("is_followed")] bool IsFollowed,
	[property: JsonPropertyName("is_ignored")] bool IsIgnored,
	[property: JsonPropertyName("is_moderator")] bool IsModerator,
	[property: JsonPropertyName("is_staff")] bool IsStaff,
	[property: JsonPropertyName("is_super_admin")] bool IsSuperAdmin,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("last_activity")] long LastActivity,
	[property: JsonPropertyName("like2_count")] long Like2Count,
	[property: JsonPropertyName("like_count")] long LikeCount,
	[property: JsonPropertyName("location")] string Location,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("message_count")] long MessageCount,
	[property: JsonPropertyName("paid_mail_left")] long PaidMailLeft,
	[property: JsonPropertyName("public_tags")] List<UserModelPublicTags> PublicTags,
	[property: JsonPropertyName("register_date")] long RegisterDate,
	[property: JsonPropertyName("rendered")] UserModelRendered Rendered,
	[property: JsonPropertyName("restore_count")] long RestoreCount,
	[property: JsonPropertyName("restore_data")] Dictionary<string, long> RestoreData,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("tags")] List<TagModel> Tags,
	[property: JsonPropertyName("telegram_client")] UserModelTelegramClient TelegramClient,
	[property: JsonPropertyName("trophy_points")] long TrophyPoints,
	[property: JsonPropertyName("user_allow_ask_discount")] bool UserAllowAskDiscount,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_title")] string UserTitle,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("view_url")] string ViewUrl,
	[property: JsonPropertyName("visible")] bool Visible,
	[property: JsonPropertyName("warning_points")] long WarningPoints
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModel ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModel ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		bool v1 = default;
		long v2 = default;
		string v3 = null!;
		List<UserModelBalances> v4 = null!;
		long v5 = default;
		bool v6 = default;
		bool v7 = default;
		bool v8 = default;
		bool v9 = default;
		bool v10 = default;
		bool v11 = default;
		bool v12 = default;
		long v13 = default;
		string v14 = null!;
		long v15 = default;
		long v16 = default;
		long v17 = default;
		string v18 = null!;
		string v19 = null!;
		string v20 = null!;
		UserModelCustomFields v21 = null!;
		string v22 = null!;
		long v23 = default;
		UserModelDob v24 = null!;
		Dictionary<string, UserModelFeedbackData> v25 = null!;
		string v26 = null!;
		string v27 = null!;
		UserModelImapData v28 = null!;
		bool v29 = default;
		bool v30 = default;
		bool v31 = default;
		bool v32 = default;
		bool v33 = default;
		bool v34 = default;
		bool v35 = default;
		long v36 = default;
		long v37 = default;
		long v38 = default;
		long v39 = default;
		string v40 = null!;
		string v41 = null!;
		long v42 = default;
		long v43 = default;
		long v44 = default;
		List<UserModelPublicTags> v45 = null!;
		long v46 = default;
		UserModelRendered v47 = null!;
		long v48 = default;
		Dictionary<string, long> v49 = null!;
		string v50 = null!;
		long v51 = default;
		List<TagModel> v52 = null!;
		UserModelTelegramClient v53 = null!;
		long v54 = default;
		bool v55 = default;
		long v56 = default;
		string v57 = null!;
		string v58 = null!;
		string v59 = null!;
		bool v60 = default;
		long v61 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("active_items_count"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("activity_visible"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("age"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("balances"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<UserModelBalances>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = UserModelBalances.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v4 = __lst;
				}
			}
			else if (reader.ValueTextEquals("bump_item_period"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("can_edit"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_follow"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_ignore"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_post_profile"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_view_profile"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_view_profile_posts"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("can_warn"u8))
			{
				reader.Read();
				v12 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("contest_count"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("conv_welcome_message"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("convertedBalance"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("convertedDeposit"u8))
			{
				reader.Read();
				v16 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("convertedHold"u8))
			{
				reader.Read();
				v17 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("currency"u8))
			{
				reader.Read();
				v18 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("currencyPhrase"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("custom_account_download_format"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("custom_fields"u8))
			{
				reader.Read();
				v21 = reader.TokenType == JsonTokenType.Null ? null! : UserModelCustomFields.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v22 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("deposit"u8))
			{
				reader.Read();
				v23 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("dob"u8))
			{
				reader.Read();
				v24 = reader.TokenType == JsonTokenType.Null ? null! : UserModelDob.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("feedback_data"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartObject)
				{
					var __dict = new Dictionary<string, UserModelFeedbackData>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
					{
						if (reader.TokenType != JsonTokenType.PropertyName) continue;
						var __key = reader.GetString()!;
						reader.Read();
						var __val = UserModelFeedbackData.ReadFromReader(ref reader);
						__dict[__key] = __val;
					}
					v25 = __dict;
				}
			}
			else if (reader.ValueTextEquals("hold"u8))
			{
				reader.Read();
				v26 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("homepage"u8))
			{
				reader.Read();
				v27 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("imap_data"u8))
			{
				reader.Read();
				v28 = reader.TokenType == JsonTokenType.Null ? null! : UserModelImapData.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("is_admin"u8))
			{
				reader.Read();
				v29 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v30 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_followed"u8))
			{
				reader.Read();
				v31 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_ignored"u8))
			{
				reader.Read();
				v32 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_moderator"u8))
			{
				reader.Read();
				v33 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_staff"u8))
			{
				reader.Read();
				v34 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_super_admin"u8))
			{
				reader.Read();
				v35 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("joined_date"u8))
			{
				reader.Read();
				v36 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("last_activity"u8))
			{
				reader.Read();
				v37 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like2_count"u8))
			{
				reader.Read();
				v38 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("like_count"u8))
			{
				reader.Read();
				v39 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("location"u8))
			{
				reader.Read();
				v40 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("market_custom_title"u8))
			{
				reader.Read();
				v41 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("max_discount_percent"u8))
			{
				reader.Read();
				v42 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("message_count"u8))
			{
				reader.Read();
				v43 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("paid_mail_left"u8))
			{
				reader.Read();
				v44 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("public_tags"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<UserModelPublicTags>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = UserModelPublicTags.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v45 = __lst;
				}
			}
			else if (reader.ValueTextEquals("register_date"u8))
			{
				reader.Read();
				v46 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("rendered"u8))
			{
				reader.Read();
				v47 = reader.TokenType == JsonTokenType.Null ? null! : UserModelRendered.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("restore_count"u8))
			{
				reader.Read();
				v48 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_data"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartObject)
				{
					var __dict = new Dictionary<string, long>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
					{
						if (reader.TokenType != JsonTokenType.PropertyName) continue;
						var __key = reader.GetString()!;
						reader.Read();
						var __val = reader.GetInt64();
						__dict[__key] = __val;
					}
					v49 = __dict;
				}
			}
			else if (reader.ValueTextEquals("short_link"u8))
			{
				reader.Read();
				v50 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sold_items_count"u8))
			{
				reader.Read();
				v51 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("tags"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<TagModel>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = TagModel.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v52 = __lst;
				}
			}
			else if (reader.ValueTextEquals("telegram_client"u8))
			{
				reader.Read();
				v53 = reader.TokenType == JsonTokenType.Null ? null! : UserModelTelegramClient.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("trophy_points"u8))
			{
				reader.Read();
				v54 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_allow_ask_discount"u8))
			{
				reader.Read();
				v55 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v56 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_title"u8))
			{
				reader.Read();
				v57 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("username"u8))
			{
				reader.Read();
				v58 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("view_url"u8))
			{
				reader.Read();
				v59 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("visible"u8))
			{
				reader.Read();
				v60 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("warning_points"u8))
			{
				reader.Read();
				v61 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UserModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61);
	}
}

public sealed record UserModelBalances(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("balance_id")] long BalanceId,
	[property: JsonPropertyName("convertedBalance")] double ConvertedBalance,
	[property: JsonPropertyName("custom_title")] JsonElement CustomTitle,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("user_id")] long UserId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelBalances ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelBalances ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		double v2 = default;
		JsonElement v3 = default;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		string v7 = null!;
		long v8 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("balance_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("convertedBalance"u8))
			{
				reader.Read();
				v2 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("custom_title"u8))
			{
				reader.Read();
				v3 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("fullTitle"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("merchant_id"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("type"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UserModelBalances(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record UserModelCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("allowSelfUnban")] List<JsonElement> AllowSelfUnban,
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("github")] string Github,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("lztAwardUserTrophy")] string LztAwardUserTrophy,
	[property: JsonPropertyName("lztLikesIncreasing")] string LztLikesIncreasing,
	[property: JsonPropertyName("lztLikesZeroing")] string LztLikesZeroing,
	[property: JsonPropertyName("lztSympathyIncreasing")] string LztSympathyIncreasing,
	[property: JsonPropertyName("lztSympathyZeroing")] string LztSympathyZeroing,
	[property: JsonPropertyName("lztUnbanAmount")] string LztUnbanAmount,
	[property: JsonPropertyName("maecenasValue")] string MaecenasValue,
	[property: JsonPropertyName("scamURL")] string ScamURL,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("telegram")] string Telegram,
	[property: JsonPropertyName("vk")] string Vk,
	[property: JsonPropertyName("favoritePorn")] string FavoritePorn,
	[property: JsonPropertyName("favoriteVape")] string FavoriteVape,
	[property: JsonPropertyName("favoriteAnime")] string FavoriteAnime,
	[property: JsonPropertyName("matrix")] string Matrix
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelCustomFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelCustomFields ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("ban_reason"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("discord"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("github"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("jabber"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztAwardUserTrophy"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztLikesIncreasing"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztLikesZeroing"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztSympathyIncreasing"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztSympathyZeroing"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("lztUnbanAmount"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("maecenasValue"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("scamURL"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("steam"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("vk"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("favoritePorn"u8))
			{
				reader.Read();
				v17 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("favoriteVape"u8))
			{
				reader.Read();
				v18 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("favoriteAnime"u8))
			{
				reader.Read();
				v19 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("matrix"u8))
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
		return new UserModelCustomFields(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20);
	}
}

public sealed record UserModelDob(
	[property: JsonPropertyName("year")] long Year,
	[property: JsonPropertyName("month")] long Month,
	[property: JsonPropertyName("day")] long Day
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelDob ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelDob ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("year"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("month"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("day"u8))
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
		return new UserModelDob(v0, v1, v2);
	}
}

public sealed record UserModelFeedbackData(
	[property: JsonPropertyName("positive")] long Positive,
	[property: JsonPropertyName("negative")] long Negative
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelFeedbackData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelFeedbackData ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("positive"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("negative"u8))
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
		return new UserModelFeedbackData(v0, v1);
	}
}

public sealed record UserModelImapDataDomainZone(
	[property: JsonPropertyName("domain")] string Domain,
	[property: JsonPropertyName("imap_server")] string ImapServer,
	[property: JsonPropertyName("port")] long Port,
	[property: JsonPropertyName("secure")] bool Secure
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelImapDataDomainZone ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelImapDataDomainZone ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		long v2 = default;
		bool v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("domain"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("imap_server"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("port"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("secure"u8))
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
		return new UserModelImapDataDomainZone(v0, v1, v2, v3);
	}
}

public sealed record UserModelImapData(
	[property: JsonPropertyName("domain.zone")] UserModelImapDataDomainZone DomainZone
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelImapData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelImapData ReadFromReader(ref Utf8JsonReader reader)
	{
		UserModelImapDataDomainZone v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("domain.zone"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : UserModelImapDataDomainZone.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UserModelImapData(v0);
	}
}

public sealed record UserModelPublicTags(
	[property: JsonPropertyName("background_color")] string BackgroundColor,
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelPublicTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelPublicTags ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("background_color"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("tag_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
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
		return new UserModelPublicTags(v0, v1, v2);
	}
}

public sealed record UserModelRenderedAvatars(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M,
	[property: JsonPropertyName("s")] string S
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelRenderedAvatars ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelRenderedAvatars ReadFromReader(ref Utf8JsonReader reader)
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
		return new UserModelRenderedAvatars(v0, v1, v2);
	}
}

public sealed record UserModelRenderedBackgrounds(
	[property: JsonPropertyName("l")] string L,
	[property: JsonPropertyName("m")] string M
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelRenderedBackgrounds ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelRenderedBackgrounds ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UserModelRenderedBackgrounds(v0, v1);
	}
}

public sealed record UserModelRendered(
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatars")] UserModelRenderedAvatars Avatars,
	[property: JsonPropertyName("backgrounds")] UserModelRenderedBackgrounds Backgrounds,
	[property: JsonPropertyName("link")] string Link
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelRendered ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelRendered ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		UserModelRenderedAvatars v1 = null!;
		UserModelRenderedBackgrounds v2 = null!;
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
				v1 = reader.TokenType == JsonTokenType.Null ? null! : UserModelRenderedAvatars.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("backgrounds"u8))
			{
				reader.Read();
				v2 = reader.TokenType == JsonTokenType.Null ? null! : UserModelRenderedBackgrounds.ReadFromReader(ref reader);
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
		return new UserModelRendered(v0, v1, v2, v3);
	}
}

public sealed record UserModelTelegramClient(
	[property: JsonPropertyName("telegram_api_id")] string TelegramApiId,
	[property: JsonPropertyName("telegram_api_hash")] string TelegramApiHash,
	[property: JsonPropertyName("telegram_device_model")] string TelegramDeviceModel,
	[property: JsonPropertyName("telegram_system_version")] string TelegramSystemVersion,
	[property: JsonPropertyName("telegram_app_version")] string TelegramAppVersion,
	[property: JsonPropertyName("telegram_system_lang_code")] string TelegramSystemLangCode,
	[property: JsonPropertyName("telegram_lang_code")] string TelegramLangCode,
	[property: JsonPropertyName("telegram_lang_pack")] string TelegramLangPack
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelTelegramClient ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelTelegramClient ReadFromReader(ref Utf8JsonReader reader)
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

			if (reader.ValueTextEquals("telegram_api_id"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram_api_hash"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram_device_model"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram_system_version"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram_app_version"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram_system_lang_code"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram_lang_code"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram_lang_pack"u8))
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
		return new UserModelTelegramClient(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

