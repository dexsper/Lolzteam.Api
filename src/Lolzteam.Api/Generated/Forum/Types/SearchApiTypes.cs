// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class SearchApiTypes
{
	public sealed record SearchAllBody
	{
		/// <summary>
		/// Search query. Can be skipped if <b>user_id</b> is set.
		/// </summary>
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		/// <summary>
		/// Tag to search for tagged contents.
		/// </summary>
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		/// <summary>
		/// Id of the container forum to search for contents. Child forums of the specified forum will be included in the search.
		/// </summary>
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
		/// <summary>
		/// Page number of results.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of results in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// The time in milliseconds (e.g. 1767214800) before last content date.
		/// </summary>
		[JsonPropertyName("before")]
		public long? Before { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Q is not null)
			{
				writer.WritePropertyName("q"u8);
				writer.WriteStringValue(Q);
			}
			if (Tag is not null)
			{
				writer.WritePropertyName("tag"u8);
				writer.WriteStringValue(Tag);
			}
			if (ForumId is not null)
			{
				writer.WritePropertyName("forum_id"u8);
				writer.WriteNumberValue(ForumId.Value);
			}
			if (UserId is not null)
			{
				writer.WritePropertyName("user_id"u8);
				UserId.Value.WriteTo(writer);
			}
			if (Page is not null)
			{
				writer.WritePropertyName("page"u8);
				writer.WriteNumberValue(Page.Value);
			}
			if (Limit is not null)
			{
				writer.WritePropertyName("limit"u8);
				writer.WriteNumberValue(Limit.Value);
			}
			if (Before is not null)
			{
				writer.WritePropertyName("before"u8);
				writer.WriteNumberValue(Before.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record SearchAllResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("users")] List<Resp_UserModel>? Users,
		[property: JsonPropertyName("links")] SearchAllResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static SearchAllResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static SearchAllResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<JsonElement> v0 = null!;
			long v1 = default;
			List<Resp_UserModel> v2 = null!;
			SearchAllResponseLinks v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
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
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_UserModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_UserModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v2 = __lst;
					}
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : SearchAllResponseLinks.ReadFromReader(ref reader);
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
			return new SearchAllResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record SearchAllResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static SearchAllResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static SearchAllResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new SearchAllResponseLinks(v0, v1, v2);
	}
}

	public sealed record SearchThreadsBody
	{
		/// <summary>
		/// Search query. Can be skipped if <b>user_id</b> is set.
		/// </summary>
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		/// <summary>
		/// Tag to search for tagged contents.
		/// </summary>
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		/// <summary>
		/// Id of the container forum to search for contents. Child forums of the specified forum will be included in the search.
		/// </summary>
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
		/// <summary>
		/// Page number of results.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of results in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// Number of thread data to be returned.
		/// </summary>
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
		/// <summary>
		/// The time in milliseconds (e.g. 1767214800) before last content date.
		/// </summary>
		[JsonPropertyName("before")]
		public long? Before { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Q is not null)
			{
				writer.WritePropertyName("q"u8);
				writer.WriteStringValue(Q);
			}
			if (Tag is not null)
			{
				writer.WritePropertyName("tag"u8);
				writer.WriteStringValue(Tag);
			}
			if (ForumId is not null)
			{
				writer.WritePropertyName("forum_id"u8);
				writer.WriteNumberValue(ForumId.Value);
			}
			if (UserId is not null)
			{
				writer.WritePropertyName("user_id"u8);
				UserId.Value.WriteTo(writer);
			}
			if (Page is not null)
			{
				writer.WritePropertyName("page"u8);
				writer.WriteNumberValue(Page.Value);
			}
			if (Limit is not null)
			{
				writer.WritePropertyName("limit"u8);
				writer.WriteNumberValue(Limit.Value);
			}
			if (DataLimit is not null)
			{
				writer.WritePropertyName("data_limit"u8);
				writer.WriteNumberValue(DataLimit.Value);
			}
			if (Before is not null)
			{
				writer.WritePropertyName("before"u8);
				writer.WriteNumberValue(Before.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record SearchThreadsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] SearchThreadsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static SearchThreadsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static SearchThreadsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<JsonElement> v0 = null!;
			long v1 = default;
			SearchThreadsResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
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
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : SearchThreadsResponseLinks.ReadFromReader(ref reader);
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
			return new SearchThreadsResponse(v0, v1, v2, v3);
		}
	}

public sealed record SearchThreadsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static SearchThreadsResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static SearchThreadsResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new SearchThreadsResponseLinks(v0, v1, v2);
	}
}

	public sealed record SearchPostsBody
	{
		/// <summary>
		/// Search query. Can be skipped if <b>user_id</b> is set.
		/// </summary>
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		/// <summary>
		/// Tag to search for tagged contents.
		/// </summary>
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		/// <summary>
		/// Id of the container forum to search for contents. Child forums of the specified forum will be included in the search.
		/// </summary>
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		[JsonPropertyName("user_id")]
		public Lolzteam.Api.Runtime.StringOrLong? UserId { get; init; }
		/// <summary>
		/// Page number of results.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of results in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// Number of post data to be returned.
		/// </summary>
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
		/// <summary>
		/// The time in milliseconds (e.g. 1767214800) before last content date.
		/// </summary>
		[JsonPropertyName("before")]
		public long? Before { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Q is not null)
			{
				writer.WritePropertyName("q"u8);
				writer.WriteStringValue(Q);
			}
			if (Tag is not null)
			{
				writer.WritePropertyName("tag"u8);
				writer.WriteStringValue(Tag);
			}
			if (ForumId is not null)
			{
				writer.WritePropertyName("forum_id"u8);
				writer.WriteNumberValue(ForumId.Value);
			}
			if (UserId is not null)
			{
				writer.WritePropertyName("user_id"u8);
				UserId.Value.WriteTo(writer);
			}
			if (Page is not null)
			{
				writer.WritePropertyName("page"u8);
				writer.WriteNumberValue(Page.Value);
			}
			if (Limit is not null)
			{
				writer.WritePropertyName("limit"u8);
				writer.WriteNumberValue(Limit.Value);
			}
			if (DataLimit is not null)
			{
				writer.WritePropertyName("data_limit"u8);
				writer.WriteNumberValue(DataLimit.Value);
			}
			if (Before is not null)
			{
				writer.WritePropertyName("before"u8);
				writer.WriteNumberValue(Before.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record SearchPostsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] SearchPostsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static SearchPostsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static SearchPostsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<JsonElement> v0 = null!;
			long v1 = default;
			SearchPostsResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
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
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : SearchPostsResponseLinks.ReadFromReader(ref reader);
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
			return new SearchPostsResponse(v0, v1, v2, v3);
		}
	}

public sealed record SearchPostsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static SearchPostsResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static SearchPostsResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new SearchPostsResponseLinks(v0, v1, v2);
	}
}

	public sealed record SearchUsersBody
	{
		/// <summary>
		/// Search query.
		/// </summary>
		[JsonPropertyName("q")]
		public string? Q { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Q is not null)
			{
				writer.WritePropertyName("q"u8);
				writer.WriteStringValue(Q);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record SearchUsersResponse(
		[property: JsonPropertyName("users")] List<Resp_UserModel> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static SearchUsersResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static SearchUsersResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_UserModel> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_UserModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_UserModel.ReadFromReader(ref reader);
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
			return new SearchUsersResponse(v0, v1);
		}
	}

	public sealed record SearchProfilePostsBody
	{
		/// <summary>
		/// Search query. Can be skipped if <b>user_id</b> is set.
		/// </summary>
		[JsonPropertyName("q")]
		public string? Q { get; init; }
		/// <summary>
		/// User ID to filter profile posts.
		/// </summary>
		[JsonPropertyName("user_id")]
		public long? UserId { get; init; }
		/// <summary>
		/// Page number of results.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of results in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// The time in milliseconds (e.g. 1767214800) before last content date.
		/// </summary>
		[JsonPropertyName("before")]
		public long? Before { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Q is not null)
			{
				writer.WritePropertyName("q"u8);
				writer.WriteStringValue(Q);
			}
			if (UserId is not null)
			{
				writer.WritePropertyName("user_id"u8);
				writer.WriteNumberValue(UserId.Value);
			}
			if (Page is not null)
			{
				writer.WritePropertyName("page"u8);
				writer.WriteNumberValue(Page.Value);
			}
			if (Limit is not null)
			{
				writer.WritePropertyName("limit"u8);
				writer.WriteNumberValue(Limit.Value);
			}
			if (Before is not null)
			{
				writer.WritePropertyName("before"u8);
				writer.WriteNumberValue(Before.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record SearchProfilePostsResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] SearchProfilePostsResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static SearchProfilePostsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static SearchProfilePostsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<JsonElement> v0 = null!;
			long v1 = default;
			SearchProfilePostsResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
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
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : SearchProfilePostsResponseLinks.ReadFromReader(ref reader);
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
			return new SearchProfilePostsResponse(v0, v1, v2, v3);
		}
	}

public sealed record SearchProfilePostsResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static SearchProfilePostsResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static SearchProfilePostsResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new SearchProfilePostsResponseLinks(v0, v1, v2);
	}
}

	public sealed record SearchTaggedBody
	{
		/// <summary>
		/// Tag to search for tagged contents.
		/// </summary>
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }
		/// <summary>
		/// Array of tags to search for tagged contents.
		/// </summary>
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		/// <summary>
		/// Page number of results.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of results in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Tag is not null)
			{
				writer.WritePropertyName("tag"u8);
				writer.WriteStringValue(Tag);
			}
			if (Tags is not null)
			{
				writer.WritePropertyName("tags"u8);
				writer.WriteStartArray();
				foreach (var __w in Tags)
				{
					writer.WriteStringValue(__w);
				}
				writer.WriteEndArray();
			}
			if (Page is not null)
			{
				writer.WritePropertyName("page"u8);
				writer.WriteNumberValue(Page.Value);
			}
			if (Limit is not null)
			{
				writer.WritePropertyName("limit"u8);
				writer.WriteNumberValue(Limit.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record SearchTaggedResponse(
		[property: JsonPropertyName("data")] List<JsonElement> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("links")] SearchTaggedResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static SearchTaggedResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static SearchTaggedResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<JsonElement> v0 = null!;
			long v1 = default;
			SearchTaggedResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
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
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : SearchTaggedResponseLinks.ReadFromReader(ref reader);
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
			return new SearchTaggedResponse(v0, v1, v2, v3);
		}
	}

public sealed record SearchTaggedResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static SearchTaggedResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static SearchTaggedResponseLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		long v1 = default;
		string v2 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("pages"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("page"u8))
			{
				reader.Read();
				v1 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("next"u8))
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
		return new SearchTaggedResponseLinks(v0, v1, v2);
	}
}

	public sealed record SearchResultsParams
	{
		/// <summary>
		/// Page number of results.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of results in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Page is not null)
			{
				writer.WritePropertyName("page"u8);
				writer.WriteNumberValue(Page.Value);
			}
			if (Limit is not null)
			{
				writer.WritePropertyName("limit"u8);
				writer.WriteNumberValue(Limit.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record SearchResultsResponse(
		[property: JsonPropertyName("data")] List<Resp_ThreadModel> Data,
		[property: JsonPropertyName("data_total")] long DataTotal,
		[property: JsonPropertyName("search_tags")] SearchResultsResponseSearchTags SearchTags,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static SearchResultsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static SearchResultsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ThreadModel> v0 = null!;
			long v1 = default;
			SearchResultsResponseSearchTags v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_ThreadModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_ThreadModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("search_tags"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : SearchResultsResponseSearchTags.ReadFromReader(ref reader);
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
			return new SearchResultsResponse(v0, v1, v2, v3);
		}
	}

public sealed record SearchResultsResponseSearchTags(
	[property: JsonPropertyName("160179")] string _160179
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static SearchResultsResponseSearchTags ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static SearchResultsResponseSearchTags ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("160179"u8))
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
		return new SearchResultsResponseSearchTags(v0);
	}
}

}
