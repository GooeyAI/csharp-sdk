using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record SeoSummaryPageOutput
{
    [JsonPropertyName("output_content")]
    public IEnumerable<string> OutputContent { get; init; } = new List<string>();

    [JsonPropertyName("serp_results")]
    public Dictionary<string, object> SerpResults { get; init; } = new Dictionary<string, object>();

    [JsonPropertyName("search_urls")]
    public IEnumerable<string> SearchUrls { get; init; } = new List<string>();

    [JsonPropertyName("summarized_urls")]
    public IEnumerable<Dictionary<string, object>> SummarizedUrls { get; init; } =
        new List<Dictionary<string, object>>();

    [JsonPropertyName("final_prompt")]
    public required string FinalPrompt { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
