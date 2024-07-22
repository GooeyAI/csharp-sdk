using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<CompareLlmPageRequestResponseFormatType>))]
public enum CompareLlmPageRequestResponseFormatType
{
    [EnumMember(Value = "text")]
    Text,

    [EnumMember(Value = "json_object")]
    JsonObject
}
