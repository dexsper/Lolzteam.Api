using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Unit;

public sealed class ProxyConfigTests
{
    [Theory]
    [InlineData("http://proxy.example.com:8080")]
    [InlineData("https://proxy.example.com:8443")]
    public void Http_and_https_proxy_builds_handler_without_throwing(string url)
    {
        var action = () => LolzteamHttpClient.BuildHandler(new ProxyConfig(url));
        action.Should().NotThrow();
    }

    [Fact]
    public void No_proxy_builds_handler_without_throwing()
    {
        var action = () => LolzteamHttpClient.BuildHandler(null);
        action.Should().NotThrow();
    }

    [Theory]
    [InlineData("ftp://proxy.example.com")]
    [InlineData("ssh://proxy.example.com")]
    public void Unsupported_scheme_throws_ConfigException(string url)
    {
        var action = () => LolzteamHttpClient.BuildHandler(new ProxyConfig(url));
        action.Should().Throw<ConfigException>().WithMessage("*Unsupported proxy scheme*");
    }

    [Theory]
    [InlineData("not-a-url")]
    [InlineData("://missing-scheme")]
    public void Invalid_url_throws_ConfigException(string url)
    {
        var action = () => LolzteamHttpClient.BuildHandler(new ProxyConfig(url));
        action.Should().Throw<ConfigException>().WithMessage("*Invalid proxy URL*");
    }

#if NET6_0_OR_GREATER
    [Fact]
    public void Socks5_proxy_builds_handler_on_net6_plus()
    {
        var action = () => LolzteamHttpClient.BuildHandler(new ProxyConfig("socks5://proxy.example.com:1080"));
        action.Should().NotThrow();
    }
#else
    [Fact]
    public void Socks5_proxy_throws_PlatformNotSupportedException_on_old_tfm()
    {
        var action = () => LolzteamHttpClient.BuildHandler(new ProxyConfig("socks5://proxy.example.com:1080"));
        action.Should().Throw<PlatformNotSupportedException>().WithMessage("*SOCKS5*");
    }
#endif
}
