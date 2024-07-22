using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record RunStart
{
    /// <summary>
    /// Unique ID for this run
    /// </summary>
    [JsonPropertyName("run_id")]
    public required string RunId { get; init; }

    /// <summary>
    /// Web URL for this run
    /// </summary>
    [JsonPropertyName("web_url")]
    public required string WebUrl { get; init; }

    /// <summary>
    /// Time when the run was created as ISO format
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// URL to check the status of the run. Also included in the `Location` header of the response.
    /// </summary>
    [JsonPropertyName("status_url")]
    public required string StatusUrl { get; init; }

    /// <summary>
    /// The run was started. Save the IDs for future requests.Use the `status_url` to check the status of the run and fetch the complete output.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
