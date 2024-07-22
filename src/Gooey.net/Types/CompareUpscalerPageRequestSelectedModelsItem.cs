using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<CompareUpscalerPageRequestSelectedModelsItem>))]
public enum CompareUpscalerPageRequestSelectedModelsItem
{
    [EnumMember(Value = "gfpgan_1_4")]
    Gfpgan14,

    [EnumMember(Value = "real_esrgan_x2")]
    RealEsrganX2,

    [EnumMember(Value = "sd_x4")]
    SdX4,

    [EnumMember(Value = "real_esrgan")]
    RealEsrgan,

    [EnumMember(Value = "gfpgan")]
    Gfpgan
}
