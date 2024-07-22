using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record AsrOutputJson
{
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    [JsonPropertyName("chunks")]
    public IEnumerable<AsrChunk>? Chunks { get; init; }
}
