using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record DocSummaryPageRequest
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

    [JsonPropertyName("task_instructions")]
    public string? TaskInstructions { get; init; }

    [JsonPropertyName("merge_instructions")]
    public string? MergeInstructions { get; init; }

    [JsonPropertyName("selected_model")]
    public DocSummaryPageRequestSelectedModel? SelectedModel { get; init; }

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

    [JsonPropertyName("chain_type")]
    public string? ChainType { get; init; }

    [JsonPropertyName("selected_asr_model")]
    public DocSummaryPageRequestSelectedAsrModel? SelectedAsrModel { get; init; }

    [JsonPropertyName("google_translate_target")]
    public string? GoogleTranslateTarget { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
