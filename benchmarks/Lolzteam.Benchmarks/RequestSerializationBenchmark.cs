#pragma warning disable CA1822 // BenchmarkDotNet requires instance (non-static) benchmark methods.
using System.Text.Json;
using System.Text.Json.Serialization;
using BenchmarkDotNet.Attributes;
using Lolzteam.Api.Generated.Market;

namespace Lolzteam.Benchmarks;

/// <summary>
/// Reflection-based <c>SerializeToElement</c> (current codegen) vs. source-generated <see cref="JsonSerializerContext"/>.
/// </summary>
[MemoryDiagnoser]
[Config(typeof(BenchmarkConfig))]
public class RequestSerializationBenchmark
{
    private static readonly ListApiTypes.ListUserParams Params = new()
    {
        UserId = 12345,
        CategoryId = CategoryId.V1,
        Page = 2,
        Show = Show.Active,
        Title = "test account",
        Pmin = 10.5,
        Pmax = 500.0,
        Login = "seller_login",
        Origin = [Origin.Brute, Origin.Personal, Origin.Resale],
        NotOrigin = [NotOrigin.Dummy],
        OrderBy = OrderBy.PriceToUp,
        Sb = true,
        SbByMe = false,
        Username = "buyer123",
        PublishedStartDate = "2024-01-01",
        PublishedEndDate = "2024-12-31",
        FilterByPublishedDate = true,
    };

    /// <summary>Current codegen output: reflection-based contract resolution.</summary>
    [Benchmark(Baseline = true, Description = "Reflection: SerializeToElement(@params)")]
    public JsonElement Reflection_SerializeToElement() => JsonSerializer.SerializeToElement(Params);

    /// <summary>Proposed: source-generated JsonTypeInfo passed explicitly — zero reflection.</summary>
    [Benchmark(Description = "SourceGen: SerializeToElement(@params, JsonTypeInfo<T>)")]
    public JsonElement SourceGen_SerializeToElement() => JsonSerializer.SerializeToElement(
        Params,
        MarketJsonContext.Default.ListUserParams
    );
}

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata)]
[JsonSerializable(typeof(ListApiTypes.ListUserParams))]
internal sealed partial class MarketJsonContext : JsonSerializerContext;
