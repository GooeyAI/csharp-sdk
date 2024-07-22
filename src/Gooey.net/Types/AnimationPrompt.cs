using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record AnimationPrompt
{
    [JsonPropertyName("frame")]
    public required string Frame { get; init; }

    [JsonPropertyName("prompt")]
    public required string Prompt { get; init; }
}
