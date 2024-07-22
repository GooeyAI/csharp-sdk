using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record MessagePart
{
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

    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("audio")]
    public string? Audio { get; init; }

    [JsonPropertyName("video")]
    public string? Video { get; init; }

    [JsonPropertyName("buttons")]
    public IEnumerable<ReplyButton>? Buttons { get; init; }

    [JsonPropertyName("documents")]
    public IEnumerable<string>? Documents { get; init; }

    /// <summary>
    /// The partial outputs from the bot will be streamed in parts. Use this to update the user interface iteratively.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
