using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record TextToSpeechPageOutput
{
    [JsonPropertyName("audio_url")]
    public required string AudioUrl { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
