// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class UptimeApiTypes
{
	public sealed record UptimeInfoResponse(
		[property: JsonPropertyName("config")] UptimeInfoResponseConfig Config,
		[property: JsonPropertyName("incidents")] List<JsonElement> Incidents,
		[property: JsonPropertyName("publicGroupList")] List<UptimeInfoResponsePublicGroupList> PublicGroupList,
		[property: JsonPropertyName("maintenanceList")] List<JsonElement> MaintenanceList
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UptimeInfoResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UptimeInfoResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			UptimeInfoResponseConfig v0 = null!;
			List<JsonElement> v1 = null!;
			List<UptimeInfoResponsePublicGroupList> v2 = null!;
			List<JsonElement> v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("config"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : UptimeInfoResponseConfig.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("incidents"u8))
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
				else if (reader.ValueTextEquals("publicGroupList"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<UptimeInfoResponsePublicGroupList>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = UptimeInfoResponsePublicGroupList.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v2 = __lst;
					}
				}
				else if (reader.ValueTextEquals("maintenanceList"u8))
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
						v3 = __lst;
					}
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new UptimeInfoResponse(v0, v1, v2, v3);
		}
	}

public sealed record UptimeInfoResponseConfig(
	[property: JsonPropertyName("slug")] string Slug,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("icon")] string Icon,
	[property: JsonPropertyName("autoRefreshInterval")] long AutoRefreshInterval,
	[property: JsonPropertyName("theme")] string Theme,
	[property: JsonPropertyName("published")] bool Published,
	[property: JsonPropertyName("showTags")] bool ShowTags,
	[property: JsonPropertyName("customCSS")] string CustomCSS,
	[property: JsonPropertyName("footerText")] string FooterText,
	[property: JsonPropertyName("showPoweredBy")] bool ShowPoweredBy,
	[property: JsonPropertyName("analyticsId")] long AnalyticsId,
	[property: JsonPropertyName("analyticsScriptUrl")] string AnalyticsScriptUrl,
	[property: JsonPropertyName("analyticsType")] string AnalyticsType,
	[property: JsonPropertyName("showCertificateExpiry")] bool ShowCertificateExpiry,
	[property: JsonPropertyName("showOnlyLastHeartbeat")] bool ShowOnlyLastHeartbeat,
	[property: JsonPropertyName("rssTitle")] string RssTitle
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UptimeInfoResponseConfig ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UptimeInfoResponseConfig ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		long v4 = default;
		string v5 = null!;
		bool v6 = default;
		bool v7 = default;
		string v8 = null!;
		string v9 = null!;
		bool v10 = default;
		long v11 = default;
		string v12 = null!;
		string v13 = null!;
		bool v14 = default;
		bool v15 = default;
		string v16 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("slug"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("icon"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("autoRefreshInterval"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("theme"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("published"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("showTags"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("customCSS"u8))
			{
				reader.Read();
				v8 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("footerText"u8))
			{
				reader.Read();
				v9 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("showPoweredBy"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("analyticsId"u8))
			{
				reader.Read();
				v11 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("analyticsScriptUrl"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("analyticsType"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("showCertificateExpiry"u8))
			{
				reader.Read();
				v14 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("showOnlyLastHeartbeat"u8))
			{
				reader.Read();
				v15 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("rssTitle"u8))
			{
				reader.Read();
				v16 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UptimeInfoResponseConfig(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);
	}
}

public sealed record UptimeInfoResponsePublicGroupListMonitorList(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("sendUrl")] long SendUrl,
	[property: JsonPropertyName("type")] string Type
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UptimeInfoResponsePublicGroupListMonitorList ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UptimeInfoResponsePublicGroupListMonitorList ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		string v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("name"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sendUrl"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("type"u8))
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
		return new UptimeInfoResponsePublicGroupListMonitorList(v0, v1, v2, v3);
	}
}

public sealed record UptimeInfoResponsePublicGroupList(
	[property: JsonPropertyName("id")] long Id,
	[property: JsonPropertyName("name")] string Name,
	[property: JsonPropertyName("weight")] long Weight,
	[property: JsonPropertyName("monitorList")] List<UptimeInfoResponsePublicGroupListMonitorList> MonitorList
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UptimeInfoResponsePublicGroupList ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UptimeInfoResponsePublicGroupList ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		List<UptimeInfoResponsePublicGroupListMonitorList> v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("name"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("weight"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("monitorList"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<UptimeInfoResponsePublicGroupListMonitorList>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = UptimeInfoResponsePublicGroupListMonitorList.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v3 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new UptimeInfoResponsePublicGroupList(v0, v1, v2, v3);
	}
}

	public sealed record UptimeHeartbeatResponse(
		[property: JsonPropertyName("heartbeatList")] Dictionary<string, List<UptimeHeartbeatResponseHeartbeatList>> HeartbeatList,
		[property: JsonPropertyName("uptimeList")] Dictionary<string, double> UptimeList
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static UptimeHeartbeatResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static UptimeHeartbeatResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Dictionary<string, List<UptimeHeartbeatResponseHeartbeatList>> v0 = null!;
			Dictionary<string, double> v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("heartbeatList"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartObject)
					{
						var __dict = new Dictionary<string, List<UptimeHeartbeatResponseHeartbeatList>>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
						{
							if (reader.TokenType != JsonTokenType.PropertyName) continue;
							var __key = reader.GetString()!;
							reader.Read();
							var __val = new List<UptimeHeartbeatResponseHeartbeatList>();
							if (reader.TokenType == JsonTokenType.StartArray)
							{
								while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
								{
									var __item1 = UptimeHeartbeatResponseHeartbeatList.ReadFromReader(ref reader);
									__val.Add(__item1);
								}
							}
							__dict[__key] = __val;
						}
						v0 = __dict;
					}
				}
				else if (reader.ValueTextEquals("uptimeList"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartObject)
					{
						var __dict = new Dictionary<string, double>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
						{
							if (reader.TokenType != JsonTokenType.PropertyName) continue;
							var __key = reader.GetString()!;
							reader.Read();
							var __val = reader.GetDouble();
							__dict[__key] = __val;
						}
						v1 = __dict;
					}
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new UptimeHeartbeatResponse(v0, v1);
		}
	}

public sealed record UptimeHeartbeatResponseHeartbeatList(
	[property: JsonPropertyName("status")] long Status,
	[property: JsonPropertyName("time")] string Time,
	[property: JsonPropertyName("msg")] string Msg,
	[property: JsonPropertyName("ping")] double Ping
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static UptimeHeartbeatResponseHeartbeatList ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static UptimeHeartbeatResponseHeartbeatList ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		double v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("status"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("time"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("msg"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("ping"u8))
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
		return new UptimeHeartbeatResponseHeartbeatList(v0, v1, v2, v3);
	}
}

}
