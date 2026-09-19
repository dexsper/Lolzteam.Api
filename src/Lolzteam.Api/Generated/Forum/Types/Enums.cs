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

/// <summary>Zero-reflection JSON string mapping for <see cref="AllowInviteGroup"/>.</summary>
internal static class AllowInviteGroupExtensions
{
	public static string ToJsonValue(this AllowInviteGroup value)
	{
		return value switch
		{
			AllowInviteGroup.None => "none",
			AllowInviteGroup.Members => "members",
			AllowInviteGroup.Followed => "followed",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowPostProfile>))]
public enum AllowPostProfile
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="AllowPostProfile"/>.</summary>
internal static class AllowPostProfileExtensions
{
	public static string ToJsonValue(this AllowPostProfile value)
	{
		return value switch
		{
			AllowPostProfile.None => "none",
			AllowPostProfile.Members => "members",
			AllowPostProfile.Followed => "followed",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowReceiveNewsFeed>))]
public enum AllowReceiveNewsFeed
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="AllowReceiveNewsFeed"/>.</summary>
internal static class AllowReceiveNewsFeedExtensions
{
	public static string ToJsonValue(this AllowReceiveNewsFeed value)
	{
		return value switch
		{
			AllowReceiveNewsFeed.None => "none",
			AllowReceiveNewsFeed.Members => "members",
			AllowReceiveNewsFeed.Followed => "followed",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowSendPersonalConversation>))]
public enum AllowSendPersonalConversation
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="AllowSendPersonalConversation"/>.</summary>
internal static class AllowSendPersonalConversationExtensions
{
	public static string ToJsonValue(this AllowSendPersonalConversation value)
	{
		return value switch
		{
			AllowSendPersonalConversation.None => "none",
			AllowSendPersonalConversation.Members => "members",
			AllowSendPersonalConversation.Followed => "followed",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<AllowViewProfile>))]
public enum AllowViewProfile
{
	[Lolzteam.Api.Runtime.EnumValue("none")] None,
	[Lolzteam.Api.Runtime.EnumValue("members")] Members,
	[Lolzteam.Api.Runtime.EnumValue("followed")] Followed,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="AllowViewProfile"/>.</summary>
internal static class AllowViewProfileExtensions
{
	public static string ToJsonValue(this AllowViewProfile value)
	{
		return value switch
		{
			AllowViewProfile.None => "none",
			AllowViewProfile.Members => "members",
			AllowViewProfile.Followed => "followed",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<CategoriesOrder>))]
public enum CategoriesOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("list")] List,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="CategoriesOrder"/>.</summary>
internal static class CategoriesOrderExtensions
{
	public static string ToJsonValue(this CategoriesOrder value)
	{
		return value switch
		{
			CategoriesOrder.Natural => "natural",
			CategoriesOrder.List => "list",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ClaimState>))]
public enum ClaimState
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("solved")] Solved,
	[Lolzteam.Api.Runtime.EnumValue("rejected")] Rejected,
	[Lolzteam.Api.Runtime.EnumValue("settled")] Settled,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="ClaimState"/>.</summary>
internal static class ClaimStateExtensions
{
	public static string ToJsonValue(this ClaimState value)
	{
		return value switch
		{
			ClaimState.Active => "active",
			ClaimState.Solved => "solved",
			ClaimState.Rejected => "rejected",
			ClaimState.Settled => "settled",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ContentType>))]
public enum ContentType
{
	[Lolzteam.Api.Runtime.EnumValue("post")] Post,
	[Lolzteam.Api.Runtime.EnumValue("post_comment")] PostComment,
	[Lolzteam.Api.Runtime.EnumValue("profile_post")] ProfilePost,
	[Lolzteam.Api.Runtime.EnumValue("profile_post_comment")] ProfilePostComment,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="ContentType"/>.</summary>
internal static class ContentTypeExtensions
{
	public static string ToJsonValue(this ContentType value)
	{
		return value switch
		{
			ContentType.Post => "post",
			ContentType.PostComment => "post_comment",
			ContentType.ProfilePost => "profile_post",
			ContentType.ProfilePostComment => "profile_post_comment",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ContestType>))]
public enum ContestType
{
	[Lolzteam.Api.Runtime.EnumValue("by_finish_date")] ByFinishDate,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="ContestType"/>.</summary>
internal static class ContestTypeExtensions
{
	public static string ToJsonValue(this ContestType value)
	{
		return value switch
		{
			ContestType.ByFinishDate => "by_finish_date",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ConversationsOrder>))]
public enum ConversationsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("natural_reverse")] NaturalReverse,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="ConversationsOrder"/>.</summary>
internal static class ConversationsOrderExtensions
{
	public static string ToJsonValue(this ConversationsOrder value)
	{
		return value switch
		{
			ConversationsOrder.Natural => "natural",
			ConversationsOrder.NaturalReverse => "natural_reverse",
			_ => value.ToString(),
		};
	}
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

/// <summary>Zero-reflection JSON string mapping for <see cref="Currency"/>.</summary>
internal static class CurrencyExtensions
{
	public static string ToJsonValue(this Currency value)
	{
		return value switch
		{
			Currency.Rub => "rub",
			Currency.Uah => "uah",
			Currency.Kzt => "kzt",
			Currency.Byn => "byn",
			Currency.Usd => "usd",
			Currency.Eur => "eur",
			Currency.Gbp => "gbp",
			Currency.Cny => "cny",
			Currency.Try => "try",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<DeleteType>))]
public enum DeleteType
{
	[Lolzteam.Api.Runtime.EnumValue("delete")] Delete,
	[Lolzteam.Api.Runtime.EnumValue("delete_ignore")] DeleteIgnore,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="DeleteType"/>.</summary>
internal static class DeleteTypeExtensions
{
	public static string ToJsonValue(this DeleteType value)
	{
		return value switch
		{
			DeleteType.Delete => "delete",
			DeleteType.DeleteIgnore => "delete_ignore",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Direction>))]
public enum Direction
{
	[Lolzteam.Api.Runtime.EnumValue("asc")] Asc,
	[Lolzteam.Api.Runtime.EnumValue("desc")] Desc,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="Direction"/>.</summary>
internal static class DirectionExtensions
{
	public static string ToJsonValue(this Direction value)
	{
		return value switch
		{
			Direction.Asc => "asc",
			Direction.Desc => "desc",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Duration>))]
public enum Duration
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("week")] Week,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="Duration"/>.</summary>
internal static class DurationExtensions
{
	public static string ToJsonValue(this Duration value)
	{
		return value switch
		{
			Duration.Day => "day",
			Duration.Week => "week",
			Duration.Month => "month",
			_ => value.ToString(),
		};
	}
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

/// <summary>Zero-reflection JSON string mapping for <see cref="Folder"/>.</summary>
internal static class FolderExtensions
{
	public static string ToJsonValue(this Folder value)
	{
		return value switch
		{
			Folder.All => "all",
			Folder.Unread => "unread",
			Folder.Groups => "groups",
			Folder.Market => "market",
			Folder.MarketReplacements => "market_replacements",
			Folder.Staff => "staff",
			Folder.Giveaways => "giveaways",
			Folder.P2p => "p2p",
			_ => value.ToString(),
		};
	}
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

/// <summary>Zero-reflection JSON string mapping for <see cref="Gender"/>.</summary>
internal static class GenderExtensions
{
	public static string ToJsonValue(this Gender value)
	{
		return value switch
		{
			Gender.None => "",
			Gender.Male => "male",
			Gender.Female => "female",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<GrantType>))]
public enum GrantType
{
	[Lolzteam.Api.Runtime.EnumValue("client_credentials")] ClientCredentials,
	[Lolzteam.Api.Runtime.EnumValue("authorization_code")] AuthorizationCode,
	[Lolzteam.Api.Runtime.EnumValue("refresh_token")] RefreshToken,
	[Lolzteam.Api.Runtime.EnumValue("password")] Password,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="GrantType"/>.</summary>
internal static class GrantTypeExtensions
{
	public static string ToJsonValue(this GrantType value)
	{
		return value switch
		{
			GrantType.ClientCredentials => "client_credentials",
			GrantType.AuthorizationCode => "authorization_code",
			GrantType.RefreshToken => "refresh_token",
			GrantType.Password => "password",
			_ => value.ToString(),
		};
	}
}

public enum LanguageId : long
{
	/// <summary>
	/// English
	/// </summary>
	V1 = 1,
	/// <summary>
	/// Russian
	/// </summary>
	V2 = 2,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LengthOption>))]
public enum LengthOption
{
	[Lolzteam.Api.Runtime.EnumValue("minutes")] Minutes,
	[Lolzteam.Api.Runtime.EnumValue("hours")] Hours,
	[Lolzteam.Api.Runtime.EnumValue("days")] Days,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="LengthOption"/>.</summary>
internal static class LengthOptionExtensions
{
	public static string ToJsonValue(this LengthOption value)
	{
		return value switch
		{
			LengthOption.Minutes => "minutes",
			LengthOption.Hours => "hours",
			LengthOption.Days => "days",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<LikeType>))]
public enum LikeType
{
	/// <summary>
	/// Sympathies
	/// </summary>
	[Lolzteam.Api.Runtime.EnumValue("like")] Like,
	/// <summary>
	/// Likes
	/// </summary>
	[Lolzteam.Api.Runtime.EnumValue("like2")] Like2,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="LikeType"/>.</summary>
internal static class LikeTypeExtensions
{
	public static string ToJsonValue(this LikeType value)
	{
		return value switch
		{
			LikeType.Like => "like",
			LikeType.Like2 => "like2",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<MessageState>))]
public enum MessageState
{
	[Lolzteam.Api.Runtime.EnumValue("visible")] Visible,
	[Lolzteam.Api.Runtime.EnumValue("deleted")] Deleted,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="MessageState"/>.</summary>
internal static class MessageStateExtensions
{
	public static string ToJsonValue(this MessageState value)
	{
		return value switch
		{
			MessageState.Visible => "visible",
			MessageState.Deleted => "deleted",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<NotificationsType>))]
public enum NotificationsType
{
	[Lolzteam.Api.Runtime.EnumValue("market")] Market,
	[Lolzteam.Api.Runtime.EnumValue("nomarket")] Nomarket,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="NotificationsType"/>.</summary>
internal static class NotificationsTypeExtensions
{
	public static string ToJsonValue(this NotificationsType value)
	{
		return value switch
		{
			NotificationsType.Market => "market",
			NotificationsType.Nomarket => "nomarket",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PayClaim>))]
public enum PayClaim
{
	[Lolzteam.Api.Runtime.EnumValue("now")] Now,
	[Lolzteam.Api.Runtime.EnumValue("later")] Later,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="PayClaim"/>.</summary>
internal static class PayClaimExtensions
{
	public static string ToJsonValue(this PayClaim value)
	{
		return value switch
		{
			PayClaim.Now => "now",
			PayClaim.Later => "later",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<Period>))]
public enum Period
{
	[Lolzteam.Api.Runtime.EnumValue("day")] Day,
	[Lolzteam.Api.Runtime.EnumValue("week")] Week,
	[Lolzteam.Api.Runtime.EnumValue("month")] Month,
	[Lolzteam.Api.Runtime.EnumValue("year")] Year,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="Period"/>.</summary>
internal static class PeriodExtensions
{
	public static string ToJsonValue(this Period value)
	{
		return value switch
		{
			Period.Day => "day",
			Period.Week => "week",
			Period.Month => "month",
			Period.Year => "year",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PostsOrder>))]
public enum PostsOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("natural_reverse")] NaturalReverse,
	[Lolzteam.Api.Runtime.EnumValue("post_likes")] PostLikes,
	[Lolzteam.Api.Runtime.EnumValue("post_likes_reverse")] PostLikesReverse,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="PostsOrder"/>.</summary>
internal static class PostsOrderExtensions
{
	public static string ToJsonValue(this PostsOrder value)
	{
		return value switch
		{
			PostsOrder.Natural => "natural",
			PostsOrder.NaturalReverse => "natural_reverse",
			PostsOrder.PostLikes => "post_likes",
			PostsOrder.PostLikesReverse => "post_likes_reverse",
			_ => value.ToString(),
		};
	}
}

public enum PrizeDataUpgrade : long
{
	/// <summary>
	/// Supreme - 1500 ₽
	/// </summary>
	V1 = 1,
	/// <summary>
	/// Legend - 2999 ₽
	/// </summary>
	V6 = 6,
	/// <summary>
	/// AntiPublic.One Plus subscription - 2000 ₽
	/// </summary>
	V12 = 12,
	/// <summary>
	/// Uniq - 7500 ₽
	/// </summary>
	V14 = 14,
	/// <summary>
	/// 18+ Photo leaks – 6 months - 1200 ₽
	/// </summary>
	V17 = 17,
	/// <summary>
	/// Auto giveaway participation - 1000 ₽
	/// </summary>
	V19 = 19,
	/// <summary>
	/// AntiPublic.one Premium subscription - 5000 ₽
	/// </summary>
	V20 = 20,
	/// <summary>
	/// AntiPublic.one Premium subscription - 500 ₽
	/// </summary>
	V21 = 21,
	/// <summary>
	/// Auto buy on Market - 999 ₽
	/// </summary>
	V22 = 22,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<PrizeType>))]
public enum PrizeType
{
	[Lolzteam.Api.Runtime.EnumValue("money")] Money,
	[Lolzteam.Api.Runtime.EnumValue("upgrades")] Upgrades,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="PrizeType"/>.</summary>
internal static class PrizeTypeExtensions
{
	public static string ToJsonValue(this PrizeType value)
	{
		return value switch
		{
			PrizeType.Money => "money",
			PrizeType.Upgrades => "upgrades",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ProfilePostsFieldsInclude>))]
public enum ProfilePostsFieldsInclude
{
	[Lolzteam.Api.Runtime.EnumValue("*")] All,
	[Lolzteam.Api.Runtime.EnumValue("latest_comments")] LatestComments,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="ProfilePostsFieldsInclude"/>.</summary>
internal static class ProfilePostsFieldsIncludeExtensions
{
	public static string ToJsonValue(this ProfilePostsFieldsInclude value)
	{
		return value switch
		{
			ProfilePostsFieldsInclude.All => "*",
			ProfilePostsFieldsInclude.LatestComments => "latest_comments",
			_ => value.ToString(),
		};
	}
}

public enum ReplyGroup : long
{
	/// <summary>
	/// Only staff members and curators can reply in thread
	/// </summary>
	V0 = 0,
	/// <summary>
	/// Everyone can reply in thread
	/// </summary>
	V2 = 2,
	/// <summary>
	/// Local and higher can reply in thread
	/// </summary>
	V21 = 21,
	/// <summary>
	/// Resident or higher can reply in thread
	/// </summary>
	V22 = 22,
	/// <summary>
	/// Expert or higher can reply in thread
	/// </summary>
	V23 = 23,
	/// <summary>
	/// Guru and higher can reply in thread
	/// </summary>
	V60 = 60,
	/// <summary>
	/// Artificial Intelligence and higher can reply in thread
	/// </summary>
	V351 = 351,
}

public enum RoomId : long
{
	/// <summary>
	/// [Russian] General chat
	/// </summary>
	V1 = 1,
	/// <summary>
	/// [English] General hat
	/// </summary>
	V2 = 2,
	/// <summary>
	/// [Russian] Market chat
	/// </summary>
	V3 = 3,
	/// <summary>
	/// [English] Market chat
	/// </summary>
	V4 = 4,
	V13 = 13,
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<State>))]
public enum State
{
	[Lolzteam.Api.Runtime.EnumValue("active")] Active,
	[Lolzteam.Api.Runtime.EnumValue("closed")] Closed,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="State"/>.</summary>
internal static class StateExtensions
{
	public static string ToJsonValue(this State value)
	{
		return value switch
		{
			State.Active => "active",
			State.Closed => "closed",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<ThreadsFieldsInclude>))]
public enum ThreadsFieldsInclude
{
	[Lolzteam.Api.Runtime.EnumValue("*")] All,
	[Lolzteam.Api.Runtime.EnumValue("latest_posts")] LatestPosts,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="ThreadsFieldsInclude"/>.</summary>
internal static class ThreadsFieldsIncludeExtensions
{
	public static string ToJsonValue(this ThreadsFieldsInclude value)
	{
		return value switch
		{
			ThreadsFieldsInclude.All => "*",
			ThreadsFieldsInclude.LatestPosts => "latest_posts",
			_ => value.ToString(),
		};
	}
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

/// <summary>Zero-reflection JSON string mapping for <see cref="ThreadsOrder"/>.</summary>
internal static class ThreadsOrderExtensions
{
	public static string ToJsonValue(this ThreadsOrder value)
	{
		return value switch
		{
			ThreadsOrder.PostDate => "post_date",
			ThreadsOrder.LastPostDate => "last_post_date",
			ThreadsOrder.ReplyCount => "reply_count",
			ThreadsOrder.ReplyCountAsc => "reply_count_asc",
			ThreadsOrder.FirstPostLikes => "first_post_likes",
			ThreadsOrder.VoteCount => "vote_count",
			_ => value.ToString(),
		};
	}
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

/// <summary>Zero-reflection JSON string mapping for <see cref="Timezone"/>.</summary>
internal static class TimezoneExtensions
{
	public static string ToJsonValue(this Timezone value)
	{
		return value switch
		{
			Timezone.PacificMidway => "Pacific/Midway",
			Timezone.PacificHonolulu => "Pacific/Honolulu",
			Timezone.PacificMarquesas => "Pacific/Marquesas",
			Timezone.AmericaAnchorage => "America/Anchorage",
			Timezone.AmericaLosAngeles => "America/Los_Angeles",
			Timezone.AmericaSantaIsabel => "America/Santa_Isabel",
			Timezone.AmericaTijuana => "America/Tijuana",
			Timezone.AmericaDenver => "America/Denver",
			Timezone.AmericaChihuahua => "America/Chihuahua",
			Timezone.AmericaPhoenix => "America/Phoenix",
			Timezone.AmericaChicago => "America/Chicago",
			Timezone.AmericaBelize => "America/Belize",
			Timezone.AmericaMexicoCity => "America/Mexico_City",
			Timezone.PacificEaster => "Pacific/Easter",
			Timezone.AmericaNewYork => "America/New_York",
			Timezone.AmericaHavana => "America/Havana",
			Timezone.AmericaBogota => "America/Bogota",
			Timezone.AmericaCaracas => "America/Caracas",
			Timezone.AmericaHalifax => "America/Halifax",
			Timezone.AmericaGooseBay => "America/Goose_Bay",
			Timezone.AmericaAsuncion => "America/Asuncion",
			Timezone.AmericaSantiago => "America/Santiago",
			Timezone.AmericaCuiaba => "America/Cuiaba",
			Timezone.AmericaLaPaz => "America/La_Paz",
			Timezone.AmericaStJohns => "America/St_Johns",
			Timezone.AmericaArgentinaBuenosAires => "America/Argentina/Buenos_Aires",
			Timezone.AmericaArgentinaSanLuis => "America/Argentina/San_Luis",
			Timezone.AmericaArgentinaMendoza => "America/Argentina/Mendoza",
			Timezone.AtlanticStanley => "Atlantic/Stanley",
			Timezone.AmericaGodthab => "America/Godthab",
			Timezone.AmericaMontevideo => "America/Montevideo",
			Timezone.AmericaSaoPaulo => "America/Sao_Paulo",
			Timezone.AmericaMiquelon => "America/Miquelon",
			Timezone.AmericaNoronha => "America/Noronha",
			Timezone.AtlanticCapeVerde => "Atlantic/Cape_Verde",
			Timezone.AtlanticAzores => "Atlantic/Azores",
			Timezone.EuropeLondon => "Europe/London",
			Timezone.AfricaCasablanca => "Africa/Casablanca",
			Timezone.AtlanticReykjavik => "Atlantic/Reykjavik",
			Timezone.EuropeAmsterdam => "Europe/Amsterdam",
			Timezone.AfricaAlgiers => "Africa/Algiers",
			Timezone.AfricaWindhoek => "Africa/Windhoek",
			Timezone.AfricaTunis => "Africa/Tunis",
			Timezone.EuropeAthens => "Europe/Athens",
			Timezone.AfricaJohannesburg => "Africa/Johannesburg",
			Timezone.EuropeKaliningrad => "Europe/Kaliningrad",
			Timezone.AsiaAmman => "Asia/Amman",
			Timezone.AsiaBeirut => "Asia/Beirut",
			Timezone.AfricaCairo => "Africa/Cairo",
			Timezone.AsiaJerusalem => "Asia/Jerusalem",
			Timezone.AsiaGaza => "Asia/Gaza",
			Timezone.AsiaDamascus => "Asia/Damascus",
			Timezone.EuropeMoscow => "Europe/Moscow",
			Timezone.EuropeMinsk => "Europe/Minsk",
			Timezone.AfricaNairobi => "Africa/Nairobi",
			Timezone.AsiaTehran => "Asia/Tehran",
			Timezone.AsiaDubai => "Asia/Dubai",
			Timezone.AsiaYerevan => "Asia/Yerevan",
			Timezone.AsiaBaku => "Asia/Baku",
			Timezone.IndianMauritius => "Indian/Mauritius",
			Timezone.AsiaKabul => "Asia/Kabul",
			Timezone.AsiaYekaterinburg => "Asia/Yekaterinburg",
			Timezone.AsiaTashkent => "Asia/Tashkent",
			Timezone.AsiaKolkata => "Asia/Kolkata",
			Timezone.AsiaKathmandu => "Asia/Kathmandu",
			Timezone.AsiaNovosibirsk => "Asia/Novosibirsk",
			Timezone.AsiaDhaka => "Asia/Dhaka",
			Timezone.AsiaAlmaty => "Asia/Almaty",
			Timezone.AsiaRangoon => "Asia/Rangoon",
			Timezone.AsiaKrasnoyarsk => "Asia/Krasnoyarsk",
			Timezone.AsiaBangkok => "Asia/Bangkok",
			Timezone.AsiaIrkutsk => "Asia/Irkutsk",
			Timezone.AsiaHongKong => "Asia/Hong_Kong",
			Timezone.AsiaSingapore => "Asia/Singapore",
			Timezone.AustraliaPerth => "Australia/Perth",
			Timezone.AsiaYakutsk => "Asia/Yakutsk",
			Timezone.AsiaTokyo => "Asia/Tokyo",
			Timezone.AsiaSeoul => "Asia/Seoul",
			Timezone.AustraliaAdelaide => "Australia/Adelaide",
			Timezone.AustraliaDarwin => "Australia/Darwin",
			Timezone.AsiaVladivostok => "Asia/Vladivostok",
			Timezone.AsiaMagadan => "Asia/Magadan",
			Timezone.AustraliaBrisbane => "Australia/Brisbane",
			Timezone.AustraliaSydney => "Australia/Sydney",
			Timezone.PacificNoumea => "Pacific/Noumea",
			Timezone.PacificNorfolk => "Pacific/Norfolk",
			Timezone.AsiaAnadyr => "Asia/Anadyr",
			Timezone.PacificAuckland => "Pacific/Auckland",
			Timezone.PacificFiji => "Pacific/Fiji",
			Timezone.PacificChatham => "Pacific/Chatham",
			Timezone.PacificTongatapu => "Pacific/Tongatapu",
			Timezone.PacificApia => "Pacific/Apia",
			Timezone.PacificKiritimati => "Pacific/Kiritimati",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<TransferType>))]
public enum TransferType
{
	[Lolzteam.Api.Runtime.EnumValue("guarantor")] Guarantor,
	[Lolzteam.Api.Runtime.EnumValue("safe")] Safe,
	[Lolzteam.Api.Runtime.EnumValue("notsafe")] Notsafe,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="TransferType"/>.</summary>
internal static class TransferTypeExtensions
{
	public static string ToJsonValue(this TransferType value)
	{
		return value switch
		{
			TransferType.Guarantor => "guarantor",
			TransferType.Safe => "safe",
			TransferType.Notsafe => "notsafe",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersFieldsInclude>))]
public enum UsersFieldsInclude
{
	[Lolzteam.Api.Runtime.EnumValue("*")] All,
	[Lolzteam.Api.Runtime.EnumValue("alerts")] Alerts,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="UsersFieldsInclude"/>.</summary>
internal static class UsersFieldsIncludeExtensions
{
	public static string ToJsonValue(this UsersFieldsInclude value)
	{
		return value switch
		{
			UsersFieldsInclude.All => "*",
			UsersFieldsInclude.Alerts => "alerts",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersOrder>))]
public enum UsersOrder
{
	[Lolzteam.Api.Runtime.EnumValue("natural")] Natural,
	[Lolzteam.Api.Runtime.EnumValue("follow_date")] FollowDate,
	[Lolzteam.Api.Runtime.EnumValue("follow_date_reverse")] FollowDateReverse,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="UsersOrder"/>.</summary>
internal static class UsersOrderExtensions
{
	public static string ToJsonValue(this UsersOrder value)
	{
		return value switch
		{
			UsersOrder.Natural => "natural",
			UsersOrder.FollowDate => "follow_date",
			UsersOrder.FollowDateReverse => "follow_date_reverse",
			_ => value.ToString(),
		};
	}
}

[JsonConverter(typeof(Lolzteam.Api.Runtime.StringEnumConverter<UsersType>))]
public enum UsersType
{
	[Lolzteam.Api.Runtime.EnumValue("gotten")] Gotten,
	[Lolzteam.Api.Runtime.EnumValue("given")] Given,
}

/// <summary>Zero-reflection JSON string mapping for <see cref="UsersType"/>.</summary>
internal static class UsersTypeExtensions
{
	public static string ToJsonValue(this UsersType value)
	{
		return value switch
		{
			UsersType.Gotten => "gotten",
			UsersType.Given => "given",
			_ => value.ToString(),
		};
	}
}

