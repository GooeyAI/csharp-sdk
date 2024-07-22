using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record EvalPrompt
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("prompt")]
    public required string Prompt { get; init; }
}
