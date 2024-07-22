using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record RelatedQnAPageOutput
{
    [JsonPropertyName("output_queries")]
    public IEnumerable<RelatedGoogleGptResponse> OutputQueries { get; init; } =
        new List<RelatedGoogleGptResponse>();

    [JsonPropertyName("serp_results")]
    public Dictionary<string, object> SerpResults { get; init; } = new Dictionary<string, object>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
