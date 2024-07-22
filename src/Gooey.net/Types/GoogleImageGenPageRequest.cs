using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record GoogleImageGenPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("serp_search_location")]
    public SerpSearchLocation? SerpSearchLocation { get; init; }

    /// <summary>
    /// DEPRECATED: use `serp_search_location` instead
    /// </summary>
    [JsonPropertyName("scaleserp_locations")]
    public IEnumerable<string>? ScaleserpLocations { get; init; }

    [JsonPropertyName("search_query")]
    public required string SearchQuery { get; init; }

    [JsonPropertyName("text_prompt")]
    public required string TextPrompt { get; init; }

    [JsonPropertyName("selected_model")]
    public GoogleImageGenPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public int? Quality { get; init; }

    [JsonPropertyName("guidance_scale")]
    public double? GuidanceScale { get; init; }

    [JsonPropertyName("prompt_strength")]
    public double? PromptStrength { get; init; }

    [JsonPropertyName("sd_2_upscaling")]
    public bool? Sd2Upscaling { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("image_guidance_scale")]
    public double? ImageGuidanceScale { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
