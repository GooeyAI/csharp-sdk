using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record TranslationPageOutput
{
    [JsonPropertyName("output_texts")]
    public IEnumerable<string>? OutputTexts { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
