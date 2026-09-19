// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class AppApiTypes
{
	public sealed record AppGetParams
	{
		[JsonPropertyName("status_code")]
		public long? StatusCode { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (StatusCode is not null)
			{
				writer.WritePropertyName("status_code"u8);
				writer.WriteNumberValue(StatusCode.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record AppGetResponse(JsonElement Data)
	{
		/// <summary>Deserialize from raw UTF-8 JSON bytes.</summary>
		public static AppGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			return new AppGetResponse(JsonDocument.ParseValue(ref reader).RootElement.Clone());
		}
	}

	public sealed record AppPushSubscriptionBody
	{
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }
		[JsonPropertyName("unsubscribed")]
		public bool? Unsubscribed { get; init; }
		[JsonPropertyName("key")]
		public string? Key { get; init; }
		[JsonPropertyName("token")]
		public string? Token { get; init; }
		[JsonPropertyName("encoding")]
		public string? Encoding { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Endpoint is not null)
			{
				writer.WritePropertyName("endpoint"u8);
				writer.WriteStringValue(Endpoint);
			}
			if (Unsubscribed is not null)
			{
				writer.WritePropertyName("unsubscribed"u8);
				writer.WriteBooleanValue(Unsubscribed.Value);
			}
			if (Key is not null)
			{
				writer.WritePropertyName("key"u8);
				writer.WriteStringValue(Key);
			}
			if (Token is not null)
			{
				writer.WritePropertyName("token"u8);
				writer.WriteStringValue(Token);
			}
			if (Encoding is not null)
			{
				writer.WritePropertyName("encoding"u8);
				writer.WriteStringValue(Encoding);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record AppPushSubscriptionResponse(JsonElement Data)
	{
		/// <summary>Deserialize from raw UTF-8 JSON bytes.</summary>
		public static AppPushSubscriptionResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			return new AppPushSubscriptionResponse(JsonDocument.ParseValue(ref reader).RootElement.Clone());
		}
	}

}
