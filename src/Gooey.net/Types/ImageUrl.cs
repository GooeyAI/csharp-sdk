using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ImageUrl
{
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonPropertyName("detail")]
    public Detail? Detail { get; init; }
}
