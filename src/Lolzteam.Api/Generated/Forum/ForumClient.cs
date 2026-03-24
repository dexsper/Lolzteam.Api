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

	public async Task<AssetsApiTypes.AssetsCssResponse> CssAsync(AssetsApiTypes.AssetsCssParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/css",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			AssetsApiTypes.AssetsCssResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class BatchApi
{
	private readonly LolzteamHttpClient _http;

	public BatchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<BatchApiTypes.BatchExecuteResponse> ExecuteAsync(List<JsonElement>? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			BatchApiTypes.BatchExecuteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CategoriesApi
{
	private readonly LolzteamHttpClient _http;

	public CategoriesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<CategoriesApiTypes.CategoriesListResponse> ListAsync(CategoriesApiTypes.CategoriesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/categories",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			CategoriesApiTypes.CategoriesListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoriesApiTypes.CategoriesGetResponse> GetAsync(long CategoryId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/categories/{CategoryId}",
		},
			CategoriesApiTypes.CategoriesGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ChatboxApi
{
	private readonly LolzteamHttpClient _http;

	public ChatboxApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ChatboxApiTypes.ChatboxIndexResponse> IndexAsync(ChatboxApiTypes.ChatboxIndexParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ChatboxApiTypes.ChatboxIndexResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxGetMessagesResponse> GetMessagesAsync(ChatboxApiTypes.ChatboxGetMessagesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ChatboxApiTypes.ChatboxGetMessagesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxPostMessageResponse> PostMessageAsync(ChatboxApiTypes.ChatboxPostMessageBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ChatboxApiTypes.ChatboxPostMessageResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxEditMessageResponse> EditMessageAsync(ChatboxApiTypes.ChatboxEditMessageBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = "/chatbox/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ChatboxApiTypes.ChatboxEditMessageResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxDeleteMessageResponse> DeleteMessageAsync(ChatboxApiTypes.ChatboxDeleteMessageBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ChatboxApiTypes.ChatboxDeleteMessageResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxOnlineResponse> OnlineAsync(ChatboxApiTypes.ChatboxOnlineParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/online",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ChatboxApiTypes.ChatboxOnlineResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxReportReasonsResponse> ReportReasonsAsync(ChatboxApiTypes.ChatboxReportReasonsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/report",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ChatboxApiTypes.ChatboxReportReasonsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxReportResponse> ReportAsync(ChatboxApiTypes.ChatboxReportBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/messages/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ChatboxApiTypes.ChatboxReportResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxGetLeaderboardResponse> GetLeaderboardAsync(ChatboxApiTypes.ChatboxGetLeaderboardParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/messages/leaderboard",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ChatboxApiTypes.ChatboxGetLeaderboardResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxGetIgnoreResponse> GetIgnoreAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/chatbox/ignore",
		},
			ChatboxApiTypes.ChatboxGetIgnoreResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxPostIgnoreResponse> PostIgnoreAsync(ChatboxApiTypes.ChatboxPostIgnoreBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/chatbox/ignore",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ChatboxApiTypes.ChatboxPostIgnoreResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ChatboxApiTypes.ChatboxDeleteIgnoreResponse> DeleteIgnoreAsync(ChatboxApiTypes.ChatboxDeleteIgnoreBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/chatbox/ignore",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ChatboxApiTypes.ChatboxDeleteIgnoreResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ConversationsApi
{
	private readonly LolzteamHttpClient _http;

	public ConversationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ConversationsApiTypes.ConversationsListResponse> ListAsync(ConversationsApiTypes.ConversationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/conversations",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ConversationsApiTypes.ConversationsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsCreateResponse> CreateAsync(ConversationsApiTypes.ConversationsCreateBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/conversations",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsUpdateResponse> UpdateAsync(ConversationsApiTypes.ConversationsUpdateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = "/conversations",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsUpdateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsDeleteResponse> DeleteAsync(ConversationsApiTypes.ConversationsDeleteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/conversations",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsStartResponse> StartAsync(ConversationsApiTypes.ConversationsStartBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/start",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsStartResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsSaveResponse> SaveAsync(ConversationsApiTypes.ConversationsSaveBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/save",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsSaveResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsGetResponse> GetAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}",
		},
			ConversationsApiTypes.ConversationsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesListResponse> MessagesListAsync(long ConversationId, ConversationsApiTypes.ConversationsMessagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/{ConversationId}/messages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ConversationsApiTypes.ConversationsMessagesListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesCreateResponse> MessagesCreateAsync(long ConversationId, ConversationsApiTypes.ConversationsMessagesCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsMessagesCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsSearchResponse> SearchAsync(ConversationsApiTypes.ConversationsSearchBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsSearchResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesGetResponse> MessagesGetAsync(long MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/conversations/messages/{MessageId}",
		},
			ConversationsApiTypes.ConversationsMessagesGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesEditResponse> MessagesEditAsync(long ConversationId, long MessageId, ConversationsApiTypes.ConversationsMessagesEditBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsMessagesEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesDeleteResponse> MessagesDeleteAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}",
		},
			ConversationsApiTypes.ConversationsMessagesDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsInviteResponse> InviteAsync(long ConversationId, ConversationsApiTypes.ConversationsInviteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/invite",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsInviteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsKickResponse> KickAsync(long ConversationId, ConversationsApiTypes.ConversationsKickBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/kick",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ConversationsApiTypes.ConversationsKickResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsReadResponse> ReadAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/read",
		},
			ConversationsApiTypes.ConversationsReadResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsReadAllResponse> ReadAllAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/conversations/read-all",
		},
			ConversationsApiTypes.ConversationsReadAllResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesStickResponse> MessagesStickAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		},
			ConversationsApiTypes.ConversationsMessagesStickResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsMessagesUnstickResponse> MessagesUnstickAsync(long ConversationId, long MessageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/messages/{MessageId}/stick",
		},
			ConversationsApiTypes.ConversationsMessagesUnstickResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsStarResponse> StarAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/star",
		},
			ConversationsApiTypes.ConversationsStarResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsUnstarResponse> UnstarAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/star",
		},
			ConversationsApiTypes.ConversationsUnstarResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsAlertsEnableResponse> AlertsEnableAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/conversations/{ConversationId}/alerts",
		},
			ConversationsApiTypes.ConversationsAlertsEnableResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ConversationsApiTypes.ConversationsAlertsDisableResponse> AlertsDisableAsync(long ConversationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/conversations/{ConversationId}/alerts",
		},
			ConversationsApiTypes.ConversationsAlertsDisableResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class FormsApi
{
	private readonly LolzteamHttpClient _http;

	public FormsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<FormsApiTypes.FormsListResponse> ListAsync(FormsApiTypes.FormsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/forms",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			FormsApiTypes.FormsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<FormsApiTypes.FormsCreateResponse> CreateAsync(FormsApiTypes.FormsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/forms/save",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			FormsApiTypes.FormsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ForumsApi
{
	private readonly LolzteamHttpClient _http;

	public ForumsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ForumsApiTypes.ForumsListResponse> ListAsync(ForumsApiTypes.ForumsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/forums",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ForumsApiTypes.ForumsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsGroupedResponse> GroupedAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/forums/grouped",
		},
			ForumsApiTypes.ForumsGroupedResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsGetResponse> GetAsync(long ForumId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}",
		},
			ForumsApiTypes.ForumsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsFollowersResponse> FollowersAsync(long ForumId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/forums/{ForumId}/followers",
		},
			ForumsApiTypes.ForumsFollowersResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsFollowResponse> FollowAsync(long ForumId, ForumsApiTypes.ForumsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/forums/{ForumId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ForumsApiTypes.ForumsFollowResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsUnfollowResponse> UnfollowAsync(long ForumId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/forums/{ForumId}/followers",
		},
			ForumsApiTypes.ForumsUnfollowResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsFollowedResponse> FollowedAsync(ForumsApiTypes.ForumsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/forums/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ForumsApiTypes.ForumsFollowedResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsGetFeedOptionsResponse> GetFeedOptionsAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/forums/feed/options",
		},
			ForumsApiTypes.ForumsGetFeedOptionsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ForumsApiTypes.ForumsEditFeedOptionsResponse> EditFeedOptionsAsync(ForumsApiTypes.ForumsEditFeedOptionsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = "/forums/feed/options",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ForumsApiTypes.ForumsEditFeedOptionsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class LinksApi
{
	private readonly LolzteamHttpClient _http;

	public LinksApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<LinksApiTypes.LinksListResponse> ListAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/link-forums",
		},
			LinksApiTypes.LinksListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<LinksApiTypes.LinksGetResponse> GetAsync(long LinkId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/link-forums/{LinkId}",
		},
			LinksApiTypes.LinksGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class NavigationApi
{
	private readonly LolzteamHttpClient _http;

	public NavigationApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<NavigationApiTypes.NavigationListResponse> ListAsync(NavigationApiTypes.NavigationListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/navigation",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			NavigationApiTypes.NavigationListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class NotificationsApi
{
	private readonly LolzteamHttpClient _http;

	public NotificationsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<NotificationsApiTypes.NotificationsListResponse> ListAsync(NotificationsApiTypes.NotificationsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/notifications",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			NotificationsApiTypes.NotificationsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<NotificationsApiTypes.NotificationsGetResponse> GetAsync(long NotificationId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/notifications/{NotificationId}/content",
		},
			NotificationsApiTypes.NotificationsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<NotificationsApiTypes.NotificationsReadResponse> ReadAsync(NotificationsApiTypes.NotificationsReadBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/notifications/read",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			NotificationsApiTypes.NotificationsReadResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class OAuthApi
{
	private readonly LolzteamHttpClient _http;

	public OAuthApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<OAuthApiTypes.OAuthTokenResponse> TokenAsync(OAuthApiTypes.OAuthTokenBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/oauth/token",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Multipart,
		},
			OAuthApiTypes.OAuthTokenResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PagesApi
{
	private readonly LolzteamHttpClient _http;

	public PagesApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PagesApiTypes.PagesListResponse> ListAsync(PagesApiTypes.PagesListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/pages",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PagesApiTypes.PagesListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PagesApiTypes.PagesGetResponse> GetAsync(long PageId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/pages/{PageId}",
		},
			PagesApiTypes.PagesGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PostsApi
{
	private readonly LolzteamHttpClient _http;

	public PostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PostsApiTypes.PostsListResponse> ListAsync(PostsApiTypes.PostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PostsApiTypes.PostsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsCreateResponse> CreateAsync(PostsApiTypes.PostsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/posts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsGetResponse> GetAsync(long PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}",
		},
			PostsApiTypes.PostsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsEditResponse> EditAsync(long PostId, PostsApiTypes.PostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsDeleteResponse> DeleteAsync(long PostId, PostsApiTypes.PostsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsLikesResponse> LikesAsync(long PostId, PostsApiTypes.PostsLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PostsApiTypes.PostsLikesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsLikeResponse> LikeAsync(long PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/likes",
		},
			PostsApiTypes.PostsLikeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsUnlikeResponse> UnlikeAsync(long PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/posts/{PostId}/likes",
		},
			PostsApiTypes.PostsUnlikeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsReportReasonsResponse> ReportReasonsAsync(long PostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/posts/{PostId}/report",
		},
			PostsApiTypes.PostsReportReasonsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsReportResponse> ReportAsync(long PostId, PostsApiTypes.PostsReportBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/posts/{PostId}/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsReportResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsCommentsGetResponse> CommentsGetAsync(PostsApiTypes.PostsCommentsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PostsApiTypes.PostsCommentsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsCommentsCreateResponse> CommentsCreateAsync(PostsApiTypes.PostsCommentsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsCommentsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsCommentsEditResponse> CommentsEditAsync(PostsApiTypes.PostsCommentsEditBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = "/posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsCommentsEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsCommentsDeleteResponse> CommentsDeleteAsync(PostsApiTypes.PostsCommentsDeleteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsCommentsDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PostsApiTypes.PostsCommentsReportResponse> CommentsReportAsync(PostsApiTypes.PostsCommentsReportBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/posts/comments/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PostsApiTypes.PostsCommentsReportResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProfilePostsApi
{
	private readonly LolzteamHttpClient _http;

	public ProfilePostsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsListResponse> ListAsync(Lolzteam.Api.Runtime.StringOrLong UserId, ProfilePostsApiTypes.ProfilePostsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/profile-posts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ProfilePostsApiTypes.ProfilePostsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsGetResponse> GetAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}",
		},
			ProfilePostsApiTypes.ProfilePostsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsEditResponse> EditAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = $"/profile-posts/{ProfilePostId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ProfilePostsApiTypes.ProfilePostsEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsDeleteResponse> DeleteAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsDeleteParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ProfilePostsApiTypes.ProfilePostsDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsReportReasonsResponse> ReportReasonsAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/report",
		},
			ProfilePostsApiTypes.ProfilePostsReportReasonsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsReportResponse> ReportAsync(long ProfilePostId, ProfilePostsApiTypes.ProfilePostsReportBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ProfilePostsApiTypes.ProfilePostsReportResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCreateResponse> CreateAsync(ProfilePostsApiTypes.ProfilePostsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ProfilePostsApiTypes.ProfilePostsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsStickResponse> StickAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		},
			ProfilePostsApiTypes.ProfilePostsStickResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsUnstickResponse> UnstickAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/stick",
		},
			ProfilePostsApiTypes.ProfilePostsUnstickResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsLikesResponse> LikesAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		},
			ProfilePostsApiTypes.ProfilePostsLikesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsLikeResponse> LikeAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		},
			ProfilePostsApiTypes.ProfilePostsLikeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsUnlikeResponse> UnlikeAsync(long ProfilePostId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/profile-posts/{ProfilePostId}/likes",
		},
			ProfilePostsApiTypes.ProfilePostsUnlikeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsListResponse> CommentsListAsync(ProfilePostsApiTypes.ProfilePostsCommentsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/profile-posts/comments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ProfilePostsApiTypes.ProfilePostsCommentsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse> CommentsCreateAsync(ProfilePostsApiTypes.ProfilePostsCommentsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/profile-posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ProfilePostsApiTypes.ProfilePostsCommentsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsEditResponse> CommentsEditAsync(ProfilePostsApiTypes.ProfilePostsCommentsEditBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = "/profile-posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ProfilePostsApiTypes.ProfilePostsCommentsEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse> CommentsDeleteAsync(ProfilePostsApiTypes.ProfilePostsCommentsDeleteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/profile-posts/comments",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ProfilePostsApiTypes.ProfilePostsCommentsDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsGetResponse> CommentsGetAsync(long ProfilePostId, long CommentId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/profile-posts/{ProfilePostId}/comments/{CommentId}",
		},
			ProfilePostsApiTypes.ProfilePostsCommentsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfilePostsApiTypes.ProfilePostsCommentsReportResponse> CommentsReportAsync(long CommentId, ProfilePostsApiTypes.ProfilePostsCommentsReportBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/profile-posts/comments/{CommentId}/report",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ProfilePostsApiTypes.ProfilePostsCommentsReportResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class SearchApi
{
	private readonly LolzteamHttpClient _http;

	public SearchApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<SearchApiTypes.SearchAllResponse> AllAsync(SearchApiTypes.SearchAllBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/search",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			SearchApiTypes.SearchAllResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<SearchApiTypes.SearchThreadsResponse> ThreadsAsync(SearchApiTypes.SearchThreadsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/search/threads",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			SearchApiTypes.SearchThreadsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<SearchApiTypes.SearchPostsResponse> PostsAsync(SearchApiTypes.SearchPostsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/search/posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			SearchApiTypes.SearchPostsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<SearchApiTypes.SearchUsersResponse> UsersAsync(SearchApiTypes.SearchUsersBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/search/users",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			SearchApiTypes.SearchUsersResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<SearchApiTypes.SearchProfilePostsResponse> ProfilePostsAsync(SearchApiTypes.SearchProfilePostsBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/search/profile-posts",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			SearchApiTypes.SearchProfilePostsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<SearchApiTypes.SearchTaggedResponse> TaggedAsync(SearchApiTypes.SearchTaggedBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/search/tagged",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			SearchApiTypes.SearchTaggedResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<SearchApiTypes.SearchResultsResponse> ResultsAsync(Lolzteam.Api.Runtime.StringOrLong SearchId, SearchApiTypes.SearchResultsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/search/{SearchId}/results",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			SearchApiTypes.SearchResultsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class TagsApi
{
	private readonly LolzteamHttpClient _http;

	public TagsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<TagsApiTypes.TagsPopularResponse> PopularAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/tags",
		},
			TagsApiTypes.TagsPopularResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<TagsApiTypes.TagsListResponse> ListAsync(TagsApiTypes.TagsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/tags/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			TagsApiTypes.TagsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<TagsApiTypes.TagsGetResponse> GetAsync(long TagId, TagsApiTypes.TagsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/tags/{TagId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			TagsApiTypes.TagsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<TagsApiTypes.TagsFindResponse> FindAsync(TagsApiTypes.TagsFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/tags/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			TagsApiTypes.TagsFindResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ThreadsApi
{
	private readonly LolzteamHttpClient _http;

	public ThreadsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ThreadsApiTypes.ThreadsListResponse> ListAsync(ThreadsApiTypes.ThreadsListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/threads",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ThreadsApiTypes.ThreadsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsCreateResponse> CreateAsync(ThreadsApiTypes.ThreadsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/threads",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsCreateContestResponse> CreateContestAsync(ThreadsApiTypes.ThreadsCreateContestBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/contests",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsCreateContestResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsClaimResponse> ClaimAsync(ThreadsApiTypes.ThreadsClaimBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsClaimResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsGetResponse> GetAsync(long ThreadId, ThreadsApiTypes.ThreadsGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ThreadsApiTypes.ThreadsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsEditResponse> EditAsync(long ThreadId, ThreadsApiTypes.ThreadsEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsDeleteResponse> DeleteAsync(long ThreadId, ThreadsApiTypes.ThreadsDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsMoveResponse> MoveAsync(long ThreadId, ThreadsApiTypes.ThreadsMoveBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/move",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsMoveResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsBumpResponse> BumpAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/bump",
		},
			ThreadsApiTypes.ThreadsBumpResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsHideResponse> HideAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/hide",
		},
			ThreadsApiTypes.ThreadsHideResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsStarResponse> StarAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/star",
		},
			ThreadsApiTypes.ThreadsStarResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsUnstarResponse> UnstarAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/star",
		},
			ThreadsApiTypes.ThreadsUnstarResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsFollowersResponse> FollowersAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/followers",
		},
			ThreadsApiTypes.ThreadsFollowersResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsFollowResponse> FollowAsync(long ThreadId, ThreadsApiTypes.ThreadsFollowBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/followers",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsFollowResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsUnfollowResponse> UnfollowAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/threads/{ThreadId}/followers",
		},
			ThreadsApiTypes.ThreadsUnfollowResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsFollowedResponse> FollowedAsync(ThreadsApiTypes.ThreadsFollowedParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/threads/followed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ThreadsApiTypes.ThreadsFollowedResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsNavigationResponse> NavigationAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/navigation",
		},
			ThreadsApiTypes.ThreadsNavigationResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsPollGetResponse> PollGetAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/threads/{ThreadId}/poll",
		},
			ThreadsApiTypes.ThreadsPollGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsPollVoteResponse> PollVoteAsync(long ThreadId, ThreadsApiTypes.ThreadsPollVoteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/threads/{ThreadId}/poll/votes",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ThreadsApiTypes.ThreadsPollVoteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsUnreadResponse> UnreadAsync(ThreadsApiTypes.ThreadsUnreadParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/threads/new",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ThreadsApiTypes.ThreadsUnreadResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsRecentResponse> RecentAsync(ThreadsApiTypes.ThreadsRecentParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/threads/recent",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ThreadsApiTypes.ThreadsRecentResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ThreadsApiTypes.ThreadsFinishResponse> FinishAsync(long ThreadId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/contests/{ThreadId}/finish",
		},
			ThreadsApiTypes.ThreadsFinishResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class UsersApi
{
	private readonly LolzteamHttpClient _http;

	public UsersApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<UsersApiTypes.UsersListResponse> ListAsync(UsersApiTypes.UsersListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/users",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersFieldsResponse> FieldsAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/users/fields",
		},
			UsersApiTypes.UsersFieldsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersFindResponse> FindAsync(UsersApiTypes.UsersFindParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/users/find",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersFindResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersGetResponse> GetAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersEditResponse> EditAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			UsersApiTypes.UsersEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersClaimsResponse> ClaimsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersClaimsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersAvatarUploadResponse> AvatarUploadAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersAvatarUploadBody body, CancellationToken cancellationToken = default)
	{
		var jsonObj = new System.Text.Json.Nodes.JsonObject();
		if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
		if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
		if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
		var byteFields = new Dictionary<string, byte[]>();
		byteFields["avatar"] = body.Avatar;
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/avatar",
			Body = JsonSerializer.SerializeToElement(jsonObj),
			BodyEncoding = BodyEncoding.Multipart,
			ByteArrayFields = byteFields,
		},
			UsersApiTypes.UsersAvatarUploadResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersAvatarDeleteResponse> AvatarDeleteAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/avatar",
		},
			UsersApiTypes.UsersAvatarDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersAvatarCropResponse> AvatarCropAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersAvatarCropBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/avatar/crop",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			UsersApiTypes.UsersAvatarCropResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersBackgroundUploadResponse> BackgroundUploadAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersBackgroundUploadBody body, CancellationToken cancellationToken = default)
	{
		var jsonObj = new System.Text.Json.Nodes.JsonObject();
		if (body.X is not null) jsonObj["x"] = System.Text.Json.Nodes.JsonValue.Create(body.X);
		if (body.Y is not null) jsonObj["y"] = System.Text.Json.Nodes.JsonValue.Create(body.Y);
		if (body.Crop is not null) jsonObj["crop"] = System.Text.Json.Nodes.JsonValue.Create(body.Crop);
		var byteFields = new Dictionary<string, byte[]>();
		byteFields["background"] = body.Background;
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/background",
			Body = JsonSerializer.SerializeToElement(jsonObj),
			BodyEncoding = BodyEncoding.Multipart,
			ByteArrayFields = byteFields,
		},
			UsersApiTypes.UsersBackgroundUploadResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersBackgroundDeleteResponse> BackgroundDeleteAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/background",
		},
			UsersApiTypes.UsersBackgroundDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersBackgroundCropResponse> BackgroundCropAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersBackgroundCropBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/background/crop",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			UsersApiTypes.UsersBackgroundCropResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersFollowersResponse> FollowersAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersFollowersParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followers",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersFollowersResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersFollowResponse> FollowAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/followers",
		},
			UsersApiTypes.UsersFollowResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersUnfollowResponse> UnfollowAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/followers",
		},
			UsersApiTypes.UsersUnfollowResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersFollowingsResponse> FollowingsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersFollowingsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/followings",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersFollowingsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersLikesResponse> LikesAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersLikesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/likes",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersLikesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersIgnoredResponse> IgnoredAsync(UsersApiTypes.UsersIgnoredParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/users/ignored",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersIgnoredResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersIgnoreResponse> IgnoreAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/users/{UserId}/ignore",
		},
			UsersApiTypes.UsersIgnoreResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersIgnoreEditResponse> IgnoreEditAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersIgnoreEditParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = $"/users/{UserId}/ignore",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersIgnoreEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersUnignoreResponse> UnignoreAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/users/{UserId}/ignore",
		},
			UsersApiTypes.UsersUnignoreResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersContentsResponse> ContentsAsync(Lolzteam.Api.Runtime.StringOrLong UserId, UsersApiTypes.UsersContentsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/timeline",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			UsersApiTypes.UsersContentsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersTrophiesResponse> TrophiesAsync(Lolzteam.Api.Runtime.StringOrLong UserId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/users/{UserId}/trophies",
		},
			UsersApiTypes.UsersTrophiesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersSecretAnswerTypesResponse> SecretAnswerTypesAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/users/secret-answer/types",
		},
			UsersApiTypes.UsersSecretAnswerTypesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersSaResetResponse> SaResetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/account/secret-answer/reset",
		},
			UsersApiTypes.UsersSaResetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<UsersApiTypes.UsersSaCancelResetResponse> SaCancelResetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/account/secret-answer/reset",
		},
			UsersApiTypes.UsersSaCancelResetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
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

	/// <summary>Create a new client. For DI / IHttpClientFactory use the Lolzteam.Api.DependencyInjection package.</summary>
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
