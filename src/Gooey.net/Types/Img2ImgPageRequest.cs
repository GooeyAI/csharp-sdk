using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public record Img2ImgPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("input_image")]
    public required string InputImage { get; init; }

    [JsonPropertyName("text_prompt")]
    public string? TextPrompt { get; init; }

    [JsonPropertyName("selected_model")]
    public Img2ImgPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("selected_controlnet_model")]
    [JsonConverter(
        typeof(OneOfSerializer<
            OneOf<
                IEnumerable<Img2ImgPageRequestSelectedControlnetModelItem>,
                string,
                string,
                string,
                string,
                string,
                string,
                string,
                string,
                string,
                string,
                string
            >
        >)
    )]
    public OneOf<
        IEnumerable<Img2ImgPageRequestSelectedControlnetModelItem>,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string,
        string
    >? SelectedControlnetModel { get; init; }

    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public int? Quality { get; init; }

    [JsonPropertyName("output_width")]
    public int? OutputWidth { get; init; }

    [JsonPropertyName("output_height")]
    public int? OutputHeight { get; init; }

    [JsonPropertyName("guidance_scale")]
    public double? GuidanceScale { get; init; }

    [JsonPropertyName("prompt_strength")]
    public double? PromptStrength { get; init; }

    [JsonPropertyName("controlnet_conditioning_scale")]
    public IEnumerable<double>? ControlnetConditioningScale { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("image_guidance_scale")]
    public double? ImageGuidanceScale { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
