using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record FailedResponseDetail
{
    /// <summary>
    /// Unique ID for this run
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Web URL for this run
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    /// <summary>
    /// Time when the run was created as ISO format
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// Error message if the run failed
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; init; }
}
