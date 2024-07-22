using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<SerpSearchType>))]
public enum SerpSearchType
{
    [EnumMember(Value = "search")]
    Search,

    [EnumMember(Value = "images")]
    Images,

    [EnumMember(Value = "videos")]
    Videos,

    [EnumMember(Value = "places")]
    Places,

    [EnumMember(Value = "news")]
    News
}
