using Lolzteam.Api.Runtime;
using Microsoft.Extensions.DependencyInjection;

namespace Lolzteam.Api.DependencyInjection;

/// <summary>
/// Extension methods for registering Lolzteam API clients with Microsoft.Extensions.DependencyInjection.
/// The core <c>Lolzteam.Api</c> package has zero dependency on this package — install it only when
/// using ASP.NET Core or Generic Host.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Register a named <see cref="LolzteamHttpClient"/> using <see cref="IHttpClientFactory"/>
    /// for proper socket pooling in ASP.NET Core / Generic Host.
    /// </summary>
    /// <typeparam name="TClient">
    /// A marker type used to name the underlying <see cref="HttpClient"/> in the factory pool
    /// (typically the generated <c>ForumClient</c> or <c>MarketClient</c>).
    /// </typeparam>
    /// <param name="services">The service collection.</param>
    /// <param name="config">Client configuration (token, proxy, retry, etc.).</param>
    /// <returns>The service collection for chaining.</returns>
    /// <example>
    /// <code>
    /// // In ASP.NET Core Startup / Program.cs:
    /// services.AddLolzteamClient&lt;ForumClient&gt;(new ClientConfig { Token = "mytoken" });
    ///
    /// // Then resolve in your services:
    /// public class MyService(LolzteamHttpClient http) { ... }
    /// </code>
    /// </example>
    public static IServiceCollection AddLolzteamClient<TClient>(
        this IServiceCollection services,
        ClientConfig config)
        where TClient : class
    {
#if NET6_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(config);
#else
        if (services is null) throw new ArgumentNullException(nameof(services));
        if (config is null) throw new ArgumentNullException(nameof(config));
#endif

        var clientName = typeof(TClient).Name;

        services.AddHttpClient(clientName, client =>
        {
            client.Timeout = config.Timeout;
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", config.Token);
        }).ConfigurePrimaryHttpMessageHandler(() => LolzteamHttpClient.BuildHandler(config.Proxy));

        services.AddScoped<LolzteamHttpClient>(sp =>
        {
            var factory = sp.GetRequiredService<IHttpClientFactory>();
            var httpClient = factory.CreateClient(clientName);
            return new LolzteamHttpClient(config.WithHttpClient(httpClient));
        });

        return services;
    }

    /// <summary>
    /// Register a named <see cref="LolzteamHttpClient"/> using <see cref="IHttpClientFactory"/>,
    /// configured via a fluent <see cref="ClientConfigBuilder"/>.
    /// </summary>
    /// <typeparam name="TClient">
    /// A marker type used to name the underlying <see cref="HttpClient"/> in the factory pool
    /// (typically the generated <c>ForumClient</c> or <c>MarketClient</c>).
    /// </typeparam>
    /// <param name="services">The service collection.</param>
    /// <param name="configure">A delegate that configures the client using <see cref="ClientConfigBuilder"/>.</param>
    /// <returns>The service collection for chaining.</returns>
    /// <example>
    /// <code>
    /// services.AddLolzteamClient&lt;ForumClient&gt;(b => b
    ///     .WithToken("mytoken")
    ///     .WithProxy("socks5://proxy:1080")
    ///     .WithTimeout(TimeSpan.FromSeconds(60))
    ///     .WithRateLimit(300)
    /// );
    /// </code>
    /// </example>
    public static IServiceCollection AddLolzteamClient<TClient>(
        this IServiceCollection services,
        Action<ClientConfigBuilder> configure)
        where TClient : class
    {
#if NET6_0_OR_GREATER
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configure);
#else
        if (services is null) throw new ArgumentNullException(nameof(services));
        if (configure is null) throw new ArgumentNullException(nameof(configure));
#endif

        var builder = new ClientConfigBuilder();
        configure(builder);
        return AddLolzteamClient<TClient>(services, builder.Build());
    }
}
