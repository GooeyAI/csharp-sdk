using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<ImageSegmentationPageRequestSelectedModel>))]
public enum ImageSegmentationPageRequestSelectedModel
{
    [EnumMember(Value = "dis")]
    Dis,

    [EnumMember(Value = "u2net")]
    U2Net
}
