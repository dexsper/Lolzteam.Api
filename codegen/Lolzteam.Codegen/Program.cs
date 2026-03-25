using System.Text.Json.Nodes;
using Lolzteam.Codegen;

var root = Directory.GetCurrentDirectory();
while (!Directory.Exists(Path.Combine(root, "schemas")) && root != Path.GetPathRoot(root))
    root = Path.GetDirectoryName(root)!;

if (!Directory.Exists(Path.Combine(root, "schemas")))
{
    Console.Error.WriteLine("ERROR: Could not find schemas/ directory. Run from the repo root or a subdirectory.");
    return 1;
}

Console.WriteLine($"Repo root: {root}");

var apis = new[]
{
    new ApiConfig(
        SchemaPath: Path.Combine(root, "schemas", "forum.json"),
        OutputDir: Path.Combine(root, "src", "Lolzteam.Api", "Generated", "Forum"),
        ClientName: "ForumClient",
        InterfaceName: "IForumClient",
        DefaultBaseUrl: "https://prod-api.lolz.live",
        DefaultRateLimit: 300,
        SubPackage: "Forum",
        DefaultSearchRateLimit: 0
    ),
    new ApiConfig(
        SchemaPath: Path.Combine(root, "schemas", "market.json"),
        OutputDir: Path.Combine(root, "src", "Lolzteam.Api", "Generated", "Market"),
        ClientName: "MarketClient",
        InterfaceName: "IMarketClient",
        DefaultBaseUrl: "https://prod-api.lzt.market",
        DefaultRateLimit: 120,
        SubPackage: "Market",
        DefaultSearchRateLimit: 20
    ),
};

foreach (var config in apis)
{
    Console.WriteLine($"\n=== Generating {config.ClientName} ===");
    var rawSpec = JsonNode.Parse(File.ReadAllText(config.SchemaPath))!;
    var result = Parser.ParseSpec(rawSpec);

    var typesDir = Path.Combine(config.OutputDir, "Types");
    Directory.CreateDirectory(config.OutputDir);
    Directory.CreateDirectory(typesDir);

    foreach (var file in Directory.GetFiles(config.OutputDir, "*.cs"))
    {
        File.Delete(file);
        Console.WriteLine($"  Deleted {Path.GetFileName(file)}");
    }
    foreach (var file in Directory.GetFiles(typesDir, "*.cs"))
    {
        File.Delete(file);
        Console.WriteLine($"  Deleted Types/{Path.GetFileName(file)}");
    }

    var (enumDefs, paramToEnumType) = EnumCollector.Collect(result.Groups);
    Console.WriteLine($"  Enums: {enumDefs.Count} types");

    var typeFiles = Emitter.EmitCSharpTypeFiles(
        result.Groups, config.SubPackage, result.ComponentSchemas, rawSpec, enumDefs, paramToEnumType
    );

    foreach (var (fileName, content) in typeFiles)
    {
        File.WriteAllText(Path.Combine(typesDir, fileName), content);
        Console.WriteLine($"  Types/{fileName}");
    }

    var (clientContent, interfaceContent) = Emitter.EmitCSharpClientFile(
        result.Groups, config.ClientName, config.InterfaceName,
        config.DefaultBaseUrl, config.DefaultRateLimit,
        config.SubPackage, config.DefaultSearchRateLimit
    );

    File.WriteAllText(Path.Combine(config.OutputDir, $"{config.ClientName}.cs"), clientContent);
    Console.WriteLine($"  {config.ClientName}.cs");

    File.WriteAllText(Path.Combine(config.OutputDir, $"{config.InterfaceName}.cs"), interfaceContent);
    Console.WriteLine($"  {config.InterfaceName}.cs");

    var totalOps = result.Groups.Sum(g => g.Methods.Count);
    Console.WriteLine($"  Done: {result.Groups.Count} groups, {totalOps} operations");
}

Console.WriteLine("\nCode generation complete.");
return 0;
