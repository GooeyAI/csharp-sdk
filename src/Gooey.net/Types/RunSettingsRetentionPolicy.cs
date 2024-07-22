using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<RunSettingsRetentionPolicy>))]
public enum RunSettingsRetentionPolicy
{
    [EnumMember(Value = "keep")]
    Keep,

    [EnumMember(Value = "delete")]
    Delete
}
