using System.Text.Json;
using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

public sealed class StringOrLongTests
{
    [Fact]
    public void Implicit_from_string()
    {
        StringOrLong v = "hello";

        v.IsString.Should().BeTrue();
        v.IsLong.Should().BeFalse();
        v.AsString().Should().Be("hello");
    }

    [Fact]
    public void Implicit_from_long()
    {
        StringOrLong v = 42L;

        v.IsLong.Should().BeTrue();
        v.AsLong().Should().Be(42);
    }

    [Fact]
    public void Deserializes_from_number_json()
    {
        var json = "123";
        var v = JsonSerializer.Deserialize<StringOrLong>(json);

        v.IsLong.Should().BeTrue();
        v.AsLong().Should().Be(123);
    }

    [Fact]
    public void Deserializes_from_string_json()
    {
        var json = "\"hello\"";
        var v = JsonSerializer.Deserialize<StringOrLong>(json);

        v.IsString.Should().BeTrue();
        v.AsString().Should().Be("hello");
    }

    [Fact]
    public void Serializes_long_as_number()
    {
        StringOrLong v = 99L;
        var json = JsonSerializer.Serialize(v);

        json.Should().Be("99");
    }

    [Fact]
    public void Serializes_string_as_string()
    {
        StringOrLong v = "test";
        var json = JsonSerializer.Serialize(v);

        json.Should().Be("\"test\"");
    }
}
