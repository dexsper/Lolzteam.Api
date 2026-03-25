// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowInviteGroup>))]
public enum AllowInviteGroup
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowPostProfile>))]
public enum AllowPostProfile
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowReceiveNewsFeed>))]
public enum AllowReceiveNewsFeed
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowSendPersonalConversation>))]
public enum AllowSendPersonalConversation
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowViewProfile>))]
public enum AllowViewProfile
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategoriesOrder>))]
public enum CategoriesOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("list")] List,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ClaimState>))]
public enum ClaimState
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("solved")] Solved,
	[Lolzteam.Api.Runtime.EnumValue("rejected")] Rejected,
	[Lolzteam.Api.Runtime.EnumValue("settled")] Settled,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ContentType>))]
public enum ContentType
{
	[Lolzteam.Api.Runtime.EnumValue("post")] Post,
	[Lolzteam.Api.Runtime.EnumValue("post_comment")] PostComment,
	[Lolzteam.Api.Runtime.EnumValue("profile_post")] ProfilePost,
	[Lolzteam.Api.Runtime.EnumValue("profile_post_comment")] ProfilePostComment,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ContestType>))]
public enum ContestType
{
	[Lolzteam.Api.Runtime.EnumValue("by_finish_date")] ByFinishDate,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ConversationsOrder>))]
public enum ConversationsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("natural_reverse")] NaturalReverse,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Currency>))]
public enum Currency
{
	[Lolzteam.Api.Runtime.EnumValue("rub")] Rub,
	[Lolzteam.Api.Runtime.EnumValue("uah")] Uah,
	[Lolzteam.Api.Runtime.EnumValue("kzt")] Kzt,
	[Lolzteam.Api.Runtime.EnumValue("byn")] Byn,
	[Lolzteam.Api.Runtime.EnumValue("usd")] Usd,
	[Lolzteam.Api.Runtime.EnumValue("eur")] Eur,
	[Lolzteam.Api.Runtime.EnumValue("gbp")] Gbp,
	[Lolzteam.Api.Runtime.EnumValue("cny")] Cny,
	[Lolzteam.Api.Runtime.EnumValue("try")] Try,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<DeleteType>))]
public enum DeleteType
{
	[Lolzteam.Api.Runtime.EnumValue("delete")] Delete,
	[Lolzteam.Api.Runtime.EnumValue("delete_ignore")] DeleteIgnore,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Direction>))]
public enum Direction
{
	[Lolzteam.Api.Runtime.EnumValue("asc")] Asc,
	[Lolzteam.Api.Runtime.EnumValue("desc")] Desc,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Duration>))]
public enum Duration
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("week")] Week,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Folder>))]
public enum Folder
{
	[Lolzteam.Api.Runtime.EnumValue("all")] All,
	[Lolzteam.Api.Runtime.EnumValue("unread")] Unread,
	[Lolzteam.Api.Runtime.EnumValue("groups")] Groups,
	[Lolzteam.Api.Runtime.EnumValue("market")] Market,
	[Lolzteam.Api.Runtime.EnumValue("market_replacements")] MarketReplacements,
	[Lolzteam.Api.Runtime.EnumValue("staff")] Staff,
	[Lolzteam.Api.Runtime.EnumValue("giveaways")] Giveaways,
	[Lolzteam.Api.Runtime.EnumValue("p2p")] P2p,
}

public enum FormId : long
{
	V1 = 1,
	V3 = 3,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Gender>))]
public enum Gender
{
	[Lolzteam.Api.Runtime.EnumValue("")] None,
	[Lolzteam.Api.Runtime.EnumValue("male")] Male,
	[Lolzteam.Api.Runtime.EnumValue("female")] Female,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<GrantType>))]
public enum GrantType
{
	[Lolzteam.Api.Runtime.EnumValue("client_credentials")] ClientCredentials,
	[Lolzteam.Api.Runtime.EnumValue("authorization_code")] AuthorizationCode,
	[Lolzteam.Api.Runtime.EnumValue("refresh_token")] RefreshToken,
	[Lolzteam.Api.Runtime.EnumValue("password")] Password,
}

public enum LanguageId : long
{
	V1 = 1,
	V2 = 2,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LengthOption>))]
public enum LengthOption
{
	[Lolzteam.Api.Runtime.EnumValue("minutes")] Minutes,
	[Lolzteam.Api.Runtime.EnumValue("hours")] Hours,
	[Lolzteam.Api.Runtime.EnumValue("days")] Days,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LikeType>))]
public enum LikeType
{
	[Lolzteam.Api.Runtime.EnumValue("like")] Like,
	[Lolzteam.Api.Runtime.EnumValue("like2")] Like2,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<NotificationsType>))]
public enum NotificationsType
{
	[Lolzteam.Api.Runtime.EnumValue("market")] Market,
	[Lolzteam.Api.Runtime.EnumValue("nomarket")] Nomarket,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PayClaim>))]
public enum PayClaim
{
	[Lolzteam.Api.Runtime.EnumValue("now")] Now,
	[Lolzteam.Api.Runtime.EnumValue("later")] Later,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Period>))]
public enum Period
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("week")] Week,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PostsOrder>))]
public enum PostsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("natural_reverse")] NaturalReverse,
	[Lolzteam.Api.Runtime.EnumValue("post_likes")] PostLikes,
	[Lolzteam.Api.Runtime.EnumValue("post_likes_reverse")] PostLikesReverse,
}

public enum PrizeDataUpgrade : long
{
	V1 = 1,
	V6 = 6,
	V12 = 12,
	V14 = 14,
	V17 = 17,
	V19 = 19,
	V20 = 20,
	V21 = 21,
	V22 = 22,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PrizeType>))]
public enum PrizeType
{
	[Lolzteam.Api.Runtime.EnumValue("money")] Money,
	[Lolzteam.Api.Runtime.EnumValue("upgrades")] Upgrades,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ProfilePostsFieldsInclude>))]
public enum ProfilePostsFieldsInclude
{
	[Lolzteam.Api.Runtime.EnumValue("*")] All,
	[Lolzteam.Api.Runtime.EnumValue("latest_comments")] LatestComments,
}

public enum ReplyGroup : long
{
	V0 = 0,
	V2 = 2,
	V21 = 21,
	V22 = 22,
	V23 = 23,
	V60 = 60,
	V351 = 351,
}

public enum RoomId : long
{
	V1 = 1,
	V2 = 2,
	V3 = 3,
	V4 = 4,
	V13 = 13,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<State>))]
public enum State
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("closed")] Closed,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ThreadsFieldsInclude>))]
public enum ThreadsFieldsInclude
{
	[Lolzteam.Api.Runtime.EnumValue("*")] All,
	[Lolzteam.Api.Runtime.EnumValue("latest_posts")] LatestPosts,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ThreadsOrder>))]
public enum ThreadsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("post_date")] PostDate,
	[Lolzteam.Api.Runtime.EnumValue("last_post_date")] LastPostDate,
	[Lolzteam.Api.Runtime.EnumValue("reply_count")] ReplyCount,
	[Lolzteam.Api.Runtime.EnumValue("reply_count_asc")] ReplyCountAsc,
	[Lolzteam.Api.Runtime.EnumValue("first_post_likes")] FirstPostLikes,
	[Lolzteam.Api.Runtime.EnumValue("vote_count")] VoteCount,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Timezone>))]
public enum Timezone
{
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Midway")] PacificMidway,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Honolulu")] PacificHonolulu,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Marquesas")] PacificMarquesas,
	[Lolzteam.Api.Runtime.EnumValue("America/Anchorage")] AmericaAnchorage,
	[Lolzteam.Api.Runtime.EnumValue("America/Los_Angeles")] AmericaLosAngeles,
	[Lolzteam.Api.Runtime.EnumValue("America/Santa_Isabel")] AmericaSantaIsabel,
	[Lolzteam.Api.Runtime.EnumValue("America/Tijuana")] AmericaTijuana,
	[Lolzteam.Api.Runtime.EnumValue("America/Denver")] AmericaDenver,
	[Lolzteam.Api.Runtime.EnumValue("America/Chihuahua")] AmericaChihuahua,
	[Lolzteam.Api.Runtime.EnumValue("America/Phoenix")] AmericaPhoenix,
	[Lolzteam.Api.Runtime.EnumValue("America/Chicago")] AmericaChicago,
	[Lolzteam.Api.Runtime.EnumValue("America/Belize")] AmericaBelize,
	[Lolzteam.Api.Runtime.EnumValue("America/Mexico_City")] AmericaMexicoCity,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Easter")] PacificEaster,
	[Lolzteam.Api.Runtime.EnumValue("America/New_York")] AmericaNewYork,
	[Lolzteam.Api.Runtime.EnumValue("America/Havana")] AmericaHavana,
	[Lolzteam.Api.Runtime.EnumValue("America/Bogota")] AmericaBogota,
	[Lolzteam.Api.Runtime.EnumValue("America/Caracas")] AmericaCaracas,
	[Lolzteam.Api.Runtime.EnumValue("America/Halifax")] AmericaHalifax,
	[Lolzteam.Api.Runtime.EnumValue("America/Goose_Bay")] AmericaGooseBay,
	[Lolzteam.Api.Runtime.EnumValue("America/Asuncion")] AmericaAsuncion,
	[Lolzteam.Api.Runtime.EnumValue("America/Santiago")] AmericaSantiago,
	[Lolzteam.Api.Runtime.EnumValue("America/Cuiaba")] AmericaCuiaba,
	[Lolzteam.Api.Runtime.EnumValue("America/La_Paz")] AmericaLaPaz,
	[Lolzteam.Api.Runtime.EnumValue("America/St_Johns")] AmericaStJohns,
	[Lolzteam.Api.Runtime.EnumValue("America/Argentina/Buenos_Aires")] AmericaArgentinaBuenosAires,
	[Lolzteam.Api.Runtime.EnumValue("America/Argentina/San_Luis")] AmericaArgentinaSanLuis,
	[Lolzteam.Api.Runtime.EnumValue("America/Argentina/Mendoza")] AmericaArgentinaMendoza,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Stanley")] AtlanticStanley,
	[Lolzteam.Api.Runtime.EnumValue("America/Godthab")] AmericaGodthab,
	[Lolzteam.Api.Runtime.EnumValue("America/Montevideo")] AmericaMontevideo,
	[Lolzteam.Api.Runtime.EnumValue("America/Sao_Paulo")] AmericaSaoPaulo,
	[Lolzteam.Api.Runtime.EnumValue("America/Miquelon")] AmericaMiquelon,
	[Lolzteam.Api.Runtime.EnumValue("America/Noronha")] AmericaNoronha,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Cape_Verde")] AtlanticCapeVerde,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Azores")] AtlanticAzores,
	[Lolzteam.Api.Runtime.EnumValue("Europe/London")] EuropeLondon,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Casablanca")] AfricaCasablanca,
	[Lolzteam.Api.Runtime.EnumValue("Atlantic/Reykjavik")] AtlanticReykjavik,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Amsterdam")] EuropeAmsterdam,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Algiers")] AfricaAlgiers,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Windhoek")] AfricaWindhoek,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Tunis")] AfricaTunis,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Athens")] EuropeAthens,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Johannesburg")] AfricaJohannesburg,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Kaliningrad")] EuropeKaliningrad,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Amman")] AsiaAmman,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Beirut")] AsiaBeirut,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Cairo")] AfricaCairo,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Jerusalem")] AsiaJerusalem,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Gaza")] AsiaGaza,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Damascus")] AsiaDamascus,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Moscow")] EuropeMoscow,
	[Lolzteam.Api.Runtime.EnumValue("Europe/Minsk")] EuropeMinsk,
	[Lolzteam.Api.Runtime.EnumValue("Africa/Nairobi")] AfricaNairobi,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Tehran")] AsiaTehran,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Dubai")] AsiaDubai,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Yerevan")] AsiaYerevan,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Baku")] AsiaBaku,
	[Lolzteam.Api.Runtime.EnumValue("Indian/Mauritius")] IndianMauritius,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Kabul")] AsiaKabul,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Yekaterinburg")] AsiaYekaterinburg,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Tashkent")] AsiaTashkent,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Kolkata")] AsiaKolkata,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Kathmandu")] AsiaKathmandu,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Novosibirsk")] AsiaNovosibirsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Dhaka")] AsiaDhaka,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Almaty")] AsiaAlmaty,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Rangoon")] AsiaRangoon,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Krasnoyarsk")] AsiaKrasnoyarsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Bangkok")] AsiaBangkok,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Irkutsk")] AsiaIrkutsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Hong_Kong")] AsiaHongKong,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Singapore")] AsiaSingapore,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Perth")] AustraliaPerth,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Yakutsk")] AsiaYakutsk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Tokyo")] AsiaTokyo,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Seoul")] AsiaSeoul,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Adelaide")] AustraliaAdelaide,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Darwin")] AustraliaDarwin,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Vladivostok")] AsiaVladivostok,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Magadan")] AsiaMagadan,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Brisbane")] AustraliaBrisbane,
	[Lolzteam.Api.Runtime.EnumValue("Australia/Sydney")] AustraliaSydney,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Noumea")] PacificNoumea,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Norfolk")] PacificNorfolk,
	[Lolzteam.Api.Runtime.EnumValue("Asia/Anadyr")] AsiaAnadyr,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Auckland")] PacificAuckland,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Fiji")] PacificFiji,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Chatham")] PacificChatham,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Tongatapu")] PacificTongatapu,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Apia")] PacificApia,
	[Lolzteam.Api.Runtime.EnumValue("Pacific/Kiritimati")] PacificKiritimati,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<TransferType>))]
public enum TransferType
{
	[Lolzteam.Api.Runtime.EnumValue("guarantor")] Guarantor,
	[Lolzteam.Api.Runtime.EnumValue("safe")] Safe,
	[Lolzteam.Api.Runtime.EnumValue("notsafe")] Notsafe,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersFieldsInclude>))]
public enum UsersFieldsInclude
{
	[Lolzteam.Api.Runtime.EnumValue("*")] All,
	[Lolzteam.Api.Runtime.EnumValue("alerts")] Alerts,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersOrder>))]
public enum UsersOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("follow_date")] FollowDate,
	[Lolzteam.Api.Runtime.EnumValue("follow_date_reverse")] FollowDateReverse,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersType>))]
public enum UsersType
{
	[Lolzteam.Api.Runtime.EnumValue("gotten")] Gotten,
	[Lolzteam.Api.Runtime.EnumValue("given")] Given,
}

