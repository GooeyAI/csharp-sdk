using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<LipsyncTtsPageRequestTtsProvider>))]
public enum LipsyncTtsPageRequestTtsProvider
{
    [EnumMember(Value = "GOOGLE_TTS")]
    GoogleTts,

    [EnumMember(Value = "ELEVEN_LABS")]
    ElevenLabs,

    [EnumMember(Value = "UBERDUCK")]
    Uberduck,

    [EnumMember(Value = "BARK")]
    Bark,

    [EnumMember(Value = "AZURE_TTS")]
    AzureTts,

    [EnumMember(Value = "OPEN_AI")]
    OpenAi
}
