using Lolzteam.Api.Generated.Forum;
using Lolzteam.Api.Runtime;

var config = new ClientConfig
{
    Token   = "your-bearer-token",
    BaseUrl = "https://prod-api.lolz.live",
};

using var forum = new ForumClient(config);

var thread = await forum.Threads.GetAsync(12345);
Console.WriteLine(thread.Thread.ThreadTitle);

var list = await forum.Threads.ListAsync(new() { ForumId = 7 });
foreach (var t in list.Threads)
    Console.WriteLine($"{t.ThreadId}: {t.ThreadTitle}");
