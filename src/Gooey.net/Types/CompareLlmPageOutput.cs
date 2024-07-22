using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record CompareLlmPageOutput
{
    [JsonPropertyName("output_text")]
    public Dictionary<string, IEnumerable<string>> OutputText { get; init; } =
        new Dictionary<string, IEnumerable<string>>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
