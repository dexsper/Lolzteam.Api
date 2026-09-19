using SteamGift = Lolzteam.Api.Generated.Market.CategoryApiTypes.CategorySteamResponseItemsSteamGifts;

namespace Lolzteam.Api.Market;

/// <summary>
/// Convenience helpers for interpreting the free-form <c>fraudwarnings</c> text attached to
/// Steam gifts returned by <c>steamGifts[]</c> in the Market category response. Lolzteam/Steam
/// encode region restrictions and "guest pass" (limited-time trial) warnings as plain sentences
/// rather than structured fields, so these helpers parse them for you.
/// </summary>
public static class SteamGiftExtensions
{
    private const string RestrictedGiftMarker =
        "This is a restricted gift which can only be redeemed in these countries";

    private const string GuestPassMarker =
        "This pass only gives you access to the full version of this game for a limited time period.";

    /// <summary>
    /// A handful of official ISO 3166 country names contain a comma themselves
    /// (e.g. "Moldova, Republic of"). When splitting the comma-separated country list from
    /// <c>fraudwarnings</c>, a fragment matching one of these continuations is merged back into
    /// the preceding entry instead of being treated as a separate country.
    /// </summary>
    private static readonly HashSet<string> CountryNameContinuations = new(StringComparer.Ordinal)
    {
        "Republic of",
        "Bolivarian Republic of",
        "Plurinational State of",
        "Democratic Republic of the",
        "The Democratic Republic of the",
        "Federated States of",
        "Islamic Republic of",
        "Democratic People's Republic of",
        "the Former Yugoslav Republic of",
        "Province of China",
        "United Republic of",
        "State of",
        "British",
        "U.S.",
    };

    /// <param name="gift">The Steam gift to inspect.</param>
    extension(SteamGift gift)
    {
        /// <summary>
        /// Determines whether this gift is region-restricted, i.e. it can only be redeemed in a
        /// specific set of countries.
        /// </summary>
        public bool IsRegionRestricted() => gift.IsRegionRestricted(out _);

        /// <summary>
        /// Determines whether this gift is region-restricted, and if so, returns the countries it
        /// can be redeemed in.
        /// </summary>
        /// <param name="countries">
        /// When this method returns <see langword="true"/>, the countries the gift can be redeemed
        /// in. Otherwise an empty array.
        /// </param>
        /// <returns><see langword="true"/> if the gift is region-restricted; otherwise <see langword="false"/>.</returns>
        public bool IsRegionRestricted(out IReadOnlyList<string> countries)
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(gift);
#else
            if (gift is null) throw new ArgumentNullException(nameof(gift));
#endif
            var warning = gift.Fraudwarnings;
            var markerIndex = warning?.IndexOf(RestrictedGiftMarker, StringComparison.Ordinal) ?? -1;
            if (markerIndex < 0)
            {
                countries = Array.Empty<string>();
                return false;
            }

            var rest = warning!.Substring(markerIndex + RestrictedGiftMarker.Length).TrimStart(' ', ':');
            countries = rest.Length == 0 ? Array.Empty<string>() : SplitCountries(rest);
            return true;
        }

        /// <summary>
        /// Determines whether this gift is a "guest pass" — a gift that only grants access to the
        /// full game for a limited time period, rather than a permanent copy of the game.
        /// </summary>
        public bool IsGuestPass()
        {
#if NET6_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(gift);
#else
            if (gift is null) throw new ArgumentNullException(nameof(gift));
#endif
            return gift.Fraudwarnings?.IndexOf(GuestPassMarker, StringComparison.Ordinal) >= 0;
        }
    }

    private static List<string> SplitCountries(string rest)
    {
        var rawParts = rest.Split([", "], StringSplitOptions.RemoveEmptyEntries);
        var countries = new List<string>(rawParts.Length);

        foreach (var part in rawParts)
        {
            var trimmed = part.Trim();
            if (countries.Count <= 0 || !CountryNameContinuations.Contains(trimmed))
            {
                countries.Add(trimmed);
                continue;
            }

            countries[countries.Count - 1] = countries[countries.Count - 1] + ", " + trimmed;
        }

        return countries;
    }
}
