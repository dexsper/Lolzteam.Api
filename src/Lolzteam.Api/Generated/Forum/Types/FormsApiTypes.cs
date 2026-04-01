// Auto-generated. Do not edit manually.
#nullable enable
#pragma warning disable CS1591, CA1707

using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lolzteam.Api.Generated.Forum;

public static class FormsApiTypes
{
	public sealed record FormsListParams
	{
		/// <summary>
		/// Page number of forms.
		/// </summary>
		[JsonPropertyName("page")]
		public long? Page { get; init; }
	}

	public sealed record FormsListResponse(
		[property: JsonPropertyName("forms")] List<FormsListResponseForms> Forms,
		[property: JsonPropertyName("formsPerPage")] long FormsPerPage,
		[property: JsonPropertyName("page")] long Page,
		[property: JsonPropertyName("totalForms")] long TotalForms,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static FormsListResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static FormsListResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			List<FormsListResponseForms> v0 = null!;
			long v1 = default;
			long v2 = default;
			long v3 = default;
			Resp_SystemInfo v4 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("forms"u8))
				{
					reader.Read();
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						var __lst = new List<FormsListResponseForms>();
						while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
						{
							var __item = FormsListResponseForms.ReadFromReader(ref reader);
							__lst.Add(__item);
						}
						v0 = __lst;
					}
				}
				else if (reader.ValueTextEquals("formsPerPage"u8))
				{
					reader.Read();
					v1 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("page"u8))
				{
					reader.Read();
					v2 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("totalForms"u8))
				{
					reader.Read();
					v3 = reader.GetInt64();
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v4 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new FormsListResponse(v0, v1, v2, v3, v4);
		}
	}

public sealed record FormsListResponseFormsFieldsFieldChoices(
	[property: JsonPropertyName("buy")] string Buy,
	[property: JsonPropertyName("sell")] string Sell
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static FormsListResponseFormsFieldsFieldChoices ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static FormsListResponseFormsFieldsFieldChoices ReadFromReader(ref Utf8JsonReader reader)
	{
		string v0 = null!;
		string v1 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("buy"u8))
			{
				reader.Read();
				v0 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("sell"u8))
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
		return new FormsListResponseFormsFieldsFieldChoices(v0, v1);
	}
}

public sealed record FormsListResponseFormsFields(
	[property: JsonPropertyName("field_id")] long FieldId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("fieldChoices")] FormsListResponseFormsFieldsFieldChoices FieldChoices,
	[property: JsonPropertyName("required")] long Required,
	[property: JsonPropertyName("max_length")] long MaxLength,
	[property: JsonPropertyName("default_value")] string DefaultValue
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static FormsListResponseFormsFields ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static FormsListResponseFormsFields ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		FormsListResponseFormsFieldsFieldChoices v2 = null!;
		long v3 = default;
		long v4 = default;
		string v5 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("field_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("fieldChoices"u8))
			{
				reader.Read();
				v2 = reader.TokenType == JsonTokenType.Null ? null! : FormsListResponseFormsFieldsFieldChoices.ReadFromReader(ref reader);
			}
			else if (reader.ValueTextEquals("required"u8))
			{
				reader.Read();
				v3 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("max_length"u8))
			{
				reader.Read();
				v4 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("default_value"u8))
			{
				reader.Read();
				v5 = reader.GetString()!;
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new FormsListResponseFormsFields(v0, v1, v2, v3, v4, v5);
	}
}

public sealed record FormsListResponseForms(
	[property: JsonPropertyName("form_id")] long FormId,
	[property: JsonPropertyName("title")] string Title,
	[property: JsonPropertyName("description")] string Description,
	[property: JsonPropertyName("fields")] List<FormsListResponseFormsFields> Fields
)
{

	/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
	public static FormsListResponseForms ReadFrom(ReadOnlyMemory<byte> json)
	{
		var reader = new Utf8JsonReader(json.Span);
		reader.Read(); // advance to StartObject
		return ReadFromReader(ref reader);
	}

	internal static FormsListResponseForms ReadFromReader(ref Utf8JsonReader reader)
	{
		long v0 = default;
		string v1 = null!;
		string v2 = null!;
		List<FormsListResponseFormsFields> v3 = null!;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName) continue;

			if (reader.ValueTextEquals("form_id"u8))
			{
				reader.Read();
				v0 = reader.GetInt64();
			}
			else if (reader.ValueTextEquals("title"u8))
			{
				reader.Read();
				v1 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("description"u8))
			{
				reader.Read();
				v2 = reader.GetString()!;
			}
			else if (reader.ValueTextEquals("fields"u8))
			{
				reader.Read();
				if (reader.TokenType == JsonTokenType.StartArray)
				{
					var __lst = new List<FormsListResponseFormsFields>();
					while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
					{
						var __item = FormsListResponseFormsFields.ReadFromReader(ref reader);
						__lst.Add(__item);
					}
					v3 = __lst;
				}
			}
			else
			{
				reader.Read();
				reader.Skip();
			}
		}
		return new FormsListResponseForms(v0, v1, v2, v3);
	}
}

	#if NET7_0_OR_GREATER
	[JsonDerivedType(typeof(FormsCreateBodyP2PTrade), "1")]
	[JsonDerivedType(typeof(FormsCreateBodyComplaint), "3")]
	#endif
	public abstract record FormsCreateBody;

	public sealed record FormsCreateBodyP2PTrade : FormsCreateBody
	{
		[JsonPropertyName("form_id")]
		public long FormId => 1;
		[JsonPropertyName("fields")]
		public required JsonElement Fields { get; init; }
	}

	public sealed record FormsCreateBodyComplaint : FormsCreateBody
	{
		[JsonPropertyName("form_id")]
		public long FormId => 3;
		[JsonPropertyName("fields")]
		public required JsonElement Fields { get; init; }
	}

	public sealed record FormsCreateResponse(
		[property: JsonPropertyName("message")] string Message,
		[property: JsonPropertyName("content")] Resp_ThreadModel Content,
		[property: JsonPropertyName("system_info")] Resp_SystemInfo SystemInfo
	)
	{

		/// <summary>Deserialize from raw UTF-8 JSON bytes — no JsonDocument, no reflection.</summary>
		public static FormsCreateResponse ReadFrom(ReadOnlyMemory<byte> json)
		{
			var reader = new Utf8JsonReader(json.Span);
			reader.Read(); // advance to StartObject
			return ReadFromReader(ref reader);
		}

		internal static FormsCreateResponse ReadFromReader(ref Utf8JsonReader reader)
		{
			string v0 = null!;
			Resp_ThreadModel v1 = null!;
			Resp_SystemInfo v2 = null!;
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType != JsonTokenType.PropertyName) continue;

				if (reader.ValueTextEquals("message"u8))
				{
					reader.Read();
					v0 = reader.GetString()!;
				}
				else if (reader.ValueTextEquals("content"u8))
				{
					reader.Read();
					v1 = reader.TokenType == JsonTokenType.Null ? null! : Resp_ThreadModel.ReadFromReader(ref reader);
				}
				else if (reader.ValueTextEquals("system_info"u8))
				{
					reader.Read();
					v2 = reader.TokenType == JsonTokenType.Null ? null! : Resp_SystemInfo.ReadFromReader(ref reader);
				}
				else
				{
					reader.Read();
					reader.Skip();
				}
			}
			return new FormsCreateResponse(v0, v1, v2);
		}
	}

}
