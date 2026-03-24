using System.Text.Json;

namespace Lolzteam.Api.Runtime;

/// <summary>Encapsulates all parameters for a single API request.</summary>
public sealed class RequestOptions
{
    /// <summary>HTTP method (GET, POST, PUT, DELETE, PATCH).</summary>
    public required string Method { get; init; }

    /// <summary>URL path, e.g. <c>/forum/posts</c>.</summary>
    public required string Path { get; init; }

    /// <summary>Query-string parameters serialized as a JSON object.</summary>
    public JsonElement? Query { get; init; }

    /// <summary>Request body serialized as a JSON object.</summary>
    public JsonElement? Body { get; init; }

    /// <summary>How the body is encoded (form, JSON, multipart). Defaults to form.</summary>
    public BodyEncoding BodyEncoding { get; init; } = BodyEncoding.Form;

    /// <summary>Binary fields to upload via multipart (filename → bytes).</summary>
    public Dictionary<string, byte[]>? ByteArrayFields { get; init; }

    /// <summary>When true, the search-specific rate limiter is also applied.</summary>
    public bool IsSearch { get; init; }
}

/// <summary>How the request body is encoded.</summary>
public enum BodyEncoding
{
    /// <summary>application/x-www-form-urlencoded (default).</summary>
    Form,
    /// <summary>application/json.</summary>
    Json,
    /// <summary>multipart/form-data.</summary>
    Multipart,
}
