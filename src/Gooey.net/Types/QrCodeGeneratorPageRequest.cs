using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record QrCodeGeneratorPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("qr_code_data")]
    public string? QrCodeData { get; init; }

    [JsonPropertyName("qr_code_input_image")]
    public string? QrCodeInputImage { get; init; }

    [JsonPropertyName("qr_code_vcard")]
    public Vcard? QrCodeVcard { get; init; }

    [JsonPropertyName("qr_code_file")]
    public string? QrCodeFile { get; init; }

    [JsonPropertyName("use_url_shortener")]
    public bool? UseUrlShortener { get; init; }

    [JsonPropertyName("text_prompt")]
    public required string TextPrompt { get; init; }

    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; init; }

    [JsonPropertyName("image_prompt")]
    public string? ImagePrompt { get; init; }

    [JsonPropertyName("image_prompt_controlnet_models")]
    public IEnumerable<QrCodeGeneratorPageRequestImagePromptControlnetModelsItem>? ImagePromptControlnetModels { get; init; }

    [JsonPropertyName("image_prompt_strength")]
    public double? ImagePromptStrength { get; init; }

    [JsonPropertyName("image_prompt_scale")]
    public double? ImagePromptScale { get; init; }

    [JsonPropertyName("image_prompt_pos_x")]
    public double? ImagePromptPosX { get; init; }

    [JsonPropertyName("image_prompt_pos_y")]
    public double? ImagePromptPosY { get; init; }

    [JsonPropertyName("selected_model")]
    public QrCodeGeneratorPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("selected_controlnet_model")]
    public IEnumerable<QrCodeGeneratorPageRequestSelectedControlnetModelItem>? SelectedControlnetModel { get; init; }

    [JsonPropertyName("output_width")]
    public int? OutputWidth { get; init; }

    [JsonPropertyName("output_height")]
    public int? OutputHeight { get; init; }

    [JsonPropertyName("guidance_scale")]
    public double? GuidanceScale { get; init; }

    [JsonPropertyName("controlnet_conditioning_scale")]
    public IEnumerable<double>? ControlnetConditioningScale { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public int? Quality { get; init; }

    [JsonPropertyName("scheduler")]
    public Scheduler? Scheduler { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("obj_scale")]
    public double? ObjScale { get; init; }

    [JsonPropertyName("obj_pos_x")]
    public double? ObjPosX { get; init; }

    [JsonPropertyName("obj_pos_y")]
    public double? ObjPosY { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
