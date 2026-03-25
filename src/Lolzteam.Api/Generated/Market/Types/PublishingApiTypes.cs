// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class PublishingApiTypes
{
	public sealed record PublishingFastSellBody
	{
		/// <summary>
		/// Title of account. If <b>title</b> specified and <b>title_en</b> is empty, <b>title_en</b> will be automatically translated to English language.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// English title of account. If <b>title_en</b> specified and <b>title</b> is empty, <b>title</b> will be automatically translated to Russian language.
		/// </summary>
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		/// <summary>
		/// Current price of account in your currency.
		/// </summary>
		[JsonPropertyName("price")]
		public required double? Price { get; init; }
		/// <summary>
		/// Accounts category.
		/// </summary>
		[JsonPropertyName("category_id")]
		public required CategoryId CategoryId { get; init; }
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		/// <summary>
		/// Account origin. Where did you get it from.
		/// </summary>
		[JsonPropertyName("item_origin")]
		public required PublishingItemOrigin ItemOrigin { get; init; }
		/// <summary>
		/// Guarantee type.
		/// </summary>
		[JsonPropertyName("extended_guarantee")]
		public ExtendedGuarantee? ExtendedGuarantee { get; init; }
		/// <summary>
		/// Allow users to ask discount for this account.
		/// </summary>
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		/// <summary>
		/// Proxy id that will be used to check account.
		/// </summary>
		[JsonPropertyName("proxy_id")]
		public long? ProxyId { get; init; }
		/// <summary>
		/// Set this parameter to <b>true</b> so that the Market will take a random proxy from its pool for each of your requests.
		/// Otherwise, if this parameter is set to <b>false</b> or not set, the Market will take a specific proxy from its pool, which is predefined for each item.
		/// &gt; This parameter only works with proxies from the Market pool. If you want to use your own proxies, use the proxy_id or extra[proxy] parameter.
		/// </summary>
		[JsonPropertyName("random_proxy")]
		public bool? RandomProxy { get; init; }
		/// <summary>
		/// Account public description.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }
		/// <summary>
		/// Account private information (visible only for buyer).
		/// </summary>
		[JsonPropertyName("information")]
		public string? Information { get; init; }
		/// <summary>
		/// Account login (or email).
		/// </summary>
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		/// <summary>
		/// Account password.
		/// </summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
		/// <summary>
		/// Account login data (login:password format).
		/// </summary>
		[JsonPropertyName("login_password")]
		public string? LoginPassword { get; init; }
		/// <summary>
		/// Required if a <b>category</b> is one of list of Required email login data categories.
		/// </summary>
		[JsonPropertyName("has_email_login_data")]
		public bool? HasEmailLoginData { get; init; }
		/// <summary>
		/// Required if a <b>category</b> is one of list of Required email login data categories. Email login data (email:password format).
		/// </summary>
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		/// <summary>
		/// Email type.
		/// </summary>
		[JsonPropertyName("email_type")]
		public EmailType? EmailType { get; init; }
		[JsonPropertyName("extra")]
		public JsonElement? Extra { get; init; }
	}

	public sealed record PublishingFastSellResponse(
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("itemLink")] string ItemLink,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PublishingFastSellResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PublishingFastSellResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ItemModel v0 = null!;
			string v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("item"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ItemModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("itemLink"u8))
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
			return new PublishingFastSellResponse(v0, v1, v2);
		}
	}

	public sealed record PublishingAddBody
	{
		/// <summary>
		/// Title of account. If <b>title</b> specified and <b>title_en</b> is empty, <b>title_en</b> will be automatically translated to English language.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// English title of account. If <b>title_en</b> specified and <b>title</b> is empty, <b>title</b> will be automatically translated to Russian language.
		/// </summary>
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		/// <summary>
		/// Current price of account in your currency.
		/// </summary>
		[JsonPropertyName("price")]
		public required double? Price { get; init; }
		/// <summary>
		/// Accounts category.
		/// </summary>
		[JsonPropertyName("category_id")]
		public required CategoryId CategoryId { get; init; }
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		/// <summary>
		/// Account origin. Where did you get it from.
		/// </summary>
		[JsonPropertyName("item_origin")]
		public required PublishingItemOrigin ItemOrigin { get; init; }
		/// <summary>
		/// Guarantee type.
		/// </summary>
		[JsonPropertyName("extended_guarantee")]
		public ExtendedGuarantee? ExtendedGuarantee { get; init; }
		/// <summary>
		/// Account public description.
		/// </summary>
		[JsonPropertyName("description")]
		public string? Description { get; init; }
		/// <summary>
		/// Account private information (visible only for buyer).
		/// </summary>
		[JsonPropertyName("information")]
		public string? Information { get; init; }
		/// <summary>
		/// Get temporary email if not required by category. Available for Supercell, Fortnite and Epic Games categories.
		/// </summary>
		[JsonPropertyName("forceTempEmail")]
		public bool? ForceTempEmail { get; init; }
		/// <summary>
		/// Put item id, if you are trying to resell item. This is useful to pass temporary email from reselling item to new item. You will get same temporary email from reselling account.
		/// </summary>
		[JsonPropertyName("resell_item_id")]
		public long? ResellItemId { get; init; }
		/// <summary>
		/// Required if a <b>category</b> is one of list of Required email login data categories.
		/// </summary>
		[JsonPropertyName("has_email_login_data")]
		public bool? HasEmailLoginData { get; init; }
		/// <summary>
		/// Required if a <b>category</b> is one of list of Required email login data categories. Email login data (email:password format).
		/// </summary>
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		/// <summary>
		/// Email type.
		/// </summary>
		[JsonPropertyName("email_type")]
		public EmailType? EmailType { get; init; }
		/// <summary>
		/// Allow users to ask discount for this account.
		/// </summary>
		[JsonPropertyName("allow_ask_discount")]
		public bool? AllowAskDiscount { get; init; }
		/// <summary>
		/// Proxy id that will be used to check account.
		/// </summary>
		[JsonPropertyName("proxy_id")]
		public long? ProxyId { get; init; }
		/// <summary>
		/// Set this parameter to <b>true</b> so that the Market will take a random proxy from its pool for each of your requests.
		/// Otherwise, if this parameter is set to <b>false</b> or not set, the Market will take a specific proxy from its pool, which is predefined for each item.
		/// &gt; This parameter only works with proxies from the Market pool. If you want to use your own proxies, use the proxy_id or extra[proxy] parameter.
		/// </summary>
		[JsonPropertyName("random_proxy")]
		public bool? RandomProxy { get; init; }
	}

	public sealed record PublishingAddResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] ItemModel Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PublishingAddResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PublishingAddResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new PublishingAddResponse(v0, v1, v2);
		}
	}

	public sealed record PublishingCheckBody
	{
		/// <summary>
		/// Put if you are trying to resell an account.
		/// </summary>
		[JsonPropertyName("resell_item_id")]
		public long? ResellItemId { get; init; }
		/// <summary>
		/// Set this parameter to <b>true</b> so that the Market will take a random proxy from its pool for each of your requests.
		/// Otherwise, if this parameter is set to <b>false</b> or not set, the Market will take a specific proxy from its pool, which is predefined for each item.
		/// &gt; This parameter only works with proxies from the Market pool. If you want to use your own proxies, use the proxy_id or extra[proxy] parameter.
		/// </summary>
		[JsonPropertyName("random_proxy")]
		public bool? RandomProxy { get; init; }
		/// <summary>
		/// Account login (or email).
		/// </summary>
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		/// <summary>
		/// Account password.
		/// </summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
		/// <summary>
		/// Account login data (login:password format).
		/// </summary>
		[JsonPropertyName("login_password")]
		public string? LoginPassword { get; init; }
		/// <summary>
		/// Required if a <b>category</b> is one of list of Required email login data categories.
		/// </summary>
		[JsonPropertyName("has_email_login_data")]
		public bool? HasEmailLoginData { get; init; }
		/// <summary>
		/// Required if a <b>category</b> is one of list of Required email login data categories. Email login data (email:password format).
		/// </summary>
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		/// <summary>
		/// Email type.
		/// </summary>
		[JsonPropertyName("email_type")]
		public EmailType? EmailType { get; init; }
		[JsonPropertyName("extra")]
		public JsonElement? Extra { get; init; }
	}

	public sealed record PublishingCheckResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("item")] PublishingCheckResponseItem Item,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PublishingCheckResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PublishingCheckResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			PublishingCheckResponseItem v1 = null!;
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
					v1 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItem.ReadFromReader(ref reader);
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
			return new PublishingCheckResponse(v0, v1, v2);
		}
	}

public sealed record PublishingCheckResponseItemGuarantee(
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
	public static PublishingCheckResponseItemGuarantee ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemGuarantee ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemGuarantee(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record PublishingCheckResponseItemLoginData(
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
	public static PublishingCheckResponseItemLoginData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemLoginData ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemLoginData(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record PublishingCheckResponseItemEmailLoginData(
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
	public static PublishingCheckResponseItemEmailLoginData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemEmailLoginData ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemEmailLoginData(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record PublishingCheckResponseItemBuyer(
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
	public static PublishingCheckResponseItemBuyer ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemBuyer ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemBuyer(v0, v1, v2, v3, v4, v5, v6, v7);
	}
}

public sealed record PublishingCheckResponseItemAccountLinks(
	[property: JsonPropertyName("link")] string Link,
	[property: JsonPropertyName("text")] string Text,
	[property: JsonPropertyName("iconClass")] string IconClass
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PublishingCheckResponseItemAccountLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemAccountLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemAccountLinks(v0, v1, v2);
	}
}

public sealed record PublishingCheckResponseItemTags1(
	[property: JsonPropertyName("tag_id")] long TagId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("forOwnedAccountsOnly")] bool ForOwnedAccountsOnly,
	[property: JsonPropertyName("bc")] string Bc
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PublishingCheckResponseItemTags1 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemTags1 ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemTags1(v0, v1, v2, v3, v4);
	}
}

public sealed record PublishingCheckResponseItemTags(
	[property: JsonPropertyName("1")] PublishingCheckResponseItemTags1 _1
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PublishingCheckResponseItemTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemTags ReadFromReader(ref Utf8JsonReader reader)
	{
		PublishingCheckResponseItemTags1 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemTags1.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PublishingCheckResponseItemTags(v0);
	}
}

public sealed record PublishingCheckResponseItemExtraPrices(
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("price")] string Price
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PublishingCheckResponseItemExtraPrices ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemExtraPrices ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemExtraPrices(v0, v1);
	}
}

public sealed record PublishingCheckResponseItemBumpSettings(
	[property: JsonPropertyName("canBumpItem")] bool CanBumpItem,
	[property: JsonPropertyName("canBumpItemGlobally")] bool CanBumpItemGlobally,
	[property: JsonPropertyName("shortErrorPhrase")] JsonElement ShortErrorPhrase,
	[property: JsonPropertyName("errorPhrase")] JsonElement ErrorPhrase
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PublishingCheckResponseItemBumpSettings ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemBumpSettings ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemBumpSettings(v0, v1, v2, v3);
	}
}

public sealed record PublishingCheckResponseItemSeller(
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
	public static PublishingCheckResponseItemSeller ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItemSeller ReadFromReader(ref Utf8JsonReader reader)
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
		return new PublishingCheckResponseItemSeller(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record PublishingCheckResponseItem(
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
	[property: JsonPropertyName("guarantee")] PublishingCheckResponseItemGuarantee Guarantee,
	[property: JsonPropertyName("canViewLoginData")] bool CanViewLoginData,
	[property: JsonPropertyName("canUpdateItemStats")] bool CanUpdateItemStats,
	[property: JsonPropertyName("canReportItem")] bool CanReportItem,
	[property: JsonPropertyName("loginData")] PublishingCheckResponseItemLoginData LoginData,
	[property: JsonPropertyName("canViewEmailLoginData")] bool CanViewEmailLoginData,
	[property: JsonPropertyName("emailLoginData")] PublishingCheckResponseItemEmailLoginData EmailLoginData,
	[property: JsonPropertyName("showGetEmailCodeButton")] bool ShowGetEmailCodeButton,
	[property: JsonPropertyName("getEmailCodeDisplayLogin")] string GetEmailCodeDisplayLogin,
	[property: JsonPropertyName("buyer")] PublishingCheckResponseItemBuyer Buyer,
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
	[property: JsonPropertyName("accountLinks")] List<PublishingCheckResponseItemAccountLinks> AccountLinks,
	[property: JsonPropertyName("accountLink")] string AccountLink,
	[property: JsonPropertyName("emailLoginUrl")] string EmailLoginUrl,
	[property: JsonPropertyName("canChangePassword")] bool CanChangePassword,
	[property: JsonPropertyName("itemOriginPhrase")] string ItemOriginPhrase,
	[property: JsonPropertyName("visitorIsAuthor")] bool VisitorIsAuthor,
	[property: JsonPropertyName("canAskDiscount")] bool CanAskDiscount,
	[property: JsonPropertyName("tags")] PublishingCheckResponseItemTags Tags,
	[property: JsonPropertyName("customFields")] List<JsonElement> CustomFields,
	[property: JsonPropertyName("externalAuth")] List<JsonElement> ExternalAuth,
	[property: JsonPropertyName("isTrusted")] bool IsTrusted,
	[property: JsonPropertyName("isBirthdayToday")] bool IsBirthdayToday,
	[property: JsonPropertyName("isIgnored")] bool IsIgnored,
	[property: JsonPropertyName("deposit")] long Deposit,
	[property: JsonPropertyName("extraPrices")] List<PublishingCheckResponseItemExtraPrices> ExtraPrices,
	[property: JsonPropertyName("canViewAccountLoginAndTempEmail")] bool CanViewAccountLoginAndTempEmail,
	[property: JsonPropertyName("bumpSettings")] PublishingCheckResponseItemBumpSettings BumpSettings,
	[property: JsonPropertyName("canCheckGuarantee")] bool CanCheckGuarantee,
	[property: JsonPropertyName("needToRequireVideoToViewLoginData")] bool NeedToRequireVideoToViewLoginData,
	[property: JsonPropertyName("descriptionHtml")] string DescriptionHtml,
	[property: JsonPropertyName("descriptionEnHtml")] string DescriptionEnHtml,
	[property: JsonPropertyName("descriptionPlain")] string DescriptionPlain,
	[property: JsonPropertyName("descriptionEnPlain")] string DescriptionEnPlain,
	[property: JsonPropertyName("seller")] PublishingCheckResponseItemSeller Seller
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PublishingCheckResponseItem ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PublishingCheckResponseItem ReadFromReader(ref Utf8JsonReader reader)
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
		PublishingCheckResponseItemGuarantee v33 = null!;
		bool v34 = default;
		bool v35 = default;
		bool v36 = default;
		PublishingCheckResponseItemLoginData v37 = null!;
		bool v38 = default;
		PublishingCheckResponseItemEmailLoginData v39 = null!;
		bool v40 = default;
		string v41 = null!;
		PublishingCheckResponseItemBuyer v42 = null!;
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
		List<PublishingCheckResponseItemAccountLinks> v53 = null!;
		string v54 = null!;
		string v55 = null!;
		bool v56 = default;
		string v57 = null!;
		bool v58 = default;
		bool v59 = default;
		PublishingCheckResponseItemTags v60 = null!;
		List<JsonElement> v61 = null!;
		List<JsonElement> v62 = null!;
		bool v63 = default;
		bool v64 = default;
		bool v65 = default;
		long v66 = default;
		List<PublishingCheckResponseItemExtraPrices> v67 = null!;
		bool v68 = default;
		PublishingCheckResponseItemBumpSettings v69 = null!;
		bool v70 = default;
		bool v71 = default;
		string v72 = null!;
		string v73 = null!;
		string v74 = null!;
		string v75 = null!;
		PublishingCheckResponseItemSeller v76 = null!;
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
				v33 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemGuarantee.ReadFromReader(ref reader);
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
				v37 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemLoginData.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("canViewEmailLoginData"u8))
			{
				reader.Read();
				v38 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("emailLoginData"u8))
			{
				reader.Read();
				v39 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemEmailLoginData.ReadFromReader(ref reader);
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
				v42 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemBuyer.ReadFromReader(ref reader);
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
					var __lst = new List<PublishingCheckResponseItemAccountLinks>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = PublishingCheckResponseItemAccountLinks.ReadFromReader(ref reader);
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
				v60 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemTags.ReadFromReader(ref reader);
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
					var __lst = new List<PublishingCheckResponseItemExtraPrices>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = PublishingCheckResponseItemExtraPrices.ReadFromReader(ref reader);
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
				v69 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemBumpSettings.ReadFromReader(ref reader);
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
				v76 = reader.TokenType == JsonTokenType.Null ? null! : PublishingCheckResponseItemSeller.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PublishingCheckResponseItem(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74, v75, v76);
	}
}

	public sealed record PublishingExternalBody
	{
		/// <summary>
		/// External account type.
		/// </summary>
		[JsonPropertyName("type")]
		public required PublishingType Type { get; init; }
		/// <summary>
		/// Account login data (login:password format).
		/// </summary>
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		/// <summary>
		/// Email login data (email:password format).
		/// </summary>
		[JsonPropertyName("email_login_data")]
		public string? EmailLoginData { get; init; }
		/// <summary>
		/// Cookies.
		/// </summary>
		[JsonPropertyName("cookies")]
		public string? Cookies { get; init; }
	}

	public sealed record PublishingExternalResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PublishingExternalResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PublishingExternalResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new PublishingExternalResponse(v0, v1, v2);
		}
	}

}
