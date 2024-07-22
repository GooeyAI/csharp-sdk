using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record LipsyncPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("input_face")]
    public string? InputFace { get; init; }

    [JsonPropertyName("face_padding_top")]
    public int? FacePaddingTop { get; init; }

    [JsonPropertyName("face_padding_bottom")]
    public int? FacePaddingBottom { get; init; }

    [JsonPropertyName("face_padding_left")]
    public int? FacePaddingLeft { get; init; }

    [JsonPropertyName("face_padding_right")]
    public int? FacePaddingRight { get; init; }

    [JsonPropertyName("sadtalker_settings")]
    public SadTalkerSettings? SadtalkerSettings { get; init; }

    [JsonPropertyName("selected_model")]
    public LipsyncPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("input_audio")]
    public string? InputAudio { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
