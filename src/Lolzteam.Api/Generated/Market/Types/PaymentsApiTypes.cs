// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class PaymentsApiTypes
{
	public sealed record PaymentsInvoiceGetParams
	{
		[JsonPropertyName("invoice_id")]
		public long? InvoiceId { get; init; }
		[JsonPropertyName("payment_id")]
		public string? PaymentId { get; init; }
	}

	public sealed record PaymentsInvoiceGetResponse(
		[property: JsonPropertyName("invoice")] InvoiceModel Invoice,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsInvoiceGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsInvoiceGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			InvoiceModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("invoice"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : InvoiceModel.ReadFromReader(ref reader);
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
			return new PaymentsInvoiceGetResponse(v0, v1);
		}
	}

	public sealed record PaymentsInvoiceCreateBody
	{
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		[JsonPropertyName("amount")]
		public required double? Amount { get; init; }
		[JsonPropertyName("payment_id")]
		public required string PaymentId { get; init; }
		[JsonPropertyName("comment")]
		public required string Comment { get; init; }
		[JsonPropertyName("url_success")]
		public required string UrlSuccess { get; init; }
		[JsonPropertyName("url_callback")]
		public string? UrlCallback { get; init; }
		[JsonPropertyName("merchant_id")]
		public required long? MerchantId { get; init; }
		[JsonPropertyName("required_telegram_id")]
		public long? RequiredTelegramId { get; init; }
		[JsonPropertyName("required_telegram_username")]
		public string? RequiredTelegramUsername { get; init; }
		/// <summary>Default: 3600</summary>
		[JsonPropertyName("lifetime")]
		public double? Lifetime { get; init; } = 3600;
		[JsonPropertyName("additional_data")]
		public string? AdditionalData { get; init; }
		[JsonPropertyName("is_test")]
		public bool? IsTest { get; init; }
	}

	public sealed record PaymentsInvoiceCreateResponse(
		[property: JsonPropertyName("invoice")] InvoiceModel Invoice,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsInvoiceCreateResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsInvoiceCreateResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			InvoiceModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("invoice"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : InvoiceModel.ReadFromReader(ref reader);
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
			return new PaymentsInvoiceCreateResponse(v0, v1);
		}
	}

	public sealed record PaymentsInvoiceListParams
	{
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("status")]
		public Status? Status { get; init; }
		[JsonPropertyName("amount")]
		public double? Amount { get; init; }
		[JsonPropertyName("merchant_id")]
		public long? MerchantId { get; init; }
	}

	public sealed record PaymentsInvoiceListResponse(
		[property: JsonPropertyName("invoices")] List<InvoiceModel> Invoices,
		[property: JsonPropertyName("count")] long Count,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("perPage")] long PerPage,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsInvoiceListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsInvoiceListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<InvoiceModel> v0 = null!;
			long v1 = default;
			long v2 = default;
			long v3 = default;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("invoices"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<InvoiceModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = InvoiceModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("count"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("page"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("perPage"u8))
				{
					reader.Read();
					v3 = reader.GetInt64();
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
			return new PaymentsInvoiceListResponse(v0, v1, v2, v3, v4);
		}
	}

	public sealed record PaymentsCurrencyResponse(
		[property: JsonPropertyName("currencyList")] PaymentsCurrencyResponseCurrencyList CurrencyList,
		[property: JsonPropertyName("lastUpdate")] long LastUpdate,
		[property: JsonPropertyName("visitorCurrency")] string VisitorCurrency,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsCurrencyResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsCurrencyResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			PaymentsCurrencyResponseCurrencyList v0 = null!;
			long v1 = default;
			string v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("currencyList"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyList.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("lastUpdate"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("visitorCurrency"u8))
				{
					reader.Read();
					v2 = reader.GetString()!;
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
			return new PaymentsCurrencyResponse(v0, v1, v2, v3);
		}
	}

public sealed record PaymentsCurrencyResponseCurrencyListBTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListBTC ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListBTC ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListBTC(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListETH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListETH ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListETH ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListETH(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListBNB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListBNB ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListBNB ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListBNB(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListBCH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListBCH ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListBCH ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListBCH(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListXMR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListXMR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListXMR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListXMR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListSOL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListSOL ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListSOL ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListSOL(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListLTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListLTC ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListLTC ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListLTC(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListDASH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListDASH ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListDASH ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListDASH(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListTON(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListTON ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListTON ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListTON(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListUSDT(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListUSDT ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListUSDT ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListUSDT(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListMATIC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListMATIC ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListMATIC ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListMATIC(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListTRX(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListTRX ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListTRX ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListTRX(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListDOGE(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListDOGE ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListDOGE ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListDOGE(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListKWD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListKWD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListKWD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListKWD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListGBP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListGBP ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListGBP ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListGBP(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListCHF(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListCHF ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListCHF ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListCHF(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListEUR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListEUR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListEUR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListEUR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListUSD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListUSD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListUSD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListUSD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListSGD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListSGD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListSGD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListSGD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListCAD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListCAD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListCAD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListCAD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListAUD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListAUD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListAUD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListAUD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListNZD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListNZD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListNZD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListNZD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListBGN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListBGN ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListBGN ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListBGN(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListGEL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListGEL ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListGEL ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListGEL(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListILS(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListILS ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListILS ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListILS(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListQAR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListQAR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListQAR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListQAR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListPEN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListPEN ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListPEN ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListPEN(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListAED(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListAED ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListAED ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListAED(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListSAR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListSAR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListSAR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListSAR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListPLN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListPLN ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListPLN ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListPLN(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListMYR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListMYR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListMYR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListMYR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListRON(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListRON ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListRON ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListRON(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListBRL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListBRL ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListBRL ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListBRL(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListDKK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListDKK ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListDKK ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListDKK(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListCNY(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListCNY ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListCNY ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListCNY(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListHKD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListHKD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListHKD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListHKD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListSEK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListSEK ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListSEK ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListSEK(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListNOK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListNOK ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListNOK ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListNOK(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListZAR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListZAR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListZAR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListZAR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListMXN(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListMXN ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListMXN ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListMXN(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListCZK(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListCZK ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListCZK ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListCZK(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListTWD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListTWD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListTWD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListTWD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListTHB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListTHB ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListTHB ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListTHB(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListTRY(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListTRY ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListTRY ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListTRY(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListUAH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListUAH ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListUAH ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListUAH(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListUYU(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListUYU ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListUYU ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListUYU(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListPHP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListPHP ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListPHP ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListPHP(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListINR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListINR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListINR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListINR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListRUB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] long Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListRUB ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListRUB ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListRUB(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListRSD(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListRSD ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListRSD ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListRSD(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListJPY(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListJPY ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListJPY ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListJPY(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListHUF(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListHUF ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListHUF ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListHUF(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListKZT(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListKZT ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListKZT ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListKZT(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListCRC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListCRC ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListCRC ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListCRC(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListCLP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListCLP ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListCLP ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListCLP(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListARS(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListARS ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListARS ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListARS(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListKRW(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListKRW ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListKRW ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListKRW(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListCOP(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListCOP ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListCOP ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListCOP(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListIDR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListIDR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListIDR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListIDR(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyListVND(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("rate")] double Rate,
	[property: JsonPropertyName("formattedRate")] string FormattedRate,
	[property: JsonPropertyName("symbol")] string Symbol
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyListVND ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyListVND ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		double v1 = default;
		string v2 = null!;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("rate"u8))
			{
				reader.Read();
				v1 = reader.GetDouble();
			}
			else if (reader.ValueTextEquals("formattedRate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("symbol"u8))
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
		return new PaymentsCurrencyResponseCurrencyListVND(v0, v1, v2, v3);
	}
}

public sealed record PaymentsCurrencyResponseCurrencyList(
	[property: JsonPropertyName("BTC")] PaymentsCurrencyResponseCurrencyListBTC BTC,
	[property: JsonPropertyName("ETH")] PaymentsCurrencyResponseCurrencyListETH ETH,
	[property: JsonPropertyName("BNB")] PaymentsCurrencyResponseCurrencyListBNB BNB,
	[property: JsonPropertyName("BCH")] PaymentsCurrencyResponseCurrencyListBCH BCH,
	[property: JsonPropertyName("XMR")] PaymentsCurrencyResponseCurrencyListXMR XMR,
	[property: JsonPropertyName("SOL")] PaymentsCurrencyResponseCurrencyListSOL SOL,
	[property: JsonPropertyName("LTC")] PaymentsCurrencyResponseCurrencyListLTC LTC,
	[property: JsonPropertyName("DASH")] PaymentsCurrencyResponseCurrencyListDASH DASH,
	[property: JsonPropertyName("TON")] PaymentsCurrencyResponseCurrencyListTON TON,
	[property: JsonPropertyName("USDT")] PaymentsCurrencyResponseCurrencyListUSDT USDT,
	[property: JsonPropertyName("MATIC")] PaymentsCurrencyResponseCurrencyListMATIC MATIC,
	[property: JsonPropertyName("TRX")] PaymentsCurrencyResponseCurrencyListTRX TRX,
	[property: JsonPropertyName("DOGE")] PaymentsCurrencyResponseCurrencyListDOGE DOGE,
	[property: JsonPropertyName("KWD")] PaymentsCurrencyResponseCurrencyListKWD KWD,
	[property: JsonPropertyName("GBP")] PaymentsCurrencyResponseCurrencyListGBP GBP,
	[property: JsonPropertyName("CHF")] PaymentsCurrencyResponseCurrencyListCHF CHF,
	[property: JsonPropertyName("EUR")] PaymentsCurrencyResponseCurrencyListEUR EUR,
	[property: JsonPropertyName("USD")] PaymentsCurrencyResponseCurrencyListUSD USD,
	[property: JsonPropertyName("SGD")] PaymentsCurrencyResponseCurrencyListSGD SGD,
	[property: JsonPropertyName("CAD")] PaymentsCurrencyResponseCurrencyListCAD CAD,
	[property: JsonPropertyName("AUD")] PaymentsCurrencyResponseCurrencyListAUD AUD,
	[property: JsonPropertyName("NZD")] PaymentsCurrencyResponseCurrencyListNZD NZD,
	[property: JsonPropertyName("BGN")] PaymentsCurrencyResponseCurrencyListBGN BGN,
	[property: JsonPropertyName("GEL")] PaymentsCurrencyResponseCurrencyListGEL GEL,
	[property: JsonPropertyName("ILS")] PaymentsCurrencyResponseCurrencyListILS ILS,
	[property: JsonPropertyName("QAR")] PaymentsCurrencyResponseCurrencyListQAR QAR,
	[property: JsonPropertyName("PEN")] PaymentsCurrencyResponseCurrencyListPEN PEN,
	[property: JsonPropertyName("AED")] PaymentsCurrencyResponseCurrencyListAED AED,
	[property: JsonPropertyName("SAR")] PaymentsCurrencyResponseCurrencyListSAR SAR,
	[property: JsonPropertyName("PLN")] PaymentsCurrencyResponseCurrencyListPLN PLN,
	[property: JsonPropertyName("MYR")] PaymentsCurrencyResponseCurrencyListMYR MYR,
	[property: JsonPropertyName("RON")] PaymentsCurrencyResponseCurrencyListRON RON,
	[property: JsonPropertyName("BRL")] PaymentsCurrencyResponseCurrencyListBRL BRL,
	[property: JsonPropertyName("DKK")] PaymentsCurrencyResponseCurrencyListDKK DKK,
	[property: JsonPropertyName("CNY")] PaymentsCurrencyResponseCurrencyListCNY CNY,
	[property: JsonPropertyName("HKD")] PaymentsCurrencyResponseCurrencyListHKD HKD,
	[property: JsonPropertyName("SEK")] PaymentsCurrencyResponseCurrencyListSEK SEK,
	[property: JsonPropertyName("NOK")] PaymentsCurrencyResponseCurrencyListNOK NOK,
	[property: JsonPropertyName("ZAR")] PaymentsCurrencyResponseCurrencyListZAR ZAR,
	[property: JsonPropertyName("MXN")] PaymentsCurrencyResponseCurrencyListMXN MXN,
	[property: JsonPropertyName("CZK")] PaymentsCurrencyResponseCurrencyListCZK CZK,
	[property: JsonPropertyName("TWD")] PaymentsCurrencyResponseCurrencyListTWD TWD,
	[property: JsonPropertyName("THB")] PaymentsCurrencyResponseCurrencyListTHB THB,
	[property: JsonPropertyName("TRY")] PaymentsCurrencyResponseCurrencyListTRY TRY,
	[property: JsonPropertyName("UAH")] PaymentsCurrencyResponseCurrencyListUAH UAH,
	[property: JsonPropertyName("UYU")] PaymentsCurrencyResponseCurrencyListUYU UYU,
	[property: JsonPropertyName("PHP")] PaymentsCurrencyResponseCurrencyListPHP PHP,
	[property: JsonPropertyName("INR")] PaymentsCurrencyResponseCurrencyListINR INR,
	[property: JsonPropertyName("RUB")] PaymentsCurrencyResponseCurrencyListRUB RUB,
	[property: JsonPropertyName("RSD")] PaymentsCurrencyResponseCurrencyListRSD RSD,
	[property: JsonPropertyName("JPY")] PaymentsCurrencyResponseCurrencyListJPY JPY,
	[property: JsonPropertyName("HUF")] PaymentsCurrencyResponseCurrencyListHUF HUF,
	[property: JsonPropertyName("KZT")] PaymentsCurrencyResponseCurrencyListKZT KZT,
	[property: JsonPropertyName("CRC")] PaymentsCurrencyResponseCurrencyListCRC CRC,
	[property: JsonPropertyName("CLP")] PaymentsCurrencyResponseCurrencyListCLP CLP,
	[property: JsonPropertyName("ARS")] PaymentsCurrencyResponseCurrencyListARS ARS,
	[property: JsonPropertyName("KRW")] PaymentsCurrencyResponseCurrencyListKRW KRW,
	[property: JsonPropertyName("COP")] PaymentsCurrencyResponseCurrencyListCOP COP,
	[property: JsonPropertyName("IDR")] PaymentsCurrencyResponseCurrencyListIDR IDR,
	[property: JsonPropertyName("VND")] PaymentsCurrencyResponseCurrencyListVND VND
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsCurrencyResponseCurrencyList ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsCurrencyResponseCurrencyList ReadFromReader(ref Utf8JsonReader reader)
	{
		PaymentsCurrencyResponseCurrencyListBTC v0 = null!;
		PaymentsCurrencyResponseCurrencyListETH v1 = null!;
		PaymentsCurrencyResponseCurrencyListBNB v2 = null!;
		PaymentsCurrencyResponseCurrencyListBCH v3 = null!;
		PaymentsCurrencyResponseCurrencyListXMR v4 = null!;
		PaymentsCurrencyResponseCurrencyListSOL v5 = null!;
		PaymentsCurrencyResponseCurrencyListLTC v6 = null!;
		PaymentsCurrencyResponseCurrencyListDASH v7 = null!;
		PaymentsCurrencyResponseCurrencyListTON v8 = null!;
		PaymentsCurrencyResponseCurrencyListUSDT v9 = null!;
		PaymentsCurrencyResponseCurrencyListMATIC v10 = null!;
		PaymentsCurrencyResponseCurrencyListTRX v11 = null!;
		PaymentsCurrencyResponseCurrencyListDOGE v12 = null!;
		PaymentsCurrencyResponseCurrencyListKWD v13 = null!;
		PaymentsCurrencyResponseCurrencyListGBP v14 = null!;
		PaymentsCurrencyResponseCurrencyListCHF v15 = null!;
		PaymentsCurrencyResponseCurrencyListEUR v16 = null!;
		PaymentsCurrencyResponseCurrencyListUSD v17 = null!;
		PaymentsCurrencyResponseCurrencyListSGD v18 = null!;
		PaymentsCurrencyResponseCurrencyListCAD v19 = null!;
		PaymentsCurrencyResponseCurrencyListAUD v20 = null!;
		PaymentsCurrencyResponseCurrencyListNZD v21 = null!;
		PaymentsCurrencyResponseCurrencyListBGN v22 = null!;
		PaymentsCurrencyResponseCurrencyListGEL v23 = null!;
		PaymentsCurrencyResponseCurrencyListILS v24 = null!;
		PaymentsCurrencyResponseCurrencyListQAR v25 = null!;
		PaymentsCurrencyResponseCurrencyListPEN v26 = null!;
		PaymentsCurrencyResponseCurrencyListAED v27 = null!;
		PaymentsCurrencyResponseCurrencyListSAR v28 = null!;
		PaymentsCurrencyResponseCurrencyListPLN v29 = null!;
		PaymentsCurrencyResponseCurrencyListMYR v30 = null!;
		PaymentsCurrencyResponseCurrencyListRON v31 = null!;
		PaymentsCurrencyResponseCurrencyListBRL v32 = null!;
		PaymentsCurrencyResponseCurrencyListDKK v33 = null!;
		PaymentsCurrencyResponseCurrencyListCNY v34 = null!;
		PaymentsCurrencyResponseCurrencyListHKD v35 = null!;
		PaymentsCurrencyResponseCurrencyListSEK v36 = null!;
		PaymentsCurrencyResponseCurrencyListNOK v37 = null!;
		PaymentsCurrencyResponseCurrencyListZAR v38 = null!;
		PaymentsCurrencyResponseCurrencyListMXN v39 = null!;
		PaymentsCurrencyResponseCurrencyListCZK v40 = null!;
		PaymentsCurrencyResponseCurrencyListTWD v41 = null!;
		PaymentsCurrencyResponseCurrencyListTHB v42 = null!;
		PaymentsCurrencyResponseCurrencyListTRY v43 = null!;
		PaymentsCurrencyResponseCurrencyListUAH v44 = null!;
		PaymentsCurrencyResponseCurrencyListUYU v45 = null!;
		PaymentsCurrencyResponseCurrencyListPHP v46 = null!;
		PaymentsCurrencyResponseCurrencyListINR v47 = null!;
		PaymentsCurrencyResponseCurrencyListRUB v48 = null!;
		PaymentsCurrencyResponseCurrencyListRSD v49 = null!;
		PaymentsCurrencyResponseCurrencyListJPY v50 = null!;
		PaymentsCurrencyResponseCurrencyListHUF v51 = null!;
		PaymentsCurrencyResponseCurrencyListKZT v52 = null!;
		PaymentsCurrencyResponseCurrencyListCRC v53 = null!;
		PaymentsCurrencyResponseCurrencyListCLP v54 = null!;
		PaymentsCurrencyResponseCurrencyListARS v55 = null!;
		PaymentsCurrencyResponseCurrencyListKRW v56 = null!;
		PaymentsCurrencyResponseCurrencyListCOP v57 = null!;
		PaymentsCurrencyResponseCurrencyListIDR v58 = null!;
		PaymentsCurrencyResponseCurrencyListVND v59 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("BTC"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListBTC.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("ETH"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListETH.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("BNB"u8))
			{
				reader.Read();
				v2 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListBNB.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("BCH"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListBCH.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("XMR"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListXMR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("SOL"u8))
			{
				reader.Read();
				v5 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListSOL.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("LTC"u8))
			{
				reader.Read();
				v6 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListLTC.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("DASH"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListDASH.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("TON"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListTON.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("USDT"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListUSDT.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("MATIC"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListMATIC.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("TRX"u8))
			{
				reader.Read();
				v11 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListTRX.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("DOGE"u8))
			{
				reader.Read();
				v12 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListDOGE.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("KWD"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListKWD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("GBP"u8))
			{
				reader.Read();
				v14 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListGBP.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("CHF"u8))
			{
				reader.Read();
				v15 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListCHF.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("EUR"u8))
			{
				reader.Read();
				v16 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListEUR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("USD"u8))
			{
				reader.Read();
				v17 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListUSD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("SGD"u8))
			{
				reader.Read();
				v18 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListSGD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("CAD"u8))
			{
				reader.Read();
				v19 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListCAD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("AUD"u8))
			{
				reader.Read();
				v20 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListAUD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("NZD"u8))
			{
				reader.Read();
				v21 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListNZD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("BGN"u8))
			{
				reader.Read();
				v22 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListBGN.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("GEL"u8))
			{
				reader.Read();
				v23 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListGEL.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("ILS"u8))
			{
				reader.Read();
				v24 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListILS.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("QAR"u8))
			{
				reader.Read();
				v25 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListQAR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("PEN"u8))
			{
				reader.Read();
				v26 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListPEN.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("AED"u8))
			{
				reader.Read();
				v27 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListAED.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("SAR"u8))
			{
				reader.Read();
				v28 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListSAR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("PLN"u8))
			{
				reader.Read();
				v29 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListPLN.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("MYR"u8))
			{
				reader.Read();
				v30 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListMYR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("RON"u8))
			{
				reader.Read();
				v31 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListRON.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("BRL"u8))
			{
				reader.Read();
				v32 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListBRL.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("DKK"u8))
			{
				reader.Read();
				v33 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListDKK.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("CNY"u8))
			{
				reader.Read();
				v34 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListCNY.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("HKD"u8))
			{
				reader.Read();
				v35 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListHKD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("SEK"u8))
			{
				reader.Read();
				v36 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListSEK.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("NOK"u8))
			{
				reader.Read();
				v37 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListNOK.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("ZAR"u8))
			{
				reader.Read();
				v38 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListZAR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("MXN"u8))
			{
				reader.Read();
				v39 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListMXN.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("CZK"u8))
			{
				reader.Read();
				v40 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListCZK.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("TWD"u8))
			{
				reader.Read();
				v41 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListTWD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("THB"u8))
			{
				reader.Read();
				v42 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListTHB.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("TRY"u8))
			{
				reader.Read();
				v43 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListTRY.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("UAH"u8))
			{
				reader.Read();
				v44 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListUAH.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("UYU"u8))
			{
				reader.Read();
				v45 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListUYU.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("PHP"u8))
			{
				reader.Read();
				v46 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListPHP.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("INR"u8))
			{
				reader.Read();
				v47 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListINR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("RUB"u8))
			{
				reader.Read();
				v48 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListRUB.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("RSD"u8))
			{
				reader.Read();
				v49 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListRSD.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("JPY"u8))
			{
				reader.Read();
				v50 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListJPY.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("HUF"u8))
			{
				reader.Read();
				v51 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListHUF.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("KZT"u8))
			{
				reader.Read();
				v52 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListKZT.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("CRC"u8))
			{
				reader.Read();
				v53 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListCRC.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("CLP"u8))
			{
				reader.Read();
				v54 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListCLP.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("ARS"u8))
			{
				reader.Read();
				v55 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListARS.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("KRW"u8))
			{
				reader.Read();
				v56 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListKRW.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("COP"u8))
			{
				reader.Read();
				v57 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListCOP.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("IDR"u8))
			{
				reader.Read();
				v58 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListIDR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("VND"u8))
			{
				reader.Read();
				v59 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsCurrencyResponseCurrencyListVND.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsCurrencyResponseCurrencyList(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);
	}
}

	public sealed record PaymentsBalanceListResponse(
		[property: JsonPropertyName("from")] PaymentsBalanceListResponseFrom From,
		[property: JsonPropertyName("to")] PaymentsBalanceListResponseTo To,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsBalanceListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsBalanceListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			PaymentsBalanceListResponseFrom v0 = null!;
			PaymentsBalanceListResponseTo v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("from"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsBalanceListResponseFrom.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("to"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsBalanceListResponseTo.ReadFromReader(ref reader);
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
			return new PaymentsBalanceListResponse(v0, v1, v2);
		}
	}

public sealed record PaymentsBalanceListResponseFromBalance(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("convertedBalance")] long ConvertedBalance,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsBalanceListResponseFromBalance ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsBalanceListResponseFromBalance ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("convertedBalance"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("fullTitle"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("type"u8))
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
		return new PaymentsBalanceListResponseFromBalance(v0, v1, v2, v3, v4);
	}
}

public sealed record PaymentsBalanceListResponseFrom(
	[property: JsonPropertyName("balance")] PaymentsBalanceListResponseFromBalance Balance,
	[property: JsonPropertyName("12345")] BalanceModel _12345
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsBalanceListResponseFrom ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsBalanceListResponseFrom ReadFromReader(ref Utf8JsonReader reader)
	{
		PaymentsBalanceListResponseFromBalance v0 = null!;
		BalanceModel v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsBalanceListResponseFromBalance.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("12345"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : BalanceModel.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsBalanceListResponseFrom(v0, v1);
	}
}

public sealed record PaymentsBalanceListResponseTo(
	[property: JsonPropertyName("balance")] UserModel Balance
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsBalanceListResponseTo ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsBalanceListResponseTo ReadFromReader(ref Utf8JsonReader reader)
	{
		UserModel v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : UserModel.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsBalanceListResponseTo(v0);
	}
}

	public sealed record PaymentsBalanceExchangeBody
	{
		[JsonPropertyName("from_balance")]
		public required string FromBalance { get; init; }
		[JsonPropertyName("to_balance")]
		public required string ToBalance { get; init; }
		[JsonPropertyName("amount")]
		public required long? Amount { get; init; }
	}

	public sealed record PaymentsBalanceExchangeResponse(
		[property: JsonPropertyName("from")] PaymentsBalanceExchangeResponseFrom From,
		[property: JsonPropertyName("to")] PaymentsBalanceExchangeResponseTo To,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsBalanceExchangeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsBalanceExchangeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			PaymentsBalanceExchangeResponseFrom v0 = null!;
			PaymentsBalanceExchangeResponseTo v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("from"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsBalanceExchangeResponseFrom.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("to"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsBalanceExchangeResponseTo.ReadFromReader(ref reader);
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
			return new PaymentsBalanceExchangeResponse(v0, v1, v2);
		}
	}

public sealed record PaymentsBalanceExchangeResponseFromBalance(
	[property: JsonPropertyName("balance")] string Balance,
	[property: JsonPropertyName("convertedBalance")] long ConvertedBalance,
	[property: JsonPropertyName("fullTitle")] string FullTitle,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("type")] string Type
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsBalanceExchangeResponseFromBalance ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsBalanceExchangeResponseFromBalance ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("convertedBalance"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("fullTitle"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("type"u8))
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
		return new PaymentsBalanceExchangeResponseFromBalance(v0, v1, v2, v3, v4);
	}
}

public sealed record PaymentsBalanceExchangeResponseFrom(
	[property: JsonPropertyName("balance")] PaymentsBalanceExchangeResponseFromBalance Balance,
	[property: JsonPropertyName("12345")] BalanceModel _12345
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsBalanceExchangeResponseFrom ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsBalanceExchangeResponseFrom ReadFromReader(ref Utf8JsonReader reader)
	{
		PaymentsBalanceExchangeResponseFromBalance v0 = null!;
		BalanceModel v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsBalanceExchangeResponseFromBalance.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("12345"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : BalanceModel.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsBalanceExchangeResponseFrom(v0, v1);
	}
}

public sealed record PaymentsBalanceExchangeResponseTo(
	[property: JsonPropertyName("balance")] UserModel Balance
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsBalanceExchangeResponseTo ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsBalanceExchangeResponseTo ReadFromReader(ref Utf8JsonReader reader)
	{
		UserModel v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("balance"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : UserModel.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsBalanceExchangeResponseTo(v0);
	}
}

	public sealed record PaymentsTransferBody
	{
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		[JsonPropertyName("username")]
		public string? Username { get; init; }
		[JsonPropertyName("amount")]
		public required long? Amount { get; init; }
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		[JsonPropertyName("comment")]
		public string? Comment { get; init; }
		[JsonPropertyName("telegram_deal")]
		public bool? TelegramDeal { get; init; }
		[JsonPropertyName("telegram_username")]
		public string? TelegramUsername { get; init; }
		[JsonPropertyName("transfer_hold")]
		public bool? TransferHold { get; init; }
		[JsonPropertyName("hold_length_value")]
		public long? HoldLengthValue { get; init; }
		[JsonPropertyName("hold_length_option")]
		public HoldLengthOption? HoldLengthOption { get; init; }
	}

	public sealed record PaymentsTransferResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsTransferResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsTransferResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new PaymentsTransferResponse(v0, v1, v2);
		}
	}

	public sealed record PaymentsFeeParams
	{
		[JsonPropertyName("amount")]
		public double? Amount { get; init; }
	}

	public sealed record PaymentsFeeResponse(
		[property: JsonPropertyName("commission_percentage")] long CommissionPercentage,
		[property: JsonPropertyName("spentCurrentMonth")] long SpentCurrentMonth,
		[property: JsonPropertyName("calculator")] PaymentsFeeResponseCalculator Calculator,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsFeeResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsFeeResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			long v1 = default;
			PaymentsFeeResponseCalculator v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("commission_percentage"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("spentCurrentMonth"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("calculator"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsFeeResponseCalculator.ReadFromReader(ref reader);
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
			return new PaymentsFeeResponse(v0, v1, v2, v3);
		}
	}

public sealed record PaymentsFeeResponseCalculator(
	[property: JsonPropertyName("inputAmount")] long InputAmount,
	[property: JsonPropertyName("commissionAmount")] long CommissionAmount,
	[property: JsonPropertyName("totalOutputAmount")] long TotalOutputAmount
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsFeeResponseCalculator ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsFeeResponseCalculator ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		long v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("inputAmount"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("commissionAmount"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("totalOutputAmount"u8))
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
		return new PaymentsFeeResponseCalculator(v0, v1, v2);
	}
}

	public sealed record PaymentsCancelBody
	{
		[JsonPropertyName("payment_id")]
		public required long? PaymentId { get; init; }
	}

	public sealed record PaymentsCancelResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsCancelResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsCancelResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new PaymentsCancelResponse(v0, v1, v2);
		}
	}

	public sealed record PaymentsHistoryParams
	{
		[JsonPropertyName("type")]
		public PaymentsType? Type { get; init; }
		[JsonPropertyName("pmin")]
		public long? Pmin { get; init; }
		[JsonPropertyName("pmax")]
		public long? Pmax { get; init; }
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("operation_id_lt")]
		public long? OperationIdLt { get; init; }
		[JsonPropertyName("receiver")]
		public string? Receiver { get; init; }
		[JsonPropertyName("sender")]
		public string? Sender { get; init; }
		[JsonPropertyName("is_api")]
		public bool? IsApi { get; init; }
		[JsonPropertyName("startDate")]
		public string? StartDate { get; init; }
		[JsonPropertyName("endDate")]
		public string? EndDate { get; init; }
		[JsonPropertyName("wallet")]
		public string? Wallet { get; init; }
		[JsonPropertyName("comment")]
		public string? Comment { get; init; }
		[JsonPropertyName("is_hold")]
		public bool? IsHold { get; init; }
		[JsonPropertyName("show_payment_stats")]
		public bool? ShowPaymentStats { get; init; }
	}

	public sealed record PaymentsHistoryResponse(
		[property: JsonPropertyName("payments")] PaymentsHistoryResponsePayments Payments,
		[property: JsonPropertyName("perPage")] string PerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("pageNavLink")] string PageNavLink,
		[property: JsonPropertyName("pageNavParams")] PaymentsHistoryResponsePageNavParams PageNavParams,
		[property: JsonPropertyName("periodLabel")] string PeriodLabel,
		[property: JsonPropertyName("periodLabelPhrase")] string PeriodLabelPhrase,
		[property: JsonPropertyName("filterDatesDefault")] bool FilterDatesDefault,
		[property: JsonPropertyName("input")] PaymentsHistoryResponseInput Input,
		[property: JsonPropertyName("paymentStats")] JsonElement PaymentStats,
		[property: JsonPropertyName("hasNextPage")] bool HasNextPage,
		[property: JsonPropertyName("lastOperationId")] long LastOperationId,
		[property: JsonPropertyName("nextPageHref")] string NextPageHref,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsHistoryResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsHistoryResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			PaymentsHistoryResponsePayments v0 = null!;
			string v1 = null!;
			long v2 = default;
			string v3 = null!;
			PaymentsHistoryResponsePageNavParams v4 = null!;
			string v5 = null!;
			string v6 = null!;
			bool v7 = default;
			PaymentsHistoryResponseInput v8 = null!;
			JsonElement v9 = default;
			bool v10 = default;
			long v11 = default;
			string v12 = null!;
			Resp_SystemInfo v13 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("payments"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponsePayments.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("perPage"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("page"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("pageNavLink"u8))
				{
					reader.Read();
					v3 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("pageNavParams"u8))
				{
					reader.Read();
					v4 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponsePageNavParams.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("periodLabel"u8))
				{
					reader.Read();
					v5 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("periodLabelPhrase"u8))
				{
					reader.Read();
					v6 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("filterDatesDefault"u8))
				{
					reader.Read();
					v7 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("input"u8))
				{
					reader.Read();
					v8 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponseInput.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("paymentStats"u8))
				{
					reader.Read();
					v9 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
				}
				else if (reader.ValueTextEquals("hasNextPage"u8))
				{
					reader.Read();
					v10 = reader.GetBoolean();
				}
				else if (reader.ValueTextEquals("lastOperationId"u8))
				{
					reader.Read();
					v11 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("nextPageHref"u8))
				{
					reader.Read();
					v12 = reader.GetString()!;
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
			return new PaymentsHistoryResponse(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13);
		}
	}

public sealed record PaymentsHistoryResponsePayments1234567890Data(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("comment")] string Comment,
	[property: JsonPropertyName("fee")] long Fee,
	[property: JsonPropertyName("invoice_id")] long InvoiceId,
	[property: JsonPropertyName("is_test")] bool IsTest,
	[property: JsonPropertyName("payment_id")] string PaymentId,
	[property: JsonPropertyName("commentPlain")] string CommentPlain,
	[property: JsonPropertyName("is_banned")] long IsBanned,
	[property: JsonPropertyName("display_style_group_id")] long DisplayStyleGroupId,
	[property: JsonPropertyName("uniq_username_css")] string UniqUsernameCss,
	[property: JsonPropertyName("uniq_banner")] string UniqBanner,
	[property: JsonPropertyName("avatar_date")] long AvatarDate,
	[property: JsonPropertyName("user_group_id")] long UserGroupId,
	[property: JsonPropertyName("username_html")] string UsernameHtml,
	[property: JsonPropertyName("avatar")] string Avatar
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponsePayments1234567890Data ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponsePayments1234567890Data ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		bool v5 = default;
		string v6 = null!;
		string v7 = null!;
		long v8 = default;
		long v9 = default;
		string v10 = null!;
		string v11 = null!;
		long v12 = default;
		long v13 = default;
		string v14 = null!;
		string v15 = null!;
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
			else if (reader.ValueTextEquals("comment"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("fee"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("invoice_id"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_test"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("payment_id"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("commentPlain"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_banned"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("display_style_group_id"u8))
			{
				reader.Read();
				v9 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("uniq_username_css"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("uniq_banner"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar_date"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_group_id"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("username_html"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsHistoryResponsePayments1234567890Data(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
	}
}

public sealed record PaymentsHistoryResponsePayments1234567890Label(
	[property: JsonPropertyName("title")] string Title
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponsePayments1234567890Label ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponsePayments1234567890Label ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
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
		return new PaymentsHistoryResponsePayments1234567890Label(v0);
	}
}

public sealed record PaymentsHistoryResponsePayments1234567890Merchant(
	[property: JsonPropertyName("merchant_id")] long MerchantId,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("created_date")] long CreatedDate,
	[property: JsonPropertyName("secret_key")] string SecretKey,
	[property: JsonPropertyName("avatar_data")] string AvatarData,
	[property: JsonPropertyName("url")] string Url
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponsePayments1234567890Merchant ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponsePayments1234567890Merchant ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("merchant_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("name"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("created_date"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("secret_key"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("avatar_data"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("url"u8))
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
		return new PaymentsHistoryResponsePayments1234567890Merchant(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record PaymentsHistoryResponsePayments1234567890User(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("user_balance")] string UserBalance,
	[property: JsonPropertyName("user_hold")] string UserHold,
	[property: JsonPropertyName("user_balance_with_hold")] double UserBalanceWithHold
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponsePayments1234567890User ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponsePayments1234567890User ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		double v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_balance"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_hold"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("user_balance_with_hold"u8))
			{
				reader.Read();
				v3 = reader.GetDouble();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsHistoryResponsePayments1234567890User(v0, v1, v2, v3);
	}
}

public sealed record PaymentsHistoryResponsePayments1234567890(
	[property: JsonPropertyName("operation_id")] long OperationId,
	[property: JsonPropertyName("operation_date")] long OperationDate,
	[property: JsonPropertyName("operation_type")] string OperationType,
	[property: JsonPropertyName("outgoing_sum")] string OutgoingSum,
	[property: JsonPropertyName("incoming_sum")] string IncomingSum,
	[property: JsonPropertyName("item_id")] long ItemId,
	[property: JsonPropertyName("wallet")] string Wallet,
	[property: JsonPropertyName("is_finished")] long IsFinished,
	[property: JsonPropertyName("is_hold")] long IsHold,
	[property: JsonPropertyName("payment_system")] string PaymentSystem,
	[property: JsonPropertyName("data")] PaymentsHistoryResponsePayments1234567890Data Data,
	[property: JsonPropertyName("hold_end_date")] long HoldEndDate,
	[property: JsonPropertyName("operation_end_date")] long OperationEndDate,
	[property: JsonPropertyName("api")] long Api,
	[property: JsonPropertyName("sum")] string Sum,
	[property: JsonPropertyName("payment_status")] string PaymentStatus,
	[property: JsonPropertyName("supportLink")] JsonElement SupportLink,
	[property: JsonPropertyName("paymentSystemIcons")] List<JsonElement> PaymentSystemIcons,
	[property: JsonPropertyName("canCancelPaidMailPayment")] bool CanCancelPaidMailPayment,
	[property: JsonPropertyName("canCancelBalanceTransfer")] bool CanCancelBalanceTransfer,
	[property: JsonPropertyName("canCancelBalancePayout")] bool CanCancelBalancePayout,
	[property: JsonPropertyName("canCancelBalanceHold")] bool CanCancelBalanceHold,
	[property: JsonPropertyName("canFinishBalanceTransfer")] bool CanFinishBalanceTransfer,
	[property: JsonPropertyName("canFinishBalancePayout")] bool CanFinishBalancePayout,
	[property: JsonPropertyName("canFinishBalanceHold")] bool CanFinishBalanceHold,
	[property: JsonPropertyName("label")] PaymentsHistoryResponsePayments1234567890Label Label,
	[property: JsonPropertyName("merchant")] PaymentsHistoryResponsePayments1234567890Merchant Merchant,
	[property: JsonPropertyName("user")] PaymentsHistoryResponsePayments1234567890User User
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponsePayments1234567890 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponsePayments1234567890 ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		long v5 = default;
		string v6 = null!;
		long v7 = default;
		long v8 = default;
		string v9 = null!;
		PaymentsHistoryResponsePayments1234567890Data v10 = null!;
		long v11 = default;
		long v12 = default;
		long v13 = default;
		string v14 = null!;
		string v15 = null!;
		JsonElement v16 = default;
		List<JsonElement> v17 = null!;
		bool v18 = default;
		bool v19 = default;
		bool v20 = default;
		bool v21 = default;
		bool v22 = default;
		bool v23 = default;
		bool v24 = default;
		PaymentsHistoryResponsePayments1234567890Label v25 = null!;
		PaymentsHistoryResponsePayments1234567890Merchant v26 = null!;
		PaymentsHistoryResponsePayments1234567890User v27 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("operation_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("operation_date"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("operation_type"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("outgoing_sum"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("incoming_sum"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("item_id"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("wallet"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_finished"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("is_hold"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("payment_system"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("data"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponsePayments1234567890Data.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("hold_end_date"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("operation_end_date"u8))
			{
				reader.Read();
				v12 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("api"u8))
			{
				reader.Read();
				v13 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("sum"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("payment_status"u8))
			{
				reader.Read();
				v15 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("supportLink"u8))
			{
				reader.Read();
				v16 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else if (reader.ValueTextEquals("paymentSystemIcons"u8))
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
					v17 = __lst;
				}
			}
			else if (reader.ValueTextEquals("canCancelPaidMailPayment"u8))
			{
				reader.Read();
				v18 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canCancelBalanceTransfer"u8))
			{
				reader.Read();
				v19 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canCancelBalancePayout"u8))
			{
				reader.Read();
				v20 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canCancelBalanceHold"u8))
			{
				reader.Read();
				v21 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canFinishBalanceTransfer"u8))
			{
				reader.Read();
				v22 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canFinishBalancePayout"u8))
			{
				reader.Read();
				v23 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("canFinishBalanceHold"u8))
			{
				reader.Read();
				v24 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("label"u8))
			{
				reader.Read();
				v25 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponsePayments1234567890Label.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("merchant"u8))
			{
				reader.Read();
				v26 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponsePayments1234567890Merchant.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("user"u8))
			{
				reader.Read();
				v27 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponsePayments1234567890User.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsHistoryResponsePayments1234567890(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27);
	}
}

public sealed record PaymentsHistoryResponsePayments(
	[property: JsonPropertyName("1234567890")] PaymentsHistoryResponsePayments1234567890 _1234567890
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponsePayments ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponsePayments ReadFromReader(ref Utf8JsonReader reader)
	{
		PaymentsHistoryResponsePayments1234567890 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("1234567890"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsHistoryResponsePayments1234567890.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsHistoryResponsePayments(v0);
	}
}

public sealed record PaymentsHistoryResponsePageNavParams(
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("startDate")] string StartDate,
	[property: JsonPropertyName("endDate")] string EndDate
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponsePageNavParams ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponsePageNavParams ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("type"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("startDate"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("endDate"u8))
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
		return new PaymentsHistoryResponsePageNavParams(v0, v1, v2);
	}
}

public sealed record PaymentsHistoryResponseInput(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("type")] string Type,
	[property: JsonPropertyName("startDate")] string StartDate,
	[property: JsonPropertyName("endDate")] string EndDate,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("period_label")] string PeriodLabel,
	[property: JsonPropertyName("receiver")] string Receiver,
	[property: JsonPropertyName("sender")] string Sender,
	[property: JsonPropertyName("comment")] string Comment,
	[property: JsonPropertyName("pmin")] string Pmin,
	[property: JsonPropertyName("pmax")] string Pmax,
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("wallet")] string Wallet,
	[property: JsonPropertyName("is_hold")] bool IsHold,
	[property: JsonPropertyName("currency")] string Currency,
	[property: JsonPropertyName("operation_id_lt")] long OperationIdLt
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsHistoryResponseInput ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsHistoryResponseInput ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		long v4 = default;
		string v5 = null!;
		string v6 = null!;
		string v7 = null!;
		string v8 = null!;
		string v9 = null!;
		string v10 = null!;
		long v11 = default;
		string v12 = null!;
		bool v13 = default;
		string v14 = null!;
		long v15 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("type"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("startDate"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("endDate"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("period_label"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("receiver"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sender"u8))
			{
				reader.Read();
				v7 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("comment"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("pmin"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("pmax"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("wallet"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("is_hold"u8))
			{
				reader.Read();
				v13 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("currency"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("operation_id_lt"u8))
			{
				reader.Read();
				v15 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsHistoryResponseInput(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
	}
}

	public sealed record PaymentsPayoutServicesResponse(
		[property: JsonPropertyName("systems")] List<PaymentsPayoutServicesResponseSystems> Systems,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsPayoutServicesResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsPayoutServicesResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<PaymentsPayoutServicesResponseSystems> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("systems"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<PaymentsPayoutServicesResponseSystems>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = PaymentsPayoutServicesResponseSystems.ReadFromReader(ref reader);
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
			return new PaymentsPayoutServicesResponse(v0, v1);
		}
	}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersBEP20(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersBEP20 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersBEP20 ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersBEP20(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersTRC20(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersTRC20 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersTRC20 ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersTRC20(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersERC20(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersERC20 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersERC20 ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersERC20(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersTRX(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersTRX ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersTRX ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersTRX(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersBTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersBTC ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersBTC ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersBTC(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersTON(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersTON ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersTON ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersTON(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersETH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersETH ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersETH ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersETH(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersLTC(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersLTC ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersLTC ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersLTC(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersBNB(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersBNB ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersBNB ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersBNB(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersDASH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersDASH ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersDASH ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersDASH(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersDOGE(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersDOGE ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersDOGE ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersDOGE(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersXMR(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersXMR ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersXMR ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersXMR(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersSOL(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersSOL ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersSOL ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersSOL(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProvidersBCH(
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isUnavailable")] bool IsUnavailable
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProvidersBCH ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProvidersBCH ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isUnavailable"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProvidersBCH(v0, v1);
	}
}

public sealed record PaymentsPayoutServicesResponseSystemsProviders(
	[property: JsonPropertyName("BEP20")] PaymentsPayoutServicesResponseSystemsProvidersBEP20 BEP20,
	[property: JsonPropertyName("TRC20")] PaymentsPayoutServicesResponseSystemsProvidersTRC20 TRC20,
	[property: JsonPropertyName("ERC20")] PaymentsPayoutServicesResponseSystemsProvidersERC20 ERC20,
	[property: JsonPropertyName("TRX")] PaymentsPayoutServicesResponseSystemsProvidersTRX TRX,
	[property: JsonPropertyName("BTC")] PaymentsPayoutServicesResponseSystemsProvidersBTC BTC,
	[property: JsonPropertyName("TON")] PaymentsPayoutServicesResponseSystemsProvidersTON TON,
	[property: JsonPropertyName("ETH")] PaymentsPayoutServicesResponseSystemsProvidersETH ETH,
	[property: JsonPropertyName("LTC")] PaymentsPayoutServicesResponseSystemsProvidersLTC LTC,
	[property: JsonPropertyName("BNB")] PaymentsPayoutServicesResponseSystemsProvidersBNB BNB,
	[property: JsonPropertyName("DASH")] PaymentsPayoutServicesResponseSystemsProvidersDASH DASH,
	[property: JsonPropertyName("DOGE")] PaymentsPayoutServicesResponseSystemsProvidersDOGE DOGE,
	[property: JsonPropertyName("XMR")] PaymentsPayoutServicesResponseSystemsProvidersXMR XMR,
	[property: JsonPropertyName("SOL")] PaymentsPayoutServicesResponseSystemsProvidersSOL SOL,
	[property: JsonPropertyName("BCH")] PaymentsPayoutServicesResponseSystemsProvidersBCH BCH
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystemsProviders ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystemsProviders ReadFromReader(ref Utf8JsonReader reader)
	{
		PaymentsPayoutServicesResponseSystemsProvidersBEP20 v0 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersTRC20 v1 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersERC20 v2 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersTRX v3 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersBTC v4 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersTON v5 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersETH v6 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersLTC v7 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersBNB v8 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersDASH v9 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersDOGE v10 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersXMR v11 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersSOL v12 = null!;
		PaymentsPayoutServicesResponseSystemsProvidersBCH v13 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("BEP20"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersBEP20.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("TRC20"u8))
			{
				reader.Read();
				v1 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersTRC20.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("ERC20"u8))
			{
				reader.Read();
				v2 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersERC20.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("TRX"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersTRX.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("BTC"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersBTC.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("TON"u8))
			{
				reader.Read();
				v5 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersTON.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("ETH"u8))
			{
				reader.Read();
				v6 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersETH.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("LTC"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersLTC.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("BNB"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersBNB.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("DASH"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersDASH.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("DOGE"u8))
			{
				reader.Read();
				v10 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersDOGE.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("XMR"u8))
			{
				reader.Read();
				v11 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersXMR.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("SOL"u8))
			{
				reader.Read();
				v12 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersSOL.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("BCH"u8))
			{
				reader.Read();
				v13 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProvidersBCH.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystemsProviders(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13);
	}
}

public sealed record PaymentsPayoutServicesResponseSystems(
	[property: JsonPropertyName("system")] string System,
	[property: JsonPropertyName("commission")] string Commission,
	[property: JsonPropertyName("min")] long Min,
	[property: JsonPropertyName("max")] long Max,
	[property: JsonPropertyName("instant_payout")] bool InstantPayout,
	[property: JsonPropertyName("problematic_payout")] bool ProblematicPayout,
	[property: JsonPropertyName("is_unavailable")] bool IsUnavailable,
	[property: JsonPropertyName("p2p")] bool P2p,
	[property: JsonPropertyName("has_wallet")] bool HasWallet,
	[property: JsonPropertyName("providers")] PaymentsPayoutServicesResponseSystemsProviders Providers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static PaymentsPayoutServicesResponseSystems ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static PaymentsPayoutServicesResponseSystems ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
		bool v7 = default;
		bool v8 = default;
		PaymentsPayoutServicesResponseSystemsProviders v9 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("system"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("commission"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("min"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("max"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("instant_payout"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("problematic_payout"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("is_unavailable"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("p2p"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("has_wallet"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("providers"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : PaymentsPayoutServicesResponseSystemsProviders.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new PaymentsPayoutServicesResponseSystems(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
	}
}

	public sealed record PaymentsPayoutBody
	{
		[JsonPropertyName("payment_system")]
		public required string PaymentSystem { get; init; }
		[JsonPropertyName("wallet")]
		public required string Wallet { get; init; }
		[JsonPropertyName("amount")]
		public required double? Amount { get; init; }
		[JsonPropertyName("currency")]
		public required Currency Currency { get; init; }
		[JsonPropertyName("include_fee")]
		public bool? IncludeFee { get; init; }
		[JsonPropertyName("extra")]
		public JsonElement? Extra { get; init; }
	}

	public sealed record PaymentsPayoutResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static PaymentsPayoutResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static PaymentsPayoutResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new PaymentsPayoutResponse(v0, v1, v2);
		}
	}

}
