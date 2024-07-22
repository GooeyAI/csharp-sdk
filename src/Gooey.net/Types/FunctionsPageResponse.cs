using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record FunctionsPageResponse
{
    /// <summary>
    /// Unique ID for this run
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Web URL for this run
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// Time when the run was created as ISO format
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// Output of the run
    /// </summary>
    [JsonPropertyName("output")]
    public required FunctionsPageOutput Output { get; init; }
}
