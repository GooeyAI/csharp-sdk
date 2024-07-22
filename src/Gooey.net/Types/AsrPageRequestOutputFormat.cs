using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<AsrPageRequestOutputFormat>))]
public enum AsrPageRequestOutputFormat
{
    [EnumMember(Value = "text")]
    Text,

    [EnumMember(Value = "json")]
    Json,

    [EnumMember(Value = "srt")]
    Srt,

    [EnumMember(Value = "vtt")]
    Vtt
}
