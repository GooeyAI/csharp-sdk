using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record LipsyncTtsPageOutput
{
    [JsonPropertyName("audio_url")]
    public string? AudioUrl { get; init; }

    [JsonPropertyName("output_video")]
    public required string OutputVideo { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
