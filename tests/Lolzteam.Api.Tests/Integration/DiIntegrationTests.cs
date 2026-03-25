using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using Lolzteam.Api.DependencyInjection;
using Lolzteam.Api.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Lolzteam.Api.Tests.Integration;

/// <summary>
/// Verifies that <c>AddLolzteamClient</c> registers a working <see cref="LolzteamHttpClient"/>
/// via <see cref="IHttpClientFactory"/> and that it can be resolved and used from the DI container.
/// </summary>
public sealed class DiIntegrationTests
{
    private sealed class MarkerClient
    {
    }

    [Fact]
    public async Task AddLolzteamClient_resolves_and_executes_request()
    {
        // Arrange — build a service collection with a delegating handler stub
        var services = new ServiceCollection();
        var config = new ClientConfig
        {
            Token = "di-test-token",
            BaseUrl = "http://di.test",
        };

        services.AddLolzteamClient<MarkerClient>(config);
        services.AddHttpClient(nameof(MarkerClient)).ConfigurePrimaryHttpMessageHandler(() =>
            new StubDelegatingHandler(_ => Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"di\":true}", Encoding.UTF8, "application/json"),
            }))
        );

        await using var sp = services.BuildServiceProvider();
        using var scope = sp.CreateScope();

        var client = scope.ServiceProvider.GetRequiredService<LolzteamHttpClient>();
        var result = await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/di-test" });

        result.GetProperty("di").GetBoolean().Should().BeTrue();
    }

    [Fact]
    public void AddLolzteamClient_throws_when_services_is_null()
    {
        var act = () => ((IServiceCollection)null!).AddLolzteamClient<MarkerClient>(new ClientConfig { Token = "tok" });
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void AddLolzteamClient_throws_when_config_is_null()
    {
        var act = () => new ServiceCollection().AddLolzteamClient<MarkerClient>((ClientConfig)null!);
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void AddLolzteamClient_throws_when_configure_is_null()
    {
        var act = () => new ServiceCollection().AddLolzteamClient<MarkerClient>((Action<ClientConfigBuilder>)null!);
        act.Should().Throw<ArgumentNullException>();
    }

    [Fact]
    public void AddLolzteamClient_fluent_throws_when_token_not_set()
    {
        var act = () => new ServiceCollection().AddLolzteamClient<MarkerClient>(_ => { });
        act.Should().Throw<InvalidOperationException>().WithMessage("*Token*");
    }

    [Fact]
    public async Task AddLolzteamClient_fluent_resolves_and_executes_request()
    {
        var services = new ServiceCollection();

        services.AddLolzteamClient<MarkerClient>(b => b
            .WithToken("di-test-token")
            .WithBaseUrl("http://di.test")
        );

        services.AddHttpClient(nameof(MarkerClient)).ConfigurePrimaryHttpMessageHandler(() =>
            new StubDelegatingHandler(_ => Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"fluent\":true}", Encoding.UTF8, "application/json"),
            }))
        );

        await using var sp = services.BuildServiceProvider();
        using var scope = sp.CreateScope();

        var client = scope.ServiceProvider.GetRequiredService<LolzteamHttpClient>();
        var result = await client.RequestAsync(new RequestOptions { Method = "GET", Path = "/di-test" });

        result.GetProperty("fluent").GetBoolean().Should().BeTrue();
    }
}

/// <summary>Minimal delegating handler for DI tests — does not need to be part of StubHandler.</summary>
internal sealed class StubDelegatingHandler : HttpMessageHandler
{
    private readonly Func<HttpRequestMessage, Task<HttpResponseMessage>> _fn;
    public StubDelegatingHandler(Func<HttpRequestMessage, Task<HttpResponseMessage>> fn) => _fn = fn;

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct) =>
        _fn(request);
}
