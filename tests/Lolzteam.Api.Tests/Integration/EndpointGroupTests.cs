using System.Net;
using System.Text;
using System.Text.Json;
using FluentAssertions;
using Lolzteam.Api.Runtime;
using Xunit;

namespace Lolzteam.Api.Tests.Integration;

/// <summary>
/// Simulates per-endpoint-group scenarios that the generated ForumClient / MarketClient would exercise.
/// Tests are written against <see cref="LolzteamHttpClient"/> directly so they remain independent of
/// the OpenAPI-generated code and run without the schemas present.
/// </summary>
public sealed class EndpointGroupTests
{
    private static LolzteamHttpClient Build(Func<HttpRequestMessage, Task<HttpResponseMessage>> handler)
    {
        var stub = new StubHandlerEndpoint(handler);
        var httpClient = new HttpClient(stub);
        var config = new ClientConfig
        {
            Token = "group-test-token",
            BaseUrl = "http://api.test",
        };

        return new LolzteamHttpClient(config.WithHttpClient(httpClient));
    }

    private static HttpResponseMessage Json(string json)
    {
        return new(HttpStatusCode.OK)
        {
            Content = new StringContent(json, Encoding.UTF8, "application/json"),
        };
    }

    [Fact]
    public async Task Forum_threads_GET_passes_query_params()
    {
        string? capturedUri = null;
        using var client = Build(req =>
        {
            capturedUri = req.RequestUri?.AbsoluteUri;
            return Task.FromResult(Json("{\"threads\":[]}"));
        });

        var query = JsonSerializer.SerializeToElement(new { page = 3, limit = 20 });
        await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/threads",
            Query = query,
        });

        capturedUri.Should().Contain("page=3").And.Contain("limit=20");
    }

    [Fact]
    public async Task Forum_post_CREATE_sends_json_body()
    {
        string? capturedBody = null;
        string? capturedContentType = null;
        using var client = Build(async req =>
        {
            capturedBody = await req.Content!.ReadAsStringAsync();
            capturedContentType = req.Content?.Headers.ContentType?.MediaType;
            return Json("{\"post_id\":100}");
        });

        var body = JsonSerializer.SerializeToElement(new { thread_id = 5, message = "Hello" });
        await client.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/posts",
            Body = body,
            BodyEncoding = BodyEncoding.Json,
        });

        capturedContentType.Should().Be("application/json");
        capturedBody.Should().Contain("thread_id");
        capturedBody.Should().Contain("Hello");
    }

    [Fact]
    public async Task Market_item_GET_returns_parsed_element()
    {
        using var client = Build(_ => Task.FromResult(Json("{\"item_id\":999,\"price\":150.5}")));
        var result = await client.RequestAsync(new RequestOptions
        {
            Method = "GET",
            Path = "/market/items/999",
        });

        result.GetProperty("item_id").GetInt64().Should().Be(999L);
        result.GetProperty("price").GetDouble().Should().BeApproximately(150.5, 0.001);
    }

    [Fact]
    public async Task Multipart_upload_sends_correct_content_type()
    {
        string? contentType = null;
        using var client = Build(req =>
        {
            contentType = req.Content?.Headers.ContentType?.MediaType;
            return Task.FromResult(Json("{\"uploaded\":true}"));
        });

        await client.RequestAsync(new RequestOptions
        {
            Method = "POST",
            Path = "/upload",
            Body = JsonSerializer.SerializeToElement(new { caption = "test" }),
            BodyEncoding = BodyEncoding.Multipart,
            ByteArrayFields = new Dictionary<string, byte[]>
            {
                ["file"] = "fake-file-data"u8.ToArray(),
            },
        });

        contentType.Should().Be("multipart/form-data");
    }

    [Fact]
    public async Task DELETE_request_passes_method_correctly()
    {
        string? capturedMethod = null;
        using var client = Build(req =>
        {
            capturedMethod = req.Method.Method;
            return Task.FromResult(Json("{\"deleted\":true}"));
        });

        await client.RequestAsync(new RequestOptions
        {
            Method = "DELETE",
            Path = "/posts/42",
        });

        capturedMethod.Should().Be("DELETE");
    }

    [Fact]
    public async Task PATCH_request_sends_form_body()
    {
        string? capturedBody = null;
        using var client = Build(async req =>
        {
            capturedBody = await req.Content!.ReadAsStringAsync();
            return Json("{\"updated\":true}");
        });

        var body = JsonSerializer.SerializeToElement(new { status = "active" });
        await client.RequestAsync(new RequestOptions
        {
            Method = "PATCH",
            Path = "/users/1",
            Body = body,
            BodyEncoding = BodyEncoding.Form,
        });

        capturedBody.Should().Contain("status=active");
    }
}

internal sealed class StubHandlerEndpoint : HttpMessageHandler
{
    private readonly Func<HttpRequestMessage, Task<HttpResponseMessage>> _fn;
    public StubHandlerEndpoint(Func<HttpRequestMessage, Task<HttpResponseMessage>> fn) => _fn = fn;
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct) => _fn(req);
}
