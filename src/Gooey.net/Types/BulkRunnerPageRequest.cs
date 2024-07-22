using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record BulkRunnerPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    /// <summary>
    /// Upload or link to a CSV or google sheet that contains your sample input data.
    /// For example, for Copilot, this would sample questions or for Art QR Code, would would be pairs of image descriptions and URLs.
    /// Remember to includes header names in your CSV too.
    /// </summary>
    [JsonPropertyName("documents")]
    public IEnumerable<string> Documents { get; init; } = new List<string>();

    /// <summary>
    /// Provide one or more Gooey.AI workflow runs.
    /// You can add multiple runs from the same recipe (e.g. two versions of your copilot) and we'll run the inputs over both of them.
    /// </summary>
    [JsonPropertyName("run_urls")]
    public IEnumerable<string> RunUrls { get; init; } = new List<string>();

    /// <summary>
    /// For each input field in the Gooey.AI workflow, specify the column in your input data that corresponds to it.
    /// </summary>
    [JsonPropertyName("input_columns")]
    public Dictionary<string, string> InputColumns { get; init; } =
        new Dictionary<string, string>();

    /// <summary>
    /// For each output field in the Gooey.AI workflow, specify the column name that you'd like to use for it in the output data.
    /// </summary>
    [JsonPropertyName("output_columns")]
    public Dictionary<string, string> OutputColumns { get; init; } =
        new Dictionary<string, string>();

    /// <summary>
    /// _(optional)_ Add one or more Gooey.AI Evaluator Workflows to evaluate the results of your runs.
    /// </summary>
    [JsonPropertyName("eval_urls")]
    public IEnumerable<string>? EvalUrls { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
