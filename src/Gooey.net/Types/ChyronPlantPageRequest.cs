using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ChyronPlantPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("midi_notes")]
    public required string MidiNotes { get; init; }

    [JsonPropertyName("midi_notes_prompt")]
    public string? MidiNotesPrompt { get; init; }

    [JsonPropertyName("chyron_prompt")]
    public string? ChyronPrompt { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
