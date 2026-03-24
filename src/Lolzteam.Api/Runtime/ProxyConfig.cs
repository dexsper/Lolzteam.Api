namespace Lolzteam.Api.Runtime;

/// <summary>Proxy configuration. Supports http://, https://, and socks5:// (net6+ only for SOCKS5).</summary>
/// <param name="Url">Full proxy URL, e.g. http://user:pass@proxy:8080 or socks5://proxy:1080.</param>
public sealed record ProxyConfig(string Url);
