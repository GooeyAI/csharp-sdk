using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record BulkEvalPageOutput
{
    [JsonPropertyName("output_documents")]
    public IEnumerable<string> OutputDocuments { get; init; } = new List<string>();

    [JsonPropertyName("final_prompts")]
    public IEnumerable<IEnumerable<string>>? FinalPrompts { get; init; }

    [JsonPropertyName("aggregations")]
    public IEnumerable<IEnumerable<AggFunctionResult>>? Aggregations { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
