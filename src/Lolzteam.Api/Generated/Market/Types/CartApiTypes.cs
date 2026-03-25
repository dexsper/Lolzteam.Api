// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class CartApiTypes
{
	public sealed record CartGetParams
	{
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
		/// Minimal price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		/// <summary>
		/// Maximum price of account (Inclusive).
		/// </summary>
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		/// <summary>
		/// The word or words contained in the account title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Order by.
		/// </summary>
		[JsonPropertyName("order_by")]
		public OrderBy? OrderBy { get; init; }
		/// <summary>
		/// List of tag ids (Tag list is available via <b>GET /me</b>).
		/// </summary>
		[JsonPropertyName("tag_id[]")]
		public List<long?>? TagId { get; init; }
		/// <summary>
		/// List of tag ids that won't be included (Tag list is available via <b>GET /me</b>).
		/// </summary>
		[JsonPropertyName("not_tag_id[]")]
		public List<long?>? NotTagId { get; init; }
		/// <summary>
		/// List of tag ids (Tag list is available via <b>GET /me</b>).
		/// </summary>
		[JsonPropertyName("public_tag_id[]")]
		public List<long?>? PublicTagId { get; init; }
		/// <summary>
		/// List of tag ids that won't be included (Tag list is available via <b>GET /me</b>).
		/// </summary>
		[JsonPropertyName("not_public_tag_id[]")]
		public List<long?>? NotPublicTagId { get; init; }
		/// <summary>
		/// List of account origins.
		/// </summary>
		[JsonPropertyName("origin[]")]
		public List<CartOrigin>? Origin { get; init; }
		/// <summary>
		/// List of account origins that won't be included.
		/// </summary>
		[JsonPropertyName("not_origin[]")]
		public List<CartNotOrigin>? NotOrigin { get; init; }
		/// <summary>
		/// Search accounts of user.
		/// </summary>
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		/// <summary>
		/// Not sold before.
		/// </summary>
		[JsonPropertyName("nsb")]
		public bool? Nsb { get; init; }
		/// <summary>
		/// Sold before.
		/// </summary>
		[JsonPropertyName("sb")]
		public bool? Sb { get; init; }
		/// <summary>
		/// Not sold by me before.
		/// </summary>
		[JsonPropertyName("nsb_by_me")]
		public bool? NsbByMe { get; init; }
		/// <summary>
		/// Sold by me before.
		/// </summary>
		[JsonPropertyName("sb_by_me")]
		public bool? SbByMe { get; init; }
		/// <summary>
		/// Currency in which the cost of the account will be searched.
		/// </summary>
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		/// <summary>
		/// Has email login data.
		/// </summary>
		[JsonPropertyName("email_login_data")]
		public bool? EmailLoginData { get; init; }
		/// <summary>
		/// Email provider.
		/// </summary>
		[JsonPropertyName("email_provider[]")]
		public List<EmailProvider>? EmailProvider { get; init; }
		/// <summary>
		/// Email provider.
		/// </summary>
		[JsonPropertyName("not_email_provider[]")]
		public NotEmailProvider? NotEmailProvider { get; init; }
		/// <summary>
		/// Parse same item ids.
		/// </summary>
		[JsonPropertyName("parse_same_item_ids")]
		public bool? ParseSameItemIds { get; init; }
	}

	public sealed record CartGetResponse(
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
		public static CartGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CartGetResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new CartGetResponse(v0, v1, v2, v3, v4, v5, v6, v7, v8);
		}
	}

	public sealed record CartAddBody
	{
		/// <summary>
		/// Item id.
		/// </summary>
		[JsonPropertyName("item_id")]
		public required long? ItemId { get; init; }
	}

	public sealed record CartAddResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CartAddResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CartAddResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			bool v0 = default;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("success"u8))
				{
					reader.Read();
					v0 = reader.GetBoolean();
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
			return new CartAddResponse(v0, v1);
		}
	}

	public sealed record CartDeleteBody
	{
		/// <summary>
		/// Item id.
		/// </summary>
		[JsonPropertyName("item_id")]
		public long? ItemId { get; init; }
	}

	public sealed record CartDeleteResponse(
		[property: JsonPropertyName("success")] bool Success,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CartDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CartDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			bool v0 = default;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("success"u8))
				{
					reader.Read();
					v0 = reader.GetBoolean();
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
			return new CartDeleteResponse(v0, v1);
		}
	}

}
