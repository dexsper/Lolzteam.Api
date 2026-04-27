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
	[property: JsonPropertyName("dota2_mmr")] long? Dota2Mmr,
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
		long v10 = default;
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
			else if (reader.ValueTextEquals("dota2_mmr"u8))
			{
				reader.Read();
				v10 = reader.GetInt64();
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
	[property: JsonPropertyName("note_text")] string NoteText,
	[property: JsonPropertyName("content_type")] JsonElement ContentType,
	[property: JsonPropertyName("content_id")] JsonElement ContentId,
	[property: JsonPropertyName("delete_date")] long DeleteDate,
	[property: JsonPropertyName("delete_user_id")] long DeleteUserId,
	[property: JsonPropertyName("delete_username")] string DeleteUsername,
	[property: JsonPropertyName("delete_reason")] string DeleteReason,
	[property: JsonPropertyName("user_allow_ask_discount")] long UserAllowAskDiscount,
	[property: JsonPropertyName("max_discount_percent")] long MaxDiscountPercent,
	[property: JsonPropertyName("market_custom_title")] string MarketCustomTitle,
	[property: JsonPropertyName("feedback_data")] string FeedbackData,
	[property: JsonPropertyName("buyer_display_icon_group_id")] long BuyerDisplayIconGroupId,
	[property: JsonPropertyName("buyer_uniq_banner")] string BuyerUniqBanner,
	[property: JsonPropertyName("buyer_avatar_date")] long BuyerAvatarDate,
	[property: JsonPropertyName("buyer_user_group_id")] long BuyerUserGroupId,
	[property: JsonPropertyName("is_fave")] JsonElement IsFave,
	[property: JsonPropertyName("in_cart")] JsonElement InCart,
	[property: JsonPropertyName("cart_price")] JsonElement CartPrice,
	[property: JsonPropertyName("canResellItem")] bool CanResellItem,
	[property: JsonPropertyName("priceWithSellerFee")] double PriceWithSellerFee,
	[property: JsonPropertyName("guarantee")] ItemModelGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("canViewItemViews")] bool CanViewItemViews,
	[property: JsonPropertyName("loginData")] ItemModelLoginData LoginData,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("copyFormatData")] ItemModelCopyFormatData CopyFormatData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("getEmailCodeDisplayLogin")] JsonElement GetEmailCodeDisplayLogin,
	[property: JsonPropertyName("buyer")] ItemModelBuyer Buyer,
	[property: JsonPropertyName("isPersonalAccount")] bool IsPersonalAccount,
	[property: JsonPropertyName("rub_price")] long RubPrice,
	[property: JsonPropertyName("price_currency")] string PriceCurrency,
	[property: JsonPropertyName("priceWithSellerFeeLabel")] string PriceWithSellerFeeLabel,
	[property: JsonPropertyName("canValidateAccount")] bool CanValidateAccount,
	[property: JsonPropertyName("canResellItemAfterPurchase")] bool CanResellItemAfterPurchase,
	[property: JsonPropertyName("isSmallExf")] bool IsSmallExf,
	[property: JsonPropertyName("account_last_activity")] long AccountLastActivity,
	[property: JsonPropertyName("canViewAccountLink")] bool CanViewAccountLink,
	[property: JsonPropertyName("accountLinks")] List<ItemModelAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("imagePreviewLinks")] List<string> ImagePreviewLinks,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("canChangeEmailPassword")] bool CanChangeEmailPassword,
	[property: JsonPropertyName("uniqueKeyExists")] bool UniqueKeyExists,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] ItemModelTags Tags,
	[property: JsonPropertyName("customFields")] ItemModelCustomFields CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<ItemModelExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] ItemModelBumpSettings BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("canShareItem")] bool CanShareItem,
	[property: JsonPropertyName("canCheckAiPrice")] bool CanCheckAiPrice,
	[property: JsonPropertyName("aiPrice")] long AiPrice,
	[property: JsonPropertyName("aiPriceCheckDate")] long AiPriceCheckDate,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("canCheckAutoBuyPrice")] bool CanCheckAutoBuyPrice,
	[property: JsonPropertyName("autoBuyPrice")] long AutoBuyPrice,
	[property: JsonPropertyName("autoBuyPriceCheckDate")] long AutoBuyPriceCheckDate,
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
		string v11 = null!;
		string v12 = null!;
		long v13 = default;
		long v14 = default;
		string v15 = null!;
		string v16 = null!;
		long v17 = default;
		long v18 = default;
		long v19 = default;
		string v20 = null!;
		string v21 = null!;
		string v22 = null!;
		string v23 = null!;
		string v24 = null!;
		string v25 = null!;
		string v26 = null!;
		string v27 = null!;
		JsonElement v28 = default;
		JsonElement v29 = default;
		long v30 = default;
		long v31 = default;
		string v32 = null!;
		string v33 = null!;
		long v34 = default;
		long v35 = default;
		string v36 = null!;
		string v37 = null!;
		long v38 = default;
		string v39 = null!;
		long v40 = default;
		long v41 = default;
		JsonElement v42 = default;
		JsonElement v43 = default;
		JsonElement v44 = default;
		bool v45 = default;
		double v46 = default;
		ItemModelGuarantee v47 = null!;
		bool v48 = default;
		bool v49 = default;
		bool v50 = default;
		bool v51 = default;
		ItemModelLoginData v52 = null!;
		bool v53 = default;
		ItemModelCopyFormatData v54 = null!;
		bool v55 = default;
		JsonElement v56 = default;
		ItemModelBuyer v57 = null!;
		bool v58 = default;
		long v59 = default;
		string v60 = null!;
		string v61 = null!;
		bool v62 = default;
		bool v63 = default;
		bool v64 = default;
		long v65 = default;
		bool v66 = default;
		List<ItemModelAccountLinks> v67 = null!;
		string v68 = null!;
		List<string> v69 = null!;
		bool v70 = default;
		bool v71 = default;
		bool v72 = default;
		string v73 = null!;
		bool v74 = default;
		bool v75 = default;
		ItemModelTags v76 = null!;
		ItemModelCustomFields v77 = null!;
		List<JsonElement> v78 = null!;
		bool v79 = default;
		bool v80 = default;
		bool v81 = default;
		long v82 = default;
		List<ItemModelExtraPrices> v83 = null!;
		bool v84 = default;
		ItemModelBumpSettings v85 = null!;
		bool v86 = default;
		bool v87 = default;
		bool v88 = default;
		long v89 = default;
		long v90 = default;
		bool v91 = default;
		bool v92 = default;
		long v93 = default;
		long v94 = default;
		string v95 = null!;
		string v96 = null!;
		string v97 = null!;
		string v98 = null!;
		ItemModelSeller v99 = null!;
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
			else if (reader.ValueTextEquals("login"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("temp_email"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("view_count"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_sticky"u8))
			{
				reader.Read();
				v14 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("information"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_origin"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("extended_guarantee"u8))
			{
				reader.Read();
				v17 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("nsb"u8))
			{
				reader.Read();
				v18 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("allow_ask_discount"u8))
			{
				reader.Read();
				v19 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title_en"u8))
			{
				reader.Read();
				v20 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description_en"u8))
			{
				reader.Read();
				v21 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("information_en"u8))
			{
				reader.Read();
				v22 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_type"u8))
			{
				reader.Read();
				v23 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("email_provider"u8))
			{
				reader.Read();
				v24 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_domain"u8))
			{
				reader.Read();
				v25 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("resale_item_origin"u8))
			{
				reader.Read();
				v26 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("note_text"u8))
			{
				reader.Read();
				v27 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("content_type"u8))
			{
				reader.Read();
				v28 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("content_id"u8))
			{
				reader.Read();
				v29 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("delete_date"u8))
			{
				reader.Read();
				v30 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("delete_user_id"u8))
			{
				reader.Read();
				v31 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("delete_username"u8))
			{
				reader.Read();
				v32 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("delete_reason"u8))
			{
				reader.Read();
				v33 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_allow_ask_discount"u8))
			{
				reader.Read();
				v34 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("max_discount_percent"u8))
			{
				reader.Read();
				v35 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("market_custom_title"u8))
			{
				reader.Read();
				v36 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("feedback_data"u8))
			{
				reader.Read();
				v37 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("buyer_display_icon_group_id"u8))
			{
				reader.Read();
				v38 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("buyer_uniq_banner"u8))
			{
				reader.Read();
				v39 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("buyer_avatar_date"u8))
			{
				reader.Read();
				v40 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("buyer_user_group_id"u8))
			{
				reader.Read();
				v41 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_fave"u8))
			{
				reader.Read();
				v42 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("in_cart"u8))
			{
				reader.Read();
				v43 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("cart_price"u8))
			{
				reader.Read();
				v44 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("canResellItem"u8))
			{
				reader.Read();
				v45 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("priceWithSellerFee"u8))
			{
				reader.Read();
				v46 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("guarantee"u8))
			{
				reader.Read();
				v47 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelGuarantee.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canViewLoginData"u8))
			{
				reader.Read();
				v48 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canUpdateItemStats"u8))
			{
				reader.Read();
				v49 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canReportItem"u8))
			{
				reader.Read();
				v50 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canViewItemViews"u8))
			{
				reader.Read();
				v51 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("loginData"u8))
			{
				reader.Read();
				v52 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelLoginData.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canViewEmailLoginData"u8))
			{
				reader.Read();
				v53 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("copyFormatData"u8))
			{
				reader.Read();
				v54 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelCopyFormatData.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("showGetEmailCodeButton"u8))
			{
				reader.Read();
				v55 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("getEmailCodeDisplayLogin"u8))
			{
				reader.Read();
				v56 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("buyer"u8))
			{
				reader.Read();
				v57 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelBuyer.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("isPersonalAccount"u8))
			{
				reader.Read();
				v58 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("rub_price"u8))
			{
				reader.Read();
				v59 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("price_currency"u8))
			{
				reader.Read();
				v60 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("priceWithSellerFeeLabel"u8))
			{
				reader.Read();
				v61 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("canValidateAccount"u8))
			{
				reader.Read();
				v62 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canResellItemAfterPurchase"u8))
			{
				reader.Read();
				v63 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isSmallExf"u8))
			{
				reader.Read();
				v64 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("account_last_activity"u8))
			{
				reader.Read();
				v65 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("canViewAccountLink"u8))
			{
				reader.Read();
				v66 = reader.GetBoolean();
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
					v67 = __lst;
				}
			}
			else if (reader.ValueTextEquals("accountLink"u8))
			{
				reader.Read();
				v68 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("imagePreviewLinks"u8))
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
					v69 = __lst;
				}
			}
			else if (reader.ValueTextEquals("canChangePassword"u8))
			{
				reader.Read();
				v70 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canChangeEmailPassword"u8))
			{
				reader.Read();
				v71 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("uniqueKeyExists"u8))
			{
				reader.Read();
				v72 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("itemOriginPhrase"u8))
			{
				reader.Read();
				v73 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("visitorIsAuthor"u8))
			{
				reader.Read();
				v74 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canAskDiscount"u8))
			{
				reader.Read();
				v75 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tags"u8))
			{
				reader.Read();
				v76 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelTags.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("customFields"u8))
			{
				reader.Read();
				v77 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelCustomFields.ReadFromReader(ref reader);
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
					v78 = __lst;
				}
			}
			else if (reader.ValueTextEquals("isTrusted"u8))
			{
				reader.Read();
				v79 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isBirthdayToday"u8))
			{
				reader.Read();
				v80 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("isIgnored"u8))
			{
				reader.Read();
				v81 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("deposit"u8))
			{
				reader.Read();
				v82 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("extraPrices"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ItemModelExtraPrices>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ItemModelExtraPrices.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v83 = __lst;
				}
			}
			else if (reader.ValueTextEquals("canViewAccountLoginAndTempEmail"u8))
			{
				reader.Read();
				v84 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("bumpSettings"u8))
			{
				reader.Read();
				v85 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelBumpSettings.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canCheckGuarantee"u8))
			{
				reader.Read();
				v86 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canShareItem"u8))
			{
				reader.Read();
				v87 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canCheckAiPrice"u8))
			{
				reader.Read();
				v88 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("aiPrice"u8))
			{
				reader.Read();
				v89 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("aiPriceCheckDate"u8))
			{
				reader.Read();
				v90 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("needToRequireVideoToViewLoginData"u8))
			{
				reader.Read();
				v91 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canCheckAutoBuyPrice"u8))
			{
				reader.Read();
				v92 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("autoBuyPrice"u8))
			{
				reader.Read();
				v93 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("autoBuyPriceCheckDate"u8))
			{
				reader.Read();
				v94 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("descriptionHtml"u8))
			{
				reader.Read();
				v95 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnHtml"u8))
			{
				reader.Read();
				v96 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionPlain"u8))
			{
				reader.Read();
				v97 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("descriptionEnPlain"u8))
			{
				reader.Read();
				v98 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("seller"u8))
			{
				reader.Read();
				v99 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelSeller.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModel(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76, v77, v78, v79, v80, v81, v82, v83, v84, v85, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99);
	}
}

public sealed record ItemModelGuarantee(
	[property: JsonPropertyName("duration")] long Duration,
	[property: JsonPropertyName("class")] string Class,
	[property: JsonPropertyName("durationPhrase")] string DurationPhrase,
	[property: JsonPropertyName("endDate")] long EndDate,
	[property: JsonPropertyName("active")] bool Active,
	[property: JsonPropertyName("cancelled")] bool Cancelled,
	[property: JsonPropertyName("remainingTime")] long RemainingTime,
	[property: JsonPropertyName("remainingTimePhrase")] string RemainingTimePhrase,
	[property: JsonPropertyName("cancelledReason")] string CancelledReason,
	[property: JsonPropertyName("cancelledReasonPhrase")] string CancelledReasonPhrase
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
		long v3 = default;
		bool v4 = default;
		bool v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
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
			else if (reader.ValueTextEquals("cancelledReason"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("cancelledReasonPhrase"u8))
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
		return new ItemModelGuarantee(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
	}
}

public sealed record ItemModelLoginData(
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
	public static ItemModelLoginData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelLoginData ReadFromReader(ref Utf8JsonReader reader)
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
		return new ItemModelLoginData(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ItemModelCopyFormatData(
	[property: JsonPropertyName("title_link")] string TitleLink,
	[property: JsonPropertyName("login_data")] string LoginData,
	[property: JsonPropertyName("full")] string Full
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
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title_link"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("login_data"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("full"u8))
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
		return new ItemModelCopyFormatData(v0, v1, v2);
	}
}

public sealed record ItemModelBuyer(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("visitorIsBuyer")] bool VisitorIsBuyer,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("display_icon_group_id")] long DisplayIconGroupId,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("uniq_banner")] string UniqBanner,
	[property: JsonPropertyName("user_group_id")] long UserGroupId
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
		string v3 = null!;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		string v7 = null!;
		string v8 = null!;
		long v9 = default;
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
			else if (reader.ValueTextEquals("display_icon_group_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("uniq_banner"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelBuyer(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
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

public sealed record ItemModelTags1234567890(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelTags1234567890 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelTags1234567890 ReadFromReader(ref Utf8JsonReader reader)
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
		return new ItemModelTags1234567890(v0, v1, v2, v3, v4);
	}
}

public sealed record ItemModelTags(
	[property: JsonPropertyName("1234567890")] ItemModelTags1234567890 _1234567890
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelTags ReadFromReader(ref Utf8JsonReader reader)
	{
		ItemModelTags1234567890 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1234567890"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelTags1234567890.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelTags(v0);
	}
}

public sealed record ItemModelCustomFields(
	[property: JsonPropertyName("_4")] string _4,
	[property: JsonPropertyName("allowSelfUnban")] List<JsonElement> AllowSelfUnban,
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("discord")] string Discord,
	[property: JsonPropertyName("github")] string Github,
	[property: JsonPropertyName("jabber")] string Jabber,
	[property: JsonPropertyName("lztUnbanAmount")] string LztUnbanAmount,
	[property: JsonPropertyName("steam")] string Steam,
	[property: JsonPropertyName("telegram")] string Telegram,
	[property: JsonPropertyName("vk")] string Vk
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelCustomFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelCustomFields ReadFromReader(ref Utf8JsonReader reader)
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
			else if (reader.ValueTextEquals("lztUnbanAmount"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("steam"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("vk"u8))
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
		return new ItemModelCustomFields(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
	}
}

public sealed record ItemModelExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price,
	[property: JsonPropertyName("priceValue")] double PriceValue
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelExtraPrices ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelExtraPrices ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		double v2 = default;
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
			else if (reader.ValueTextEquals("priceValue"u8))
			{
				reader.Read();
				v2 = reader.GetDouble();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelExtraPrices(v0, v1, v2);
	}
}

public sealed record ItemModelBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("nextAllowedBumpDate")] JsonElement NextAllowedBumpDate,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelBumpSettings ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelBumpSettings ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		JsonElement v2 = default;
		JsonElement v3 = default;
		JsonElement v4 = default;
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
			else if (reader.ValueTextEquals("nextAllowedBumpDate"u8))
			{
				reader.Read();
				v3 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("errorPhrase"u8))
			{
				reader.Read();
				v4 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelBumpSettings(v0, v1, v2, v3, v4);
	}
}

public sealed record ItemModelSellerContacts(
	[property: JsonPropertyName("ban_reason")] string BanReason,
	[property: JsonPropertyName("telegram")] string Telegram
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ItemModelSellerContacts ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ItemModelSellerContacts ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("ban_reason"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("telegram"u8))
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
		return new ItemModelSellerContacts(v0, v1);
	}
}

public sealed record ItemModelSeller(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("joined_date")] long JoinedDate,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("active_items_count")] long ActiveItemsCount,
	[property: JsonPropertyName("restore_data")] string RestoreData,
	[property: JsonPropertyName("effective_last_activity")] long EffectiveLastActivity,
	[property: JsonPropertyName("restore_percents")] JsonElement RestorePercents,
	[property: JsonPropertyName("isOnline")] bool IsOnline,
	[property: JsonPropertyName("contacts")] ItemModelSellerContacts Contacts
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
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		long v6 = default;
		long v7 = default;
		string v8 = null!;
		long v9 = default;
		JsonElement v10 = default;
		bool v11 = default;
		ItemModelSellerContacts v12 = null!;
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
			else if (reader.ValueTextEquals("effective_last_activity"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("restore_percents"u8))
			{
				reader.Read();
				v10 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("isOnline"u8))
			{
				reader.Read();
				v11 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("contacts"u8))
			{
				reader.Read();
				v12 = reader.TokenType == JsonTokenType.Null ? null! : ItemModelSellerContacts.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ItemModelSeller(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12);
	}
}

public sealed record Resp_SystemInfo(
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
		long v0 = default;
		long v1 = default;
		long v2 = default;
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
			else if (reader.ValueTextEquals("log_id"u8))
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
		return new Resp_SystemInfo(v0, v1, v2);
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
	[property: JsonPropertyName("feedback_data")] UserModelFeedbackData FeedbackData,
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
	[property: JsonPropertyName("restore_data")] UserModelRestoreData RestoreData,
	[property: JsonPropertyName("short_link")] string ShortLink,
	[property: JsonPropertyName("sold_items_count")] long SoldItemsCount,
	[property: JsonPropertyName("tags")] List<UserModelTags> Tags,
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
		UserModelFeedbackData v25 = null!;
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
		UserModelRestoreData v49 = null!;
		string v50 = null!;
		long v51 = default;
		List<UserModelTags> v52 = null!;
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
				v25 = reader.TokenType == JsonTokenType.Null ? null! : UserModelFeedbackData.ReadFromReader(ref reader);
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
				v49 = reader.TokenType == JsonTokenType.Null ? null! : UserModelRestoreData.ReadFromReader(ref reader);
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
					var __lst = new List<UserModelTags>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = UserModelTags.ReadFromReader(ref reader);
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

public sealed record UserModelFeedbackData12345(
	[property: JsonPropertyName("positive")] long Positive,
	[property: JsonPropertyName("negative")] long Negative
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelFeedbackData12345 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelFeedbackData12345 ReadFromReader(ref Utf8JsonReader reader)
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
		return new UserModelFeedbackData12345(v0, v1);
	}
}

public sealed record UserModelFeedbackData(
	[property: JsonPropertyName("12345")] UserModelFeedbackData12345 _12345
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
		UserModelFeedbackData12345 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("12345"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : UserModelFeedbackData12345.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UserModelFeedbackData(v0);
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

public sealed record UserModelRestoreData(
	[property: JsonPropertyName("12345")] long _12345
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelRestoreData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelRestoreData ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("12345"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UserModelRestoreData(v0);
	}
}

public sealed record UserModelTags(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UserModelTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UserModelTags ReadFromReader(ref Utf8JsonReader reader)
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
		return new UserModelTags(v0, v1, v2, v3, v4);
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

