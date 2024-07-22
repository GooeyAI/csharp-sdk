using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record Text2AudioPageOutput
{
    [JsonPropertyName("output_audios")]
    public Dictionary<string, IEnumerable<string>> OutputAudios { get; init; } =
        new Dictionary<string, IEnumerable<string>>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
