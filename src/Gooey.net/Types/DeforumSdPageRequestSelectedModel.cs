using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<DeforumSdPageRequestSelectedModel>))]
public enum DeforumSdPageRequestSelectedModel
{
    [EnumMember(Value = "protogen_2_2")]
    Protogen22,

    [EnumMember(Value = "epicdream")]
    Epicdream
}
