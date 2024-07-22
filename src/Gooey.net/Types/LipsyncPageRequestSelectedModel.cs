using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<LipsyncPageRequestSelectedModel>))]
public enum LipsyncPageRequestSelectedModel
{
    [EnumMember(Value = "Wav2Lip")]
    Wav2Lip,

    [EnumMember(Value = "SadTalker")]
    SadTalker
}
