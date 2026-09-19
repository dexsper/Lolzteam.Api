// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class ForumsApiTypes
{
	public sealed record ForumsListParams
	{
		/// <summary>
		/// Id of parent category. If exists, filter forums that are direct children of that category.
		/// </summary>
		[JsonPropertyName("parent_category_id")]
		public long? ParentCategoryId { get; init; }
		/// <summary>
		/// Id of parent forum. If exists, filter forums that are direct children of that forum.
		/// </summary>
		[JsonPropertyName("parent_forum_id")]
		public long? ParentForumId { get; init; }
		/// <summary>
		/// Ordering of forums.
		/// </summary>
		[JsonPropertyName("order")]
		public CategoriesOrder? Order { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (ParentCategoryId is not null)
			{
				writer.WritePropertyName("parent_category_id"u8);
				writer.WriteNumberValue(ParentCategoryId.Value);
			}
			if (ParentForumId is not null)
			{
				writer.WritePropertyName("parent_forum_id"u8);
				writer.WriteNumberValue(ParentForumId.Value);
			}
			if (Order is not null)
			{
				writer.WritePropertyName("order"u8);
				writer.WriteStringValue(Order.Value.ToJsonValue());
			}
			writer.WriteEndObject();
		}
	}

	public sealed record ForumsListResponse(
		[property: JsonPropertyName("forums")] List<Resp_ForumModel> Forums,
		[property: JsonPropertyName("forums_total")] long ForumsTotal,
		[property: JsonPropertyName("tabs")] List<ForumsListResponseTabs> Tabs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ForumModel> v0 = null!;
			long v1 = default;
			List<ForumsListResponseTabs> v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("forums"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_ForumModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_ForumModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("forums_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("tabs"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ForumsListResponseTabs>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ForumsListResponseTabs.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v2 = __lst;
					}
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
			return new ForumsListResponse(v0, v1, v2, v3);
		}
	}

public sealed record ForumsListResponseTabs(
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isHidden")] bool IsHidden
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsListResponseTabs ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsListResponseTabs ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		string v2 = null!;
		bool v3 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("link_title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isDefault"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isHidden"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsListResponseTabs(v0, v1, v2, v3);
	}
}

	public sealed record ForumsGroupedResponse(
		[property: JsonPropertyName("data")] List<List<Resp_ForumModel>> Data,
		[property: JsonPropertyName("tabs")] List<ForumsGroupedResponseTabs> Tabs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsGroupedResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsGroupedResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<List<Resp_ForumModel>> v0 = null!;
			List<ForumsGroupedResponseTabs> v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<List<Resp_ForumModel>>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = new List<Resp_ForumModel>();
							if (reader.TokenType == JsonTokenType.StartArray)
							{
								while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
								{
									var __item1 = Resp_ForumModel.ReadFromReader(ref reader);
									__item.Add(__item1);
								}
							}
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("tabs"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ForumsGroupedResponseTabs>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ForumsGroupedResponseTabs.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v1 = __lst;
					}
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
			return new ForumsGroupedResponse(v0, v1, v2);
		}
	}

public sealed record ForumsGroupedResponseTabs(
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("isDefault")] bool? IsDefault,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isHidden")] bool? IsHidden,
	[property: JsonPropertyName("tabLink")] string? TabLink,
	[property: JsonPropertyName("isDynamicTitle")] bool? IsDynamicTitle,
	[property: JsonPropertyName("node_ids")] string? NodeIds,
	[property: JsonPropertyName("isExtendedTab")] bool? IsExtendedTab,
	[property: JsonPropertyName("prefixes")] List<JsonElement>? Prefixes,
	[property: JsonPropertyName("prefixes_not")] List<JsonElement>? PrefixesNot,
	[property: JsonPropertyName("order")] string? Order,
	[property: JsonPropertyName("direction")] string? Direction,
	[property: JsonPropertyName("period")] string? Period,
	[property: JsonPropertyName("state")] string? State,
	[property: JsonPropertyName("q")] string? Q
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGroupedResponseTabs ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGroupedResponseTabs ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		bool v1 = default;
		string v2 = null!;
		bool v3 = default;
		string v4 = null!;
		bool v5 = default;
		string v6 = null!;
		bool v7 = default;
		List<JsonElement> v8 = null!;
		List<JsonElement> v9 = null!;
		string v10 = null!;
		string v11 = null!;
		string v12 = null!;
		string v13 = null!;
		string v14 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("link_title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isDefault"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isHidden"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tabLink"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isDynamicTitle"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("node_ids"u8))
			{
				reader.Read();
				v6 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("isExtendedTab"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("prefixes"u8))
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
					v8 = __lst;
				}
			}
			else if (reader.ValueTextEquals("prefixes_not"u8))
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
					v9 = __lst;
				}
			}
			else if (reader.ValueTextEquals("order"u8))
			{
				reader.Read();
				v10 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("direction"u8))
			{
				reader.Read();
				v11 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("period"u8))
			{
				reader.Read();
				v12 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("state"u8))
			{
				reader.Read();
				v13 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("q"u8))
			{
				reader.Read();
				v14 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGroupedResponseTabs(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);
	}
}

	public sealed record ForumsGetResponse(
		[property: JsonPropertyName("forum")] Resp_ForumModel Forum,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ForumModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("forum"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ForumModel.ReadFromReader(ref reader);
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
			return new ForumsGetResponse(v0, v1);
		}
	}

	public sealed record ForumsFollowersResponse(
		[property: JsonPropertyName("users")] Resp_UserModel Users,
		[property: JsonPropertyName("users_total")] long? UsersTotal,
		[property: JsonPropertyName("links")] ForumsFollowersResponseLinks? Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsFollowersResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsFollowersResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_UserModel v0 = null!;
			long v1 = default;
			ForumsFollowersResponseLinks v2 = null!;
			Resp_SystemInfo v3 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_UserModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("users_total"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : ForumsFollowersResponseLinks.ReadFromReader(ref reader);
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
			return new ForumsFollowersResponse(v0, v1, v2, v3);
		}
	}

public sealed record ForumsFollowersResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowersResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowersResponseLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ForumsFollowersResponseLinks(v0, v1, v2);
	}
}

	public sealed record ForumsFollowBody
	{
		/// <summary>
		/// Whether to receive notification for post.
		/// </summary>
		[JsonPropertyName("post")]
		public bool? Post { get; init; }
		/// <summary>
		/// Whether to receive notification as alert.
		/// </summary>
		[JsonPropertyName("alert")]
		public bool? Alert { get; init; }
		/// <summary>
		/// Whether to receive notification as email.
		/// </summary>
		[JsonPropertyName("email")]
		public bool? Email { get; init; }
		/// <summary>
		/// Prefix ids.
		/// </summary>
		[JsonPropertyName("prefix_ids")]
		public List<long?>? PrefixIds { get; init; }
		/// <summary>
		/// Minimal contest amount. (Only for 766 forumId)
		/// </summary>
		[JsonPropertyName("minimal_contest_amount")]
		public long? MinimalContestAmount { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Post is not null)
			{
				writer.WritePropertyName("post"u8);
				writer.WriteBooleanValue(Post.Value);
			}
			if (Alert is not null)
			{
				writer.WritePropertyName("alert"u8);
				writer.WriteBooleanValue(Alert.Value);
			}
			if (Email is not null)
			{
				writer.WritePropertyName("email"u8);
				writer.WriteBooleanValue(Email.Value);
			}
			if (PrefixIds is not null)
			{
				writer.WritePropertyName("prefix_ids"u8);
				writer.WriteStartArray();
				foreach (var __w in PrefixIds)
				{
					writer.WriteNumberValue(__w.GetValueOrDefault());
				}
				writer.WriteEndArray();
			}
			if (MinimalContestAmount is not null)
			{
				writer.WritePropertyName("minimal_contest_amount"u8);
				writer.WriteNumberValue(MinimalContestAmount.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record ForumsFollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsFollowResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsFollowResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ForumsFollowResponse(v0, v1, v2);
		}
	}

	public sealed record ForumsUnfollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsUnfollowResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsUnfollowResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ForumsUnfollowResponse(v0, v1, v2);
		}
	}

	public sealed record ForumsFollowedParams
	{
		/// <summary>
		/// If included in the request, only the forum count is returned as <b>forums_total</b>.
		/// </summary>
		[JsonPropertyName("total")]
		public bool? Total { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (Total is not null)
			{
				writer.WritePropertyName("total"u8);
				writer.WriteBooleanValue(Total.Value);
			}
			writer.WriteEndObject();
		}
	}

	public sealed record ForumsFollowedResponse(
		[property: JsonPropertyName("forums")] List<Resp_ForumModel> Forums,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsFollowedResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsFollowedResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ForumModel> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("forums"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_ForumModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_ForumModel.ReadFromReader(ref reader);
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
			return new ForumsFollowedResponse(v0, v1);
		}
	}

	public sealed record ForumsGetFeedOptionsResponse(
		[property: JsonPropertyName("forums")] List<Resp_ForumModel> Forums,
		[property: JsonPropertyName("excluded_forums_ids")] List<long> ExcludedForumsIds,
		[property: JsonPropertyName("default_excluded_forums_ids")] List<long> DefaultExcludedForumsIds,
		[property: JsonPropertyName("keywords")] string Keywords,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsGetFeedOptionsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsGetFeedOptionsResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ForumModel> v0 = null!;
			List<long> v1 = null!;
			List<long> v2 = null!;
			string v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("forums"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<Resp_ForumModel>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = Resp_ForumModel.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("excluded_forums_ids"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<long>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = reader.GetInt64();
							__lst.Add(__item);
						}
						v1 = __lst;
					}
				}
				else if (reader.ValueTextEquals("default_excluded_forums_ids"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<long>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = reader.GetInt64();
							__lst.Add(__item);
						}
						v2 = __lst;
					}
				}
				else if (reader.ValueTextEquals("keywords"u8))
				{
					reader.Read();
					v3 = reader.GetString()!;
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
			return new ForumsGetFeedOptionsResponse(v0, v1, v2, v3, v4);
		}
	}

	public sealed record ForumsEditFeedOptionsBody
	{
		/// <summary>
		/// Array of forum ids to exclude from the feed.
		/// </summary>
		[JsonPropertyName("node_ids")]
		public List<long?>? NodeIds { get; init; }
		/// <summary>
		/// List of keywords to exclude specific threads from the feed.
		/// </summary>
		[JsonPropertyName("keywords")]
		public List<string>? Keywords { get; init; }

		/// <summary>Serialize directly via Utf8JsonWriter, no JsonSerializer, no reflection.</summary>
		public void WriteTo(Utf8JsonWriter writer)
		{
			writer.WriteStartObject();
			if (NodeIds is not null)
			{
				writer.WritePropertyName("node_ids"u8);
				writer.WriteStartArray();
				foreach (var __w in NodeIds)
				{
					writer.WriteNumberValue(__w.GetValueOrDefault());
				}
				writer.WriteEndArray();
			}
			if (Keywords is not null)
			{
				writer.WritePropertyName("keywords"u8);
				writer.WriteStartArray();
				foreach (var __w in Keywords)
				{
					writer.WriteStringValue(__w);
				}
				writer.WriteEndArray();
			}
			writer.WriteEndObject();
		}
	}

	public sealed record ForumsEditFeedOptionsResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ForumsEditFeedOptionsResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ForumsEditFeedOptionsResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ForumsEditFeedOptionsResponse(v0, v1, v2);
		}
	}

}
