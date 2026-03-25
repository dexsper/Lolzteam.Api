// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class BatchApiTypes
{
	public sealed record BatchExecuteResponse(
		[property: JsonPropertyName("jobs")] BatchExecuteResponseJobs Jobs
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static BatchExecuteResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static BatchExecuteResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			BatchExecuteResponseJobs v0 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("jobs"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : BatchExecuteResponseJobs.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new BatchExecuteResponse(v0);
		}
	}

public sealed record BatchExecuteResponseJobs(
	[property: JsonPropertyName("job_id")] JsonElement JobId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static BatchExecuteResponseJobs ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static BatchExecuteResponseJobs ReadFromReader(ref Utf8JsonReader reader)
	{
		JsonElement v0 = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("job_id"u8))
			{
				reader.Read();
				v0 = JsonDocument.ParseValue(ref reader).RootElement.Clone();
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new BatchExecuteResponseJobs(v0);
	}
}

}
