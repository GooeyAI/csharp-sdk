using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<RecipeRunState>))]
public enum RecipeRunState
{
    [EnumMember(Value = "starting")]
    Starting,

    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "failed")]
    Failed
}
