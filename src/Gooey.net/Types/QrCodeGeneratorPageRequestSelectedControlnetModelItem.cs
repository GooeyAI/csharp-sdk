using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<QrCodeGeneratorPageRequestSelectedControlnetModelItem>))]
public enum QrCodeGeneratorPageRequestSelectedControlnetModelItem
{
    [EnumMember(Value = "sd_controlnet_canny")]
    SdControlnetCanny,

    [EnumMember(Value = "sd_controlnet_depth")]
    SdControlnetDepth,

    [EnumMember(Value = "sd_controlnet_hed")]
    SdControlnetHed,

    [EnumMember(Value = "sd_controlnet_mlsd")]
    SdControlnetMlsd,

    [EnumMember(Value = "sd_controlnet_normal")]
    SdControlnetNormal,

    [EnumMember(Value = "sd_controlnet_openpose")]
    SdControlnetOpenpose,

    [EnumMember(Value = "sd_controlnet_scribble")]
    SdControlnetScribble,

    [EnumMember(Value = "sd_controlnet_seg")]
    SdControlnetSeg,

    [EnumMember(Value = "sd_controlnet_tile")]
    SdControlnetTile,

    [EnumMember(Value = "sd_controlnet_brightness")]
    SdControlnetBrightness,

    [EnumMember(Value = "control_v1p_sd15_qrcode_monster_v2")]
    ControlV1PSd15QrcodeMonsterV2
}
