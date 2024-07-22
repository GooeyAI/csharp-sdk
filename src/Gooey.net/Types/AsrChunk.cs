using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record AsrChunk
{
    [JsonPropertyName("timestamp")]
    public IEnumerable<object> Timestamp { get; init; } = new List<object>();

    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("speaker")]
    public required int Speaker { get; init; }
}
