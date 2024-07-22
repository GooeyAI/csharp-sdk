using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ChyronPlantPageOutput
{
    [JsonPropertyName("midi_translation")]
    public required string MidiTranslation { get; init; }

    [JsonPropertyName("chyron_output")]
    public required string ChyronOutput { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
