using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record ReplyButton
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }
}
