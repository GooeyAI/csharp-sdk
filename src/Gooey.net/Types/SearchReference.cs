using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record SearchReference
{
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("snippet")]
    public required string Snippet { get; init; }

    [JsonPropertyName("score")]
    public required double Score { get; init; }
}
