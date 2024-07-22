using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record DocExtractPageRequest
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

    [JsonPropertyName("sheet_url")]
    public string? SheetUrl { get; init; }

    [JsonPropertyName("selected_asr_model")]
    public DocExtractPageRequestSelectedAsrModel? SelectedAsrModel { get; init; }

    [JsonPropertyName("google_translate_target")]
    public string? GoogleTranslateTarget { get; init; }

    /// <summary>
    /// Provide a glossary to customize translation and improve accuracy of domain-specific terms.
    /// If not specified or invalid, no glossary will be used. Read about the expected format [here](https://docs.google.com/document/d/1TwzAvFmFYekloRKql2PXNPIyqCbsHRL8ZtnWkzAYrh8/edit?usp=sharing).
    /// </summary>
    [JsonPropertyName("glossary_document")]
    public string? GlossaryDocument { get; init; }

    [JsonPropertyName("task_instructions")]
    public string? TaskInstructions { get; init; }

    [JsonPropertyName("selected_model")]
    public DocExtractPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("avoid_repetition")]
    public bool? AvoidRepetition { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public double? Quality { get; init; }

    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; init; }

    [JsonPropertyName("sampling_temperature")]
    public double? SamplingTemperature { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
