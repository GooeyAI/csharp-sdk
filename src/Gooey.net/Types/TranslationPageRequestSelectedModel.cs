using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<TranslationPageRequestSelectedModel>))]
public enum TranslationPageRequestSelectedModel
{
    [EnumMember(Value = "google")]
    Google,

    [EnumMember(Value = "ghana_nlp")]
    GhanaNlp
}
