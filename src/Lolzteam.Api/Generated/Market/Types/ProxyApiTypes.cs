// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class ProxyApiTypes
{
	public sealed record ProxyGetResponse(
		[property: JsonPropertyName("proxies")] List<ProxyGetResponseProxies> Proxies,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProxyGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProxyGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ProxyGetResponseProxies> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("proxies"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ProxyGetResponseProxies>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ProxyGetResponseProxies.ReadFromReader(ref reader);
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
			return new ProxyGetResponse(v0, v1);
		}
	}

public sealed record ProxyGetResponseProxiesProxy(
	[property: JsonPropertyName("proxy_id")] long ProxyId,
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("proxy_ip")] string ProxyIp,
	[property: JsonPropertyName("proxy_port")] long ProxyPort,
	[property: JsonPropertyName("proxy_user")] string ProxyUser,
	[property: JsonPropertyName("proxy_pass")] string ProxyPass,
	[property: JsonPropertyName("proxyString")] string ProxyString
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProxyGetResponseProxiesProxy ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProxyGetResponseProxiesProxy ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		long v3 = default;
		string v4 = null!;
		string v5 = null!;
		string v6 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("proxy_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("user_id"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("proxy_ip"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("proxy_port"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("proxy_user"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("proxy_pass"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("proxyString"u8))
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
		return new ProxyGetResponseProxiesProxy(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ProxyGetResponseProxies(
	[property: JsonPropertyName("proxy")] ProxyGetResponseProxiesProxy Proxy
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ProxyGetResponseProxies ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ProxyGetResponseProxies ReadFromReader(ref Utf8JsonReader reader)
	{
		ProxyGetResponseProxiesProxy v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("proxy"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ProxyGetResponseProxiesProxy.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ProxyGetResponseProxies(v0);
	}
}

	public sealed record ProxyAddBody
	{
		[JsonPropertyName("proxy_ip")]
		public string? ProxyIp { get; init; }
		[JsonPropertyName("proxy_port")]
		public long? ProxyPort { get; init; }
		[JsonPropertyName("proxy_user")]
		public string? ProxyUser { get; init; }
		[JsonPropertyName("proxy_pass")]
		public string? ProxyPass { get; init; }
		[JsonPropertyName("proxy_row")]
		public string? ProxyRow { get; init; }
	}

	public sealed record ProxyAddResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProxyAddResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProxyAddResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ProxyAddResponse(v0, v1, v2);
		}
	}

	public sealed record ProxyDeleteBody
	{
		[JsonPropertyName("proxy_id")]
		public long? ProxyId { get; init; }
		[JsonPropertyName("delete_all")]
		public bool? DeleteAll { get; init; }
	}

	public sealed record ProxyDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ProxyDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ProxyDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ProxyDeleteResponse(v0, v1, v2);
		}
	}

}
