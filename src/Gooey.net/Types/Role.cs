using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Role>))]
public enum Role
{
    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "system")]
    System,

    [EnumMember(Value = "assistant")]
    Assistant
}
