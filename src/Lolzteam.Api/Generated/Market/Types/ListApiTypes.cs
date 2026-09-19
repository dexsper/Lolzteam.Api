// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class ListApiTypes
{
	public sealed record ListUserParams
	{
		/// <summary>
		/// User id.
		/// </summary>
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		/// <summary>
		/// Accounts category.
		/// </summary>
		[JsonPropertyName("category_id")]
		public CategoryId? CategoryId { get; init; }
		/// <summary>
		/// The number of the page to display results from.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Account status.
		/// </summary>
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		/// <summary>
		/// Delete reason. (Only if <b>show</b> is set to <b>deleted</b>)
		/// </summary>
		[JsonPropertyName("delete_reason")]
		public string? DeleteReason { get; init; }
		/// <summary>
		/// The word or words contained in the account title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Minimal price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmin")]
		public double? Pmin { get; init; }
		/// <summary>
		/// Maximum price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmax")]
		public double? Pmax { get; init; }
		/// <summary>
		/// Login.
		/// </summary>
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		/// <summary>
		/// List of account origins.
		/// </summary>
		[JsonPropertyName("origin[]")]
		public List<Origin>? Origin { get; init; }
		/// <summary>
		/// List of account origins that won't be included.
		/// </summary>
		[JsonPropertyName("not_origin[]")]
		public List<NotOrigin>? NotOrigin { get; init; }
		/// <summary>
		/// Order by.
		/// </summary>
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		/// <summary>
		/// Sold before.
		/// </summary>
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		/// <summary>
		/// Sold by me before.
		/// </summary>
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		/// <summary>
		/// Not sold before.
		/// </summary>
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		/// <summary>
		/// Not sold by me before.
		/// </summary>
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		/// <summary>
		/// Username of buyer. (If <b>show</b> is <b>paid</b>)
		/// </summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		/// <summary>
		/// Start date for filtering by publication date.
		/// </summary>
		[JsonPropertyName("published_startDate")]
		public string? PublishedStartDate { get; init; }
		/// <summary>
		/// End date for filtering by publication date.
		/// </summary>
		[JsonPropertyName("published_endDate")]
		public string? PublishedEndDate { get; init; }
		/// <summary>
		/// Enable filtering by publication date.
		/// </summary>
		[JsonPropertyName("filter_by_published_date")]
		public bool? FilterByPublishedDate { get; init; }
		/// <summary>
		/// Start date for filtering by buyer operation date.
		/// </summary>
		[JsonPropertyName("paid_startDate")]
		public string? PaidStartDate { get; init; }
		/// <summary>
		/// End date for filtering by buyer operation date.
		/// </summary>
		[JsonPropertyName("paid_endDate")]
		public string? PaidEndDate { get; init; }
		/// <summary>
		/// Enable filtering by buyer operation date.
		/// </summary>
		[JsonPropertyName("filter_by_buyer_operation_date")]
		public bool? FilterByBuyerOperationDate { get; init; }
		/// <summary>
		/// Start date for filtering by deletion date.
		/// </summary>
		[JsonPropertyName("delete_startDate")]
		public string? DeleteStartDate { get; init; }
		/// <summary>
		/// End date for filtering by deletion date.
		/// </summary>
		[JsonPropertyName("delete_endDate")]
		public string? DeleteEndDate { get; init; }
		/// <summary>
		/// Enable filtering by deletion date.
		/// </summary>
		[JsonPropertyName("filter_by_delete_date")]
		public bool? FilterByDeleteDate { get; init; }
	}

	public sealed record ListUserResponse(
		[property: JsonPropertyName("items")] List<ItemModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] long TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("totalItemsPriceWithSellerFee")] double TotalItemsPriceWithSellerFee,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("search")] string Search,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("user")] ListUserResponseUser User,
		[property: JsonPropertyName("publishedPeriodLabelPhrase")] string PublishedPeriodLabelPhrase,
		[property: JsonPropertyName("filterDatesDefault")] bool FilterDatesDefault,
		[property: JsonPropertyName("published_startDate")] string PublishedStartDate,
		[property: JsonPropertyName("published_endDate")] string PublishedEndDate,
		[property: JsonPropertyName("filter_by_published_date")] bool FilterByPublishedDate,
		[property: JsonPropertyName("published_period_label")] string PublishedPeriodLabel,
		[property: JsonPropertyName("paidPeriodLabelPhrase")] string PaidPeriodLabelPhrase,
		[property: JsonPropertyName("paid_startDate")] string PaidStartDate,
		[property: JsonPropertyName("paid_endDate")] string PaidEndDate,
		[property: JsonPropertyName("filter_by_buyer_operation_date")] bool FilterByBuyerOperationDate,
		[property: JsonPropertyName("paid_period_label")] string PaidPeriodLabel,
		[property: JsonPropertyName("deletePeriodLabelPhrase")] string DeletePeriodLabelPhrase,
		[property: JsonPropertyName("delete_startDate")] string DeleteStartDate,
		[property: JsonPropertyName("delete_endDate")] string DeleteEndDate,
		[property: JsonPropertyName("filter_by_delete_date")] bool FilterByDeleteDate,
		[property: JsonPropertyName("delete_period_label")] string DeletePeriodLabel,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ListUserResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ListUserResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ItemModel> v0 = null!;
			long v1 = default;
			long v2 = default;
			bool v3 = default;
			long v4 = default;
			long v5 = default;
			bool v6 = default;
			long v7 = default;
			long v8 = default;
			long v9 = default;
			double v10 = default;
			string v11 = null!;
			string v12 = null!;
			List<JsonElement> v13 = null!;
			ListUserResponseUser v14 = null!;
			string v15 = null!;
			bool v16 = default;
			string v17 = null!;
			string v18 = null!;
			bool v19 = default;
			string v20 = null!;
			string v21 = null!;
			string v22 = null!;
			string v23 = null!;
			bool v24 = default;
			string v25 = null!;
			string v26 = null!;
			string v27 = null!;
			string v28 = null!;
			bool v29 = default;
			string v30 = null!;
			Resp_SystemInfo v31 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("items"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ItemModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ItemModel.ReadFromReader(ref reader);
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
					v2 = reader.GetInt64();
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
				else if (reader.ValueTextEquals("wasCached"u8))
				{
					reader.Read();
					v6 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("cacheTTL"u8))
				{
					reader.Read();
					v7 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("lastModified"u8))
				{
					reader.Read();
					v8 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("serverTime"u8))
				{
					reader.Read();
					v9 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("totalItemsPriceWithSellerFee"u8))
				{
					reader.Read();
					v10 = reader.GetDouble();
				}
				else if (reader.ValueTextEquals("searchUrl"u8))
				{
					reader.Read();
					v11 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("search"u8))
				{
					reader.Read();
					v12 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("stickyItems"u8))
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
						v13 = __lst;
					}
				}
				else if (reader.ValueTextEquals("user"u8))
				{
					reader.Read();
					v14 = reader.TokenType == JsonTokenType.Null ? null! : ListUserResponseUser.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("publishedPeriodLabelPhrase"u8))
				{
					reader.Read();
					v15 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("filterDatesDefault"u8))
				{
					reader.Read();
					v16 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("published_startDate"u8))
				{
					reader.Read();
					v17 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("published_endDate"u8))
				{
					reader.Read();
					v18 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("filter_by_published_date"u8))
				{
					reader.Read();
					v19 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("published_period_label"u8))
				{
					reader.Read();
					v20 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("paidPeriodLabelPhrase"u8))
				{
					reader.Read();
					v21 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("paid_startDate"u8))
				{
					reader.Read();
					v22 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("paid_endDate"u8))
				{
					reader.Read();
					v23 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("filter_by_buyer_operation_date"u8))
				{
					reader.Read();
					v24 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("paid_period_label"u8))
				{
					reader.Read();
					v25 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("deletePeriodLabelPhrase"u8))
				{
					reader.Read();
					v26 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("delete_startDate"u8))
				{
					reader.Read();
					v27 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("delete_endDate"u8))
				{
					reader.Read();
					v28 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("filter_by_delete_date"u8))
				{
					reader.Read();
					v29 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("delete_period_label"u8))
				{
					reader.Read();
					v30 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v31 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ListUserResponse(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31);
		}
	}

public sealed record ListUserResponseUser(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("is_banned")] bool IsBanned,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListUserResponseUser ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListUserResponseUser ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		bool v4 = default;
		string v5 = null!;
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
			else if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
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
		return new ListUserResponseUser(v0, v1, v2, v3, v4, v5);
	}
}

	public sealed record ListOrdersParams
	{
		/// <summary>
		/// User id.
		/// </summary>
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		/// <summary>
		/// Accounts category.
		/// </summary>
		[JsonPropertyName("category_id")]
		public CategoryId? CategoryId { get; init; }
		/// <summary>
		/// The number of the page to display results from.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Account status.
		/// </summary>
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		/// <summary>
		/// The word or words contained in the account title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Minimal price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmin")]
		public double? Pmin { get; init; }
		/// <summary>
		/// Maximum price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmax")]
		public double? Pmax { get; init; }
		/// <summary>
		/// Login.
		/// </summary>
		[JsonPropertyName("login")]
		public string? Login { get; init; }
		/// <summary>
		/// List of account origins.
		/// </summary>
		[JsonPropertyName("origin[]")]
		public List<Origin>? Origin { get; init; }
		/// <summary>
		/// List of account origins that won't be included.
		/// </summary>
		[JsonPropertyName("not_origin[]")]
		public List<NotOrigin>? NotOrigin { get; init; }
		/// <summary>
		/// Order by.
		/// </summary>
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		/// <summary>
		/// Sold before.
		/// </summary>
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		/// <summary>
		/// Sold by me before.
		/// </summary>
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		/// <summary>
		/// Not sold before.
		/// </summary>
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		/// <summary>
		/// Not sold by me before.
		/// </summary>
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
	}

	public sealed record ListOrdersResponse(
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
		public static ListOrdersResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ListOrdersResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ListOrdersResponse(v0, v1, v2, v3, v4, v5, v6, v7, v8);
		}
	}

	public sealed record ListStatesParams
	{
		/// <summary>
		/// User ID.
		/// </summary>
		[JsonPropertyName("user_id")]
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
	}

	public sealed record ListStatesResponse(
		[property: JsonPropertyName("userItemStates")] ListStatesResponseUserItemStates UserItemStates,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ListStatesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ListStatesResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ListStatesResponseUserItemStates v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("userItemStates"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStates.ReadFromReader(ref reader);
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
			return new ListStatesResponse(v0, v1);
		}
	}

public sealed record ListStatesResponseUserItemStatesStickied(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("stickyLimit")] long StickyLimit
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesStickied ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesStickied ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		long v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("stickyLimit"u8))
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
		return new ListStatesResponseUserItemStatesStickied(v0, v1, v2, v3);
	}
}

public sealed record ListStatesResponseUserItemStatesDiscountRequest(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesDiscountRequest ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesDiscountRequest ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
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
		return new ListStatesResponseUserItemStatesDiscountRequest(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesInBuyersFavorites(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesInBuyersFavorites ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesInBuyersFavorites ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
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
		return new ListStatesResponseUserItemStatesInBuyersFavorites(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesActive(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesActive ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesActive ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_count"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
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
		return new ListStatesResponseUserItemStatesActive(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesPaid(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesPaid ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesPaid ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_count"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
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
		return new ListStatesResponseUserItemStatesPaid(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesClosed(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesClosed ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesClosed ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
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
		return new ListStatesResponseUserItemStatesClosed(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesDeleted(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesDeleted ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesDeleted ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_count"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
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
		return new ListStatesResponseUserItemStatesDeleted(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesAwaiting(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesAwaiting ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesAwaiting ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_count"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
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
		return new ListStatesResponseUserItemStatesAwaiting(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesPreActive(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesPreActive ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesPreActive ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
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
		return new ListStatesResponseUserItemStatesPreActive(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesPreUpload(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesPreUpload ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesPreUpload ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
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
		return new ListStatesResponseUserItemStatesPreUpload(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesPendingDeletion(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesPendingDeletion ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesPendingDeletion ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
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
		return new ListStatesResponseUserItemStatesPendingDeletion(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesClosedInactive(
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesClosedInactive ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesClosedInactive ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_count"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
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
		return new ListStatesResponseUserItemStatesClosedInactive(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStatesAutoBump(
	[property: JsonPropertyName("item_state")] string ItemState,
	[property: JsonPropertyName("item_count")] long ItemCount,
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStatesAutoBump ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStatesAutoBump ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("item_state"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_count"u8))
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
		return new ListStatesResponseUserItemStatesAutoBump(v0, v1, v2);
	}
}

public sealed record ListStatesResponseUserItemStates(
	[property: JsonPropertyName("stickied")] ListStatesResponseUserItemStatesStickied Stickied,
	[property: JsonPropertyName("discount_request")] ListStatesResponseUserItemStatesDiscountRequest DiscountRequest,
	[property: JsonPropertyName("in_buyers_favorites")] ListStatesResponseUserItemStatesInBuyersFavorites InBuyersFavorites,
	[property: JsonPropertyName("active")] ListStatesResponseUserItemStatesActive Active,
	[property: JsonPropertyName("paid")] ListStatesResponseUserItemStatesPaid Paid,
	[property: JsonPropertyName("closed")] ListStatesResponseUserItemStatesClosed Closed,
	[property: JsonPropertyName("deleted")] ListStatesResponseUserItemStatesDeleted Deleted,
	[property: JsonPropertyName("awaiting")] ListStatesResponseUserItemStatesAwaiting Awaiting,
	[property: JsonPropertyName("pre_active")] ListStatesResponseUserItemStatesPreActive PreActive,
	[property: JsonPropertyName("pre_upload")] ListStatesResponseUserItemStatesPreUpload PreUpload,
	[property: JsonPropertyName("pending_deletion")] ListStatesResponseUserItemStatesPendingDeletion PendingDeletion,
	[property: JsonPropertyName("closed_inactive")] ListStatesResponseUserItemStatesClosedInactive ClosedInactive,
	[property: JsonPropertyName("auto_bump")] ListStatesResponseUserItemStatesAutoBump AutoBump
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ListStatesResponseUserItemStates ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ListStatesResponseUserItemStates ReadFromReader(ref Utf8JsonReader reader)
	{
		ListStatesResponseUserItemStatesStickied v0 = null!;
		ListStatesResponseUserItemStatesDiscountRequest v1 = null!;
		ListStatesResponseUserItemStatesInBuyersFavorites v2 = null!;
		ListStatesResponseUserItemStatesActive v3 = null!;
		ListStatesResponseUserItemStatesPaid v4 = null!;
		ListStatesResponseUserItemStatesClosed v5 = null!;
		ListStatesResponseUserItemStatesDeleted v6 = null!;
		ListStatesResponseUserItemStatesAwaiting v7 = null!;
		ListStatesResponseUserItemStatesPreActive v8 = null!;
		ListStatesResponseUserItemStatesPreUpload v9 = null!;
		ListStatesResponseUserItemStatesPendingDeletion v10 = null!;
		ListStatesResponseUserItemStatesClosedInactive v11 = null!;
		ListStatesResponseUserItemStatesAutoBump v12 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("stickied"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesStickied.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("discount_request"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesDiscountRequest.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("in_buyers_favorites"u8))
			{
				reader.Read();
				v2 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesInBuyersFavorites.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("active"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesActive.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("paid"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesPaid.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("closed"u8))
			{
				reader.Read();
				v5 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesClosed.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("deleted"u8))
			{
				reader.Read();
				v6 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesDeleted.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("awaiting"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesAwaiting.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("pre_active"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesPreActive.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("pre_upload"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesPreUpload.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("pending_deletion"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesPendingDeletion.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("closed_inactive"u8))
			{
				reader.Read();
				v11 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesClosedInactive.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("auto_bump"u8))
			{
				reader.Read();
				v12 = reader.TokenType == JsonTokenType.Null ? null! : ListStatesResponseUserItemStatesAutoBump.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ListStatesResponseUserItemStates(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12);
	}
}

	public sealed record ListDownloadParams
	{
		/// <summary>
		/// Format of the downloaded accounts.
		/// </summary>
		[JsonPropertyName("format")]
		public Format? Format { get; init; }
		/// <summary>
		/// Custom format string for download. (Required if <b>format</b> is set to <b>custom</b>)
		/// </summary>
		[JsonPropertyName("custom_format")]
		public string? CustomFormat { get; init; }
		/// <summary>
		/// Accounts category.
		/// </summary>
		[JsonPropertyName("category_id")]
		public CategoryId? CategoryId { get; init; }
		/// <summary>
		/// The number of the page to display results from.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Account status.
		/// </summary>
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		/// <summary>
		/// Delete reason. (Only if <b>show</b> is set to <b>deleted</b>)
		/// </summary>
		[JsonPropertyName("delete_reason")]
		public string? DeleteReason { get; init; }
		/// <summary>
		/// The word or words contained in the account title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Minimal price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmin")]
		public double? Pmin { get; init; }
		/// <summary>
		/// Maximum price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmax")]
		public double? Pmax { get; init; }
		/// <summary>
		/// List of account origins.
		/// </summary>
		[JsonPropertyName("origin[]")]
		public List<Origin>? Origin { get; init; }
		/// <summary>
		/// List of account origins that won't be included.
		/// </summary>
		[JsonPropertyName("not_origin[]")]
		public List<NotOrigin>? NotOrigin { get; init; }
		/// <summary>
		/// Order by.
		/// </summary>
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		/// <summary>
		/// Sold before.
		/// </summary>
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		/// <summary>
		/// Sold by me before.
		/// </summary>
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		/// <summary>
		/// Not sold before.
		/// </summary>
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		/// <summary>
		/// Not sold by me before.
		/// </summary>
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		/// <summary>
		/// Username of buyer. (If <b>show</b> is <b>paid</b>)
		/// </summary>
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		/// <summary>
		/// Start date for filtering by publication date.
		/// </summary>
		[JsonPropertyName("published_startDate")]
		public string? PublishedStartDate { get; init; }
		/// <summary>
		/// End date for filtering by publication date.
		/// </summary>
		[JsonPropertyName("published_endDate")]
		public string? PublishedEndDate { get; init; }
		/// <summary>
		/// Enable filtering by publication date.
		/// </summary>
		[JsonPropertyName("filter_by_published_date")]
		public bool? FilterByPublishedDate { get; init; }
		/// <summary>
		/// Start date for filtering by buyer operation date.
		/// </summary>
		[JsonPropertyName("paid_startDate")]
		public string? PaidStartDate { get; init; }
		/// <summary>
		/// End date for filtering by buyer operation date.
		/// </summary>
		[JsonPropertyName("paid_endDate")]
		public string? PaidEndDate { get; init; }
		/// <summary>
		/// Enable filtering by buyer operation date.
		/// </summary>
		[JsonPropertyName("filter_by_buyer_operation_date")]
		public bool? FilterByBuyerOperationDate { get; init; }
		/// <summary>
		/// Start date for filtering by deletion date.
		/// </summary>
		[JsonPropertyName("delete_startDate")]
		public string? DeleteStartDate { get; init; }
		/// <summary>
		/// End date for filtering by deletion date.
		/// </summary>
		[JsonPropertyName("delete_endDate")]
		public string? DeleteEndDate { get; init; }
		/// <summary>
		/// Enable filtering by deletion date.
		/// </summary>
		[JsonPropertyName("filter_by_delete_date")]
		public bool? FilterByDeleteDate { get; init; }
	}

	public sealed record ListDownloadResponse(string Data);

	public sealed record ListFavoritesParams
	{
		/// <summary>
		/// The number of the page to display results from.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Account status.
		/// </summary>
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		/// <summary>
		/// The word or words contained in the account title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Minimal price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmin")]
		public double? Pmin { get; init; }
		/// <summary>
		/// Maximum price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmax")]
		public double? Pmax { get; init; }
		/// <summary>
		/// List of account origins.
		/// </summary>
		[JsonPropertyName("origin[]")]
		public List<Origin>? Origin { get; init; }
		/// <summary>
		/// List of account origins that won't be included.
		/// </summary>
		[JsonPropertyName("not_origin[]")]
		public List<NotOrigin>? NotOrigin { get; init; }
		/// <summary>
		/// Order by.
		/// </summary>
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		/// <summary>
		/// Sold before.
		/// </summary>
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		/// <summary>
		/// Sold by me before.
		/// </summary>
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		/// <summary>
		/// Not sold before.
		/// </summary>
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		/// <summary>
		/// Not sold by me before.
		/// </summary>
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
	}

	public sealed record ListFavoritesResponse(
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
		public static ListFavoritesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ListFavoritesResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ListFavoritesResponse(v0, v1, v2, v3, v4, v5, v6, v7, v8);
		}
	}

	public sealed record ListViewedParams
	{
		/// <summary>
		/// The number of the page to display results from.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Account status.
		/// </summary>
		[JsonPropertyName("show")]
		public Show? Show { get; init; }
		/// <summary>
		/// The word or words contained in the account title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Minimal price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmin")]
		public double? Pmin { get; init; }
		/// <summary>
		/// Maximum price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmax")]
		public double? Pmax { get; init; }
		/// <summary>
		/// List of account origins.
		/// </summary>
		[JsonPropertyName("origin[]")]
		public List<Origin>? Origin { get; init; }
		/// <summary>
		/// List of account origins that won't be included.
		/// </summary>
		[JsonPropertyName("not_origin[]")]
		public List<NotOrigin>? NotOrigin { get; init; }
		/// <summary>
		/// Order by.
		/// </summary>
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		/// <summary>
		/// Sold before.
		/// </summary>
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		/// <summary>
		/// Sold by me before.
		/// </summary>
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		/// <summary>
		/// Not sold before.
		/// </summary>
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		/// <summary>
		/// Not sold by me before.
		/// </summary>
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
	}

	public sealed record ListViewedResponse(
		[property: JsonPropertyName("items")] List<ItemModel> Items,
		[property: JsonPropertyName("totalItems")] long TotalItems,
		[property: JsonPropertyName("totalItemsPrice")] JsonElement TotalItemsPrice,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("wasCached")] bool WasCached,
		[property: JsonPropertyName("cacheTTL")] long CacheTTL,
		[property: JsonPropertyName("lastModified")] long LastModified,
		[property: JsonPropertyName("serverTime")] long ServerTime,
		[property: JsonPropertyName("searchUrl")] string SearchUrl,
		[property: JsonPropertyName("search")] string Search,
		[property: JsonPropertyName("stickyItems")] List<JsonElement> StickyItems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ListViewedResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ListViewedResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ItemModel> v0 = null!;
			long v1 = default;
			JsonElement v2 = default;
			bool v3 = default;
			long v4 = default;
			long v5 = default;
			bool v6 = default;
			long v7 = default;
			long v8 = default;
			long v9 = default;
			string v10 = null!;
			string v11 = null!;
			List<JsonElement> v12 = null!;
			Resp_SystemInfo v13 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("items"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ItemModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ItemModel.ReadFromReader(ref reader);
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
				else if (reader.ValueTextEquals("wasCached"u8))
				{
					reader.Read();
					v6 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("cacheTTL"u8))
				{
					reader.Read();
					v7 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("lastModified"u8))
				{
					reader.Read();
					v8 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("serverTime"u8))
				{
					reader.Read();
					v9 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("searchUrl"u8))
				{
					reader.Read();
					v10 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("search"u8))
				{
					reader.Read();
					v11 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("stickyItems"u8))
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
						v12 = __lst;
					}
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v13 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new ListViewedResponse(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13);
		}
	}

}
