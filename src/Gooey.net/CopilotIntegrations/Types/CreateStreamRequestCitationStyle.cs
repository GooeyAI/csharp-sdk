using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;

#nullable enable

namespace Gooey.net;

[JsonConverter(typeof(StringEnumSerializer<CreateStreamRequestCitationStyle>))]
public enum CreateStreamRequestCitationStyle
{
    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "title")]
    Title,

    [EnumMember(Value = "url")]
    Url,

    [EnumMember(Value = "symbol")]
    Symbol,

    [EnumMember(Value = "markdown")]
    Markdown,

    [EnumMember(Value = "html")]
    Html,

    [EnumMember(Value = "slack_mrkdwn")]
    SlackMrkdwn,

    [EnumMember(Value = "plaintext")]
    Plaintext,

    [EnumMember(Value = "number_markdown")]
    NumberMarkdown,

    [EnumMember(Value = "number_html")]
    NumberHtml,

    [EnumMember(Value = "number_slack_mrkdwn")]
    NumberSlackMrkdwn,

    [EnumMember(Value = "number_plaintext")]
    NumberPlaintext,

    [EnumMember(Value = "symbol_markdown")]
    SymbolMarkdown,

    [EnumMember(Value = "symbol_html")]
    SymbolHtml,

    [EnumMember(Value = "symbol_slack_mrkdwn")]
    SymbolSlackMrkdwn,

    [EnumMember(Value = "symbol_plaintext")]
    SymbolPlaintext
}
