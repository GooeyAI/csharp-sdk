using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public record VideoBotsPageOutput
{
    [JsonPropertyName("final_prompt")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, IEnumerable<ConversationEntry>>>))]
    public OneOf<string, IEnumerable<ConversationEntry>>? FinalPrompt { get; init; }

    [JsonPropertyName("output_text")]
    public IEnumerable<string>? OutputText { get; init; }

    [JsonPropertyName("output_audio")]
    public IEnumerable<string>? OutputAudio { get; init; }

    [JsonPropertyName("output_video")]
    public IEnumerable<string>? OutputVideo { get; init; }

    [JsonPropertyName("raw_input_text")]
    public string? RawInputText { get; init; }

    [JsonPropertyName("raw_tts_text")]
    public IEnumerable<string>? RawTtsText { get; init; }

    [JsonPropertyName("raw_output_text")]
    public IEnumerable<string>? RawOutputText { get; init; }

    [JsonPropertyName("references")]
    public IEnumerable<SearchReference>? References { get; init; }

    [JsonPropertyName("final_search_query")]
    public string? FinalSearchQuery { get; init; }

    [JsonPropertyName("final_keyword_query")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, IEnumerable<string>>>))]
    public OneOf<string, IEnumerable<string>>? FinalKeywordQuery { get; init; }

    [JsonPropertyName("output_documents")]
    public IEnumerable<string>? OutputDocuments { get; init; }

    [JsonPropertyName("reply_buttons")]
    public IEnumerable<ReplyButton>? ReplyButtons { get; init; }

    [JsonPropertyName("finish_reason")]
    public IEnumerable<string>? FinishReason { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
