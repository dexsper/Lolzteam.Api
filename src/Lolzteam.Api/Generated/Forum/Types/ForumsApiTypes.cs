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
	}

	public sealed record ForumsListResponse(
		[property: JsonPropertyName("forums")] List<ForumsListResponseForums> Forums,
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
			List<ForumsListResponseForums> v0 = null!;
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
						var __lst = new List<ForumsListResponseForums>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ForumsListResponseForums.ReadFromReader(ref reader);
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

public sealed record ForumsListResponseForumsForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsListResponseForumsForumPrefixesGroupPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsListResponseForumsForumPrefixesGroupPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("prefix_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("prefix_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsListResponseForumsForumPrefixesGroupPrefixes(v0, v1);
	}
}

public sealed record ForumsListResponseForumsForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ForumsListResponseForumsForumPrefixesGroupPrefixes> GroupPrefixes
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsListResponseForumsForumPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsListResponseForumsForumPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		List<ForumsListResponseForumsForumPrefixesGroupPrefixes> v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("group_title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("group_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ForumsListResponseForumsForumPrefixesGroupPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ForumsListResponseForumsForumPrefixesGroupPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v1 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsListResponseForumsForumPrefixes(v0, v1);
	}
}

public sealed record ForumsListResponseForumsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsListResponseForumsLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsListResponseForumsLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("permalink"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-categories"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-forums"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("threads"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsListResponseForumsLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsListResponseForumsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsListResponseForumsPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsListResponseForumsPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("create_thread"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tag_thread"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsListResponseForumsPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsListResponseForums(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ForumsListResponseForumsForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ForumsListResponseForumsLinks Links,
	[property: JsonPropertyName("permissions")] ForumsListResponseForumsPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsListResponseForums ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsListResponseForums ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		List<ForumsListResponseForumsForumPrefixes> v5 = null!;
		long v6 = default;
		bool v7 = default;
		ForumsListResponseForumsLinks v8 = null!;
		ForumsListResponseForumsPermissions v9 = null!;
		bool v10 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_thread_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_post_count"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ForumsListResponseForumsForumPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ForumsListResponseForumsForumPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v5 = __lst;
				}
			}
			else if (reader.ValueTextEquals("thread_default_prefix_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_prefix_is_required"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : ForumsListResponseForumsLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ForumsListResponseForumsPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum_is_followed"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsListResponseForums(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
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
		[property: JsonPropertyName("data")] ForumsGroupedResponseData Data,
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
			ForumsGroupedResponseData v0 = null!;
			List<ForumsGroupedResponseTabs> v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("data"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGroupedResponseData.ReadFromReader(ref reader);
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

public sealed record ForumsGroupedResponseData00Links(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGroupedResponseData00Links ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGroupedResponseData00Links ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("permalink"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-categories"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-forums"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("threads"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGroupedResponseData00Links(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsGroupedResponseData00Permissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGroupedResponseData00Permissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGroupedResponseData00Permissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("create_thread"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tag_thread"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGroupedResponseData00Permissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsGroupedResponseData00(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("parent_node_id")] long ParentNodeId,
	[property: JsonPropertyName("links")] ForumsGroupedResponseData00Links Links,
	[property: JsonPropertyName("permissions")] ForumsGroupedResponseData00Permissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGroupedResponseData00 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGroupedResponseData00 ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		long v5 = default;
		ForumsGroupedResponseData00Links v6 = null!;
		ForumsGroupedResponseData00Permissions v7 = null!;
		bool v8 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_thread_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_post_count"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("parent_node_id"u8))
			{
				reader.Read();
				v5 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v6 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGroupedResponseData00Links.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGroupedResponseData00Permissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum_is_followed"u8))
			{
				reader.Read();
				v8 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGroupedResponseData00(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

public sealed record ForumsGroupedResponseData0(
	[property: JsonPropertyName("0")] ForumsGroupedResponseData00 _0
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGroupedResponseData0 ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGroupedResponseData0 ReadFromReader(ref Utf8JsonReader reader)
	{
		ForumsGroupedResponseData00 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("0"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGroupedResponseData00.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGroupedResponseData0(v0);
	}
}

public sealed record ForumsGroupedResponseData(
	[property: JsonPropertyName("0")] ForumsGroupedResponseData0 _0
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGroupedResponseData ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGroupedResponseData ReadFromReader(ref Utf8JsonReader reader)
	{
		ForumsGroupedResponseData0 v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("0"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGroupedResponseData0.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGroupedResponseData(v0);
	}
}

public sealed record ForumsGroupedResponseTabs(
	[property: JsonPropertyName("link_title")] string LinkTitle,
	[property: JsonPropertyName("isDefault")] bool IsDefault,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("isHidden")] bool IsHidden
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
		return new ForumsGroupedResponseTabs(v0, v1, v2, v3);
	}
}

	public sealed record ForumsGetResponse(
		[property: JsonPropertyName("forum")] ForumsGetResponseForum Forum,
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
			ForumsGetResponseForum v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("forum"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGetResponseForum.ReadFromReader(ref reader);
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

public sealed record ForumsGetResponseForumForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetResponseForumForumPrefixesGroupPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetResponseForumForumPrefixesGroupPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("prefix_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("prefix_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetResponseForumForumPrefixesGroupPrefixes(v0, v1);
	}
}

public sealed record ForumsGetResponseForumForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ForumsGetResponseForumForumPrefixesGroupPrefixes> GroupPrefixes
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetResponseForumForumPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetResponseForumForumPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		List<ForumsGetResponseForumForumPrefixesGroupPrefixes> v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("group_title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("group_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ForumsGetResponseForumForumPrefixesGroupPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ForumsGetResponseForumForumPrefixesGroupPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v1 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetResponseForumForumPrefixes(v0, v1);
	}
}

public sealed record ForumsGetResponseForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetResponseForumLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetResponseForumLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("permalink"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-categories"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-forums"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("threads"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetResponseForumLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsGetResponseForumPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetResponseForumPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetResponseForumPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("create_thread"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("upload_attachment"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tag_thread"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetResponseForumPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ForumsGetResponseForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ForumsGetResponseForumForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ForumsGetResponseForumLinks Links,
	[property: JsonPropertyName("permissions")] ForumsGetResponseForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetResponseForum ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetResponseForum ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		List<ForumsGetResponseForumForumPrefixes> v5 = null!;
		long v6 = default;
		bool v7 = default;
		ForumsGetResponseForumLinks v8 = null!;
		ForumsGetResponseForumPermissions v9 = null!;
		bool v10 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_thread_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_post_count"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ForumsGetResponseForumForumPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ForumsGetResponseForumForumPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v5 = __lst;
				}
			}
			else if (reader.ValueTextEquals("thread_default_prefix_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_prefix_is_required"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGetResponseForumLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGetResponseForumPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum_is_followed"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetResponseForum(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

	public sealed record ForumsFollowersResponse(
		[property: JsonPropertyName("users")] List<ForumsFollowersResponseUsers> Users,
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
			List<ForumsFollowersResponseUsers> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ForumsFollowersResponseUsers>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ForumsFollowersResponseUsers.ReadFromReader(ref reader);
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
			return new ForumsFollowersResponse(v0, v1);
		}
	}

public sealed record ForumsFollowersResponseUsersFollow(
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("alert")] bool Alert,
	[property: JsonPropertyName("email")] bool Email
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowersResponseUsersFollow ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowersResponseUsersFollow ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("post"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("alert"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("email"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowersResponseUsersFollow(v0, v1, v2);
	}
}

public sealed record ForumsFollowersResponseUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("follow")] ForumsFollowersResponseUsersFollow Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowersResponseUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowersResponseUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		ForumsFollowersResponseUsersFollow v2 = null!;
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
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v2 = reader.TokenType == JsonTokenType.Null ? null! : ForumsFollowersResponseUsersFollow.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowersResponseUsers(v0, v1, v2);
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
	}

	public sealed record ForumsFollowedResponse(
		[property: JsonPropertyName("forums")] List<ForumsFollowedResponseForums> Forums,
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
			List<ForumsFollowedResponseForums> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("forums"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ForumsFollowedResponseForums>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ForumsFollowedResponseForums.ReadFromReader(ref reader);
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

public sealed record ForumsFollowedResponseForumsForumPrefixesGroupPrefixes(
	[property: JsonPropertyName("prefix_id")] long PrefixId,
	[property: JsonPropertyName("prefix_title")] string PrefixTitle
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowedResponseForumsForumPrefixesGroupPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowedResponseForumsForumPrefixesGroupPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("prefix_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("prefix_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowedResponseForumsForumPrefixesGroupPrefixes(v0, v1);
	}
}

public sealed record ForumsFollowedResponseForumsForumPrefixes(
	[property: JsonPropertyName("group_title")] string GroupTitle,
	[property: JsonPropertyName("group_prefixes")] List<ForumsFollowedResponseForumsForumPrefixesGroupPrefixes> GroupPrefixes
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowedResponseForumsForumPrefixes ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowedResponseForumsForumPrefixes ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		List<ForumsFollowedResponseForumsForumPrefixesGroupPrefixes> v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("group_title"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("group_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ForumsFollowedResponseForumsForumPrefixesGroupPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ForumsFollowedResponseForumsForumPrefixesGroupPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v1 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowedResponseForumsForumPrefixes(v0, v1);
	}
}

public sealed record ForumsFollowedResponseForumsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowedResponseForumsLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowedResponseForumsLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("permalink"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-categories"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-forums"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("threads"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowedResponseForumsLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsFollowedResponseForumsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("upload_attachment")] bool UploadAttachment,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowedResponseForumsPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowedResponseForumsPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		bool v6 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("create_thread"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("upload_attachment"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tag_thread"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowedResponseForumsPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ForumsFollowedResponseForumsFollow(
	[property: JsonPropertyName("post")] bool Post,
	[property: JsonPropertyName("alert")] bool Alert,
	[property: JsonPropertyName("email")] bool Email
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowedResponseForumsFollow ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowedResponseForumsFollow ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("post"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("alert"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("email"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowedResponseForumsFollow(v0, v1, v2);
	}
}

public sealed record ForumsFollowedResponseForums(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<ForumsFollowedResponseForumsForumPrefixes> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ForumsFollowedResponseForumsLinks Links,
	[property: JsonPropertyName("permissions")] ForumsFollowedResponseForumsPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed,
	[property: JsonPropertyName("follow")] ForumsFollowedResponseForumsFollow Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsFollowedResponseForums ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsFollowedResponseForums ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		List<ForumsFollowedResponseForumsForumPrefixes> v5 = null!;
		long v6 = default;
		bool v7 = default;
		ForumsFollowedResponseForumsLinks v8 = null!;
		ForumsFollowedResponseForumsPermissions v9 = null!;
		bool v10 = default;
		ForumsFollowedResponseForumsFollow v11 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_thread_count"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_post_count"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_prefixes"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ForumsFollowedResponseForumsForumPrefixes>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ForumsFollowedResponseForumsForumPrefixes.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v5 = __lst;
				}
			}
			else if (reader.ValueTextEquals("thread_default_prefix_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("thread_prefix_is_required"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : ForumsFollowedResponseForumsLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ForumsFollowedResponseForumsPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum_is_followed"u8))
			{
				reader.Read();
				v10 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v11 = reader.TokenType == JsonTokenType.Null ? null! : ForumsFollowedResponseForumsFollow.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsFollowedResponseForums(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
	}
}

	public sealed record ForumsGetFeedOptionsResponse(
		[property: JsonPropertyName("forums")] List<ForumsGetFeedOptionsResponseForums> Forums,
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
			List<ForumsGetFeedOptionsResponseForums> v0 = null!;
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
						var __lst = new List<ForumsGetFeedOptionsResponseForums>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ForumsGetFeedOptionsResponseForums.ReadFromReader(ref reader);
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

public sealed record ForumsGetFeedOptionsResponseForumsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetFeedOptionsResponseForumsLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetFeedOptionsResponseForumsLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
		string v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("permalink"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("detail"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-categories"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sub-forums"u8))
			{
				reader.Read();
				v3 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("threads"u8))
			{
				reader.Read();
				v4 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("followers"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetFeedOptionsResponseForumsLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsGetFeedOptionsResponseForumsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete,
	[property: JsonPropertyName("create_thread")] bool CreateThread,
	[property: JsonPropertyName("tag_thread")] bool TagThread,
	[property: JsonPropertyName("follow")] bool Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetFeedOptionsResponseForumsPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetFeedOptionsResponseForumsPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
		bool v3 = default;
		bool v4 = default;
		bool v5 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("view"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("edit"u8))
			{
				reader.Read();
				v1 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("delete"u8))
			{
				reader.Read();
				v2 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("create_thread"u8))
			{
				reader.Read();
				v3 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("tag_thread"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("follow"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetFeedOptionsResponseForumsPermissions(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ForumsGetFeedOptionsResponseForums(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("parent_node_id")] long ParentNodeId,
	[property: JsonPropertyName("links")] ForumsGetFeedOptionsResponseForumsLinks Links,
	[property: JsonPropertyName("permissions")] ForumsGetFeedOptionsResponseForumsPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed,
	[property: JsonPropertyName("has_children")] bool HasChildren
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ForumsGetFeedOptionsResponseForums ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ForumsGetFeedOptionsResponseForums ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		ForumsGetFeedOptionsResponseForumsLinks v4 = null!;
		ForumsGetFeedOptionsResponseForumsPermissions v5 = null!;
		bool v6 = default;
		bool v7 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("forum_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("forum_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("forum_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("parent_node_id"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGetFeedOptionsResponseForumsLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v5 = reader.TokenType == JsonTokenType.Null ? null! : ForumsGetFeedOptionsResponseForumsPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("forum_is_followed"u8))
			{
				reader.Read();
				v6 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("has_children"u8))
			{
				reader.Read();
				v7 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ForumsGetFeedOptionsResponseForums(v0, v1, v2, v3, v4, v5, v6, v7);
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
