using FluentAssertions;
using Lolzteam.Api.DependencyInjection;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

public sealed class ClientConfigBuilderTests
{
    [Fact]
    public void Build_with_all_options_produces_correct_config()
    {
        var onRetryCalled = false;
        var retryConfig   = new RetryConfig { MaxRetries = 1, BaseDelay = TimeSpan.FromMilliseconds(100) };
        var proxyConfig   = new ProxyConfig("http://proxy:8080");

        var config = new ClientConfigBuilder()
            .WithToken("tok")
            .WithBaseUrl("https://custom.api")
            .WithProxy(proxyConfig)
            .WithRetry(retryConfig)
            .WithRateLimit(120)
            .WithSearchRateLimit(20)
            .WithTimeout(TimeSpan.FromSeconds(10))
            .OnRetry(_ => onRetryCalled = true)
            .Build();

        config.Token.Should().Be("tok");
        config.BaseUrl.Should().Be("https://custom.api");
        config.Proxy.Should().Be(proxyConfig);
        config.Retry.Should().Be(retryConfig);
        config.RateLimit.Should().Be(new RateLimitConfig(120));
        config.SearchRateLimit.Should().Be(new RateLimitConfig(20));
        config.Timeout.Should().Be(TimeSpan.FromSeconds(10));

        config.OnRetry.Should().NotBeNull();
        config.OnRetry?.Invoke(null!);
        onRetryCalled.Should().BeTrue();
    }

    [Fact]
    public void Build_with_proxy_url_string_creates_proxy_config()
    {
        var config = new ClientConfigBuilder()
            .WithToken("tok")
            .WithProxy("socks5://proxy:1080")
            .Build();

        config.Proxy.Should().Be(new ProxyConfig("socks5://proxy:1080"));
    }

    [Fact]
    public void WithoutRetry_sets_retry_to_null()
    {
        var config = new ClientConfigBuilder()
            .WithToken("tok")
            .WithoutRetry()
            .Build();

        config.Retry.Should().BeNull();
    }

    [Fact]
    public void Build_defaults_are_applied_when_not_overridden()
    {
        var config = new ClientConfigBuilder()
            .WithToken("tok")
            .Build();

        config.Retry.Should().Be(RetryConfig.Default);
        config.Timeout.Should().Be(TimeSpan.FromSeconds(30));
        config.Proxy.Should().BeNull();
        config.BaseUrl.Should().BeNull();
        config.RateLimit.Should().BeNull();
        config.SearchRateLimit.Should().BeNull();
        config.OnRetry.Should().BeNull();
    }

    [Fact]
    public void Build_throws_when_token_is_empty()
    {
        var act = () => new ClientConfigBuilder().WithToken("").Build();
        act.Should().Throw<InvalidOperationException>().WithMessage("*Token*");
    }

    [Fact]
    public void Build_throws_when_token_is_whitespace()
    {
        var act = () => new ClientConfigBuilder().WithToken("   ").Build();
        act.Should().Throw<InvalidOperationException>().WithMessage("*Token*");
    }

    [Fact]
    public void Build_throws_when_token_never_set()
    {
        var act = () => new ClientConfigBuilder().Build();
        act.Should().Throw<InvalidOperationException>().WithMessage("*Token*");
    }
}
