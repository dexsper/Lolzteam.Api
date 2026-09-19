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
