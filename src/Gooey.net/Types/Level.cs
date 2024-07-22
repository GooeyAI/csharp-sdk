using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Level>))]
public enum Level
{
    [EnumMember(Value = "log")]
    Log,

    [EnumMember(Value = "error")]
    Error
}
