using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<DocExtractPageRequestSelectedAsrModel>))]
public enum DocExtractPageRequestSelectedAsrModel
{
    [EnumMember(Value = "whisper_large_v2")]
    WhisperLargeV2,

    [EnumMember(Value = "whisper_large_v3")]
    WhisperLargeV3,

    [EnumMember(Value = "whisper_hindi_large_v2")]
    WhisperHindiLargeV2,

    [EnumMember(Value = "whisper_telugu_large_v2")]
    WhisperTeluguLargeV2,

    [EnumMember(Value = "nemo_english")]
    NemoEnglish,

    [EnumMember(Value = "nemo_hindi")]
    NemoHindi,

    [EnumMember(Value = "vakyansh_bhojpuri")]
    VakyanshBhojpuri,

    [EnumMember(Value = "gcp_v1")]
    GcpV1,

    [EnumMember(Value = "usm")]
    Usm,

    [EnumMember(Value = "deepgram")]
    Deepgram,

    [EnumMember(Value = "azure")]
    Azure,

    [EnumMember(Value = "seamless_m4t")]
    SeamlessM4T,

    [EnumMember(Value = "mms_1b_all")]
    Mms1BAll
}
