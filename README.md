Lolzteam.Api
===
[![Build](https://github.com/lolzteam/Lolzteam.Api/actions/workflows/pr.yml/badge.svg)](https://github.com/lolzteam/Lolzteam.Api/actions) ![Coverage](https://img.shields.io/badge/coverage-80%25-brightgreen) [![NuGet](https://img.shields.io/nuget/v/Lolzteam.Api.svg)](https://www.nuget.org/packages/Lolzteam.Api) [![NuGet](https://img.shields.io/nuget/v/Lolzteam.Api.DependencyInjection.svg?label=Lolzteam.Api.DependencyInjection)](https://www.nuget.org/packages/Lolzteam.Api.DependencyInjection)

Production-grade C# client for the [Lolzteam Forum](https://prod-api.lolz.live) and [Market](https://prod-api.lzt.market) APIs.

* **Code-generated** from official OpenAPI schemas — 151 Forum and 115 Market operations, all strongly typed
* **AOT-safe** deserialization — each response record reads itself directly from a binary stream, zero runtime reflection
* **Low allocation** HTTP — `ArrayPool<byte>` response buffering with a static pooled `HttpMessageHandler`
* **Automatic retry** on 429 / 502 / 503 with `Retry-After` header respect and configurable back-off
* **Client-side rate limiting** — proactively throttles requests before the server ever returns 429
* **Proxy support** — HTTP, HTTPS, and SOCKS5 with optional per-proxy credentials
* **Multi-target** — `netstandard2.0`, `netstandard2.1`, `net6.0`, `net8.0` (.NET Framework 4.6.1+, Unity, Xamarin)
* **Optional DI package** — `IHttpClientFactory` integration for ASP.NET Core / Generic Host
* **Well tested** — 80%+ line coverage across all handwritten code (generated types excluded)
## Table of Contents

- [Installation](#installation)
- [Getting Started](#getting-started)
- [Configuration](#configuration)
- [Retry](#retry)
- [Rate Limiting](#rate-limiting)
- [Proxy](#proxy)
- [Dependency Injection](#dependency-injection)
- [Error Handling](#error-handling)
- [Forum API Groups](#forum-api-groups)
- [Market API Groups](#market-api-groups)
- [Regenerating Code](#regenerating-code)
- [License](#license)

Installation
---
Install the core package from NuGet:

```bash
dotnet add package Lolzteam.Api
```

For ASP.NET Core / Generic Host with `IHttpClientFactory`, also install the optional DI package:

```bash
dotnet add package Lolzteam.Api.DependencyInjection
```

Getting Started
---
Create a `ClientConfig` with your bearer token and instantiate a client:

```csharp
using Lolzteam.Api.Generated.Forum;
using Lolzteam.Api.Runtime;

var config = new ClientConfig
{
    Token   = "your-bearer-token",
    BaseUrl = "https://prod-api.lolz.live",
};

using var forum = new ForumClient(config);

// Get a thread by ID
var thread = await forum.Threads.GetAsync(threadId: 12345);
Console.WriteLine(thread.Thread?.Title);

// List threads in a forum node
var list = await forum.Threads.ListAsync(new() { ForumId = 7 });
foreach (var t in list.Threads ?? [])
    Console.WriteLine($"{t.ThreadId}: {t.Title}");
```

Market client works the same way:

```csharp
using Lolzteam.Api.Generated.Market;

using var market = new MarketClient(new ClientConfig
{
    Token   = "your-bearer-token",
    BaseUrl = "https://prod-api.lzt.market",
});

// Browse account listings
var listing = await market.List.GetListingAsync(new() { CategoryId = 1, Page = 1 });

// Purchase an account
await market.Purchasing.BuyAsync(itemId: 99999, new() { Price = listing.Items?[0].Price });
```

Both clients implement `IDisposable`. `using` or `using var` is recommended when lifetime is scoped; for singleton use omit the `using`.

Configuration
---
`ClientConfig` is an immutable C# record. All properties except `Token` are optional.

```csharp
var config = new ClientConfig
{
    // Required
    Token = "your-bearer-token",

    // Override base URL (defaults to the official endpoint per client)
    BaseUrl = "https://prod-api.lolz.live",

    // Proxy (HTTP, HTTPS, or SOCKS5)
    Proxy = new ProxyConfig("socks5://user:pass@proxy.example.com:1080"),

    // Retry policy (default: 3 retries, 500 ms base, 30 s max)
    Retry = new RetryConfig
    {
        MaxRetries = 5,
        BaseDelay  = TimeSpan.FromMilliseconds(300),
        MaxDelay   = TimeSpan.FromSeconds(60),
    },

    // Client-side rate limiting (per-minute budget)
    RateLimit       = new RateLimitConfig(RequestsPerMinute: 300),
    SearchRateLimit = new RateLimitConfig(RequestsPerMinute: 20),

    // Per-request timeout
    Timeout = TimeSpan.FromSeconds(30),

    // Callback invoked before each retry attempt (for logging, metrics, etc.)
    OnRetry = ctx => Console.WriteLine($"Retry {ctx.Attempt}/{ctx.MaxRetries} — {ctx.Exception.Message}"),
};
```

Retry
---
The default policy retries on `429 Too Many Requests`, `502 Bad Gateway`, and `503 Service Unavailable`. On 429 the `Retry-After` response header is respected; on 5xx a configurable exponential back-off with jitter is used.

```csharp
// Disable retries entirely
var config = new ClientConfig { Token = "...", Retry = null };

// Custom policy
var config = new ClientConfig
{
    Token = "...",
    Retry = new RetryConfig
    {
        MaxRetries = 3,
        BaseDelay  = TimeSpan.FromMilliseconds(500),
        MaxDelay   = TimeSpan.FromSeconds(30),
    },
    OnRetry = ctx => logger.LogWarning("Retry {Attempt} after {Delay:g}: {Message}", ctx.Attempt, ctx.Delay, ctx.Exception.Message),
};
```

When all retries are exhausted a `RetryExhaustedException` is thrown, with the last underlying exception as `InnerException`.

Rate Limiting
---
Client-side rate limiting is disabled by default. When configured, a sliding-window token bucket ensures the request rate never exceeds the specified budget, preventing the server from returning 429 in the first place.

```csharp
var config = new ClientConfig
{
    Token = "...",

    // General-purpose endpoints: 300 req/min (Forum default)
    RateLimit = new RateLimitConfig(300),

    // Search endpoints are counted separately (stricter limit)
    SearchRateLimit = new RateLimitConfig(20),
};
```

Search requests are automatically identified by the client and consume the `SearchRateLimit` bucket when set.

Proxy
---
Pass a `ProxyConfig` with a URI. Supported schemes: `http://`, `https://`, `socks5://`. Credentials are embedded in the URI.

```csharp
// HTTP proxy, no auth
Proxy = new ProxyConfig("http://proxy.example.com:8080")

// SOCKS5 proxy with credentials
Proxy = new ProxyConfig("socks5://user:secret@10.0.0.1:1080")
```

Handlers are cached per proxy URL at the process level, so creating multiple clients with the same proxy reuses the underlying socket pool.

Dependency Injection
---
Install `Lolzteam.Api.DependencyInjection` and call `AddLolzteamClient<TClient>` in your `Program.cs`. This registers a named `HttpClient` via `IHttpClientFactory` for proper socket lifecycle management in hosted applications.

```csharp
// Program.cs
builder.Services.AddLolzteamClient<ForumClient>(new ClientConfig
{
    Token   = builder.Configuration["Lolzteam:Token"]!,
    BaseUrl = "https://prod-api.lolz.live",
    Retry   = new RetryConfig { MaxRetries = 3 },
});

// Resolve in your service
public class ThreadService(LolzteamHttpClient http)
{
    private readonly ForumClient _forum = new(new ClientConfig
    {
        Token = "...",
        HttpClient = http.Inner, // reuse the factory-managed HttpClient
    });
}
```

> When using `IHttpClientFactory` the `HttpClient` lifetime is managed by the factory. Do **not** dispose the injected `LolzteamHttpClient` in this case.

Error Handling
---
All client-facing exceptions derive from `LolzteamException`.

| Exception | HTTP status | Notes |
|---|---|---|
| `HttpApiException` | 4xx (except 429) | `StatusCode`, `ResponseBody` |
| `RateLimitException` | 429 | `RetryAfter` (parsed from header) |
| `ServerException` | 5xx | `StatusCode`, `ResponseBody` |
| `NetworkException` | — | Connection-level failure, `IsTransient` |
| `RetryExhaustedException` | — | After all retries fail, wraps last exception |
| `ConfigException` | — | Invalid proxy URL or unsupported scheme |

```csharp
try
{
    var thread = await forum.Threads.GetAsync(12345);
}
catch (RateLimitException ex)
{
    // Honour the server's hint even when client-side limiting is enabled
    await Task.Delay(ex.RetryAfter ?? TimeSpan.FromSeconds(5));
}
catch (HttpApiException ex) when (ex.StatusCode == 404)
{
    Console.WriteLine("Thread not found.");
}
catch (ServerException ex)
{
    Console.WriteLine($"Server error {ex.StatusCode}: {ex.ResponseBody}");
}
```

Forum API Groups
---
`ForumClient` exposes 151 operations across 18 endpoint groups:

| Property | Description |
|---|---|
| `Assets` | Static asset URLs (CSS, styles) |
| `Batch` | Execute multiple API calls in one request |
| `Categories` | Browse forum categories |
| `Chatbox` | Chatbox messages |
| `Conversations` | Private conversations |
| `Forms` | Form definitions |
| `Forums` | Forum node listings and subscriptions |
| `Links` | Short-link resolution |
| `Navigation` | Navigation elements |
| `Notifications` | User notifications |
| `OAuth` | OAuth token management |
| `Pages` | Static pages |
| `Posts` | Thread posts (create, edit, delete, react) |
| `ProfilePosts` | Profile wall posts |
| `Search` | Full-text thread and user search |
| `Tags` | Thread tags |
| `Threads` | Threads (list, create, edit, delete, vote) |
| `Users` | User profiles, followers, fields, avatar |

Market API Groups
---
`MarketClient` exposes 115 operations across 14 endpoint groups:

| Property | Description |
|---|---|
| `AutoPayments` | Autopayment rules |
| `Batch` | Batch request execution |
| `Cart` | Shopping cart |
| `Category` | Account categories and search |
| `CustomDiscounts` | Coupon / discount management |
| `Imap` | IMAP verification for accounts |
| `List` | Account listing and browsing |
| `Managing` | Seller account management |
| `Payments` | Wallet operations and transfer |
| `Profile` | Buyer/seller profile |
| `Proxy` | Proxy operations on listed accounts |
| `Publishing` | Create and edit listings |
| `Purchasing` | Buy, reserve, and confirm accounts |
| `Tags` | Listing tags |

Regenerating Code
---
The clients in `src/Lolzteam.Api/Generated/` are produced from the OpenAPI schemas in `schemas/`. To regenerate after updating a schema, run:

```bash
dotnet run --project codegen/Lolzteam.Codegen
```

The generator will:
1. Parse `schemas/forum.json` and `schemas/market.json`
2. Delete existing `.cs` files in each `Generated/` subdirectory
3. Emit fresh `Types.cs`, `ForumClient.cs` / `MarketClient.cs`, and `IForumClient.cs` / `IMarketClient.cs`

Generated files are committed to the repository so the library builds without running the codegen.

License
---
This library is licensed under the [MIT License](LICENSE).
