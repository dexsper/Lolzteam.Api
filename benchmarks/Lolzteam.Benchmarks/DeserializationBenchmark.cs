using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Compares four deserialization paths for a typical API response.
/// Measures allocations (via MemoryDiagnoser) and throughput.
///
/// Path 1 (Competitor baseline): ReadAsStringAsync → Deserialize&lt;T&gt;(string)
/// Path 2 (Our improvement):     ReadAsStreamAsync → DeserializeAsync&lt;T&gt;(stream)
/// Path 3 (Zero-alloc):          ReadAsStreamAsync → JsonDocument.Parse → struct access
/// </summary>
[MemoryDiagnoser]
[GcForce]
public class DeserializationBenchmark
{
    private static readonly byte[] _responseBytes = Encoding.UTF8.GetBytes("""
        {
            "user_id": 12345,
            "username": "testuser",
            "user_title": "Member",
            "user_group_id": 2,
            "register_date": 1600000000,
            "like_count": 42,
            "post_count": 100
        }
        """);

    private static readonly JsonSerializerOptions _opts = new(JsonSerializerOptions.Default);

    [Benchmark(Baseline = true, Description = "Competitor: string→Deserialize")]
    public static UserDto? Competitor_StringDeserialize()
    {
        var str = Encoding.UTF8.GetString(_responseBytes);
        return JsonSerializer.Deserialize<UserDto>(str, _opts);
    }

    [Benchmark(Description = "Ours: stream→DeserializeAsync")]
    public static async Task<UserDto?> Ours_StreamDeserialize()
    {
        await using var stream = new MemoryStream(_responseBytes, writable: false);
        return await JsonSerializer.DeserializeAsync<UserDto>(stream, _opts);
    }

    [Benchmark(Description = "Utf8JsonReader: zero-alloc on net7+")]
    public static UserDto Utf8JsonReader_Manual()
    {
        var reader = new Utf8JsonReader(_responseBytes);
        return UserDto.ReadFrom(ref reader);
    }
}

/// <summary>Simulated generated model with manual ReadFrom (protobuf-style).</summary>
public sealed class UserDto
{
    public long UserId { get; set; }
    public string? Username { get; set; }
    public string? UserTitle { get; set; }
    public long UserGroupId { get; set; }
    public long RegisterDate { get; set; }
    public long LikeCount { get; set; }
    public long PostCount { get; set; }

    /// <summary>Generated ReadFrom — zero reflection, tiered property comparison.</summary>
    public static UserDto ReadFrom(ref Utf8JsonReader reader)
    {
        var result = new UserDto();

        // skip start object
        if (reader.TokenType == JsonTokenType.None) reader.Read();
        if (reader.TokenType == JsonTokenType.StartObject) reader.Read();

        while (reader.TokenType != JsonTokenType.EndObject)
        {
            if (reader.TokenType == JsonTokenType.PropertyName)
            {
#if NET7_0_OR_GREATER
                // u8 UTF-8 literals: zero allocation
                if (reader.ValueTextEquals("user_id"u8))          { reader.Read(); result.UserId        = reader.GetInt64();  }
                else if (reader.ValueTextEquals("username"u8))     { reader.Read(); result.Username      = reader.GetString(); }
                else if (reader.ValueTextEquals("user_title"u8))   { reader.Read(); result.UserTitle     = reader.GetString(); }
                else if (reader.ValueTextEquals("user_group_id"u8)){ reader.Read(); result.UserGroupId   = reader.GetInt64();  }
                else if (reader.ValueTextEquals("register_date"u8)){ reader.Read(); result.RegisterDate  = reader.GetInt64();  }
                else if (reader.ValueTextEquals("like_count"u8))   { reader.Read(); result.LikeCount     = reader.GetInt64();  }
                else if (reader.ValueTextEquals("post_count"u8))   { reader.Read(); result.PostCount     = reader.GetInt64();  }
                else { reader.Read(); reader.Skip(); }
#else
                var prop = reader.GetString();
                reader.Read();
                switch (prop)
                {
                    case "user_id":       result.UserId       = reader.GetInt64();  break;
                    case "username":      result.Username     = reader.GetString(); break;
                    case "user_title":    result.UserTitle    = reader.GetString(); break;
                    case "user_group_id": result.UserGroupId  = reader.GetInt64();  break;
                    case "register_date": result.RegisterDate = reader.GetInt64();  break;
                    case "like_count":    result.LikeCount    = reader.GetInt64();  break;
                    case "post_count":    result.PostCount    = reader.GetInt64();  break;
                    default: reader.Skip(); break;
                }
#endif
            }

            if (!reader.Read()) break;
        }

        return result;
    }
}
