using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<TextToSpeechPageRequestOpenaiTtsModel>))]
public enum TextToSpeechPageRequestOpenaiTtsModel
{
    [EnumMember(Value = "tts_1")]
    Tts1,

    [EnumMember(Value = "tts_1_hd")]
    Tts1Hd
}
