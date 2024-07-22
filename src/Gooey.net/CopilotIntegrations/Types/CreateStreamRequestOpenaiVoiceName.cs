using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<CreateStreamRequestOpenaiVoiceName>))]
public enum CreateStreamRequestOpenaiVoiceName
{
    [EnumMember(Value = "alloy")]
    Alloy,

    [EnumMember(Value = "echo")]
    Echo,

    [EnumMember(Value = "fable")]
    Fable,

    [EnumMember(Value = "onyx")]
    Onyx,

    [EnumMember(Value = "nova")]
    Nova,

    [EnumMember(Value = "shimmer")]
    Shimmer
}
