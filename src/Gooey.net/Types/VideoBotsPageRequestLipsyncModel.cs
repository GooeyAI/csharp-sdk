using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<VideoBotsPageRequestLipsyncModel>))]
public enum VideoBotsPageRequestLipsyncModel
{
    [EnumMember(Value = "Wav2Lip")]
    Wav2Lip,

    [EnumMember(Value = "SadTalker")]
    SadTalker
}
