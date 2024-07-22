using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record AggFunctionResult
{
    [JsonPropertyName("column")]
    public required string Column { get; init; }

    [JsonPropertyName("function")]
    public required Function Function { get; init; }

    [JsonPropertyName("count")]
    public required int Count { get; init; }

    [JsonPropertyName("value")]
    public required double Value { get; init; }
}
