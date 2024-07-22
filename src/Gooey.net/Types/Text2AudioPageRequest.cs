using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record Text2AudioPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("text_prompt")]
    public required string TextPrompt { get; init; }

    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; init; }

    [JsonPropertyName("duration_sec")]
    public double? DurationSec { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public int? Quality { get; init; }

    [JsonPropertyName("guidance_scale")]
    public double? GuidanceScale { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("sd_2_upscaling")]
    public bool? Sd2Upscaling { get; init; }

    [JsonPropertyName("selected_models")]
    public IEnumerable<string>? SelectedModels { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
