using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record SmartGptPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("input_prompt")]
    public required string InputPrompt { get; init; }

    [JsonPropertyName("cot_prompt")]
    public string? CotPrompt { get; init; }

    [JsonPropertyName("reflexion_prompt")]
    public string? ReflexionPrompt { get; init; }

    [JsonPropertyName("dera_prompt")]
    public string? DeraPrompt { get; init; }

    [JsonPropertyName("selected_model")]
    public SmartGptPageRequestSelectedModel? SelectedModel { get; init; }

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
