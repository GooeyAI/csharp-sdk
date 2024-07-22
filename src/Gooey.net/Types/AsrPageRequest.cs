using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record AsrPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("documents")]
    public IEnumerable<string> Documents { get; init; } = new List<string>();

    [JsonPropertyName("selected_model")]
    public AsrPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("language")]
    public string? Language { get; init; }

    [JsonPropertyName("translation_model")]
    public AsrPageRequestTranslationModel? TranslationModel { get; init; }

    [JsonPropertyName("output_format")]
    public AsrPageRequestOutputFormat? OutputFormat { get; init; }

    /// <summary>
    /// use `translation_model` & `translation_target` instead.
    /// </summary>
    [JsonPropertyName("google_translate_target")]
    public string? GoogleTranslateTarget { get; init; }

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
