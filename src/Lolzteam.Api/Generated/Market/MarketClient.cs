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

	public async Task<AutoPaymentsApiTypes.AutoPaymentsListResponse> ListAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/auto-payments",
		},
			AutoPaymentsApiTypes.AutoPaymentsListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<AutoPaymentsApiTypes.AutoPaymentsCreateResponse> CreateAsync(AutoPaymentsApiTypes.AutoPaymentsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/auto-payment",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			AutoPaymentsApiTypes.AutoPaymentsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<AutoPaymentsApiTypes.AutoPaymentsDeleteResponse> DeleteAsync(AutoPaymentsApiTypes.AutoPaymentsDeleteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/auto-payment",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			AutoPaymentsApiTypes.AutoPaymentsDeleteResponse.ReadFrom,
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

	public async Task<BatchApiTypes.BatchBatchResponse> BatchAsync(List<JsonElement> body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/batch",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			BatchApiTypes.BatchBatchResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CartApi
{
	private readonly LolzteamHttpClient _http;

	public CartApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<CartApiTypes.CartGetResponse> GetAsync(CartApiTypes.CartGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/cart",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			CartApiTypes.CartGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CartApiTypes.CartAddResponse> AddAsync(CartApiTypes.CartAddBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/cart",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			CartApiTypes.CartAddResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CartApiTypes.CartDeleteResponse> DeleteAsync(CartApiTypes.CartDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/cart",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			CartApiTypes.CartDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CategoryApi
{
	private readonly LolzteamHttpClient _http;

	public CategoryApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<CategoryApiTypes.CategoryAllResponse> AllAsync(CategoryApiTypes.CategoryAllParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryAllResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategorySteamResponse> SteamAsync(CategoryApiTypes.CategorySteamParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/steam",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategorySteamResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryFortniteResponse> FortniteAsync(CategoryApiTypes.CategoryFortniteParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/fortnite",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryFortniteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryMihoyoResponse> MihoyoAsync(CategoryApiTypes.CategoryMihoyoParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/mihoyo",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryMihoyoResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryRiotResponse> RiotAsync(CategoryApiTypes.CategoryRiotParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/riot",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryRiotResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryTelegramResponse> TelegramAsync(CategoryApiTypes.CategoryTelegramParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/telegram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryTelegramResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategorySupercellResponse> SupercellAsync(CategoryApiTypes.CategorySupercellParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/supercell",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategorySupercellResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryEaResponse> EaAsync(CategoryApiTypes.CategoryEaParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/ea",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryEaResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryWotResponse> WotAsync(CategoryApiTypes.CategoryWotParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/world-of-tanks",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryWotResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryWotBlitzResponse> WotBlitzAsync(CategoryApiTypes.CategoryWotBlitzParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/wot-blitz",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryWotBlitzResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryGiftsResponse> GiftsAsync(CategoryApiTypes.CategoryGiftsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/gifts",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryGiftsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryEpicGamesResponse> EpicGamesAsync(CategoryApiTypes.CategoryEpicGamesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/epicgames",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryEpicGamesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryEscapeFromTarkovResponse> EscapeFromTarkovAsync(CategoryApiTypes.CategoryEscapeFromTarkovParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/escape-from-tarkov",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryEscapeFromTarkovResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategorySocialClubResponse> SocialClubAsync(CategoryApiTypes.CategorySocialClubParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/socialclub",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategorySocialClubResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryUplayResponse> UplayAsync(CategoryApiTypes.CategoryUplayParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/uplay",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryUplayResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryDiscordResponse> DiscordAsync(CategoryApiTypes.CategoryDiscordParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/discord",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryDiscordResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryTikTokResponse> TikTokAsync(CategoryApiTypes.CategoryTikTokParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/tiktok",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryTikTokResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryInstagramResponse> InstagramAsync(CategoryApiTypes.CategoryInstagramParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/instagram",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryInstagramResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryBattleNetResponse> BattleNetAsync(CategoryApiTypes.CategoryBattleNetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/battlenet",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryBattleNetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryChatGPTResponse> ChatGPTAsync(CategoryApiTypes.CategoryChatGPTParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/chatgpt",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryChatGPTResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryVpnResponse> VpnAsync(CategoryApiTypes.CategoryVpnParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/vpn",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryVpnResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryRobloxResponse> RobloxAsync(CategoryApiTypes.CategoryRobloxParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/roblox",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryRobloxResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryWarfaceResponse> WarfaceAsync(CategoryApiTypes.CategoryWarfaceParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/warface",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryWarfaceResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryMinecraftResponse> MinecraftAsync(CategoryApiTypes.CategoryMinecraftParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/minecraft",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryMinecraftResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryHytaleResponse> HytaleAsync(CategoryApiTypes.CategoryHytaleParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/hytale",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryHytaleResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryListResponse> ListAsync(CategoryApiTypes.CategoryListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/category",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
			IsSearch = true,
		},
			CategoryApiTypes.CategoryListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryParamsResponse> ParamsAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/params",
			IsSearch = true,
		},
			CategoryApiTypes.CategoryParamsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CategoryApiTypes.CategoryGamesResponse> GamesAsync(string CategoryName, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{CategoryName}/games",
			IsSearch = true,
		},
			CategoryApiTypes.CategoryGamesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class CustomDiscountsApi
{
	private readonly LolzteamHttpClient _http;

	public CustomDiscountsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsGetResponse> GetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/custom-discounts",
		},
			CustomDiscountsApiTypes.CustomDiscountsGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsCreateResponse> CreateAsync(CustomDiscountsApiTypes.CustomDiscountsCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			CustomDiscountsApiTypes.CustomDiscountsCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsEditResponse> EditAsync(CustomDiscountsApiTypes.CustomDiscountsEditBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			CustomDiscountsApiTypes.CustomDiscountsEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<CustomDiscountsApiTypes.CustomDiscountsDeleteResponse> DeleteAsync(CustomDiscountsApiTypes.CustomDiscountsDeleteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/custom-discounts",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			CustomDiscountsApiTypes.CustomDiscountsDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ImapApi
{
	private readonly LolzteamHttpClient _http;

	public ImapApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ImapApiTypes.ImapCreateResponse> CreateAsync(ImapApiTypes.ImapCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/imap",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ImapApiTypes.ImapCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ImapApiTypes.ImapDeleteResponse> DeleteAsync(ImapApiTypes.ImapDeleteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/imap",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ImapApiTypes.ImapDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ListApi
{
	private readonly LolzteamHttpClient _http;

	public ListApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ListApiTypes.ListUserResponse> UserAsync(ListApiTypes.ListUserParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/user/items",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ListApiTypes.ListUserResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ListApiTypes.ListOrdersResponse> OrdersAsync(ListApiTypes.ListOrdersParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/user/orders",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ListApiTypes.ListOrdersResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ListApiTypes.ListStatesResponse> StatesAsync(ListApiTypes.ListStatesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/user/item-states",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ListApiTypes.ListStatesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ListApiTypes.ListDownloadResponse> DownloadAsync(string Type, ListApiTypes.ListDownloadParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestRawAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/user/{Type}/download",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ListApiTypes.ListDownloadResponse(__result);
	}

	public async Task<ListApiTypes.ListFavoritesResponse> FavoritesAsync(ListApiTypes.ListFavoritesParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/fave",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ListApiTypes.ListFavoritesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ListApiTypes.ListViewedResponse> ViewedAsync(ListApiTypes.ListViewedParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/viewed",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ListApiTypes.ListViewedResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ManagingApi
{
	private readonly LolzteamHttpClient _http;

	public ManagingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ManagingApiTypes.ManagingGetResponse> GetAsync(long ItemId, ManagingApiTypes.ManagingGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ManagingApiTypes.ManagingGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingDeleteResponse> DeleteAsync(long ItemId, ManagingApiTypes.ManagingDeleteBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingCreateClaimResponse> CreateClaimAsync(ManagingApiTypes.ManagingCreateClaimBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/claims",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingCreateClaimResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingBulkGetResponse> BulkGetAsync(ManagingApiTypes.ManagingBulkGetBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/bulk/items",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingBulkGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamInventoryValueResponse> SteamInventoryValueAsync(long ItemId, ManagingApiTypes.ManagingSteamInventoryValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/inventory-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ManagingApiTypes.ManagingSteamInventoryValueResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamValueResponse> SteamValueAsync(ManagingApiTypes.ManagingSteamValueParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/steam-value",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ManagingApiTypes.ManagingSteamValueResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamPreviewResponse> SteamPreviewAsync(long ItemId, ManagingApiTypes.ManagingSteamPreviewParams? @params = null, CancellationToken cancellationToken = default)
	{
		var __result = await _http.RequestRawAsync(new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/steam-preview",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		}, cancellationToken).ConfigureAwait(false);
		return new ManagingApiTypes.ManagingSteamPreviewResponse(__result);
	}

	public async Task<ManagingApiTypes.ManagingEditResponse> EditAsync(long ItemId, ManagingApiTypes.ManagingEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = $"/{ItemId}/edit",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingAIPriceResponse> AIPriceAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/ai-price",
		},
			ManagingApiTypes.ManagingAIPriceResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingAutoBuyPriceResponse> AutoBuyPriceAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/auto-buy-price",
		},
			ManagingApiTypes.ManagingAutoBuyPriceResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingNoteResponse> NoteAsync(long ItemId, ManagingApiTypes.ManagingNoteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/note-save",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingNoteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamUpdateValueResponse> SteamUpdateValueAsync(long ItemId, ManagingApiTypes.ManagingSteamUpdateValueBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/update-inventory",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingSteamUpdateValueResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingBumpResponse> BumpAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/bump",
		},
			ManagingApiTypes.ManagingBumpResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingAutoBumpResponse> AutoBumpAsync(long ItemId, ManagingApiTypes.ManagingAutoBumpBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/auto-bump",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingAutoBumpResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingAutoBumpDisableResponse> AutoBumpDisableAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/auto-bump",
		},
			ManagingApiTypes.ManagingAutoBumpDisableResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingOpenResponse> OpenAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/open",
		},
			ManagingApiTypes.ManagingOpenResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingCloseResponse> CloseAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/close",
		},
			ManagingApiTypes.ManagingCloseResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingImageResponse> ImageAsync(long ItemId, ManagingApiTypes.ManagingImageParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/image",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ManagingApiTypes.ManagingImageResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingEmailCodeResponse> EmailCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/email-code",
		},
			ManagingApiTypes.ManagingEmailCodeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingGetLetters2Response> GetLetters2Async(ManagingApiTypes.ManagingGetLetters2Params? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/letters2",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ManagingApiTypes.ManagingGetLetters2Response.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamGetMafileResponse> SteamGetMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/mafile",
		},
			ManagingApiTypes.ManagingSteamGetMafileResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamAddMafileResponse> SteamAddMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/mafile",
		},
			ManagingApiTypes.ManagingSteamAddMafileResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamRemoveMafileResponse> SteamRemoveMafileAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/mafile",
		},
			ManagingApiTypes.ManagingSteamRemoveMafileResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamMafileCodeResponse> SteamMafileCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/guard-code",
		},
			ManagingApiTypes.ManagingSteamMafileCodeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingSteamSDAResponse> SteamSDAAsync(long ItemId, ManagingApiTypes.ManagingSteamSDABody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-sda",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingSteamSDAResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingTelegramCodeResponse> TelegramCodeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/telegram-login-code",
		},
			ManagingApiTypes.ManagingTelegramCodeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingTelegramResetAuthResponse> TelegramResetAuthAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/telegram-reset-authorizations",
		},
			ManagingApiTypes.ManagingTelegramResetAuthResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingRefuseGuaranteeResponse> RefuseGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/refuse-guarantee",
		},
			ManagingApiTypes.ManagingRefuseGuaranteeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingDeclineVideoRecordingResponse> DeclineVideoRecordingAsync(long ItemId, ManagingApiTypes.ManagingDeclineVideoRecordingBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/decline-video-recording",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingDeclineVideoRecordingResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingCheckGuaranteeResponse> CheckGuaranteeAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-guarantee",
		},
			ManagingApiTypes.ManagingCheckGuaranteeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingChangePasswordResponse> ChangePasswordAsync(long ItemId, ManagingApiTypes.ManagingChangePasswordBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-password",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingChangePasswordResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingTempEmailPasswordResponse> TempEmailPasswordAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = $"/{ItemId}/temp-email-password",
		},
			ManagingApiTypes.ManagingTempEmailPasswordResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingTagResponse> TagAsync(long ItemId, ManagingApiTypes.ManagingTagBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingTagResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingUntagResponse> UntagAsync(long ItemId, ManagingApiTypes.ManagingUntagBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingUntagResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingPublicTagResponse> PublicTagAsync(long ItemId, ManagingApiTypes.ManagingPublicTagBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/public-tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingPublicTagResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingPublicUntagResponse> PublicUntagAsync(long ItemId, ManagingApiTypes.ManagingPublicUntagBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/public-tag",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingPublicUntagResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingFavoriteResponse> FavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/star",
		},
			ManagingApiTypes.ManagingFavoriteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingUnfavoriteResponse> UnfavoriteAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/star",
		},
			ManagingApiTypes.ManagingUnfavoriteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingStickResponse> StickAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/stick",
		},
			ManagingApiTypes.ManagingStickResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingUnstickResponse> UnstickAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/stick",
		},
			ManagingApiTypes.ManagingUnstickResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ManagingApiTypes.ManagingTransferResponse> TransferAsync(long ItemId, ManagingApiTypes.ManagingTransferBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/change-owner",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ManagingApiTypes.ManagingTransferResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PaymentsApi
{
	private readonly LolzteamHttpClient _http;

	public PaymentsApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceGetResponse> InvoiceGetAsync(PaymentsApiTypes.PaymentsInvoiceGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/invoice",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PaymentsApiTypes.PaymentsInvoiceGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceCreateResponse> InvoiceCreateAsync(PaymentsApiTypes.PaymentsInvoiceCreateBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/invoice",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PaymentsApiTypes.PaymentsInvoiceCreateResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsInvoiceListResponse> InvoiceListAsync(PaymentsApiTypes.PaymentsInvoiceListParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/invoice/list",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PaymentsApiTypes.PaymentsInvoiceListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsCurrencyResponse> CurrencyAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/currency",
		},
			PaymentsApiTypes.PaymentsCurrencyResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsBalanceListResponse> BalanceListAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/balance/exchange",
		},
			PaymentsApiTypes.PaymentsBalanceListResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsBalanceExchangeResponse> BalanceExchangeAsync(PaymentsApiTypes.PaymentsBalanceExchangeBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/balance/exchange",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PaymentsApiTypes.PaymentsBalanceExchangeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsTransferResponse> TransferAsync(PaymentsApiTypes.PaymentsTransferBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PaymentsApiTypes.PaymentsTransferResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsFeeResponse> FeeAsync(PaymentsApiTypes.PaymentsFeeParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/balance/transfer/fee",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PaymentsApiTypes.PaymentsFeeResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsCancelResponse> CancelAsync(PaymentsApiTypes.PaymentsCancelBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/balance/transfer/cancel",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PaymentsApiTypes.PaymentsCancelResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsHistoryResponse> HistoryAsync(PaymentsApiTypes.PaymentsHistoryParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/user/payments",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			PaymentsApiTypes.PaymentsHistoryResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsPayoutServicesResponse> PayoutServicesAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/balance/payout/services",
		},
			PaymentsApiTypes.PaymentsPayoutServicesResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PaymentsApiTypes.PaymentsPayoutResponse> PayoutAsync(PaymentsApiTypes.PaymentsPayoutBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/balance/payout",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PaymentsApiTypes.PaymentsPayoutResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProfileApi
{
	private readonly LolzteamHttpClient _http;

	public ProfileApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ProfileApiTypes.ProfileClaimsResponse> ClaimsAsync(ProfileApiTypes.ProfileClaimsParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/claims",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ProfileApiTypes.ProfileClaimsResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfileApiTypes.ProfileGetResponse> GetAsync(ProfileApiTypes.ProfileGetParams? @params = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/me",
			Query = @params is not null ? JsonSerializer.SerializeToElement(@params) : null,
		},
			ProfileApiTypes.ProfileGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProfileApiTypes.ProfileEditResponse> EditAsync(ProfileApiTypes.ProfileEditBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "PUT",
			Path = "/me",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ProfileApiTypes.ProfileEditResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class ProxyApi
{
	private readonly LolzteamHttpClient _http;

	public ProxyApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<ProxyApiTypes.ProxyGetResponse> GetAsync(CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "GET",
			Path = "/proxy",
		},
			ProxyApiTypes.ProxyGetResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProxyApiTypes.ProxyAddResponse> AddAsync(ProxyApiTypes.ProxyAddBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/proxy",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			ProxyApiTypes.ProxyAddResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<ProxyApiTypes.ProxyDeleteResponse> DeleteAsync(ProxyApiTypes.ProxyDeleteBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = "/proxy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			ProxyApiTypes.ProxyDeleteResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PublishingApi
{
	private readonly LolzteamHttpClient _http;

	public PublishingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PublishingApiTypes.PublishingFastSellResponse> FastSellAsync(PublishingApiTypes.PublishingFastSellBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/item/fast-sell",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PublishingApiTypes.PublishingFastSellResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PublishingApiTypes.PublishingAddResponse> AddAsync(PublishingApiTypes.PublishingAddBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = "/item/add",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PublishingApiTypes.PublishingAddResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PublishingApiTypes.PublishingCheckResponse> CheckAsync(long ItemId, PublishingApiTypes.PublishingCheckBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/goods/check",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			PublishingApiTypes.PublishingCheckResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PublishingApiTypes.PublishingExternalResponse> ExternalAsync(long ItemId, PublishingApiTypes.PublishingExternalBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/external-account",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PublishingApiTypes.PublishingExternalResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}
}

public sealed class PurchasingApi
{
	private readonly LolzteamHttpClient _http;

	public PurchasingApi(LolzteamHttpClient http)
	{
		_http = http;
	}

	public async Task<PurchasingApiTypes.PurchasingFastBuyResponse> FastBuyAsync(long ItemId, PurchasingApiTypes.PurchasingFastBuyBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/fast-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			PurchasingApiTypes.PurchasingFastBuyResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PurchasingApiTypes.PurchasingCheckResponse> CheckAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/check-account",
		},
			PurchasingApiTypes.PurchasingCheckResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PurchasingApiTypes.PurchasingConfirmResponse> ConfirmAsync(long ItemId, PurchasingApiTypes.PurchasingConfirmBody? body = null, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/confirm-buy",
			Body = body is not null ? JsonSerializer.SerializeToElement(body) : null,
			BodyEncoding = BodyEncoding.Json,
		},
			PurchasingApiTypes.PurchasingConfirmResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PurchasingApiTypes.PurchasingDiscountRequestResponse> DiscountRequestAsync(long ItemId, PurchasingApiTypes.PurchasingDiscountRequestBody body, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "POST",
			Path = $"/{ItemId}/discount",
			Body = JsonSerializer.SerializeToElement(body),
			BodyEncoding = BodyEncoding.Json,
		},
			PurchasingApiTypes.PurchasingDiscountRequestResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
	}

	public async Task<PurchasingApiTypes.PurchasingDiscountCancelResponse> DiscountCancelAsync(long ItemId, CancellationToken cancellationToken = default)
	{
		return await _http.RequestAsync(
			new RequestOptions
		{
			Method = "DELETE",
			Path = $"/{ItemId}/discount",
		},
			PurchasingApiTypes.PurchasingDiscountCancelResponse.ReadFrom,
			cancellationToken).ConfigureAwait(false);
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

	/// <summary>Create a new client. For DI / IHttpClientFactory use the Lolzteam.Api.DependencyInjection package.</summary>
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
