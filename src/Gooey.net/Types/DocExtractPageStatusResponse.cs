using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record DocExtractPageStatusResponse
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
    /// Total run time in seconds
    /// </summary>
    [JsonPropertyName("run_time_sec")]
    public required int RunTimeSec { get; init; }

    /// <summary>
    /// Status of the run
    /// </summary>
    [JsonPropertyName("status")]
    public required RecipeRunState Status { get; init; }

    /// <summary>
    /// Details about the status of the run as a human readable string
    /// </summary>
    [JsonPropertyName("detail")]
    public required string Detail { get; init; }

    /// <summary>
    /// Output of the run. Only available if status is `"completed"`
    /// </summary>
    [JsonPropertyName("output")]
    public DocExtractPageOutput? Output { get; init; }
}
