using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record RelatedQnADocPageOutput
{
    [JsonPropertyName("output_queries")]
    public IEnumerable<RelatedDocSearchResponse> OutputQueries { get; init; } =
        new List<RelatedDocSearchResponse>();

    [JsonPropertyName("serp_results")]
    public Dictionary<string, object> SerpResults { get; init; } = new Dictionary<string, object>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
