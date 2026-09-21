using System.Text;
using FluentAssertions;
using Lolzteam.Api.Generated.Market;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

/// <summary>
/// Optional integer response fields are declared as <c>long?</c>.
/// A missing property and a JSON null must both deserialize as null, not as 0.
/// </summary>
public sealed class NullableLongDeserializationTests
{
    [Fact]
    public void ItemModelSeller_restore_percents_is_null_when_field_is_absent()
    {
        var result = ItemModelSeller.ReadFrom(Utf8(Seller()));

        result.RestorePercents.Should().BeNull();
    }

    [Fact]
    public void ItemModelSeller_restore_percents_is_null_when_json_null()
    {
        var result = ItemModelSeller.ReadFrom(Utf8(Seller("null")));

        result.RestorePercents.Should().BeNull();
    }

    [Fact]
    public void ItemModelSeller_restore_percents_reads_a_present_number()
    {
        var result = ItemModelSeller.ReadFrom(Utf8(Seller("15")));

        result.RestorePercents.Should().Be(15);
    }

    private static string Seller(string? restorePercents = null)
    {
        var restore = restorePercents is null ? "" : $",\"restore_percents\":{restorePercents}";
        return $$"""
                 {"user_id":1,"sold_items_count":2,"active_items_count":3,"restore_data":"ok","username":"seller","avatar_date":4,"is_banned":0,"display_style_group_id":5{{restore}}}
                 """;
    }

    private static ReadOnlyMemory<byte> Utf8(string json) => Encoding.UTF8.GetBytes(json).AsMemory();
}
