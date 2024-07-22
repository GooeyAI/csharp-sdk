using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record CalledFunctionResponse
{
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonPropertyName("trigger")]
    public required Trigger Trigger { get; init; }

    [JsonPropertyName("return_value")]
    public object? ReturnValue { get; init; }
}
