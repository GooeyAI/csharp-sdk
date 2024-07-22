using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<SmartGptPageRequestSelectedModel>))]
public enum SmartGptPageRequestSelectedModel
{
    [EnumMember(Value = "gpt_4_o")]
    Gpt4O,

    [EnumMember(Value = "gpt_4_turbo_vision")]
    Gpt4TurboVision,

    [EnumMember(Value = "gpt_4_vision")]
    Gpt4Vision,

    [EnumMember(Value = "gpt_4_turbo")]
    Gpt4Turbo,

    [EnumMember(Value = "gpt_4")]
    Gpt4,

    [EnumMember(Value = "gpt_4_32k")]
    Gpt432K,

    [EnumMember(Value = "gpt_3_5_turbo")]
    Gpt35Turbo,

    [EnumMember(Value = "gpt_3_5_turbo_16k")]
    Gpt35Turbo16K,

    [EnumMember(Value = "gpt_3_5_turbo_instruct")]
    Gpt35TurboInstruct,

    [EnumMember(Value = "llama3_70b")]
    Llama370B,

    [EnumMember(Value = "llama3_8b")]
    Llama38B,

    [EnumMember(Value = "llama2_70b_chat")]
    Llama270BChat,

    [EnumMember(Value = "mixtral_8x7b_instruct_0_1")]
    Mixtral8X7BInstruct01,

    [EnumMember(Value = "gemma_7b_it")]
    Gemma7BIt,

    [EnumMember(Value = "gemini_1_5_pro")]
    Gemini15Pro,

    [EnumMember(Value = "gemini_1_pro_vision")]
    Gemini1ProVision,

    [EnumMember(Value = "gemini_1_pro")]
    Gemini1Pro,

    [EnumMember(Value = "palm2_chat")]
    Palm2Chat,

    [EnumMember(Value = "palm2_text")]
    Palm2Text,

    [EnumMember(Value = "claude_3_5_sonnet")]
    Claude35Sonnet,

    [EnumMember(Value = "claude_3_opus")]
    Claude3Opus,

    [EnumMember(Value = "claude_3_sonnet")]
    Claude3Sonnet,

    [EnumMember(Value = "claude_3_haiku")]
    Claude3Haiku,

    [EnumMember(Value = "sea_lion_7b_instruct")]
    SeaLion7BInstruct,

    [EnumMember(Value = "text_davinci_003")]
    TextDavinci003,

    [EnumMember(Value = "text_davinci_002")]
    TextDavinci002,

    [EnumMember(Value = "code_davinci_002")]
    CodeDavinci002,

    [EnumMember(Value = "text_curie_001")]
    TextCurie001,

    [EnumMember(Value = "text_babbage_001")]
    TextBabbage001,

    [EnumMember(Value = "text_ada_001")]
    TextAda001
}
