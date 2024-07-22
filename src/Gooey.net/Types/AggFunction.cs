using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record AggFunction
{
    [JsonPropertyName("column")]
    public string? Column { get; init; }

    [JsonPropertyName("function")]
    public required Function Function { get; init; }
}
