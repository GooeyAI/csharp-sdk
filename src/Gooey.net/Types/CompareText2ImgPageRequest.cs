using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record CompareText2ImgPageRequest
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

    [JsonPropertyName("output_width")]
    public int? OutputWidth { get; init; }

    [JsonPropertyName("output_height")]
    public int? OutputHeight { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public int? Quality { get; init; }

    [JsonPropertyName("dall_e_3_quality")]
    public string? DallE3Quality { get; init; }

    [JsonPropertyName("dall_e_3_style")]
    public string? DallE3Style { get; init; }

    [JsonPropertyName("guidance_scale")]
    public double? GuidanceScale { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("sd_2_upscaling")]
    public bool? Sd2Upscaling { get; init; }

    [JsonPropertyName("selected_models")]
    public IEnumerable<CompareText2ImgPageRequestSelectedModelsItem>? SelectedModels { get; init; }

    [JsonPropertyName("scheduler")]
    public Scheduler? Scheduler { get; init; }

    [JsonPropertyName("edit_instruction")]
    public string? EditInstruction { get; init; }

    [JsonPropertyName("image_guidance_scale")]
    public double? ImageGuidanceScale { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
