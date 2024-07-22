using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record StreamError
{
    /// <summary>
    /// Details about the error
    /// </summary>
    [JsonPropertyName("detail")]
    public required string Detail { get; init; }

    /// <summary>
    /// An error occurred. The stream has ended.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
