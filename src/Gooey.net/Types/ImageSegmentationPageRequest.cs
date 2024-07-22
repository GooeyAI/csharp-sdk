using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ImageSegmentationPageRequest
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

    [JsonPropertyName("selected_model")]
    public ImageSegmentationPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("mask_threshold")]
    public double? MaskThreshold { get; init; }

    [JsonPropertyName("rect_persepective_transform")]
    public bool? RectPersepectiveTransform { get; init; }

    [JsonPropertyName("reflection_opacity")]
    public double? ReflectionOpacity { get; init; }

    [JsonPropertyName("obj_scale")]
    public double? ObjScale { get; init; }

    [JsonPropertyName("obj_pos_x")]
    public double? ObjPosX { get; init; }

    [JsonPropertyName("obj_pos_y")]
    public double? ObjPosY { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
