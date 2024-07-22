using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record VideoBotsPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("input_prompt")]
    public string? InputPrompt { get; init; }

    [JsonPropertyName("input_audio")]
    public string? InputAudio { get; init; }

    [JsonPropertyName("input_images")]
    public IEnumerable<string>? InputImages { get; init; }

    [JsonPropertyName("input_documents")]
    public IEnumerable<string>? InputDocuments { get; init; }

    /// <summary>
    /// Select a workflow to extract text from documents and images.
    /// </summary>
    [JsonPropertyName("doc_extract_url")]
    public string? DocExtractUrl { get; init; }

    [JsonPropertyName("messages")]
    public IEnumerable<ConversationEntry>? Messages { get; init; }

    [JsonPropertyName("bot_script")]
    public string? BotScript { get; init; }

    [JsonPropertyName("selected_model")]
    public VideoBotsPageRequestSelectedModel? SelectedModel { get; init; }

    /// <summary>
    /// When your copilot users upload a photo or pdf, what kind of document are they mostly likely to upload? (via [Azure](https://learn.microsoft.com/en-us/azure/ai-services/document-intelligence/how-to-guides/use-sdk-rest-api?view=doc-intel-3.1.0&tabs=linux&pivots=programming-language-rest-api))
    /// </summary>
    [JsonPropertyName("document_model")]
    public string? DocumentModel { get; init; }

    [JsonPropertyName("avoid_repetition")]
    public bool? AvoidRepetition { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public double? Quality { get; init; }

    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; init; }

    [JsonPropertyName("sampling_temperature")]
    public double? SamplingTemperature { get; init; }

    [JsonPropertyName("task_instructions")]
    public string? TaskInstructions { get; init; }

    [JsonPropertyName("query_instructions")]
    public string? QueryInstructions { get; init; }

    [JsonPropertyName("keyword_instructions")]
    public string? KeywordInstructions { get; init; }

    [JsonPropertyName("documents")]
    public IEnumerable<string>? Documents { get; init; }

    [JsonPropertyName("max_references")]
    public int? MaxReferences { get; init; }

    [JsonPropertyName("max_context_words")]
    public int? MaxContextWords { get; init; }

    [JsonPropertyName("scroll_jump")]
    public int? ScrollJump { get; init; }

    [JsonPropertyName("embedding_model")]
    public VideoBotsPageRequestEmbeddingModel? EmbeddingModel { get; init; }

    /// <summary>
    /// Weightage for dense vs sparse embeddings. `0` for sparse, `1` for dense, `0.5` for equal weight.
    /// Generally speaking, dense embeddings excel at understanding the context of the query, whereas sparse vectors excel at keyword matches.
    /// </summary>
    [JsonPropertyName("dense_weight")]
    public double? DenseWeight { get; init; }

    [JsonPropertyName("citation_style")]
    public VideoBotsPageRequestCitationStyle? CitationStyle { get; init; }

    [JsonPropertyName("use_url_shortener")]
    public bool? UseUrlShortener { get; init; }

    /// <summary>
    /// Choose a model to transcribe incoming audio messages to text.
    /// </summary>
    [JsonPropertyName("asr_model")]
    public VideoBotsPageRequestAsrModel? AsrModel { get; init; }

    /// <summary>
    /// Choose a language to transcribe incoming audio messages to text.
    /// </summary>
    [JsonPropertyName("asr_language")]
    public string? AsrLanguage { get; init; }

    [JsonPropertyName("translation_model")]
    public VideoBotsPageRequestTranslationModel? TranslationModel { get; init; }

    /// <summary>
    /// Choose a language to translate incoming text & audio messages to English and responses back to your selected language. Useful for low-resource languages.
    /// </summary>
    [JsonPropertyName("user_language")]
    public string? UserLanguage { get; init; }

    /// <summary>
    /// Translation Glossary for User Langauge -> LLM Language (English)
    /// </summary>
    [JsonPropertyName("input_glossary_document")]
    public string? InputGlossaryDocument { get; init; }

    /// <summary>
    /// Translation Glossary for LLM Language (English) -> User Langauge
    /// </summary>
    [JsonPropertyName("output_glossary_document")]
    public string? OutputGlossaryDocument { get; init; }

    [JsonPropertyName("lipsync_model")]
    public VideoBotsPageRequestLipsyncModel? LipsyncModel { get; init; }

    /// <summary>
    /// Give your copilot superpowers by giving it access to tools. Powered by [Function calling](https://platform.openai.com/docs/guides/function-calling).
    /// </summary>
    [JsonPropertyName("tools")]
    public IEnumerable<string>? Tools { get; init; }

    [JsonPropertyName("tts_provider")]
    public VideoBotsPageRequestTtsProvider? TtsProvider { get; init; }

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
    public VideoBotsPageRequestOpenaiVoiceName? OpenaiVoiceName { get; init; }

    [JsonPropertyName("openai_tts_model")]
    public VideoBotsPageRequestOpenaiTtsModel? OpenaiTtsModel { get; init; }

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

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
