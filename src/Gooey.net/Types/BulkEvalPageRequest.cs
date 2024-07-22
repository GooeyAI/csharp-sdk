using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record BulkEvalPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("selected_model")]
    public BulkEvalPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("avoid_repetition")]
    public bool? AvoidRepetition { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public double? Quality { get; init; }

    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; init; }

    [JsonPropertyName("sampling_temperature")]
    public double? SamplingTemperature { get; init; }

    /// <summary>
    /// Upload or link to a CSV or google sheet that contains your sample input data.
    /// For example, for Copilot, this would sample questions or for Art QR Code, would would be pairs of image descriptions and URLs.
    /// Remember to includes header names in your CSV too.
    /// </summary>
    [JsonPropertyName("documents")]
    public IEnumerable<string> Documents { get; init; } = new List<string>();

    /// <summary>
    /// Specify custom LLM prompts to calculate metrics that evaluate each row of the input data. The output should be a JSON object mapping the metric names to values.
    /// _The `columns` dictionary can be used to reference the spreadsheet columns._
    ///
    /// </summary>
    [JsonPropertyName("eval_prompts")]
    public IEnumerable<EvalPrompt>? EvalPrompts { get; init; }

    /// <summary>
    /// Aggregate using one or more operations. Uses [pandas](https://pandas.pydata.org/pandas-docs/stable/reference/groupby.html#dataframegroupby-computations-descriptive-stats).
    /// </summary>
    [JsonPropertyName("agg_functions")]
    public IEnumerable<AggFunction>? AggFunctions { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
