using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<FaceInpaintingPageRequestSelectedModel>))]
public enum FaceInpaintingPageRequestSelectedModel
{
    [EnumMember(Value = "sd_2")]
    Sd2,

    [EnumMember(Value = "runway_ml")]
    RunwayMl,

    [EnumMember(Value = "dall_e")]
    DallE,

    [EnumMember(Value = "jack_qiao")]
    JackQiao
}
