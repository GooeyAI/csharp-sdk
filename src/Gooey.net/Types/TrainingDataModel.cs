using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record TrainingDataModel
{
    [JsonPropertyName("prompt")]
    public required string Prompt { get; init; }

    [JsonPropertyName("completion")]
    public required string Completion { get; init; }
}
