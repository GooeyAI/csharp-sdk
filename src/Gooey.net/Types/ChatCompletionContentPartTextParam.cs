using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record ChatCompletionContentPartTextParam
{
    [JsonPropertyName("text")]
    public string? Text { get; init; }
}
