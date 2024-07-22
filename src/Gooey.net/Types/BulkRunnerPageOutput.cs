using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record BulkRunnerPageOutput
{
    [JsonPropertyName("output_documents")]
    public IEnumerable<string> OutputDocuments { get; init; } = new List<string>();

    /// <summary>
    /// List of URLs to the evaluation runs that you requested.
    /// </summary>
    [JsonPropertyName("eval_runs")]
    public IEnumerable<string>? EvalRuns { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
