using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record LipsyncTtsPageRequest
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

    [JsonPropertyName("tts_provider")]
    public LipsyncTtsPageRequestTtsProvider? TtsProvider { get; init; }

    [JsonPropertyName("uberduck_voice_name")]
    public string? UberduckVoiceName { get; init; }

    [JsonPropertyName("uberduck_speaking_rate")]
    public double? UberduckSpeakingRate { get; init; }

    [JsonPropertyName("google_voice_name")]
    public string? GoogleVoiceName { get; init; }

    [JsonPropertyName("google_speaking_rate")]
    public double? GoogleSpeakingRate { get; init; }

    [JsonPropertyName("google_pitch")]
    public double? GooglePitch { get; init; }

    [JsonPropertyName("bark_history_prompt")]
    public string? BarkHistoryPrompt { get; init; }

    /// <summary>
    /// Use `elevenlabs_voice_id` instead
    /// </summary>
    [JsonPropertyName("elevenlabs_voice_name")]
    public string? ElevenlabsVoiceName { get; init; }

    [JsonPropertyName("elevenlabs_api_key")]
    public string? ElevenlabsApiKey { get; init; }

    [JsonPropertyName("elevenlabs_voice_id")]
    public string? ElevenlabsVoiceId { get; init; }

    [JsonPropertyName("elevenlabs_model")]
    public string? ElevenlabsModel { get; init; }

    [JsonPropertyName("elevenlabs_stability")]
    public double? ElevenlabsStability { get; init; }

    [JsonPropertyName("elevenlabs_similarity_boost")]
    public double? ElevenlabsSimilarityBoost { get; init; }

    [JsonPropertyName("elevenlabs_style")]
    public double? ElevenlabsStyle { get; init; }

    [JsonPropertyName("elevenlabs_speaker_boost")]
    public bool? ElevenlabsSpeakerBoost { get; init; }

    [JsonPropertyName("azure_voice_name")]
    public string? AzureVoiceName { get; init; }

    [JsonPropertyName("openai_voice_name")]
    public LipsyncTtsPageRequestOpenaiVoiceName? OpenaiVoiceName { get; init; }

    [JsonPropertyName("openai_tts_model")]
    public LipsyncTtsPageRequestOpenaiTtsModel? OpenaiTtsModel { get; init; }

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
    public LipsyncTtsPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
