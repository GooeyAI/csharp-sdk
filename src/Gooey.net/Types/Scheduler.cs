using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<Scheduler>))]
public enum Scheduler
{
    [EnumMember(Value = "singlestep_dpm_solver")]
    SinglestepDpmSolver,

    [EnumMember(Value = "multistep_dpm_solver")]
    MultistepDpmSolver,

    [EnumMember(Value = "dpm_sde")]
    DpmSde,

    [EnumMember(Value = "dpm_discrete")]
    DpmDiscrete,

    [EnumMember(Value = "dpm_discrete_ancestral")]
    DpmDiscreteAncestral,

    [EnumMember(Value = "unipc")]
    Unipc,

    [EnumMember(Value = "lms_discrete")]
    LmsDiscrete,

    [EnumMember(Value = "heun")]
    Heun,

    [EnumMember(Value = "euler")]
    Euler,

    [EnumMember(Value = "euler_ancestral")]
    EulerAncestral,

    [EnumMember(Value = "pndm")]
    Pndm,

    [EnumMember(Value = "ddpm")]
    Ddpm,

    [EnumMember(Value = "ddim")]
    Ddim,

    [EnumMember(Value = "deis")]
    Deis
}
