using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record FaceInpaintingPageRequest
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
    public required string TextPrompt { get; init; }

    [JsonPropertyName("face_scale")]
    public double? FaceScale { get; init; }

    [JsonPropertyName("face_pos_x")]
    public double? FacePosX { get; init; }

    [JsonPropertyName("face_pos_y")]
    public double? FacePosY { get; init; }

    [JsonPropertyName("selected_model")]
    public FaceInpaintingPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("negative_prompt")]
    public string? NegativePrompt { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public int? Quality { get; init; }

    [JsonPropertyName("upscale_factor")]
    public double? UpscaleFactor { get; init; }

    [JsonPropertyName("output_width")]
    public int? OutputWidth { get; init; }

    [JsonPropertyName("output_height")]
    public int? OutputHeight { get; init; }

    [JsonPropertyName("guidance_scale")]
    public double? GuidanceScale { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
