using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public record PromptTreeNode
{
    [JsonPropertyName("prompt")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, IEnumerable<ConversationEntry>>>))]
    public required OneOf<string, IEnumerable<ConversationEntry>> Prompt { get; init; }

    [JsonPropertyName("children")]
    public IEnumerable<PromptTreeNode> Children { get; init; } = new List<PromptTreeNode>();
}
