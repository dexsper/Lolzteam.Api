using System.Text.Json;
using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

/// <summary>
/// Round-trip serialization tests for value-type helpers generated/used by the library.
/// Ensures AOT-incompatible runtime reflection paths are not silently broken.
/// </summary>
public sealed class SerializationTests
{
    [Fact]
    public void StringOrLong_deserializes_string_value()
    {
        var json = "\"hello\"";
        var value = JsonSerializer.Deserialize<StringOrLong>(json);

        value.IsString.Should().BeTrue();
        value.AsString().Should().Be("hello");
    }

    [Fact]
    public void StringOrLong_deserializes_integer_value()
    {
        var json = "12345";
        var value = JsonSerializer.Deserialize<StringOrLong>(json);

        value.IsLong.Should().BeTrue();
        value.AsLong().Should().Be(12345L);
    }

    [Fact]
    public void StringOrLong_serializes_string_value()
    {
        var value = (StringOrLong)"world";
        var json = JsonSerializer.Serialize(value);

        json.Should().Be("\"world\"");
    }

    [Fact]
    public void StringOrLong_serializes_long_value()
    {
        var value = (StringOrLong)99L;
        var json = JsonSerializer.Serialize(value);

        json.Should().Be("99");
    }

    [Fact]
    public void StringOrLong_round_trips_string()
    {
        var original = (StringOrLong)"round-trip";
        var json = JsonSerializer.Serialize(original);
        var restored = JsonSerializer.Deserialize<StringOrLong>(json);

        restored.Should().Be(original);
    }

    [Fact]
    public void StringOrLong_round_trips_long()
    {
        var original = (StringOrLong)42L;
        var json = JsonSerializer.Serialize(original);
        var restored = JsonSerializer.Deserialize<StringOrLong>(json);

        restored.Should().Be(original);
    }

    [Fact]
    public void StringOrLong_AsString_converts_long_using_invariant_culture()
    {
        var value = (StringOrLong)1_000_000L;
        value.AsString().Should().Be("1000000");
    }

    [Fact]
    public void StringOrLong_equality_operators_work()
    {
        var a = (StringOrLong)"test";
        var b = (StringOrLong)"test";
        var c = (StringOrLong)"other";

        (a == b).Should().BeTrue();
        (a != c).Should().BeTrue();
    }

    [Fact]
    public void StringOrLong_default_is_string_with_null_value()
    {
        var d = default(StringOrLong);

        d.IsLong.Should().BeFalse();
        d.IsString.Should().BeTrue();
        d.AsString().Should().BeNull();
    }

    [Fact]
    public void RequestOptions_body_round_trips_as_json_element()
    {
        var payload = new { user_id = 42, message = "hello" };
        var body = JsonSerializer.SerializeToElement(payload);

        var opts = new RequestOptions
        {
            Method = "POST",
            Path = "/test",
            Body = body,
            BodyEncoding = BodyEncoding.Json,
        };

        opts.Body!.Value.GetProperty("user_id").GetInt32().Should().Be(42);
        opts.Body!.Value.GetProperty("message").GetString().Should().Be("hello");
    }

    [Fact]
    public void RequestOptions_query_round_trips_as_json_element()
    {
        var qp = new { page = 1, limit = 20, q = "search term" };
        var query = JsonSerializer.SerializeToElement(qp);

        var opts = new RequestOptions
        {
            Method = "GET",
            Path = "/list",
            Query = query,
        };

        opts.Query!.Value.GetProperty("page").GetInt32().Should().Be(1);
        opts.Query!.Value.GetProperty("q").GetString().Should().Be("search term");
    }

    [Fact]
    public void ClientConfig_with_expression_creates_copy_with_new_values()
    {
        var original = new ClientConfig { Token = "tok1", BaseUrl = "https://example.com" };
        var copy = original with { BaseUrl = "https://other.com" };

        original.Token.Should().Be("tok1");
        original.BaseUrl.Should().Be("https://example.com");
        copy.Token.Should().Be("tok1");
        copy.BaseUrl.Should().Be("https://other.com");
    }

    [Fact]
    public void RetryConfig_defaults_are_sane()
    {
        var cfg = new RetryConfig();
        cfg.MaxRetries.Should().BeGreaterThan(0);
        cfg.BaseDelay.Should().BeGreaterThan(TimeSpan.Zero);
        cfg.MaxDelay.Should().BeGreaterThan(cfg.BaseDelay);
    }

    [Fact]
    public void StringEnumConverter_deserializes_known_value()
    {
        var opts = ConverterOptions();
        var result = JsonSerializer.Deserialize<TestColor>("\"red\"", opts);
        result.Should().Be(TestColor.Red);
    }

    [Fact]
    public void StringEnumConverter_deserializes_second_known_value()
    {
        var opts = ConverterOptions();
        var result = JsonSerializer.Deserialize<TestColor>("\"blue-color\"", opts);
        result.Should().Be(TestColor.Blue);
    }

    [Fact]
    public void StringEnumConverter_returns_default_for_null_token()
    {
        var opts = ConverterOptions();
        var result = JsonSerializer.Deserialize<TestColor>("null", opts);
        result.Should().Be(default(TestColor));
    }

    [Fact]
    public void StringEnumConverter_returns_default_for_unknown_value()
    {
        var opts = ConverterOptions();
        var result = JsonSerializer.Deserialize<TestColor>("\"purple\"", opts);
        result.Should().Be(default(TestColor));
    }

    [Fact]
    public void StringEnumConverter_serializes_known_value_using_attribute()
    {
        var opts = ConverterOptions();
        var json = JsonSerializer.Serialize(TestColor.Blue, opts);
        json.Should().Be("\"blue-color\"");
    }

    [Fact]
    public void StringEnumConverter_serializes_value_without_attribute_uses_name()
    {
        var opts = ConverterOptions();
        var json = JsonSerializer.Serialize(TestColor.Green, opts);
        json.Should().Be("\"Green\"");
    }

    [Fact]
    public void StringEnumConverter_round_trips_value()
    {
        var opts = ConverterOptions();
        var json = JsonSerializer.Serialize(TestColor.Red, opts);
        var restored = JsonSerializer.Deserialize<TestColor>(json, opts);
        restored.Should().Be(TestColor.Red);
    }

    [Fact]
    public void RetryExhaustedException_stores_attempts_and_inner_exception()
    {
        var inner = new InvalidOperationException("oops");
        var ex = new RetryExhaustedException(5, inner);
        ex.Attempts.Should().Be(5);
        ex.InnerException.Should().BeSameAs(inner);
        ex.Message.Should().Contain("5");
    }

    [Fact]
    public void EnumValueAttribute_stores_json_value()
    {
        var attr = new EnumValueAttribute("some-value");
        attr.Value.Should().Be("some-value");
    }

    [Fact]
    public void RateLimitConfig_stores_requests_per_minute()
    {
        var cfg = new RateLimitConfig(120);
        cfg.RequestsPerMinute.Should().Be(120);
    }

    private static JsonSerializerOptions ConverterOptions()
    {
        var opts = new JsonSerializerOptions();
        opts.Converters.Add(new StringEnumConverter<TestColor>());
        return opts;
    }
}

internal enum TestColor
{
    [EnumValue("red")]
    Red,

    [EnumValue("blue-color")]
    Blue,
    Green
}
