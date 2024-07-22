using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Function>))]
public enum Function
{
    [EnumMember(Value = "mean")]
    Mean,

    [EnumMember(Value = "median")]
    Median,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,

    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "cumsum")]
    Cumsum,

    [EnumMember(Value = "prod")]
    Prod,

    [EnumMember(Value = "cumprod")]
    Cumprod,

    [EnumMember(Value = "std")]
    Std,

    [EnumMember(Value = "var")]
    Var,

    [EnumMember(Value = "first")]
    First,

    [EnumMember(Value = "last")]
    Last,

    [EnumMember(Value = "count")]
    Count,

    [EnumMember(Value = "cumcount")]
    Cumcount,

    [EnumMember(Value = "nunique")]
    Nunique,

    [EnumMember(Value = "rank")]
    Rank
}
