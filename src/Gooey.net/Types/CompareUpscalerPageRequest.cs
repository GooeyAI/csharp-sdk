using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record CompareUpscalerPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    /// <summary>
    /// Input Image
    /// </summary>
    [JsonPropertyName("input_image")]
    public string? InputImage { get; init; }

    /// <summary>
    /// Input Video
    /// </summary>
    [JsonPropertyName("input_video")]
    public string? InputVideo { get; init; }

    /// <summary>
    /// The final upsampling scale of the image
    /// </summary>
    [JsonPropertyName("scale")]
    public required int Scale { get; init; }

    [JsonPropertyName("selected_models")]
    public IEnumerable<CompareUpscalerPageRequestSelectedModelsItem>? SelectedModels { get; init; }

    [JsonPropertyName("selected_bg_model")]
    public string? SelectedBgModel { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
