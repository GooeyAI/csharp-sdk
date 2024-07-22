using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record RelatedGoogleGptResponse
{
    [JsonPropertyName("output_text")]
    public IEnumerable<string> OutputText { get; init; } = new List<string>();

    [JsonPropertyName("serp_results")]
    public Dictionary<string, object> SerpResults { get; init; } = new Dictionary<string, object>();

    [JsonPropertyName("references")]
    public IEnumerable<SearchReference> References { get; init; } = new List<SearchReference>();

    [JsonPropertyName("final_prompt")]
    public required string FinalPrompt { get; init; }

    [JsonPropertyName("final_search_query")]
    public string? FinalSearchQuery { get; init; }

    [JsonPropertyName("search_query")]
    public required string SearchQuery { get; init; }
}
