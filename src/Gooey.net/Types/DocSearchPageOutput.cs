using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record DocSearchPageOutput
{
    [JsonPropertyName("output_text")]
    public IEnumerable<string> OutputText { get; init; } = new List<string>();

    [JsonPropertyName("references")]
    public IEnumerable<SearchReference> References { get; init; } = new List<SearchReference>();

    [JsonPropertyName("final_prompt")]
    public required string FinalPrompt { get; init; }

    [JsonPropertyName("final_search_query")]
    public string? FinalSearchQuery { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
