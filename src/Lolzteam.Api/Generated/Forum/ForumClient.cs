// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Text.Json;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Api.Generated.Forum;

public sealed class AssetsApi
{
	private readonly LolzteamHttpClient _http;

	public AssetsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Gets css rulesets for requested selectors.
	/// </summary>
	public async Task<AssetsApiTypes.AssetsCssResponse> CssAsync(AssetsApiTypes.AssetsCssParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/css",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, AssetsApiTypes.AssetsCssResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class BatchApi
{
	private readonly LolzteamHttpClient _http;

	public BatchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Execute multiple API requests at once (Separated by comma). Maximum batch jobs is 10.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description>Same as called API requests.</description></item>
	/// </list>
	/// </summary>
	public async Task<BatchApiTypes.BatchExecuteResponse> ExecuteAsync(List<JsonElement>? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, BatchApiTypes.BatchExecuteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CategoriesApi
{
	private readonly LolzteamHttpClient _http;

	public CategoriesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of all categories in the system.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<CategoriesApiTypes.CategoriesListResponse> ListAsync(CategoriesApiTypes.CategoriesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/categories",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, CategoriesApiTypes.CategoriesListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a category.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<CategoriesApiTypes.CategoriesGetResponse> GetAsync(long CategoryId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/categories/{CategoryId}",
		};
		return await _http.RequestAsync(__opts, CategoriesApiTypes.CategoriesGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ChatboxApi
{
	private readonly LolzteamHttpClient _http;

	public ChatboxApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Get chat rooms.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxIndexResponse> IndexAsync(ChatboxApiTypes.ChatboxIndexParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxIndexResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get chat messages.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxGetMessagesResponse> GetMessagesAsync(ChatboxApiTypes.ChatboxGetMessagesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxGetMessagesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create chat message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxPostMessageResponse> PostMessageAsync(ChatboxApiTypes.ChatboxPostMessageBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxPostMessageResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit chat message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxEditMessageResponse> EditMessageAsync(ChatboxApiTypes.ChatboxEditMessageBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = "/chatbox/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxEditMessageResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete chat message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxDeleteMessageResponse> DeleteMessageAsync(ChatboxApiTypes.ChatboxDeleteMessageBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxDeleteMessageResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get chat Online Users.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxOnlineResponse> OnlineAsync(ChatboxApiTypes.ChatboxOnlineParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/online",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxOnlineResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Report chat message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxReportReasonsResponse> ReportReasonsAsync(ChatboxApiTypes.ChatboxReportReasonsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/report",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxReportReasonsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Report chat message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxReportResponse> ReportAsync(ChatboxApiTypes.ChatboxReportBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxReportResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get chat leaderboard.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxGetLeaderboardResponse> GetLeaderboardAsync(ChatboxApiTypes.ChatboxGetLeaderboardParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/leaderboard",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxGetLeaderboardResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get list of ignored chat users.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxGetIgnoreResponse> GetIgnoreAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/ignore",
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxGetIgnoreResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Ignore chat user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxPostIgnoreResponse> PostIgnoreAsync(ChatboxApiTypes.ChatboxPostIgnoreBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/ignore",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxPostIgnoreResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unignore chat user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>chatbox</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ChatboxApiTypes.ChatboxDeleteIgnoreResponse> DeleteIgnoreAsync(ChatboxApiTypes.ChatboxDeleteIgnoreBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/ignore",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ChatboxApiTypes.ChatboxDeleteIgnoreResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ConversationsApi
{
	private readonly LolzteamHttpClient _http;

	public ConversationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of conversations (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsListResponse> ListAsync(ConversationsApiTypes.ConversationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/conversations",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a new conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsCreateResponse> CreateAsync(ConversationsApiTypes.ConversationsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsUpdateResponse> UpdateAsync(ConversationsApiTypes.ConversationsUpdateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = "/conversations",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsUpdateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Leave the conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsDeleteResponse> DeleteAsync(ConversationsApiTypes.ConversationsDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/conversations",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Start a new conversation with a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsStartResponse> StartAsync(ConversationsApiTypes.ConversationsStartBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/start",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsStartResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Send content to Saved Messages.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsSaveResponse> SaveAsync(ConversationsApiTypes.ConversationsSaveBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/save",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsSaveResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsGetResponse> GetAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of messages in a conversation (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsMessagesListResponse> MessagesListAsync(long ConversationId, ConversationsApiTypes.ConversationsMessagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsMessagesListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a new conversation message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsMessagesCreateResponse> MessagesCreateAsync(long ConversationId, ConversationsApiTypes.ConversationsMessagesCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsMessagesCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Search for conversations messages or recipients.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsSearchResponse> SearchAsync(ConversationsApiTypes.ConversationsSearchBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsSearchResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsMessagesGetResponse> MessagesGetAsync(long MessageId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/messages/{MessageId}",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsMessagesGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit a message.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsMessagesEditResponse> MessagesEditAsync(long ConversationId, long MessageId, ConversationsApiTypes.ConversationsMessagesEditBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsMessagesEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Deletes a message from a conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsMessagesDeleteResponse> MessagesDeleteAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsMessagesDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Invite one or more users to an existing conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>conversate</b></description></item>
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsInviteResponse> InviteAsync(long ConversationId, ConversationsApiTypes.ConversationsInviteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/invite",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsInviteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Kicks a user from a conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsKickResponse> KickAsync(long ConversationId, ConversationsApiTypes.ConversationsKickBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/kick",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsKickResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Read a specific conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsReadResponse> ReadAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/read",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsReadResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Mark all conversations as read.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsReadAllResponse> ReadAllAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/read-all",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsReadAllResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Stick a message in a conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsMessagesStickResponse> MessagesStickAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsMessagesStickResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unstick a message in a conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsMessagesUnstickResponse> MessagesUnstickAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsMessagesUnstickResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Star conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsStarResponse> StarAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/star",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsStarResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unstar conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsUnstarResponse> UnstarAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/star",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsUnstarResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Enable alerts for conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsAlertsEnableResponse> AlertsEnableAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/alerts",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsAlertsEnableResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Disable alerts for conversation.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// <item><description><b>conversate</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ConversationsApiTypes.ConversationsAlertsDisableResponse> AlertsDisableAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/alerts",
		};
		return await _http.RequestAsync(__opts, ConversationsApiTypes.ConversationsAlertsDisableResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class FormsApi
{
	private readonly LolzteamHttpClient _http;

	public FormsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Get Forms List
	/// </summary>
	public async Task<FormsApiTypes.FormsListResponse> ListAsync(FormsApiTypes.FormsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/forms",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, FormsApiTypes.FormsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create Form.
	/// </summary>
	public async Task<FormsApiTypes.FormsCreateResponse> CreateAsync(FormsApiTypes.FormsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/forms/save",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, FormsApiTypes.FormsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ForumsApi
{
	private readonly LolzteamHttpClient _http;

	public ForumsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of all forums in the system.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsListResponse> ListAsync(ForumsApiTypes.ForumsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/forums",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Returns grouped forums.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsGroupedResponse> GroupedAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/forums/grouped",
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsGroupedResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a forum.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsGetResponse> GetAsync(long ForumId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}",
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of a forum's followers. For privacy reason, only the current user will be included in the list (if the user follows the specified forum).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsFollowersResponse> FollowersAsync(long ForumId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}/followers",
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsFollowersResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Follow a forum.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsFollowResponse> FollowAsync(long ForumId, ForumsApiTypes.ForumsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/forums/{ForumId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsFollowResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unfollow a forum.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsUnfollowResponse> UnfollowAsync(long ForumId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/forums/{ForumId}/followers",
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsUnfollowResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of followed forums by current user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsFollowedResponse> FollowedAsync(ForumsApiTypes.ForumsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/forums/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsFollowedResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Returns available options for the forums feed.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsGetFeedOptionsResponse> GetFeedOptionsAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/forums/feed/options",
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsGetFeedOptionsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit feed options.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ForumsApiTypes.ForumsEditFeedOptionsResponse> EditFeedOptionsAsync(ForumsApiTypes.ForumsEditFeedOptionsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = "/forums/feed/options",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ForumsApiTypes.ForumsEditFeedOptionsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class LinksApi
{
	private readonly LolzteamHttpClient _http;

	public LinksApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of all link forums.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<LinksApiTypes.LinksListResponse> ListAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/link-forums",
		};
		return await _http.RequestAsync(__opts, LinksApiTypes.LinksListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a link forum.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<LinksApiTypes.LinksGetResponse> GetAsync(long LinkId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/link-forums/{LinkId}",
		};
		return await _http.RequestAsync(__opts, LinksApiTypes.LinksGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class NavigationApi
{
	private readonly LolzteamHttpClient _http;

	public NavigationApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of navigation elements within the system.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<NavigationApiTypes.NavigationListResponse> ListAsync(NavigationApiTypes.NavigationListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/navigation",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, NavigationApiTypes.NavigationListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class NotificationsApi
{
	private readonly LolzteamHttpClient _http;

	public NotificationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of notifications (both read and unread).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<NotificationsApiTypes.NotificationsListResponse> ListAsync(NotificationsApiTypes.NotificationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/notifications",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, NotificationsApiTypes.NotificationsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get associated content of notification. The response depends on the content type.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<NotificationsApiTypes.NotificationsGetResponse> GetAsync(long NotificationId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/notifications/{NotificationId}/content",
		};
		return await _http.RequestAsync(__opts, NotificationsApiTypes.NotificationsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Mark single notification or all existing notifications read.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<NotificationsApiTypes.NotificationsReadResponse> ReadAsync(NotificationsApiTypes.NotificationsReadBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/notifications/read",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, NotificationsApiTypes.NotificationsReadResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class OAuthApi
{
	private readonly LolzteamHttpClient _http;

	public OAuthApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Obtain an access token using various grant types.
	/// <para/>
	/// Supports the following grant types:
	/// <list type="bullet">
	/// <item><description>Client Credentials</description></item>
	/// <item><description>Authorization Code</description></item>
	/// <item><description>Refresh Token</description></item>
	/// <item><description>Password</description></item>
	/// </list>
	/// </summary>
	public async Task<OAuthApiTypes.OAuthTokenResponse> TokenAsync(OAuthApiTypes.OAuthTokenBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/oauth/token",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Multipart,
		};
		return await _http.RequestAsync(__opts, OAuthApiTypes.OAuthTokenResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PagesApi
{
	private readonly LolzteamHttpClient _http;

	public PagesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of all pages in the system.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PagesApiTypes.PagesListResponse> ListAsync(PagesApiTypes.PagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/pages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PagesApiTypes.PagesListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a page.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PagesApiTypes.PagesGetResponse> GetAsync(long PageId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/pages/{PageId}",
		};
		return await _http.RequestAsync(__opts, PagesApiTypes.PagesGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PostsApi
{
	private readonly LolzteamHttpClient _http;

	public PostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of posts in a thread (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsListResponse> ListAsync(PostsApiTypes.PostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a new post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsCreateResponse> CreateAsync(PostsApiTypes.PostsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/posts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsGetResponse> GetAsync(long PostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}",
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit a post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsEditResponse> EditAsync(long PostId, PostsApiTypes.PostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete a post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsDeleteResponse> DeleteAsync(long PostId, PostsApiTypes.PostsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of users who liked a post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsLikesResponse> LikesAsync(long PostId, PostsApiTypes.PostsLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsLikesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Like a post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsLikeResponse> LikeAsync(long PostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/likes",
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsLikeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unlike a post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsUnlikeResponse> UnlikeAsync(long PostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}/likes",
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsUnlikeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get post report reasons.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsReportReasonsResponse> ReportReasonsAsync(long PostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/report",
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsReportReasonsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Report a post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsReportResponse> ReportAsync(long PostId, PostsApiTypes.PostsReportBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsReportResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of post comments in a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsCommentsGetResponse> CommentsGetAsync(PostsApiTypes.PostsCommentsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsCommentsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsCommentsCreateResponse> CommentsCreateAsync(PostsApiTypes.PostsCommentsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsCommentsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit a post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsCommentsEditResponse> CommentsEditAsync(PostsApiTypes.PostsCommentsEditBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = "/posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsCommentsEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete a post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsCommentsDeleteResponse> CommentsDeleteAsync(PostsApiTypes.PostsCommentsDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsCommentsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Report a post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PostsApiTypes.PostsCommentsReportResponse> CommentsReportAsync(PostsApiTypes.PostsCommentsReportBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PostsApiTypes.PostsCommentsReportResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProfilePostsApi
{
	private readonly LolzteamHttpClient _http;

	public ProfilePostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of profile posts (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsListResponse> ListAsync(Lolzteam.Api.Runtime.StringOrLong UserId, ProfilePostsApiTypes.ProfilePostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/profile-posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsGetResponse> GetAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsEditResponse> EditAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = $"/profile-posts/{ProfilePostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsDeleteResponse> DeleteAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsDeleteParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get Profile Post Report Reasons.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsReportReasonsResponse> ReportReasonsAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/report",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsReportReasonsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Report a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsReportResponse> ReportAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsReportBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsReportResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a profile post on a user profile.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsCreateResponse> CreateAsync(ProfilePostsApiTypes.ProfilePostsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Stick a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsStickResponse> StickAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsStickResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unstick a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsUnstickResponse> UnstickAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsUnstickResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of users who liked a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsLikesResponse> LikesAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsLikesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Like a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsLikeResponse> LikeAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsLikeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unlike a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsUnlikeResponse> UnlikeAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsUnlikeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of comments of a profile post.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsListResponse> CommentsListAsync(ProfilePostsApiTypes.ProfilePostsCommentsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/profile-posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsCommentsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a new profile post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse> CommentsCreateAsync(ProfilePostsApiTypes.ProfilePostsCommentsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit a profile post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsEditResponse> CommentsEditAsync(ProfilePostsApiTypes.ProfilePostsCommentsEditBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = "/profile-posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsCommentsEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete a profile post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse> CommentsDeleteAsync(ProfilePostsApiTypes.ProfilePostsCommentsDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/profile-posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a profile post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsGetResponse> CommentsGetAsync(long ProfilePostId, long CommentId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/comments/{CommentId}",
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsCommentsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Report a profile post comment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsReportResponse> CommentsReportAsync(long CommentId, ProfilePostsApiTypes.ProfilePostsCommentsReportBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/comments/{CommentId}/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfilePostsApiTypes.ProfilePostsCommentsReportResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class SearchApi
{
	private readonly LolzteamHttpClient _http;

	public SearchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Search for all supported contents.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<SearchApiTypes.SearchAllResponse> AllAsync(SearchApiTypes.SearchAllBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, SearchApiTypes.SearchAllResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Search for threads.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<SearchApiTypes.SearchThreadsResponse> ThreadsAsync(SearchApiTypes.SearchThreadsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/search/threads",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, SearchApiTypes.SearchThreadsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Search for posts.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<SearchApiTypes.SearchPostsResponse> PostsAsync(SearchApiTypes.SearchPostsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/search/posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, SearchApiTypes.SearchPostsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Search for users.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<SearchApiTypes.SearchUsersResponse> UsersAsync(SearchApiTypes.SearchUsersBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/search/users",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, SearchApiTypes.SearchUsersResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Search for profile posts.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<SearchApiTypes.SearchProfilePostsResponse> ProfilePostsAsync(SearchApiTypes.SearchProfilePostsBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/search/profile-posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, SearchApiTypes.SearchProfilePostsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Search for tagged contents.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<SearchApiTypes.SearchTaggedResponse> TaggedAsync(SearchApiTypes.SearchTaggedBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/search/tagged",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, SearchApiTypes.SearchTaggedResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of search results (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>get</b></description></item>
	/// </list>
	/// </summary>
	public async Task<SearchApiTypes.SearchResultsResponse> ResultsAsync(Lolzteam.Api.Runtime.StringOrLong SearchId, SearchApiTypes.SearchResultsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/search/{SearchId}/results",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, SearchApiTypes.SearchResultsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class TagsApi
{
	private readonly LolzteamHttpClient _http;

	public TagsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of popular tags (no pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<TagsApiTypes.TagsPopularResponse> PopularAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/tags",
		};
		return await _http.RequestAsync(__opts, TagsApiTypes.TagsPopularResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of tags.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<TagsApiTypes.TagsListResponse> ListAsync(TagsApiTypes.TagsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/tags/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, TagsApiTypes.TagsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of tagged contents.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<TagsApiTypes.TagsGetResponse> GetAsync(long TagId, TagsApiTypes.TagsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/tags/{TagId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, TagsApiTypes.TagsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Filtered list of tags.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<TagsApiTypes.TagsFindResponse> FindAsync(TagsApiTypes.TagsFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/tags/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, TagsApiTypes.TagsFindResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ThreadsApi
{
	private readonly LolzteamHttpClient _http;

	public ThreadsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of threads in a forum (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsListResponse> ListAsync(ThreadsApiTypes.ThreadsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/threads",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a new thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsCreateResponse> CreateAsync(ThreadsApiTypes.ThreadsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/threads",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a new contest.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsCreateContestResponse> CreateContestAsync(ThreadsApiTypes.ThreadsCreateContestBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/contests",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsCreateContestResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a Claim.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsClaimResponse> ClaimAsync(ThreadsApiTypes.ThreadsClaimBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsClaimResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsGetResponse> GetAsync(long ThreadId, ThreadsApiTypes.ThreadsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsEditResponse> EditAsync(long ThreadId, ThreadsApiTypes.ThreadsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsDeleteResponse> DeleteAsync(long ThreadId, ThreadsApiTypes.ThreadsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Move a thread to another forum.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsMoveResponse> MoveAsync(long ThreadId, ThreadsApiTypes.ThreadsMoveBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/move",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsMoveResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Bump a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsBumpResponse> BumpAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/bump",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsBumpResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Hide a thread from your feed.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsHideResponse> HideAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/hide",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsHideResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Bookmark a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsStarResponse> StarAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/star",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsStarResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unbookmark a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsUnstarResponse> UnstarAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/star",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsUnstarResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of a thread's followers. For privacy reason, only the current user will be included in the list.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsFollowersResponse> FollowersAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/followers",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsFollowersResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Follow a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsFollowResponse> FollowAsync(long ThreadId, ThreadsApiTypes.ThreadsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsFollowResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unfollow a thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsUnfollowResponse> UnfollowAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/followers",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsUnfollowResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of followed threads by current user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsFollowedResponse> FollowedAsync(ThreadsApiTypes.ThreadsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/threads/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsFollowedResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of navigation elements to reach the specified thread.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsNavigationResponse> NavigationAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/navigation",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsNavigationResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a poll.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsPollGetResponse> PollGetAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/poll",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsPollGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Vote on a thread poll.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsPollVoteResponse> PollVoteAsync(long ThreadId, ThreadsApiTypes.ThreadsPollVoteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/poll/votes",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsPollVoteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of unread threads (must be logged in).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsUnreadResponse> UnreadAsync(ThreadsApiTypes.ThreadsUnreadParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/threads/new",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsUnreadResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of recent threads.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsRecentResponse> RecentAsync(ThreadsApiTypes.ThreadsRecentParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/threads/recent",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsRecentResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Finishes a contest.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<ThreadsApiTypes.ThreadsFinishResponse> FinishAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/contests/{ThreadId}/finish",
		};
		return await _http.RequestAsync(__opts, ThreadsApiTypes.ThreadsFinishResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class UsersApi
{
	private readonly LolzteamHttpClient _http;

	public UsersApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// List of users (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersListResponse> ListAsync(UsersApiTypes.UsersListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/users",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of user fields.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersFieldsResponse> FieldsAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/users/fields",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersFieldsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of users filtered by username, email or custom fields.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersFindResponse> FindAsync(UsersApiTypes.UsersFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/users/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersFindResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Detail information of a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// <item><description><b>basic</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersGetResponse> GetAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersEditResponse> EditAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get user claims.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersClaimsResponse> ClaimsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersClaimsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Upload avatar for a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersAvatarUploadResponse> AvatarUploadAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersAvatarUploadBody body, CancellationToken cancellationToken = default)
	{
		var jsonObj = new System.Text.Json.Nodes.JsonObject();
		if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
		if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
		if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
		var byteFields = new Dictionary<string, byte[]>();
		byteFields["avatar"] = body.Avatar;
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/avatar",
			Body = JsonSerializer.SerializeToElement(jsonObj),
			BodyEncoding = BodyEncoding.Multipart,
			ByteArrayFields = byteFields,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersAvatarUploadResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete avatar for a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersAvatarDeleteResponse> AvatarDeleteAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/avatar",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersAvatarDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Crop avatar for a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersAvatarCropResponse> AvatarCropAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersAvatarCropBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/avatar/crop",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersAvatarCropResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Upload background for a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersBackgroundUploadResponse> BackgroundUploadAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersBackgroundUploadBody body, CancellationToken cancellationToken = default)
	{
		var jsonObj = new System.Text.Json.Nodes.JsonObject();
		if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
		if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
		if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
		var byteFields = new Dictionary<string, byte[]>();
		byteFields["background"] = body.Background;
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/background",
			Body = JsonSerializer.SerializeToElement(jsonObj),
			BodyEncoding = BodyEncoding.Multipart,
			ByteArrayFields = byteFields,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersBackgroundUploadResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete background for a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersBackgroundDeleteResponse> BackgroundDeleteAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/background",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersBackgroundDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Crop background for a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersBackgroundCropResponse> BackgroundCropAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersBackgroundCropBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/background/crop",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersBackgroundCropResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of a user's followers.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersFollowersResponse> FollowersAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersFollowersParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followers",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersFollowersResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Follow a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersFollowResponse> FollowAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/followers",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersFollowResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unfollow a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersUnfollowResponse> UnfollowAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/followers",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersUnfollowResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of users whom are followed by a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersFollowingsResponse> FollowingsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersFollowingsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followings",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersFollowingsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get information about user likes.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersLikesResponse> LikesAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersLikesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of ignored users of current user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersIgnoredResponse> IgnoredAsync(UsersApiTypes.UsersIgnoredParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/users/ignored",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersIgnoredResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Ignore a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersIgnoreResponse> IgnoreAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/ignore",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersIgnoreResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit ignoring options.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersIgnoreEditResponse> IgnoreEditAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersIgnoreEditParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}/ignore",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersIgnoreEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Stop ignoring a user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersUnignoreResponse> UnignoreAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/ignore",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersUnignoreResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of contents created by user (with pagination).
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersContentsResponse> ContentsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersContentsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/timeline",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersContentsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// List of user trophies.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersTrophiesResponse> TrophiesAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/trophies",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersTrophiesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get available secret answer types for user account security.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>read</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersSecretAnswerTypesResponse> SecretAnswerTypesAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/users/secret-answer/types",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersSecretAnswerTypesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Request a reset of the secret answer for the account.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersSaResetResponse> SaResetAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/account/secret-answer/reset",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersSaResetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Cancel a pending secret answer reset request for the account.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>post</b></description></item>
	/// </list>
	/// </summary>
	public async Task<UsersApiTypes.UsersSaCancelResetResponse> SaCancelResetAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/account/secret-answer/reset",
		};
		return await _http.RequestAsync(__opts, UsersApiTypes.UsersSaCancelResetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ForumClient : IForumClient
{
	public AssetsApi Assets { get; }
	public BatchApi Batch { get; }
	public CategoriesApi Categories { get; }
	public ChatboxApi Chatbox { get; }
	public ConversationsApi Conversations { get; }
	public FormsApi Forms { get; }
	public ForumsApi Forums { get; }
	public LinksApi Links { get; }
	public NavigationApi Navigation { get; }
	public NotificationsApi Notifications { get; }
	public OAuthApi OAuth { get; }
	public PagesApi Pages { get; }
	public PostsApi Posts { get; }
	public ProfilePostsApi ProfilePosts { get; }
	public SearchApi Search { get; }
	public TagsApi Tags { get; }
	public ThreadsApi Threads { get; }
	public UsersApi Users { get; }

	private readonly LolzteamHttpClient _http;

	/// <summary>Create a new client.</summary>
	public ForumClient(ClientConfig config)
	{
		var resolvedConfig = config with
		{
			BaseUrl = config.BaseUrl ?? "https://prod-api.lolz.live",
			RateLimit = config.RateLimit ?? new RateLimitConfig(300),
		};
		_http = new LolzteamHttpClient(resolvedConfig);

		Assets = new AssetsApi(_http);
		Batch = new BatchApi(_http);
		Categories = new CategoriesApi(_http);
		Chatbox = new ChatboxApi(_http);
		Conversations = new ConversationsApi(_http);
		Forms = new FormsApi(_http);
		Forums = new ForumsApi(_http);
		Links = new LinksApi(_http);
		Navigation = new NavigationApi(_http);
		Notifications = new NotificationsApi(_http);
		OAuth = new OAuthApi(_http);
		Pages = new PagesApi(_http);
		Posts = new PostsApi(_http);
		ProfilePosts = new ProfilePostsApi(_http);
		Search = new SearchApi(_http);
		Tags = new TagsApi(_http);
		Threads = new ThreadsApi(_http);
		Users = new UsersApi(_http);
	}

	/// <summary>Internal constructor for IHttpClientFactory integration.</summary>
	internal ForumClient(LolzteamHttpClient http)
	{
		_http = http;
		Assets = new AssetsApi(_http);
		Batch = new BatchApi(_http);
		Categories = new CategoriesApi(_http);
		Chatbox = new ChatboxApi(_http);
		Conversations = new ConversationsApi(_http);
		Forms = new FormsApi(_http);
		Forums = new ForumsApi(_http);
		Links = new LinksApi(_http);
		Navigation = new NavigationApi(_http);
		Notifications = new NotificationsApi(_http);
		OAuth = new OAuthApi(_http);
		Pages = new PagesApi(_http);
		Posts = new PostsApi(_http);
		ProfilePosts = new ProfilePostsApi(_http);
		Search = new SearchApi(_http);
		Tags = new TagsApi(_http);
		Threads = new ThreadsApi(_http);
		Users = new UsersApi(_http);
	}

	public void Dispose()
	{
		_http.Dispose();
	}
}
