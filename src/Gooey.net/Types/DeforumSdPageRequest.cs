using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record DeforumSdPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("animation_prompts")]
    public IEnumerable<AnimationPrompt> AnimationPrompts { get; init; } =
        new List<AnimationPrompt>();

    [JsonPropertyName("max_frames")]
    public int? MaxFrames { get; init; }

    [JsonPropertyName("selected_model")]
    public DeforumSdPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("animation_mode")]
    public string? AnimationMode { get; init; }

    [JsonPropertyName("zoom")]
    public string? Zoom { get; init; }

    [JsonPropertyName("translation_x")]
    public string? TranslationX { get; init; }

    [JsonPropertyName("translation_y")]
    public string? TranslationY { get; init; }

    [JsonPropertyName("rotation_3d_x")]
    public string? Rotation3DX { get; init; }

    [JsonPropertyName("rotation_3d_y")]
    public string? Rotation3DY { get; init; }

    [JsonPropertyName("rotation_3d_z")]
    public string? Rotation3DZ { get; init; }

    [JsonPropertyName("fps")]
    public int? Fps { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
