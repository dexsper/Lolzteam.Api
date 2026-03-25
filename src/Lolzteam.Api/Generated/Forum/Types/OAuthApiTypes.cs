// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class OAuthApiTypes
{
	#if NET7_0_OR_GREATER
	[JsonDerivedType(typeof(OAuthTokenBodyClientCredentials), "client_credentials")]
	[JsonDerivedType(typeof(OAuthTokenBodyAuthorizationCode), "authorization_code")]
	[JsonDerivedType(typeof(OAuthTokenBodyRefreshToken), "refresh_token")]
	[JsonDerivedType(typeof(OAuthTokenBodyPassword), "password")]
	#endif
	public abstract record OAuthTokenBody;

	public sealed record OAuthTokenBodyClientCredentials : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "client_credentials";
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
		[JsonPropertyName("scope")]
		public required JsonElement Scope { get; init; }
	}

	public sealed record OAuthTokenBodyAuthorizationCode : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "authorization_code";
		[JsonPropertyName("code")]
		public required string Code { get; init; }
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
		[JsonPropertyName("redirect_uri")]
		public required string RedirectUri { get; init; }
		[JsonPropertyName("scope")]
		public required JsonElement Scope { get; init; }
	}

	public sealed record OAuthTokenBodyRefreshToken : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "refresh_token";
		[JsonPropertyName("refresh_token")]
		public required string RefreshToken { get; init; }
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
	}

	public sealed record OAuthTokenBodyPassword : OAuthTokenBody
	{
		[JsonPropertyName("grant_type")]
		public string GrantType => "password";
		[JsonPropertyName("username")]
		public required string Username { get; init; }
		[JsonPropertyName("password")]
		public required string Password { get; init; }
		[JsonPropertyName("client_id")]
		public required string ClientId { get; init; }
		[JsonPropertyName("client_secret")]
		public required string ClientSecret { get; init; }
		[JsonPropertyName("scope")]
		public required JsonElement Scope { get; init; }
	}

	public sealed record OAuthTokenResponse(
		[property: JsonPropertyName("access_token")] string AccessToken,
		[property: JsonPropertyName("token_type")] string TokenType,
		[property: JsonPropertyName("expires_in")] long ExpiresIn,
		[property: JsonPropertyName("refresh_token")] string? RefreshToken,
		[property: JsonPropertyName("scope")] string? Scope
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static OAuthTokenResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static OAuthTokenResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			string v1 = null!;
			long v2 = default;
			string v3 = null!;
			string v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("access_token"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("token_type"u8))
				{
					reader.Read();
					v1 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("expires_in"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("refresh_token"u8))
				{
					reader.Read();
					v3 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("scope"u8))
				{
					reader.Read();
					v4 = reader.GetString()!;
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new OAuthTokenResponse(v0, v1, v2, v3, v4);
		}
	}

}
