// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Text.Json;
using Lolzteam.Api.Runtime;

namespace Lolzteam.Api.Generated.Market;

public sealed class AutoPaymentsApi
{
	private readonly LolzteamHttpClient _http;

	public AutoPaymentsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Get auto payments list.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>payment</b></description></item>
	/// </list>
	/// </summary>
	public async Task<AutoPaymentsApiTypes.AutoPaymentsListResponse> ListAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/auto-payments",
		};
		return await _http.RequestAsync(__opts, AutoPaymentsApiTypes.AutoPaymentsListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Creates auto payment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>payment</b></description></item>
	/// </list>
	/// </summary>
	public async Task<AutoPaymentsApiTypes.AutoPaymentsCreateResponse> CreateAsync(AutoPaymentsApiTypes.AutoPaymentsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/auto-payment",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, AutoPaymentsApiTypes.AutoPaymentsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Deletes an auto payment.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>payment</b></description></item>
	/// </list>
	/// </summary>
	public async Task<AutoPaymentsApiTypes.AutoPaymentsDeleteResponse> DeleteAsync(AutoPaymentsApiTypes.AutoPaymentsDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/auto-payment",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, AutoPaymentsApiTypes.AutoPaymentsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
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
	/// Execute multiple API requests at once (separated by comma). Maximum batch jobs is 10.
	/// Following methods are unavailable in Batch:
	/// <list type="bullet">
	/// <item><description>GET /{item_id}/image</description></item>
	/// <item><description>/item/fast-sell</description></item>
	/// </list>
	/// </summary>
	public async Task<BatchApiTypes.BatchBatchResponse> BatchAsync(List<JsonElement> body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, BatchApiTypes.BatchBatchResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CartApi
{
	private readonly LolzteamHttpClient _http;

	public CartApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Returns the list of items currently in your cart.
	/// </summary>
	public async Task<CartApiTypes.CartGetResponse> GetAsync(CartApiTypes.CartGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/cart",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, CartApiTypes.CartGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Adds item to your cart.
	/// </summary>
	public async Task<CartApiTypes.CartAddResponse> AddAsync(CartApiTypes.CartAddBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/cart",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, CartApiTypes.CartAddResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Deletes an item from the cart.
	/// </summary>
	public async Task<CartApiTypes.CartDeleteResponse> DeleteAsync(CartApiTypes.CartDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/cart",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, CartApiTypes.CartDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CategoryApi
{
	private readonly LolzteamHttpClient _http;

	public CategoryApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Displays a list of latest accounts.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryAllResponse> AllAsync(CategoryApiTypes.CategoryAllParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryAllResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategorySteamResponse> SteamAsync(CategoryApiTypes.CategorySteamParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/steam",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategorySteamResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryFortniteResponse> FortniteAsync(CategoryApiTypes.CategoryFortniteParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/fortnite",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryFortniteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryMihoyoResponse> MihoyoAsync(CategoryApiTypes.CategoryMihoyoParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/mihoyo",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryMihoyoResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryRiotResponse> RiotAsync(CategoryApiTypes.CategoryRiotParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/riot",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryRiotResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryTelegramResponse> TelegramAsync(CategoryApiTypes.CategoryTelegramParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/telegram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryTelegramResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategorySupercellResponse> SupercellAsync(CategoryApiTypes.CategorySupercellParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/supercell",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategorySupercellResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryEaResponse> EaAsync(CategoryApiTypes.CategoryEaParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/ea",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryEaResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryWotResponse> WotAsync(CategoryApiTypes.CategoryWotParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/world-of-tanks",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryWotResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryWotBlitzResponse> WotBlitzAsync(CategoryApiTypes.CategoryWotBlitzParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/wot-blitz",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryWotBlitzResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryGiftsResponse> GiftsAsync(CategoryApiTypes.CategoryGiftsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/gifts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryGiftsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryEpicGamesResponse> EpicGamesAsync(CategoryApiTypes.CategoryEpicGamesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/epicgames",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryEpicGamesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryEscapeFromTarkovResponse> EscapeFromTarkovAsync(CategoryApiTypes.CategoryEscapeFromTarkovParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/escape-from-tarkov",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryEscapeFromTarkovResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategorySocialClubResponse> SocialClubAsync(CategoryApiTypes.CategorySocialClubParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/socialclub",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategorySocialClubResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryUplayResponse> UplayAsync(CategoryApiTypes.CategoryUplayParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/uplay",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryUplayResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryDiscordResponse> DiscordAsync(CategoryApiTypes.CategoryDiscordParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/discord",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryDiscordResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryTikTokResponse> TikTokAsync(CategoryApiTypes.CategoryTikTokParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/tiktok",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryTikTokResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryInstagramResponse> InstagramAsync(CategoryApiTypes.CategoryInstagramParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/instagram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryInstagramResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryBattleNetResponse> BattleNetAsync(CategoryApiTypes.CategoryBattleNetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/battlenet",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryBattleNetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryChatGPTResponse> ChatGPTAsync(CategoryApiTypes.CategoryChatGPTParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/chatgpt",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryChatGPTResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryVpnResponse> VpnAsync(CategoryApiTypes.CategoryVpnParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/vpn",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryVpnResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryRobloxResponse> RobloxAsync(CategoryApiTypes.CategoryRobloxParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/roblox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryRobloxResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryWarfaceResponse> WarfaceAsync(CategoryApiTypes.CategoryWarfaceParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/warface",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryWarfaceResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryMinecraftResponse> MinecraftAsync(CategoryApiTypes.CategoryMinecraftParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/minecraft",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryMinecraftResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryHytaleResponse> HytaleAsync(CategoryApiTypes.CategoryHytaleParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/hytale",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryHytaleResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of accounts in a specific category according to your parameters.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryCursorResponse> CursorAsync(CategoryApiTypes.CategoryCursorParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/cursor",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryCursorResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Display category list.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryListResponse> ListAsync(CategoryApiTypes.CategoryListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/category",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays search parameters for a category.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryParamsResponse> ParamsAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/params",
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryParamsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of games in the category.
	/// </summary>
	public async Task<CategoryApiTypes.CategoryGamesResponse> GamesAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/games",
			IsSearch = true,
		};
		return await _http.RequestAsync(__opts, CategoryApiTypes.CategoryGamesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CustomDiscountsApi
{
	private readonly LolzteamHttpClient _http;

	public CustomDiscountsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Get a list of custom discounts.
	/// </summary>
	public async Task<CustomDiscountsApiTypes.CustomDiscountsGetResponse> GetAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/custom-discounts",
		};
		return await _http.RequestAsync(__opts, CustomDiscountsApiTypes.CustomDiscountsGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Creates a new custom discount.
	/// </summary>
	public async Task<CustomDiscountsApiTypes.CustomDiscountsCreateResponse> CreateAsync(CustomDiscountsApiTypes.CustomDiscountsCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, CustomDiscountsApiTypes.CustomDiscountsCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edit an existing custom discount.
	/// </summary>
	public async Task<CustomDiscountsApiTypes.CustomDiscountsEditResponse> EditAsync(CustomDiscountsApiTypes.CustomDiscountsEditBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, CustomDiscountsApiTypes.CustomDiscountsEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete an existing custom discount.
	/// </summary>
	public async Task<CustomDiscountsApiTypes.CustomDiscountsDeleteResponse> DeleteAsync(CustomDiscountsApiTypes.CustomDiscountsDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, CustomDiscountsApiTypes.CustomDiscountsDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ImapApi
{
	private readonly LolzteamHttpClient _http;

	public ImapApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Create an IMAP configuration for a domain.
	/// </summary>
	public async Task<ImapApiTypes.ImapCreateResponse> CreateAsync(ImapApiTypes.ImapCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/imap",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ImapApiTypes.ImapCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete an IMAP configuration for a domain.
	/// </summary>
	public async Task<ImapApiTypes.ImapDeleteResponse> DeleteAsync(ImapApiTypes.ImapDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/imap",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ImapApiTypes.ImapDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ListApi
{
	private readonly LolzteamHttpClient _http;

	public ListApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Displays a list of user accounts.
	/// </summary>
	public async Task<ListApiTypes.ListUserResponse> UserAsync(ListApiTypes.ListUserParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/user/items",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ListApiTypes.ListUserResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of purchased accounts.
	/// </summary>
	public async Task<ListApiTypes.ListOrdersResponse> OrdersAsync(ListApiTypes.ListOrdersParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/user/orders",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ListApiTypes.ListOrdersResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Returns the states of user items.
	/// </summary>
	public async Task<ListApiTypes.ListStatesResponse> StatesAsync(ListApiTypes.ListStatesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/user/item-states",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ListApiTypes.ListStatesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Download accounts data in the specified format.
	/// </summary>
	public async Task<ListApiTypes.ListDownloadResponse> DownloadAsync(string Type, ListApiTypes.ListDownloadParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/user/{Type}/download",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		var __raw = await _http.RequestRawAsync(__opts, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListDownloadResponse(__raw);
	}

	/// <summary>
	/// Displays a list of favourites accounts.
	/// </summary>
	public async Task<ListApiTypes.ListFavoritesResponse> FavoritesAsync(ListApiTypes.ListFavoritesParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/fave",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ListApiTypes.ListFavoritesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays a list of viewed accounts.
	/// </summary>
	public async Task<ListApiTypes.ListViewedResponse> ViewedAsync(ListApiTypes.ListViewedParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/viewed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ListApiTypes.ListViewedResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ManagingApi
{
	private readonly LolzteamHttpClient _http;

	public ManagingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Displays account information.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingGetResponse> GetAsync(long ItemId, ManagingApiTypes.ManagingGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Deletes your account from public search. Deletion type is soft. You can restore account after deletion if you want.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingDeleteResponse> DeleteAsync(long ItemId, ManagingApiTypes.ManagingDeleteBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create a claim.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingCreateClaimResponse> CreateClaimAsync(ManagingApiTypes.ManagingCreateClaimBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingCreateClaimResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Bulk get up to 250 accounts.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingBulkGetResponse> BulkGetAsync(ManagingApiTypes.ManagingBulkGetBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/bulk/items",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingBulkGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets Account steam inventory value.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamInventoryValueResponse> SteamInventoryValueAsync(long ItemId, ManagingApiTypes.ManagingSteamInventoryValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/inventory-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamInventoryValueResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets steam inventory value.
	/// &gt; 📘 This method is rate limited. You can send 20 requests per minute (3s delay between requests)
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamValueResponse> SteamValueAsync(ManagingApiTypes.ManagingSteamValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/steam-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamValueResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Returns Steam account profile/games preview.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamPreviewResponse> SteamPreviewAsync(long ItemId, ManagingApiTypes.ManagingSteamPreviewParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/steam-preview",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		var __raw = await _http.RequestRawAsync(__opts, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamPreviewResponse(__raw);
	}

	/// <summary>
	/// Edits any details of account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingEditResponse> EditAsync(long ItemId, ManagingApiTypes.ManagingEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = $"/{ItemId}/edit",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get AI-suggested price for the account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingAIPriceResponse> AIPriceAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/ai-price",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingAIPriceResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get auto buy price for the account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingAutoBuyPriceResponse> AutoBuyPriceAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/auto-buy-price",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingAutoBuyPriceResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Edits a note for the account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingNoteResponse> NoteAsync(long ItemId, ManagingApiTypes.ManagingNoteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/note-save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingNoteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Update inventory value.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamUpdateValueResponse> SteamUpdateValueAsync(long ItemId, ManagingApiTypes.ManagingSteamUpdateValueBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/update-inventory",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamUpdateValueResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Bumps account in the search.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingBumpResponse> BumpAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/bump",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingBumpResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Enables/edits automatic bumping for the specified account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingAutoBumpResponse> AutoBumpAsync(long ItemId, ManagingApiTypes.ManagingAutoBumpBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/auto-bump",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingAutoBumpResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Disables automatic bumping for the specified account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingAutoBumpDisableResponse> AutoBumpDisableAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/auto-bump",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingAutoBumpDisableResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Opens account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingOpenResponse> OpenAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/open",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingOpenResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Closes account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingCloseResponse> CloseAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/close",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingCloseResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get account image.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingImageResponse> ImageAsync(long ItemId, ManagingApiTypes.ManagingImageParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/image",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingImageResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets confirmation code or link.
	/// <para/>
	/// &gt; ❗️ If you receive a "retry_request" error, you should repeat the same request (up to a maximum of 100 times)
	/// </summary>
	public async Task<ManagingApiTypes.ManagingEmailCodeResponse> EmailCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/email-code",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingEmailCodeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Returns account letters.
	/// <para/>
	/// &gt; ❗️ If you receive a "retry_request" error, you should repeat the same request (up to a maximum of 100 times)
	/// </summary>
	public async Task<ManagingApiTypes.ManagingGetLetters2Response> GetLetters2Async(ManagingApiTypes.ManagingGetLetters2Params? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/letters2",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingGetLetters2Response.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Returns steam mafile.
	/// &gt; ❗️ This action is cancelling active account guarantee
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamGetMafileResponse> SteamGetMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/mafile",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamGetMafileResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Add a new Steam mafile to the account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamAddMafileResponse> SteamAddMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/mafile",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamAddMafileResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Remove steam mafile.
	/// &gt; ❗️ This will unlink the authenticator from the account and remove mafile from the item
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamRemoveMafileResponse> SteamRemoveMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/mafile",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamRemoveMafileResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets confirmation code from MaFile (Only for Steam accounts).
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamMafileCodeResponse> SteamMafileCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/guard-code",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamMafileCodeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Confirm steam action. 
	/// <para/>
	///  Don't set <b>id</b> and <b>nonce</b> parameters to get list of available confirmation requests. 
	/// <para/>
	/// &gt; ❗️ This action is cancelling active account guarantee
	/// </summary>
	public async Task<ManagingApiTypes.ManagingSteamSDAResponse> SteamSDAAsync(long ItemId, ManagingApiTypes.ManagingSteamSDABody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-sda",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingSteamSDAResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets confirmation code from Telegram.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingTelegramCodeResponse> TelegramCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/telegram-login-code",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingTelegramCodeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Resets Telegram authorizations.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingTelegramResetAuthResponse> TelegramResetAuthAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/telegram-reset-authorizations",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingTelegramResetAuthResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Cancel guarantee of account. It can be useful for account reselling.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingRefuseGuaranteeResponse> RefuseGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/refuse-guarantee",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingRefuseGuaranteeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Waiver of the requirement to record a video and any claims regarding this account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingDeclineVideoRecordingResponse> DeclineVideoRecordingAsync(long ItemId, ManagingApiTypes.ManagingDeclineVideoRecordingBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/decline-video-recording",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingDeclineVideoRecordingResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Checks the guarantee and cancels it if there are reasons to cancel it.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingCheckGuaranteeResponse> CheckGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-guarantee",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingCheckGuaranteeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Changes password of account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingChangePasswordResponse> ChangePasswordAsync(long ItemId, ManagingApiTypes.ManagingChangePasswordBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-password",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingChangePasswordResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Gets password from temp email of account. After calling of this method, the guarantee will be cancelled and you cannot automatically resell account.
	/// &gt; ❗️ This action is cancelling active account guarantee
	/// </summary>
	public async Task<ManagingApiTypes.ManagingTempEmailPasswordResponse> TempEmailPasswordAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/temp-email-password",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingTempEmailPasswordResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Adds a tag to the specified account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingTagResponse> TagAsync(long ItemId, ManagingApiTypes.ManagingTagBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingTagResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Removes a tag from from the specified account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingUntagResponse> UntagAsync(long ItemId, ManagingApiTypes.ManagingUntagBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingUntagResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Adds a public tag to the specified account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingPublicTagResponse> PublicTagAsync(long ItemId, ManagingApiTypes.ManagingPublicTagBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/public-tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingPublicTagResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Removes a public tag from the specified account.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingPublicUntagResponse> PublicUntagAsync(long ItemId, ManagingApiTypes.ManagingPublicUntagBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/public-tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingPublicUntagResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Adds account to favorites.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingFavoriteResponse> FavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/star",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingFavoriteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete account from favorites.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingUnfavoriteResponse> UnfavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/star",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingUnfavoriteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Stick account in the top of search.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingStickResponse> StickAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/stick",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingStickResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Unstick account from the top of search.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingUnstickResponse> UnstickAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/stick",
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingUnstickResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Transfer account to another user.
	/// </summary>
	public async Task<ManagingApiTypes.ManagingTransferResponse> TransferAsync(long ItemId, ManagingApiTypes.ManagingTransferBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-owner",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ManagingApiTypes.ManagingTransferResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PaymentsApi
{
	private readonly LolzteamHttpClient _http;

	public PaymentsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Get invoice.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>invoice</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsInvoiceGetResponse> InvoiceGetAsync(PaymentsApiTypes.PaymentsInvoiceGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/invoice",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsInvoiceGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Create invoice.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>invoice</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsInvoiceCreateResponse> InvoiceCreateAsync(PaymentsApiTypes.PaymentsInvoiceCreateBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/invoice",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsInvoiceCreateResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get invoice list.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>invoice</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsInvoiceListResponse> InvoiceListAsync(PaymentsApiTypes.PaymentsInvoiceListParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/invoice/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsInvoiceListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get currency list.
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsCurrencyResponse> CurrencyAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/currency",
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsCurrencyResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Returns list of balances.
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsBalanceListResponse> BalanceListAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/balance/exchange",
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsBalanceListResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Transfer funds from one balance to another.
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsBalanceExchangeResponse> BalanceExchangeAsync(PaymentsApiTypes.PaymentsBalanceExchangeBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/balance/exchange",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsBalanceExchangeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Transfer money to any user.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>payment</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsTransferResponse> TransferAsync(PaymentsApiTypes.PaymentsTransferBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsTransferResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get transfer limits and get fee amount for transfer.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>payment</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsFeeResponse> FeeAsync(PaymentsApiTypes.PaymentsFeeParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/balance/transfer/fee",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsFeeResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Cancels a transfer with a hold that was sent to your account.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>payment</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsCancelResponse> CancelAsync(PaymentsApiTypes.PaymentsCancelBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer/cancel",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsCancelResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays list of your payments.
	/// <para/>
	/// Required scopes:
	/// <list type="bullet">
	/// <item><description><b>payment</b></description></item>
	/// </list>
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsHistoryResponse> HistoryAsync(PaymentsApiTypes.PaymentsHistoryParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/user/payments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsHistoryResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Get a list of available payout services.
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsPayoutServicesResponse> PayoutServicesAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/balance/payout/services",
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsPayoutServicesResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Creates a payout request.
	/// </summary>
	public async Task<PaymentsApiTypes.PaymentsPayoutResponse> PayoutAsync(PaymentsApiTypes.PaymentsPayoutBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/balance/payout",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PaymentsApiTypes.PaymentsPayoutResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProfileApi
{
	private readonly LolzteamHttpClient _http;

	public ProfileApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Returns a list of claims filed against you.
	/// </summary>
	public async Task<ProfileApiTypes.ProfileClaimsResponse> ClaimsAsync(ProfileApiTypes.ProfileClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ProfileApiTypes.ProfileClaimsResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Displays info about your profile.
	/// </summary>
	public async Task<ProfileApiTypes.ProfileGetResponse> GetAsync(ProfileApiTypes.ProfileGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/me",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		};
		return await _http.RequestAsync(__opts, ProfileApiTypes.ProfileGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Change settings about your profile on the market.
	/// </summary>
	public async Task<ProfileApiTypes.ProfileEditResponse> EditAsync(ProfileApiTypes.ProfileEditBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "PUT",
			Path = "/me",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProfileApiTypes.ProfileEditResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProxyApi
{
	private readonly LolzteamHttpClient _http;

	public ProxyApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Gets your proxy list.
	/// </summary>
	public async Task<ProxyApiTypes.ProxyGetResponse> GetAsync(CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "GET",
			Path = "/proxy",
		};
		return await _http.RequestAsync(__opts, ProxyApiTypes.ProxyGetResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Add single proxy or proxy list.
	/// <para/>
	/// <para/>
	/// To add single proxy use this parameters:
	/// <para/>
	/// <para/>
	/// <list type="bullet">
	/// <item><description><b>proxy_ip</b> (required) - proxy ip or host</description></item>
	/// <item><description><b>proxy_port</b> (required) - proxy port</description></item>
	/// <item><description><b>proxy_user</b> (optional) - proxy username</description></item>
	/// <item><description><b>proxy_pass</b> (optional) - proxy password</description></item>
	/// </list>
	/// <para/>
	/// To add proxy list use this parameters:
	/// <para/>
	/// <para/>
	/// <list type="bullet">
	/// <item><description><b>proxy_row</b> (required) - proxy list in String format ip:port:user:pass. Each proxy must be start with new line (use \n separator)</description></item>
	/// </list>
	/// </summary>
	public async Task<ProxyApiTypes.ProxyAddResponse> AddAsync(ProxyApiTypes.ProxyAddBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/proxy",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProxyApiTypes.ProxyAddResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Delete single or all proxies.
	/// </summary>
	public async Task<ProxyApiTypes.ProxyDeleteResponse> DeleteAsync(ProxyApiTypes.ProxyDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = "/proxy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, ProxyApiTypes.ProxyDeleteResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PublishingApi
{
	private readonly LolzteamHttpClient _http;

	public PublishingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Adds and checks the account for validity.
	/// <para/>
	/// &gt; ❗️ If you receive a "retry_request" error, you should repeat the same request (up to a maximum of 100 times).
	/// </summary>
	public async Task<PublishingApiTypes.PublishingFastSellResponse> FastSellAsync(PublishingApiTypes.PublishingFastSellBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/item/fast-sell",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PublishingApiTypes.PublishingFastSellResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Adds account on the market.
	/// <para/>
	/// Required email login data categories:
	/// <list type="bullet">
	/// <item><description>9 - Fortnite</description></item>
	/// <item><description>12 - Epic games</description></item>
	/// <item><description>18 - Escape from Tarkov</description></item>
	/// </list>
	/// </summary>
	public async Task<PublishingApiTypes.PublishingAddResponse> AddAsync(PublishingApiTypes.PublishingAddBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = "/item/add",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PublishingApiTypes.PublishingAddResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Check and put up to sale not published account OR update account information existing account.
	/// <para/>
	/// &gt; ❗️ If you receive a "retry_request" error, you should repeat the same request (up to a maximum of 100 times).
	/// </summary>
	public async Task<PublishingApiTypes.PublishingCheckResponse> CheckAsync(long ItemId, PublishingApiTypes.PublishingCheckBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/goods/check",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PublishingApiTypes.PublishingCheckResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Check and add an external account to your item.
	/// <para/>
	/// &gt; ❗️ Please note that if you're linking a Social Club account to Steam, it will update the last activity on your account (This is a limitation of Steam). If Social Club Games does not have a linked account, do not enter any data.
	/// </summary>
	public async Task<PublishingApiTypes.PublishingExternalResponse> ExternalAsync(long ItemId, PublishingApiTypes.PublishingExternalBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/external-account",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PublishingApiTypes.PublishingExternalResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PurchasingApi
{
	private readonly LolzteamHttpClient _http;

	public PurchasingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	/// <summary>
	/// Check and buy account.
	/// <para/>
	/// &gt; ❗️ If you receive a "retry_request" error, you should repeat the same request (up to a maximum of 100 times).
	/// </summary>
	public async Task<PurchasingApiTypes.PurchasingFastBuyResponse> FastBuyAsync(long ItemId, PurchasingApiTypes.PurchasingFastBuyBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/fast-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PurchasingApiTypes.PurchasingFastBuyResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Checking account for validity.
	/// <para/>
	/// &gt; ❗️ If you receive a "retry_request" error, you should repeat the same request (up to a maximum of 100 times).
	/// </summary>
	public async Task<PurchasingApiTypes.PurchasingCheckResponse> CheckAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-account",
		};
		return await _http.RequestAsync(__opts, PurchasingApiTypes.PurchasingCheckResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Confirm buy.
	/// <para/>
	/// &gt; ❗️ This method doesn't check account for validity. If you want to confirm validity before buying, you should use <see href="https://lzt-market.readme.io/reference/purchasingfastbuy">FastBuy</see> method
	/// </summary>
	public async Task<PurchasingApiTypes.PurchasingConfirmResponse> ConfirmAsync(long ItemId, PurchasingApiTypes.PurchasingConfirmBody? body = null, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PurchasingApiTypes.PurchasingConfirmResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Request a discount for the specified item.
	/// </summary>
	public async Task<PurchasingApiTypes.PurchasingDiscountRequestResponse> DiscountRequestAsync(long ItemId, PurchasingApiTypes.PurchasingDiscountRequestBody body, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/discount",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		};
		return await _http.RequestAsync(__opts, PurchasingApiTypes.PurchasingDiscountRequestResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Cancel a requested discount for the specified item.
	/// </summary>
	public async Task<PurchasingApiTypes.PurchasingDiscountCancelResponse> DiscountCancelAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		var __opts = new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/discount",
		};
		return await _http.RequestAsync(__opts, PurchasingApiTypes.PurchasingDiscountCancelResponse.ReadFrom, cancellationToken).ConfigureAwait(false);
	}
}

public sealed class MarketClient : IMarketClient
{
	public AutoPaymentsApi AutoPayments { get; }
	public BatchApi Batch { get; }
	public CartApi Cart { get; }
	public CategoryApi Category { get; }
	public CustomDiscountsApi CustomDiscounts { get; }
	public ImapApi Imap { get; }
	public ListApi List { get; }
	public ManagingApi Managing { get; }
	public PaymentsApi Payments { get; }
	public ProfileApi Profile { get; }
	public ProxyApi Proxy { get; }
	public PublishingApi Publishing { get; }
	public PurchasingApi Purchasing { get; }

	private readonly LolzteamHttpClient _http;

	/// <summary>Create a new client.</summary>
	public MarketClient(ClientConfig config)
	{
		var resolvedConfig = config with
		{
			BaseUrl = config.BaseUrl ?? "https://prod-api.lzt.market",
			RateLimit = config.RateLimit ?? new RateLimitConfig(120),
			SearchRateLimit = config.SearchRateLimit ?? new RateLimitConfig(20),
		};
		_http = new LolzteamHttpClient(resolvedConfig);

		AutoPayments = new AutoPaymentsApi(_http);
		Batch = new BatchApi(_http);
		Cart = new CartApi(_http);
		Category = new CategoryApi(_http);
		CustomDiscounts = new CustomDiscountsApi(_http);
		Imap = new ImapApi(_http);
		List = new ListApi(_http);
		Managing = new ManagingApi(_http);
		Payments = new PaymentsApi(_http);
		Profile = new ProfileApi(_http);
		Proxy = new ProxyApi(_http);
		Publishing = new PublishingApi(_http);
		Purchasing = new PurchasingApi(_http);
	}

	/// <summary>Internal constructor for IHttpClientFactory integration.</summary>
	internal MarketClient(LolzteamHttpClient http)
	{
		_http = http;
		AutoPayments = new AutoPaymentsApi(_http);
		Batch = new BatchApi(_http);
		Cart = new CartApi(_http);
		Category = new CategoryApi(_http);
		CustomDiscounts = new CustomDiscountsApi(_http);
		Imap = new ImapApi(_http);
		List = new ListApi(_http);
		Managing = new ManagingApi(_http);
		Payments = new PaymentsApi(_http);
		Profile = new ProfileApi(_http);
		Proxy = new ProxyApi(_http);
		Publishing = new PublishingApi(_http);
		Purchasing = new PurchasingApi(_http);
	}

	public void Dispose()
	{
		_http.Dispose();
	}
}
