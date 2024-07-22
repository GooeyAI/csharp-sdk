using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record TranslationPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("texts")]
    public IEnumerable<string>? Texts { get; init; }

    [JsonPropertyName("selected_model")]
    public TranslationPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("translation_source")]
    public string? TranslationSource { get; init; }

    [JsonPropertyName("translation_target")]
    public string? TranslationTarget { get; init; }

    /// <summary>
    /// Provide a glossary to customize translation and improve accuracy of domain-specific terms.
    /// If not specified or invalid, no glossary will be used. Read about the expected format [here](https://docs.google.com/document/d/1TwzAvFmFYekloRKql2PXNPIyqCbsHRL8ZtnWkzAYrh8/edit?usp=sharing).
    /// </summary>
    [JsonPropertyName("glossary_document")]
    public string? GlossaryDocument { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
