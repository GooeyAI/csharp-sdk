using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Preprocess>))]
public enum Preprocess
{
    [EnumMember(Value = "crop")]
    Crop,

    [EnumMember(Value = "extcrop")]
    Extcrop,

    [EnumMember(Value = "resize")]
    Resize,

    [EnumMember(Value = "full")]
    Full,

    [EnumMember(Value = "extfull")]
    Extfull
}
