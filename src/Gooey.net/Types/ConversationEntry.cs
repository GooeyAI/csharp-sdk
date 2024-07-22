using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public record ConversationEntry
{
    [JsonPropertyName("role")]
    public required Role Role { get; init; }

    [JsonPropertyName("content")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, IEnumerable<object>>>))]
    public required OneOf<string, IEnumerable<object>> Content { get; init; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }
}
