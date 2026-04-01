using System.Text;
using FluentAssertions;
using Lolzteam.Api.Generated.Forum;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

/// <summary>
/// Correctness tests for generated Dictionary&lt;string, T&gt; deserialization paths.
/// The generated code is excluded from coverage metrics, so these tests exist purely
/// to catch regressions in the codegen ReadFromReader dictionary logic.
/// </summary>
public sealed class DictionaryDeserializationTests
{
    // ── TagsPopularResponse ──────────────────────────────────────────────────

    [Fact]
    public void TagsPopularResponse_deserializes_string_dictionary()
    {
        var json = """{"tags":{"123":"Gaming","456":"Tech"},"system_info":{"visitor_id":1,"time":1000}}""";

        var result = TagsApiTypes.TagsPopularResponse.ReadFrom(Utf8(json));

        result.Tags.Should().HaveCount(2);
        result.Tags["123"].Should().Be("Gaming");
        result.Tags["456"].Should().Be("Tech");
    }

    [Fact]
    public void TagsPopularResponse_deserializes_empty_dictionary()
    {
        var json = """{"tags":{},"system_info":{"visitor_id":1,"time":1000}}""";

        var result = TagsApiTypes.TagsPopularResponse.ReadFrom(Utf8(json));

        result.Tags.Should().NotBeNull().And.BeEmpty();
    }

    [Fact]
    public void TagsPopularResponse_leaves_dictionary_null_when_field_absent()
    {
        var json = """{"system_info":{"visitor_id":1,"time":1000}}""";

        var result = TagsApiTypes.TagsPopularResponse.ReadFrom(Utf8(json));

        result.Tags.Should().BeNull();
    }

    [Fact]
    public void TagsPopularResponse_skips_unknown_fields_correctly()
    {
        var json = """{"extra":"ignored","tags":{"1":"hello"},"system_info":{"visitor_id":2,"time":500}}""";

        var result = TagsApiTypes.TagsPopularResponse.ReadFrom(Utf8(json));

        result.Tags.Should().ContainKey("1").WhoseValue.Should().Be("hello");
        result.SystemInfo.VisitorId.Should().Be(2);
    }

    // ── TagsListResponse ─────────────────────────────────────────────────────

    [Fact]
    public void TagsListResponse_deserializes_string_dictionary_with_multiple_entries()
    {
        var json = """
        {
            "tags": {"10":"News","20":"Sport","30":"Tech"},
            "tags_total": 3,
            "links": {},
            "system_info": {"visitor_id":99,"time":9999}
        }
        """;

        var result = TagsApiTypes.TagsListResponse.ReadFrom(Utf8(json));

        result.Tags.Should().HaveCount(3)
            .And.ContainKey("10").WhoseValue.Should().Be("News");
        result.Tags["20"].Should().Be("Sport");
        result.Tags["30"].Should().Be("Tech");
        result.TagsTotal.Should().Be(3);
    }

    [Fact]
    public void TagsListResponse_dictionary_preserves_all_key_value_pairs()
    {
        var expected = new Dictionary<string, string>
        {
            ["a"] = "alpha",
            ["b"] = "beta",
            ["c"] = "gamma",
            ["d"] = "delta",
        };

        var tagsJson = string.Join(",", expected.Select(kv => $"\"{kv.Key}\":\"{kv.Value}\""));
        var json = $$"""{"tags":{{{tagsJson}}},"tags_total":4,"links":{},"system_info":{"visitor_id":1,"time":0}}""";

        var result = TagsApiTypes.TagsListResponse.ReadFrom(Utf8(json));

        result.Tags.Should().BeEquivalentTo(expected);
    }

    // ── Resp_ThreadModel (Dictionary inside a complex record) ────────────────

    [Fact]
    public void Resp_ThreadModel_deserializes_thread_tags_dictionary()
    {
        // Only thread_tags is populated; all other required fields remain at their default values.
        var json = """{"thread_tags":{"159103":"tag-one","159104":"tag-two"}}""";

        var result = Resp_ThreadModel.ReadFrom(Utf8(json));

        result.ThreadTags.Should().HaveCount(2);
        result.ThreadTags["159103"].Should().Be("tag-one");
        result.ThreadTags["159104"].Should().Be("tag-two");
    }

    [Fact]
    public void Resp_ThreadModel_deserializes_empty_thread_tags()
    {
        var json = """{"thread_tags":{}}""";

        var result = Resp_ThreadModel.ReadFrom(Utf8(json));

        result.ThreadTags.Should().NotBeNull().And.BeEmpty();
    }

    // ── helpers ──────────────────────────────────────────────────────────────

    private static ReadOnlyMemory<byte> Utf8(string json) =>
        Encoding.UTF8.GetBytes(json).AsMemory();
}
