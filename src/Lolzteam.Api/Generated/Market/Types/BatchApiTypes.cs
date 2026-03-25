// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Market;

public static class BatchApiTypes
{
	public sealed record BatchBatchResponse(
		[property: JsonPropertyName("jobs")] BatchBatchResponseJobs Jobs,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo? SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static BatchBatchResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static BatchBatchResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			BatchBatchResponseJobs v0 = null!;
			Resp_SystemInfo v1 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("jobs"u8))
				{
					reader.Read();
					v0 = reader.TokenType == JsonTokenType.Null ? null! : BatchBatchResponseJobs.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new BatchBatchResponse(v0, v1);
		}
	}

public sealed record BatchBatchResponseJobsJobId(
	[property: JsonPropertyName("_job_result")] string? JobResult,
	[property: JsonPropertyName("_job_error")] string? JobError
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static BatchBatchResponseJobsJobId ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static BatchBatchResponseJobsJobId ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("_job_result"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("_job_error"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new BatchBatchResponseJobsJobId(v0, v1);
	}
}

public sealed record BatchBatchResponseJobs(
	[property: JsonPropertyName("job_id")] BatchBatchResponseJobsJobId JobId
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static BatchBatchResponseJobs ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static BatchBatchResponseJobs ReadFromReader(ref Utf8JsonReader reader)
	{
		BatchBatchResponseJobsJobId v0 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("job_id"u8))
			{
				reader.Read();
				v0 = reader.TokenType == JsonTokenType.Null ? null! : BatchBatchResponseJobsJobId.ReadFromReader(ref reader);
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new BatchBatchResponseJobs(v0);
	}
}

}
