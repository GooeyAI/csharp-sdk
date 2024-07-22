using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Img2ImgPageRequestSelectedModel>))]
public enum Img2ImgPageRequestSelectedModel
{
    [EnumMember(Value = "dream_shaper")]
    DreamShaper,

    [EnumMember(Value = "dreamlike_2")]
    Dreamlike2,

    [EnumMember(Value = "sd_2")]
    Sd2,

    [EnumMember(Value = "sd_1_5")]
    Sd15,

    [EnumMember(Value = "dall_e")]
    DallE,

    [EnumMember(Value = "instruct_pix2pix")]
    InstructPix2Pix,

    [EnumMember(Value = "openjourney_2")]
    Openjourney2,

    [EnumMember(Value = "openjourney")]
    Openjourney,

    [EnumMember(Value = "analog_diffusion")]
    AnalogDiffusion,

    [EnumMember(Value = "protogen_5_3")]
    Protogen53,

    [EnumMember(Value = "jack_qiao")]
    JackQiao,

    [EnumMember(Value = "rodent_diffusion_1_5")]
    RodentDiffusion15
}
