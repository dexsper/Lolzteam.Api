// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class CustomDiscountsApiTypes
{
	public sealed record CustomDiscountsGetResponse(
		[property: JsonPropertyName("discounts")] List<DiscountModel> Discounts,
		[property: JsonPropertyName("total")] long Total,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CustomDiscountsGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CustomDiscountsGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<DiscountModel> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("discounts"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<DiscountModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = DiscountModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("total"u8))
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
			return new CustomDiscountsGetResponse(v0, v1, v2);
		}
	}

	public sealed record CustomDiscountsCreateBody
	{
		/// <summary>
		/// User ID.
		/// </summary>
		[JsonPropertyName("user_id")]
		public required long? UserId { get; init; }
		/// <summary>
		/// Accounts category.
		/// </summary>
		[JsonPropertyName("category_id")]
		public required CategoryId CategoryId { get; init; }
		/// <summary>
		/// Discount percent to apply.
		/// </summary>
		[JsonPropertyName("discount_percent")]
		public required double? DiscountPercent { get; init; }
		/// <summary>
		/// Minimum accounts price for which the discount applies.
		/// </summary>
		[JsonPropertyName("min_price")]
		public required double? MinPrice { get; init; }
		/// <summary>
		/// Maximum accounts price for which the discount applies.
		/// </summary>
		[JsonPropertyName("max_price")]
		public double? MaxPrice { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
	}

	public sealed record CustomDiscountsCreateResponse(
		[property: JsonPropertyName("discount")] DiscountModel Discount,
		[property: JsonPropertyName("total")] long Total,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CustomDiscountsCreateResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CustomDiscountsCreateResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			DiscountModel v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("discount"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : DiscountModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("total"u8))
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
			return new CustomDiscountsCreateResponse(v0, v1, v2);
		}
	}

	public sealed record CustomDiscountsEditBody
	{
		/// <summary>
		/// ID of the discount to edit.
		/// </summary>
		[JsonPropertyName("discount_id")]
		public required long? DiscountId { get; init; }
		/// <summary>
		/// Discount percent to apply.
		/// </summary>
		[JsonPropertyName("discount_percent")]
		public double? DiscountPercent { get; init; }
		/// <summary>
		/// Minimum price for which the discount applies.
		/// </summary>
		[JsonPropertyName("min_price")]
		public double? MinPrice { get; init; }
		/// <summary>
		/// Maximum price for which the discount applies.
		/// </summary>
		[JsonPropertyName("max_price")]
		public double? MaxPrice { get; init; }
	}

	public sealed record CustomDiscountsEditResponse(
		[property: JsonPropertyName("discounts")] List<DiscountModel> Discounts,
		[property: JsonPropertyName("total")] long Total,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CustomDiscountsEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CustomDiscountsEditResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<DiscountModel> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("discounts"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<DiscountModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = DiscountModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("total"u8))
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
			return new CustomDiscountsEditResponse(v0, v1, v2);
		}
	}

	public sealed record CustomDiscountsDeleteBody
	{
		/// <summary>
		/// ID of the discount to delete.
		/// </summary>
		[JsonPropertyName("discount_id")]
		public required long? DiscountId { get; init; }
	}

	public sealed record CustomDiscountsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static CustomDiscountsDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static CustomDiscountsDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new CustomDiscountsDeleteResponse(v0, v1, v2);
		}
	}

}
