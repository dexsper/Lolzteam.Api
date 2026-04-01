// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class ThreadsApiTypes
{
	public sealed record ThreadsListParams
	{
		/// <summary>
		/// Id of the containing forum.
		/// </summary>
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		/// <summary>
		/// Tab to get threads from.
		/// </summary>
		[JsonPropertyName("tab")]
		public string? Tab { get; init; }
		/// <summary>
		/// Thread state. Works only if <b>forum_id</b> is set.
		/// </summary>
		[JsonPropertyName("state")]
		public State? State { get; init; }
		/// <summary>
		/// Filter to get only threads created within the selected period. Works only if <b>forum_id</b> is set.
		/// </summary>
		[JsonPropertyName("period")]
		public Period? Period { get; init; }
		/// <summary>
		/// Thread title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Search only in titles.
		/// </summary>
		[JsonPropertyName("title_only")]
		public bool? TitleOnly { get; init; }
		/// <summary>
		/// Filter to get only threads created by the specified user.
		/// </summary>
		[JsonPropertyName("creator_user_id")]
		public long? CreatorUserId { get; init; }
		/// <summary>
		/// Filter to get only sticky or non-sticky threads. By default, all threads will be included and sticky ones will be at the top of the result on the first page. In mixed mode, sticky threads are not counted towards <b>threads_total</b> and does not affect pagination.
		/// </summary>
		[JsonPropertyName("sticky")]
		public bool? Sticky { get; init; }
		/// <summary>
		/// Filter to get only threads with the specified prefix.
		/// </summary>
		[JsonPropertyName("prefix_ids[]")]
		public List<long?>? PrefixIds { get; init; }
		/// <summary>
		/// Filter to get only threads without the specified prefix.
		/// </summary>
		[JsonPropertyName("prefix_ids_not[]")]
		public List<long?>? PrefixIdsNot { get; init; }
		/// <summary>
		/// Filter to get only threads with the specified tag.
		/// </summary>
		[JsonPropertyName("thread_tag_id")]
		public long? ThreadTagId { get; init; }
		/// <summary>
		/// Page number of threads.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
		/// <summary>
		/// Number of threads in a page.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// Ordering of threads.
		/// </summary>
		[JsonPropertyName("order")]
		public ThreadsOrder? Order { get; init; }
		/// <summary>
		/// Direction of threads ordering.
		/// </summary>
		[JsonPropertyName("direction")]
		public Direction? Direction { get; init; }
		/// <summary>
		/// Filter threads by creation date. Only works with 'thread<i>create</i>date' and 'thread<i>create</i>date_reverse' ordering.
		/// </summary>
		[JsonPropertyName("thread_create_date")]
		public long? ThreadCreateDate { get; init; }
		/// <summary>
		/// Filter threads by update date. Only works with 'thread<i>update</i>date' and 'thread<i>update</i>date_reverse' ordering.
		/// </summary>
		[JsonPropertyName("thread_update_date")]
		public long? ThreadUpdateDate { get; init; }
		/// <summary>
		/// List of fields to include.
		/// </summary>
		[JsonPropertyName("fields_include")]
		public List<ThreadsFieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record ThreadsListResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("forum")] ThreadsListResponseForum Forum,
		[property: JsonPropertyName("threads_total")] long ThreadsTotal,
		[property: JsonPropertyName("links")] ThreadsListResponseLinks Links,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ThreadModel> v0 = null!;
			ThreadsListResponseForum v1 = null!;
			long v2 = default;
			ThreadsListResponseLinks v3 = null!;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("threads"u8))
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
				else if (reader.ValueTextEquals("forum"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsListResponseForum.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("threads_total"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("links"u8))
				{
					reader.Read();
					v3 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsListResponseLinks.ReadFromReader(ref reader);
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
			return new ThreadsListResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record ThreadsListResponseForumLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("threads")] string Threads,
	[property: JsonPropertyName("followers")] string Followers
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsListResponseForumLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsListResponseForumLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ThreadsListResponseForumLinks(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record ThreadsListResponseForumPermissions(
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
	public static ThreadsListResponseForumPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsListResponseForumPermissions ReadFromReader(ref Utf8JsonReader reader)
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
		return new ThreadsListResponseForumPermissions(v0, v1, v2, v3, v4, v5, v6);
	}
}

public sealed record ThreadsListResponseForum(
	[property: JsonPropertyName("forum_id")] long ForumId,
	[property: JsonPropertyName("forum_title")] string ForumTitle,
	[property: JsonPropertyName("forum_description")] string ForumDescription,
	[property: JsonPropertyName("forum_thread_count")] long ForumThreadCount,
	[property: JsonPropertyName("forum_post_count")] long ForumPostCount,
	[property: JsonPropertyName("forum_prefixes")] List<JsonElement> ForumPrefixes,
	[property: JsonPropertyName("thread_default_prefix_id")] long ThreadDefaultPrefixId,
	[property: JsonPropertyName("thread_prefix_is_required")] bool ThreadPrefixIsRequired,
	[property: JsonPropertyName("links")] ThreadsListResponseForumLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsListResponseForumPermissions Permissions,
	[property: JsonPropertyName("forum_is_followed")] bool ForumIsFollowed
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsListResponseForum ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsListResponseForum ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		long v3 = default;
		long v4 = default;
		List<JsonElement> v5 = null!;
		long v6 = default;
		bool v7 = default;
		ThreadsListResponseForumLinks v8 = null!;
		ThreadsListResponseForumPermissions v9 = null!;
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
					var __lst = new List<JsonElement>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = JsonDocument.ParseValue(ref reader).RootElement.Clone();
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
				v8 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsListResponseForumLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v9 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsListResponseForumPermissions.ReadFromReader(ref reader);
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
		return new ThreadsListResponseForum(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
	}
}

public sealed record ThreadsListResponseLinks(
	[property: JsonPropertyName("pages")] long Pages,
	[property: JsonPropertyName("page")] long Page,
	[property: JsonPropertyName("next")] string Next
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsListResponseLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsListResponseLinks ReadFromReader(ref Utf8JsonReader reader)
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
		return new ThreadsListResponseLinks(v0, v1, v2);
	}
}

	public sealed record ThreadsCreateBody
	{
		/// <summary>
		/// Content of the new thread.
		/// </summary>
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
		/// <summary>
		/// Id of the target forum.
		/// </summary>
		[JsonPropertyName("forum_id")]
		public required long? ForumId { get; init; }
		/// <summary>
		/// Thread title. Can be skipped if <b>title_en</b> set.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Thread english title. Can be skipped if <b>title</b> set.
		/// </summary>
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		/// <summary>
		/// Prefix ids.
		/// </summary>
		[JsonPropertyName("prefix_id")]
		public List<long?>? PrefixId { get; init; }
		/// <summary>
		/// Thread tags.
		/// </summary>
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		/// <summary>
		/// Hide contacts.
		/// </summary>
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		/// <summary>
		/// Allow ask hidden content.
		/// </summary>
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		/// <summary>
		/// Allow to reply only users with chosen or higher group.
		/// <para/>
		/// Default: <c>2</c>
		/// </summary>
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
		/// <summary>
		/// Allow commenting if user can't post in thread.
		/// </summary>
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
		/// <summary>
		/// Don't alert followers about thread creation.
		/// </summary>
		[JsonPropertyName("dont_alert_followers")]
		public bool? DontAlertFollowers { get; init; }
		/// <summary>
		/// Date to schedule thread creation (format: <c>DD-MM-YYYY</c>).
		/// </summary>
		[JsonPropertyName("schedule_date")]
		public string? ScheduleDate { get; init; }
		/// <summary>
		/// Time to schedule thread creation (format: <c>HH:MM</c>).
		/// </summary>
		[JsonPropertyName("schedule_time")]
		public string? ScheduleTime { get; init; }
		/// <summary>
		/// Watch thread state.
		/// </summary>
		[JsonPropertyName("watch_thread_state")]
		public bool? WatchThreadState { get; init; }
		/// <summary>
		/// Receive forum notifications of new posts in this thread.
		/// </summary>
		[JsonPropertyName("watch_thread")]
		public bool? WatchThread { get; init; }
		/// <summary>
		/// Receive email notifications of new posts in this thread.
		/// </summary>
		[JsonPropertyName("watch_thread_email")]
		public bool? WatchThreadEmail { get; init; }
	}

	public sealed record ThreadsCreateResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsCreateResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsCreateResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ThreadModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("thread"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModel.ReadFromReader(ref reader);
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
			return new ThreadsCreateResponse(v0, v1);
		}
	}

	public sealed record ThreadsCreateContestBody
	{
		/// <summary>
		/// Content of the new contest.
		/// </summary>
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
		/// <summary>
		/// Thread title. Can be skipped if <b>title_en</b> set.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Thread english title. Can be skipped if <b>title</b> set.
		/// </summary>
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		/// <summary>
		/// Contest type.
		/// <para/>
		/// Default: <c>by_finish_date</c>
		/// </summary>
		[JsonPropertyName("contest_type")]
		public required ContestType ContestType { get; init; }
		/// <summary>
		/// Giveaway duration value. The maximum duration is 3 days. Required if <b>contest_type</b> is <b>by<i>finish</i>date</b>.
		/// </summary>
		[JsonPropertyName("length_value")]
		public long? LengthValue { get; init; }
		/// <summary>
		/// Giveaway duration type. The maximum duration is 3 days. Required if <b>contest_type</b> is <b>by<i>finish</i>date</b>.
		/// </summary>
		[JsonPropertyName("length_option")]
		public LengthOption? LengthOption { get; init; }
		/// <summary>
		/// Prize type.
		/// </summary>
		[JsonPropertyName("prize_type")]
		public required PrizeType PrizeType { get; init; }
		/// <summary>
		/// Winner count (prize count). Optional if <b>prize_type</b> is <b>money</b>.
		/// </summary>
		[JsonPropertyName("count_winners")]
		public long? CountWinners { get; init; }
		/// <summary>
		/// How much money will each winner receive. Optional if <b>prize_type</b> is <b>money</b>.
		/// </summary>
		[JsonPropertyName("prize_data_money")]
		public double? PrizeDataMoney { get; init; }
		/// <summary>
		/// Enable the distribution of money prizes by places. Optional if <b>prize_type</b> is <b>money</b>.
		/// </summary>
		[JsonPropertyName("is_money_places")]
		public bool? IsMoneyPlaces { get; init; }
		/// <summary>
		/// How much money will receive each place. Required if <b>is<i>money</i>places</b> is <b>1</b>.
		/// </summary>
		[JsonPropertyName("prize_data_places")]
		public List<double?>? PrizeDataPlaces { get; init; }
		/// <summary>
		/// Which upgrade will each winner receive. Required if <b>prize_type</b> is <b>upgrades</b>.
		/// </summary>
		[JsonPropertyName("prize_data_upgrade")]
		public PrizeDataUpgrade? PrizeDataUpgrade { get; init; }
		/// <summary>
		/// Sympathies for this week.
		/// </summary>
		[JsonPropertyName("require_like_count")]
		public required long? RequireLikeCount { get; init; }
		/// <summary>
		/// Sympathies for all time.
		/// </summary>
		[JsonPropertyName("require_total_like_count")]
		public required long? RequireTotalLikeCount { get; init; }
		/// <summary>
		/// Secret answer of your account.
		/// </summary>
		[JsonPropertyName("secret_answer")]
		public string? SecretAnswer { get; init; }
		/// <summary>
		/// Thread tags.
		/// </summary>
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		/// <summary>
		/// Allow to reply only users with chosen or higher group.
		/// <para/>
		/// Default: <c>2</c>
		/// </summary>
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
		/// <summary>
		/// Allow commenting if user can't post in thread.
		/// </summary>
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
		/// <summary>
		/// Don't alert followers about thread creation.
		/// </summary>
		[JsonPropertyName("dont_alert_followers")]
		public bool? DontAlertFollowers { get; init; }
		/// <summary>
		/// Hide contacts.
		/// </summary>
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		/// <summary>
		/// Allow ask hidden content.
		/// </summary>
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		/// <summary>
		/// Date to schedule thread creation (format: <c>DD-MM-YYYY</c>).
		/// </summary>
		[JsonPropertyName("schedule_date")]
		public string? ScheduleDate { get; init; }
		/// <summary>
		/// Time to schedule thread creation (format: <c>HH:MM</c>).
		/// </summary>
		[JsonPropertyName("schedule_time")]
		public string? ScheduleTime { get; init; }
		/// <summary>
		/// Watch thread state.
		/// </summary>
		[JsonPropertyName("watch_thread_state")]
		public bool? WatchThreadState { get; init; }
		/// <summary>
		/// Receive forum notifications of new posts in this thread.
		/// </summary>
		[JsonPropertyName("watch_thread")]
		public bool? WatchThread { get; init; }
		/// <summary>
		/// Receive email notifications of new posts in this thread.
		/// </summary>
		[JsonPropertyName("watch_thread_email")]
		public bool? WatchThreadEmail { get; init; }
	}

	public sealed record ThreadsCreateContestResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsCreateContestResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsCreateContestResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ThreadModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("thread"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModel.ReadFromReader(ref reader);
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
			return new ThreadsCreateContestResponse(v0, v1);
		}
	}

	public sealed record ThreadsClaimBody
	{
		/// <summary>
		/// To whom the complaint is filed. Specify a nickname or a link to the profile.
		/// </summary>
		[JsonPropertyName("as_responder")]
		public required string AsResponder { get; init; }
		/// <summary>
		/// Did you buy account on the market?
		/// </summary>
		[JsonPropertyName("as_is_market_deal")]
		public required bool? AsIsMarketDeal { get; init; }
		/// <summary>
		/// Market item id.
		/// Required if <b>as<i>is</i>market_deal</b> is 1.
		/// </summary>
		[JsonPropertyName("as_market_item_id")]
		public long? AsMarketItemId { get; init; }
		/// <summary>
		/// Contacts and wallets of the responder. Specify the known data about the responder, if any.
		/// Optional if <b>as<i>is</i>market_deal</b> is 0.
		/// </summary>
		[JsonPropertyName("as_data")]
		public string? AsData { get; init; }
		/// <summary>
		/// Indicate the amount by which the responder deceived you.
		/// </summary>
		[JsonPropertyName("as_amount")]
		public required double? AsAmount { get; init; }
		/// <summary>
		/// Currency of Claim.
		/// </summary>
		[JsonPropertyName("currency")]
		public Currency? Currency { get; init; }
		/// <summary>
		/// The transaction took place through a guarantor or there was a transfer to the market with a hold?
		/// Required if <b>as<i>is</i>market_deal</b> is 0.
		/// </summary>
		[JsonPropertyName("transfer_type")]
		public required TransferType TransferType { get; init; }
		/// <summary>
		/// Pay claim fee now or later. (Only for <b>transfer_type</b> = <b>notsafe</b>)
		/// </summary>
		[JsonPropertyName("pay_claim")]
		public PayClaim? PayClaim { get; init; }
		/// <summary>
		/// Funds transfer receipt.
		/// Upload a receipt for the transfer of funds, use the "View receipt" button in your wallet. May be uploaded to <see href="https://imgur.com/upload">Imgur</see>. Write "no" if you have not paid.
		/// Required if <b>as<i>is</i>market_deal</b> is 0.
		/// </summary>
		[JsonPropertyName("as_funds_receipt")]
		public string? AsFundsReceipt { get; init; }
		/// <summary>
		/// Screenshot showing the respondent's Telegram login.
		/// If the correspondence was conducted in Telegram, upload a screenshot that will display the respondent's Telegram login against the background of your dialogue. The screenshot may be uploaded to <see href="https://imgur.com/upload">Imgur</see>. If the correspondence was conducted elsewhere, write "no".
		/// </summary>
		[JsonPropertyName("as_tg_login_screenshot")]
		public string? AsTgLoginScreenshot { get; init; }
		/// <summary>
		/// Thread tags.
		/// </summary>
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		/// <summary>
		/// Hide contacts.
		/// </summary>
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		/// <summary>
		/// Allow ask hidden content.
		/// </summary>
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		/// <summary>
		/// Allow to reply only users with chosen or higher group.
		/// <para/>
		/// Default: <c>2</c>
		/// </summary>
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
		/// <summary>
		/// Allow commenting if user can't post in thread.
		/// </summary>
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
		/// <summary>
		/// Don't alert followers about thread creation.
		/// </summary>
		[JsonPropertyName("dont_alert_followers")]
		public bool? DontAlertFollowers { get; init; }
		/// <summary>
		/// Date to schedule thread creation (format: <c>DD-MM-YYYY</c>).
		/// </summary>
		[JsonPropertyName("schedule_date")]
		public string? ScheduleDate { get; init; }
		/// <summary>
		/// Time to schedule thread creation (format: <c>HH:MM</c>).
		/// </summary>
		[JsonPropertyName("schedule_time")]
		public string? ScheduleTime { get; init; }
		/// <summary>
		/// Watch thread state.
		/// </summary>
		[JsonPropertyName("watch_thread_state")]
		public bool? WatchThreadState { get; init; }
		/// <summary>
		/// Receive forum notifications of new posts in this thread.
		/// </summary>
		[JsonPropertyName("watch_thread")]
		public bool? WatchThread { get; init; }
		/// <summary>
		/// Receive email notifications of new posts in this thread.
		/// </summary>
		[JsonPropertyName("watch_thread_email")]
		public bool? WatchThreadEmail { get; init; }
		/// <summary>
		/// You should describe what's happened.
		/// <list type="bullet">
		/// <item><description>describe the situation in a nutshell. If you wish, you can describe the situation in more detail using the "Spoiler" function.</description></item>
		/// <item><description>attach screenshots of correspondence. You may upload to the site <see href="https://imgur.com/upload">Imgur</see> - for convenience, use Ctrl + V when uploading screenshots to the album.</description></item>
		/// <item><description>other evidence;</description></item>
		/// <item><description>notify the respondent about the complaint you created, familiarize him with hidden content</description></item>
		/// </list>
		/// <para/>
		/// Describe the situation in as much detail as possible.
		/// </summary>
		[JsonPropertyName("post_body")]
		public required string PostBody { get; init; }
	}

	public sealed record ThreadsClaimResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsClaimResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsClaimResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ThreadModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("thread"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModel.ReadFromReader(ref reader);
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
			return new ThreadsClaimResponse(v0, v1);
		}
	}

	public sealed record ThreadsGetParams
	{
		/// <summary>
		/// List of fields to include.
		/// </summary>
		[JsonPropertyName("fields_include")]
		public List<ThreadsFieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record ThreadsGetResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ThreadModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("thread"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModel.ReadFromReader(ref reader);
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
			return new ThreadsGetResponse(v0, v1);
		}
	}

	public sealed record ThreadsEditBody
	{
		/// <summary>
		/// Thread title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Thread title english.
		/// </summary>
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		/// <summary>
		/// Prefix ids. Set "0" to remove all thread prefixes.
		/// </summary>
		[JsonPropertyName("prefix_id")]
		public List<long?>? PrefixId { get; init; }
		/// <summary>
		/// Thread tags.
		/// </summary>
		[JsonPropertyName("tags")]
		public List<string>? Tags { get; init; }
		/// <summary>
		/// Discussion state.
		/// </summary>
		[JsonPropertyName("discussion_open")]
		public bool? DiscussionOpen { get; init; }
		/// <summary>
		/// Hide contacts.
		/// </summary>
		[JsonPropertyName("hide_contacts")]
		public bool? HideContacts { get; init; }
		/// <summary>
		/// Allow ask hidden content.
		/// </summary>
		[JsonPropertyName("allow_ask_hidden_content")]
		public bool? AllowAskHiddenContent { get; init; }
		/// <summary>
		/// Allow to reply only users with chosen or higher group.
		/// </summary>
		[JsonPropertyName("reply_group")]
		public ReplyGroup? ReplyGroup { get; init; }
		/// <summary>
		/// Allow commenting if user can't post in thread.
		/// </summary>
		[JsonPropertyName("comment_ignore_group")]
		public bool? CommentIgnoreGroup { get; init; }
	}

	public sealed record ThreadsEditResponse(
		[property: JsonPropertyName("thread")] Resp_ThreadModel Thread,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsEditResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsEditResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			Resp_ThreadModel v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("thread"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModel.ReadFromReader(ref reader);
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
			return new ThreadsEditResponse(v0, v1);
		}
	}

	public sealed record ThreadsDeleteBody
	{
		/// <summary>
		/// Reason of the thread removal.
		/// </summary>
		[JsonPropertyName("reason")]
		public string? Reason { get; init; }
	}

	public sealed record ThreadsDeleteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsDeleteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsDeleteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsDeleteResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsMoveBody
	{
		/// <summary>
		/// Forum id.
		/// </summary>
		[JsonPropertyName("node_id")]
		public required string NodeId { get; init; }
		/// <summary>
		/// Thread title.
		/// </summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
		/// <summary>
		/// Thread title english.
		/// </summary>
		[JsonPropertyName("title_en")]
		public string? TitleEn { get; init; }
		/// <summary>
		/// Prefix ids. Set "0" to remove all thread prefixes.
		/// </summary>
		[JsonPropertyName("prefix_id")]
		public List<long?>? PrefixId { get; init; }
		/// <summary>
		/// Apply thread prefix.
		/// </summary>
		[JsonPropertyName("apply_thread_prefix")]
		public bool? ApplyThreadPrefix { get; init; }
		/// <summary>
		/// Send a notification to users who are followed to target node.
		/// </summary>
		[JsonPropertyName("send_alert")]
		public bool? SendAlert { get; init; }
	}

	public sealed record ThreadsMoveResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsMoveResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsMoveResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsMoveResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsBumpResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsBumpResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsBumpResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsBumpResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsHideResponse(
		[property: JsonPropertyName("status")] string Status,
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsHideResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsHideResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsHideResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsStarResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsStarResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsStarResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsStarResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsUnstarResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsUnstarResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsUnstarResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsUnstarResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsFollowersResponse(
		[property: JsonPropertyName("users")] List<ThreadsFollowersResponseUsers> Users,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsFollowersResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsFollowersResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ThreadsFollowersResponseUsers> v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("users"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ThreadsFollowersResponseUsers>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ThreadsFollowersResponseUsers.ReadFromReader(ref reader);
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
			return new ThreadsFollowersResponse(v0, v1);
		}
	}

public sealed record ThreadsFollowersResponseUsersFollow(
	[property: JsonPropertyName("alert")] bool Alert,
	[property: JsonPropertyName("email")] bool Email
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsFollowersResponseUsersFollow ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsFollowersResponseUsersFollow ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("alert"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("email"u8))
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
		return new ThreadsFollowersResponseUsersFollow(v0, v1);
	}
}

public sealed record ThreadsFollowersResponseUsers(
	[property: JsonPropertyName("user_id")] long UserId,
	[property: JsonPropertyName("username")] string Username,
	[property: JsonPropertyName("follow")] ThreadsFollowersResponseUsersFollow Follow
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsFollowersResponseUsers ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsFollowersResponseUsers ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		ThreadsFollowersResponseUsersFollow v2 = null!;
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
				v2 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsFollowersResponseUsersFollow.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ThreadsFollowersResponseUsers(v0, v1, v2);
	}
}

	public sealed record ThreadsFollowBody
	{
		/// <summary>
		/// Whether to receive notification as email.
		/// </summary>
		[JsonPropertyName("email")]
		public bool? Email { get; init; }
	}

	public sealed record ThreadsFollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsFollowResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsFollowResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsFollowResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsUnfollowResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsUnfollowResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsUnfollowResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsUnfollowResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsFollowedParams
	{
		/// <summary>
		/// If included in the request, only the thread count is returned as <b>threads_total</b>.
		/// </summary>
		[JsonPropertyName("total")]
		public bool? Total { get; init; }
		/// <summary>
		/// List of fields to include.
		/// </summary>
		[JsonPropertyName("fields_include")]
		public List<ThreadsFieldsInclude>? FieldsInclude { get; init; }
	}

	public sealed record ThreadsFollowedResponse(
		[property: JsonPropertyName("threads")] List<Resp_ThreadModel> Threads,
		[property: JsonPropertyName("threads_total")] long ThreadsTotal,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsFollowedResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsFollowedResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<Resp_ThreadModel> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("threads"u8))
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
				else if (reader.ValueTextEquals("threads_total"u8))
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
			return new ThreadsFollowedResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsNavigationResponse(
		[property: JsonPropertyName("elements")] List<ThreadsNavigationResponseElements> Elements,
		[property: JsonPropertyName("elements_count")] long ElementsCount,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsNavigationResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsNavigationResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ThreadsNavigationResponseElements> v0 = null!;
			long v1 = default;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("elements"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ThreadsNavigationResponseElements>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ThreadsNavigationResponseElements.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("elements_count"u8))
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
			return new ThreadsNavigationResponse(v0, v1, v2);
		}
	}

public sealed record ThreadsNavigationResponseElementsLinks(
	[property: JsonPropertyName("permalink")] string Permalink,
	[property: JsonPropertyName("detail")] string Detail,
	[property: JsonPropertyName("sub-categories")] string SubCategories,
	[property: JsonPropertyName("sub-forums")] string SubForums,
	[property: JsonPropertyName("sub-elements")] string SubElements
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsNavigationResponseElementsLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsNavigationResponseElementsLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		string v2 = null!;
		string v3 = null!;
		string v4 = null!;
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
			else if (reader.ValueTextEquals("sub-elements"u8))
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
		return new ThreadsNavigationResponseElementsLinks(v0, v1, v2, v3, v4);
	}
}

public sealed record ThreadsNavigationResponseElementsPermissions(
	[property: JsonPropertyName("view")] bool View,
	[property: JsonPropertyName("edit")] bool Edit,
	[property: JsonPropertyName("delete")] bool Delete
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsNavigationResponseElementsPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsNavigationResponseElementsPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		bool v2 = default;
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
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ThreadsNavigationResponseElementsPermissions(v0, v1, v2);
	}
}

public sealed record ThreadsNavigationResponseElements(
	[property: JsonPropertyName("category_id")] long CategoryId,
	[property: JsonPropertyName("category_title")] string CategoryTitle,
	[property: JsonPropertyName("category_description")] string CategoryDescription,
	[property: JsonPropertyName("links")] ThreadsNavigationResponseElementsLinks Links,
	[property: JsonPropertyName("permissions")] ThreadsNavigationResponseElementsPermissions Permissions,
	[property: JsonPropertyName("navigation_type")] string NavigationType,
	[property: JsonPropertyName("navigation_id")] long NavigationId,
	[property: JsonPropertyName("navigation_depth")] long NavigationDepth,
	[property: JsonPropertyName("navigation_parent_id")] long NavigationParentId,
	[property: JsonPropertyName("has_sub_elements")] bool HasSubElements
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsNavigationResponseElements ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsNavigationResponseElements ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		ThreadsNavigationResponseElementsLinks v3 = null!;
		ThreadsNavigationResponseElementsPermissions v4 = null!;
		string v5 = null!;
		long v6 = default;
		long v7 = default;
		long v8 = default;
		bool v9 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("category_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("category_title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("category_description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v3 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsNavigationResponseElementsLinks.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v4 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsNavigationResponseElementsPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("navigation_type"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("navigation_id"u8))
			{
				reader.Read();
				v6 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("navigation_depth"u8))
			{
				reader.Read();
				v7 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("navigation_parent_id"u8))
			{
				reader.Read();
				v8 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("has_sub_elements"u8))
			{
				reader.Read();
				v9 = reader.GetBoolean();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ThreadsNavigationResponseElements(v0, v1, v2, v3, v4, v5, v6, v7, v8, v9);
	}
}

	public sealed record ThreadsPollGetResponse(
		[property: JsonPropertyName("poll")] ThreadsPollGetResponsePoll Poll,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsPollGetResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsPollGetResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			ThreadsPollGetResponsePoll v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("poll"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsPollGetResponsePoll.ReadFromReader(ref reader);
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
			return new ThreadsPollGetResponse(v0, v1);
		}
	}

public sealed record ThreadsPollGetResponsePollResponses(
	[property: JsonPropertyName("response_id")] long ResponseId,
	[property: JsonPropertyName("response_answer")] string ResponseAnswer,
	[property: JsonPropertyName("response_vote_count")] long ResponseVoteCount
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsPollGetResponsePollResponses ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsPollGetResponsePollResponses ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("response_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("response_answer"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("response_vote_count"u8))
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
		return new ThreadsPollGetResponsePollResponses(v0, v1, v2);
	}
}

public sealed record ThreadsPollGetResponsePollPermissions(
	[property: JsonPropertyName("vote")] bool Vote,
	[property: JsonPropertyName("result")] bool Result
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsPollGetResponsePollPermissions ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsPollGetResponsePollPermissions ReadFromReader(ref Utf8JsonReader reader)
	{
		bool v0 = default;
		bool v1 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("vote"u8))
			{
				reader.Read();
				v0 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("result"u8))
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
		return new ThreadsPollGetResponsePollPermissions(v0, v1);
	}
}

public sealed record ThreadsPollGetResponsePollLinks(
	[property: JsonPropertyName("vote")] string Vote
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsPollGetResponsePollLinks ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsPollGetResponsePollLinks ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("vote"u8))
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
		return new ThreadsPollGetResponsePollLinks(v0);
	}
}

public sealed record ThreadsPollGetResponsePoll(
	[property: JsonPropertyName("poll_id")] long PollId,
	[property: JsonPropertyName("poll_question")] string PollQuestion,
	[property: JsonPropertyName("poll_vote_count")] long PollVoteCount,
	[property: JsonPropertyName("poll_max_votes")] long PollMaxVotes,
	[property: JsonPropertyName("poll_is_open")] bool PollIsOpen,
	[property: JsonPropertyName("poll_is_voted")] bool PollIsVoted,
	[property: JsonPropertyName("responses")] List<ThreadsPollGetResponsePollResponses> Responses,
	[property: JsonPropertyName("permissions")] ThreadsPollGetResponsePollPermissions Permissions,
	[property: JsonPropertyName("links")] ThreadsPollGetResponsePollLinks Links
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsPollGetResponsePoll ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsPollGetResponsePoll ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		long v2 = default;
		long v3 = default;
		bool v4 = default;
		bool v5 = default;
		List<ThreadsPollGetResponsePollResponses> v6 = null!;
		ThreadsPollGetResponsePollPermissions v7 = null!;
		ThreadsPollGetResponsePollLinks v8 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("poll_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poll_question"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("poll_vote_count"u8))
			{
				reader.Read();
				v2 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poll_max_votes"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("poll_is_open"u8))
			{
				reader.Read();
				v4 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("poll_is_voted"u8))
			{
				reader.Read();
				v5 = reader.GetBoolean();
			}
			else if (reader.ValueTextEquals("responses"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<ThreadsPollGetResponsePollResponses>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = ThreadsPollGetResponsePollResponses.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v6 = __lst;
				}
			}
			else if (reader.ValueTextEquals("permissions"u8))
			{
				reader.Read();
				v7 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsPollGetResponsePollPermissions.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("links"u8))
			{
				reader.Read();
				v8 = reader.TokenType == JsonTokenType.Null ? null! : ThreadsPollGetResponsePollLinks.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ThreadsPollGetResponsePoll(v0, v1, v2, v3, v4, v5, v6, v7, v8);
	}
}

	public sealed record ThreadsPollVoteBody
	{
		/// <summary>
		/// The id of the response to vote for. Can be skipped if <b>response_ids</b> set.
		/// </summary>
		[JsonPropertyName("response_id")]
		public long? ResponseId { get; init; }
		/// <summary>
		/// An array of ids of responses (if the poll allows multiple choices).
		/// </summary>
		[JsonPropertyName("response_ids")]
		public List<long?>? ResponseIds { get; init; }
	}

	public sealed record ThreadsPollVoteResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsPollVoteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsPollVoteResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsPollVoteResponse(v0, v1, v2);
		}
	}

	public sealed record ThreadsUnreadParams
	{
		/// <summary>
		/// Maximum number of result threads. The limit may get decreased if the value is too large (depending on the system configuration).
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// Id of the container forum to search for threads. Child forums of the specified forum will be included in the search.
		/// </summary>
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		/// <summary>
		/// Number of thread data to be returned. Default value is 20.
		/// </summary>
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
	}

	public sealed record ThreadsUnreadResponse(
		[property: JsonPropertyName("threads")] List<ThreadsUnreadResponseThreads> Threads,
		[property: JsonPropertyName("data")] List<Resp_ThreadModel> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsUnreadResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsUnreadResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ThreadsUnreadResponseThreads> v0 = null!;
			List<Resp_ThreadModel> v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("threads"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ThreadsUnreadResponseThreads>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ThreadsUnreadResponseThreads.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data"u8))
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
			return new ThreadsUnreadResponse(v0, v1, v2);
		}
	}

public sealed record ThreadsUnreadResponseThreads(
	[property: JsonPropertyName("thread_id")] long ThreadId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsUnreadResponseThreads ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsUnreadResponseThreads ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ThreadsUnreadResponseThreads(v0);
	}
}

	public sealed record ThreadsRecentParams
	{
		/// <summary>
		/// Maximum number of days to search for threads.
		/// </summary>
		[JsonPropertyName("days")]
		public long? Days { get; init; }
		/// <summary>
		/// Maximum number of result threads. The limit may get decreased if the value is too large.
		/// </summary>
		[JsonPropertyName("limit")]
		public long? Limit { get; init; }
		/// <summary>
		/// Id of the container forum to search for threads. Child forums of the specified forum will be included in the search.
		/// </summary>
		[JsonPropertyName("forum_id")]
		public long? ForumId { get; init; }
		/// <summary>
		/// Number of thread data to be returned. Default value is 20.
		/// </summary>
		[JsonPropertyName("data_limit")]
		public long? DataLimit { get; init; }
	}

	public sealed record ThreadsRecentResponse(
		[property: JsonPropertyName("threads")] List<ThreadsRecentResponseThreads> Threads,
		[property: JsonPropertyName("data")] List<Resp_ThreadModel> Data,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsRecentResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsRecentResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<ThreadsRecentResponseThreads> v0 = null!;
			List<Resp_ThreadModel> v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("threads"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<ThreadsRecentResponseThreads>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = ThreadsRecentResponseThreads.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("data"u8))
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
			return new ThreadsRecentResponse(v0, v1, v2);
		}
	}

public sealed record ThreadsRecentResponseThreads(
	[property: JsonPropertyName("thread_id")] long ThreadId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static ThreadsRecentResponseThreads ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static ThreadsRecentResponseThreads ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("thread_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new ThreadsRecentResponseThreads(v0);
	}
}

	public sealed record ThreadsFinishResponse(
		[property: JsonPropertyName("status")] string? Status,
		[property: JsonPropertyName("message")] string? Message,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static ThreadsFinishResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static ThreadsFinishResponse ReadFromReader(ref Utf8JsonReader reader)
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
			return new ThreadsFinishResponse(v0, v1, v2);
		}
	}

}
