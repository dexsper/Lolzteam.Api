// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class NotificationsApiTypes
{
	public sealed record NotificationsListParams
	{
		[JsonPropertyName("type")]
		public NotificationsType? Type { get; init; }
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
	}

	public sealed record NotificationsListResponse(
		[property: JsonPropertyName("notifications")] List<Resp_NotificationModel> Notifications,
		[property: JsonPropertyName("notifications_total")] long NotificationsTotal,
		[property: JsonPropertyName("links")] NotificationsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static NotificationsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static NotificationsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_NotificationModel> v0 = null!;
			long v1 = default;
			NotificationsListResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("notifications"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_NotificationModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_NotificationModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("notifications_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : NotificationsListResponseLinks.ReadFromReader(ref reader);
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
			return new NotificationsListResponse(v0, v1, v2, v3);
		}
	}

public sealed record NotificationsListResponseLinks(
	[property: JsonPropertyName("read")] string Read,
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static NotificationsListResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static NotificationsListResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		long v1 = default;
		long v2 = default;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("read"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new NotificationsListResponseLinks(v0, v1, v2, v3);
	}
}

	public sealed record NotificationsGetResponse(
		[property: JsonPropertyName("notification_id")] long NotificationId,
		[property: JsonPropertyName("notification")] Resp_NotificationModel Notification,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static NotificationsGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static NotificationsGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			long v0 = default;
			Resp_NotificationModel v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("notification_id"u8))
				{
					reader.Read();
					v0 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("notification"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : Resp_NotificationModel.ReadFromReader(ref reader);
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
			return new NotificationsGetResponse(v0, v1, v2);
		}
	}

	public sealed record NotificationsReadBody
	{
		[JsonPropertyName("notification_id")]
		public long? NotificationId { get; init; }
	}

	public sealed record NotificationsReadResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static NotificationsReadResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static NotificationsReadResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new NotificationsReadResponse(v0, v1, v2);
		}
	}

}
