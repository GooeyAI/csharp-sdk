using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ConsoleLogs
{
    [JsonPropertyName("level")]
    public required Level Level { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }
}
