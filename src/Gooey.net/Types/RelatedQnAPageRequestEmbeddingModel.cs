using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<RelatedQnAPageRequestEmbeddingModel>))]
public enum RelatedQnAPageRequestEmbeddingModel
{
    [EnumMember(Value = "openai_3_large")]
    Openai3Large,

    [EnumMember(Value = "openai_3_small")]
    Openai3Small,

    [EnumMember(Value = "openai_ada_2")]
    OpenaiAda2,

    [EnumMember(Value = "e5_large_v2")]
    E5LargeV2,

    [EnumMember(Value = "e5_base_v2")]
    E5BaseV2,

    [EnumMember(Value = "multilingual_e5_base")]
    MultilingualE5Base,

    [EnumMember(Value = "multilingual_e5_large")]
    MultilingualE5Large,

    [EnumMember(Value = "gte_large")]
    GteLarge,

    [EnumMember(Value = "gte_base")]
    GteBase
}
