using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Trigger>))]
public enum Trigger
{
    [EnumMember(Value = "pre")]
    Pre,

    [EnumMember(Value = "post")]
    Post
}
