using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<SerpSearchLocation>))]
public enum SerpSearchLocation
{
    [EnumMember(Value = "af")]
    Af,

    [EnumMember(Value = "al")]
    Al,

    [EnumMember(Value = "dz")]
    Dz,

    [EnumMember(Value = "as")]
    As,

    [EnumMember(Value = "ad")]
    Ad,

    [EnumMember(Value = "ao")]
    Ao,

    [EnumMember(Value = "ai")]
    Ai,

    [EnumMember(Value = "aq")]
    Aq,

    [EnumMember(Value = "ag")]
    Ag,

    [EnumMember(Value = "ar")]
    Ar,

    [EnumMember(Value = "am")]
    Am,

    [EnumMember(Value = "aw")]
    Aw,

    [EnumMember(Value = "au")]
    Au,

    [EnumMember(Value = "at")]
    At,

    [EnumMember(Value = "az")]
    Az,

    [EnumMember(Value = "bs")]
    Bs,

    [EnumMember(Value = "bh")]
    Bh,

    [EnumMember(Value = "bd")]
    Bd,

    [EnumMember(Value = "bb")]
    Bb,

    [EnumMember(Value = "by")]
    By,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "bz")]
    Bz,

    [EnumMember(Value = "bj")]
    Bj,

    [EnumMember(Value = "bm")]
    Bm,

    [EnumMember(Value = "bt")]
    Bt,

    [EnumMember(Value = "bo")]
    Bo,

    [EnumMember(Value = "ba")]
    Ba,

    [EnumMember(Value = "bw")]
    Bw,

    [EnumMember(Value = "bv")]
    Bv,

    [EnumMember(Value = "br")]
    Br,

    [EnumMember(Value = "io")]
    Io,

    [EnumMember(Value = "bn")]
    Bn,

    [EnumMember(Value = "bg")]
    Bg,

    [EnumMember(Value = "bf")]
    Bf,

    [EnumMember(Value = "bi")]
    Bi,

    [EnumMember(Value = "kh")]
    Kh,

    [EnumMember(Value = "cm")]
    Cm,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "cv")]
    Cv,

    [EnumMember(Value = "ky")]
    Ky,

    [EnumMember(Value = "cf")]
    Cf,

    [EnumMember(Value = "td")]
    Td,

    [EnumMember(Value = "cl")]
    Cl,

    [EnumMember(Value = "cn")]
    Cn,

    [EnumMember(Value = "cx")]
    Cx,

    [EnumMember(Value = "cc")]
    Cc,

    [EnumMember(Value = "co")]
    Co,

    [EnumMember(Value = "km")]
    Km,

    [EnumMember(Value = "cg")]
    Cg,

    [EnumMember(Value = "cd")]
    Cd,

    [EnumMember(Value = "ck")]
    Ck,

    [EnumMember(Value = "cr")]
    Cr,

    [EnumMember(Value = "ci")]
    Ci,

    [EnumMember(Value = "hr")]
    Hr,

    [EnumMember(Value = "cu")]
    Cu,

    [EnumMember(Value = "cy")]
    Cy,

    [EnumMember(Value = "cz")]
    Cz,

    [EnumMember(Value = "dk")]
    Dk,

    [EnumMember(Value = "dj")]
    Dj,

    [EnumMember(Value = "dm")]
    Dm,

    [EnumMember(Value = "do")]
    Do,

    [EnumMember(Value = "ec")]
    Ec,

    [EnumMember(Value = "eg")]
    Eg,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "gq")]
    Gq,

    [EnumMember(Value = "er")]
    Er,

    [EnumMember(Value = "ee")]
    Ee,

    [EnumMember(Value = "et")]
    Et,

    [EnumMember(Value = "fk")]
    Fk,

    [EnumMember(Value = "fo")]
    Fo,

    [EnumMember(Value = "fj")]
    Fj,

    [EnumMember(Value = "fi")]
    Fi,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "gf")]
    Gf,

    [EnumMember(Value = "pf")]
    Pf,

    [EnumMember(Value = "tf")]
    Tf,

    [EnumMember(Value = "ga")]
    Ga,

    [EnumMember(Value = "gm")]
    Gm,

    [EnumMember(Value = "ge")]
    Ge,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "gh")]
    Gh,

    [EnumMember(Value = "gi")]
    Gi,

    [EnumMember(Value = "gr")]
    Gr,

    [EnumMember(Value = "gl")]
    Gl,

    [EnumMember(Value = "gd")]
    Gd,

    [EnumMember(Value = "gp")]
    Gp,

    [EnumMember(Value = "gu")]
    Gu,

    [EnumMember(Value = "gt")]
    Gt,

    [EnumMember(Value = "gn")]
    Gn,

    [EnumMember(Value = "gw")]
    Gw,

    [EnumMember(Value = "gy")]
    Gy,

    [EnumMember(Value = "ht")]
    Ht,

    [EnumMember(Value = "hm")]
    Hm,

    [EnumMember(Value = "va")]
    Va,

    [EnumMember(Value = "hn")]
    Hn,

    [EnumMember(Value = "hk")]
    Hk,

    [EnumMember(Value = "hu")]
    Hu,

    [EnumMember(Value = "is")]
    Is,

    [EnumMember(Value = "in")]
    In,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "ir")]
    Ir,

    [EnumMember(Value = "iq")]
    Iq,

    [EnumMember(Value = "ie")]
    Ie,

    [EnumMember(Value = "il")]
    Il,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "jm")]
    Jm,

    [EnumMember(Value = "jp")]
    Jp,

    [EnumMember(Value = "jo")]
    Jo,

    [EnumMember(Value = "kz")]
    Kz,

    [EnumMember(Value = "ke")]
    Ke,

    [EnumMember(Value = "ki")]
    Ki,

    [EnumMember(Value = "kp")]
    Kp,

    [EnumMember(Value = "kr")]
    Kr,

    [EnumMember(Value = "kw")]
    Kw,

    [EnumMember(Value = "kg")]
    Kg,

    [EnumMember(Value = "la")]
    La,

    [EnumMember(Value = "lv")]
    Lv,

    [EnumMember(Value = "lb")]
    Lb,

    [EnumMember(Value = "ls")]
    Ls,

    [EnumMember(Value = "lr")]
    Lr,

    [EnumMember(Value = "ly")]
    Ly,

    [EnumMember(Value = "li")]
    Li,

    [EnumMember(Value = "lt")]
    Lt,

    [EnumMember(Value = "lu")]
    Lu,

    [EnumMember(Value = "mo")]
    Mo,

    [EnumMember(Value = "mk")]
    Mk,

    [EnumMember(Value = "mg")]
    Mg,

    [EnumMember(Value = "mw")]
    Mw,

    [EnumMember(Value = "my")]
    My,

    [EnumMember(Value = "mv")]
    Mv,

    [EnumMember(Value = "ml")]
    Ml,

    [EnumMember(Value = "mt")]
    Mt,

    [EnumMember(Value = "mh")]
    Mh,

    [EnumMember(Value = "mq")]
    Mq,

    [EnumMember(Value = "mr")]
    Mr,

    [EnumMember(Value = "mu")]
    Mu,

    [EnumMember(Value = "yt")]
    Yt,

    [EnumMember(Value = "mx")]
    Mx,

    [EnumMember(Value = "fm")]
    Fm,

    [EnumMember(Value = "md")]
    Md,

    [EnumMember(Value = "mc")]
    Mc,

    [EnumMember(Value = "mn")]
    Mn,

    [EnumMember(Value = "ms")]
    Ms,

    [EnumMember(Value = "ma")]
    Ma,

    [EnumMember(Value = "mz")]
    Mz,

    [EnumMember(Value = "mm")]
    Mm,

    [EnumMember(Value = "na")]
    Na,

    [EnumMember(Value = "nr")]
    Nr,

    [EnumMember(Value = "np")]
    Np,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "an")]
    An,

    [EnumMember(Value = "nc")]
    Nc,

    [EnumMember(Value = "nz")]
    Nz,

    [EnumMember(Value = "ni")]
    Ni,

    [EnumMember(Value = "ne")]
    Ne,

    [EnumMember(Value = "ng")]
    Ng,

    [EnumMember(Value = "nu")]
    Nu,

    [EnumMember(Value = "nf")]
    Nf,

    [EnumMember(Value = "mp")]
    Mp,

    [EnumMember(Value = "no")]
    No,

    [EnumMember(Value = "om")]
    Om,

    [EnumMember(Value = "pk")]
    Pk,

    [EnumMember(Value = "pw")]
    Pw,

    [EnumMember(Value = "ps")]
    Ps,

    [EnumMember(Value = "pa")]
    Pa,

    [EnumMember(Value = "pg")]
    Pg,

    [EnumMember(Value = "py")]
    Py,

    [EnumMember(Value = "pe")]
    Pe,

    [EnumMember(Value = "ph")]
    Ph,

    [EnumMember(Value = "pn")]
    Pn,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "pr")]
    Pr,

    [EnumMember(Value = "qa")]
    Qa,

    [EnumMember(Value = "re")]
    Re,

    [EnumMember(Value = "ro")]
    Ro,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "rw")]
    Rw,

    [EnumMember(Value = "sh")]
    Sh,

    [EnumMember(Value = "kn")]
    Kn,

    [EnumMember(Value = "lc")]
    Lc,

    [EnumMember(Value = "pm")]
    Pm,

    [EnumMember(Value = "vc")]
    Vc,

    [EnumMember(Value = "ws")]
    Ws,

    [EnumMember(Value = "sm")]
    Sm,

    [EnumMember(Value = "st")]
    St,

    [EnumMember(Value = "sa")]
    Sa,

    [EnumMember(Value = "sn")]
    Sn,

    [EnumMember(Value = "rs")]
    Rs,

    [EnumMember(Value = "sc")]
    Sc,

    [EnumMember(Value = "sl")]
    Sl,

    [EnumMember(Value = "sg")]
    Sg,

    [EnumMember(Value = "sk")]
    Sk,

    [EnumMember(Value = "si")]
    Si,

    [EnumMember(Value = "sb")]
    Sb,

    [EnumMember(Value = "so")]
    So,

    [EnumMember(Value = "za")]
    Za,

    [EnumMember(Value = "gs")]
    Gs,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "lk")]
    Lk,

    [EnumMember(Value = "sd")]
    Sd,

    [EnumMember(Value = "sr")]
    Sr,

    [EnumMember(Value = "sj")]
    Sj,

    [EnumMember(Value = "sz")]
    Sz,

    [EnumMember(Value = "se")]
    Se,

    [EnumMember(Value = "ch")]
    Ch,

    [EnumMember(Value = "sy")]
    Sy,

    [EnumMember(Value = "tw")]
    Tw,

    [EnumMember(Value = "tj")]
    Tj,

    [EnumMember(Value = "tz")]
    Tz,

    [EnumMember(Value = "th")]
    Th,

    [EnumMember(Value = "tl")]
    Tl,

    [EnumMember(Value = "tg")]
    Tg,

    [EnumMember(Value = "tk")]
    Tk,

    [EnumMember(Value = "to")]
    To,

    [EnumMember(Value = "tt")]
    Tt,

    [EnumMember(Value = "tn")]
    Tn,

    [EnumMember(Value = "tr")]
    Tr,

    [EnumMember(Value = "tm")]
    Tm,

    [EnumMember(Value = "tc")]
    Tc,

    [EnumMember(Value = "tv")]
    Tv,

    [EnumMember(Value = "ug")]
    Ug,

    [EnumMember(Value = "ua")]
    Ua,

    [EnumMember(Value = "ae")]
    Ae,

    [EnumMember(Value = "gb")]
    Gb,

    [EnumMember(Value = "us")]
    Us,

    [EnumMember(Value = "um")]
    Um,

    [EnumMember(Value = "uy")]
    Uy,

    [EnumMember(Value = "uz")]
    Uz,

    [EnumMember(Value = "vu")]
    Vu,

    [EnumMember(Value = "ve")]
    Ve,

    [EnumMember(Value = "vn")]
    Vn,

    [EnumMember(Value = "vg")]
    Vg,

    [EnumMember(Value = "vi")]
    Vi,

    [EnumMember(Value = "wf")]
    Wf,

    [EnumMember(Value = "eh")]
    Eh,

    [EnumMember(Value = "ye")]
    Ye,

    [EnumMember(Value = "zm")]
    Zm,

    [EnumMember(Value = "zw")]
    Zw
}
