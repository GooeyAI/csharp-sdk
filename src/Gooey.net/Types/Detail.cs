using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Detail>))]
public enum Detail
{
    [EnumMember(Value = "auto")]
    Auto,

    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "high")]
    High
}
