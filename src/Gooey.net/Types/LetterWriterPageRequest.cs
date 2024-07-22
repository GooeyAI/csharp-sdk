using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record LetterWriterPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("action_id")]
    public required string ActionId { get; init; }

    [JsonPropertyName("prompt_header")]
    public string? PromptHeader { get; init; }

    [JsonPropertyName("example_letters")]
    public IEnumerable<TrainingDataModel>? ExampleLetters { get; init; }

    [JsonPropertyName("lm_selected_api")]
    public string? LmSelectedApi { get; init; }

    [JsonPropertyName("lm_selected_engine")]
    public string? LmSelectedEngine { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public double? Quality { get; init; }

    [JsonPropertyName("lm_sampling_temperature")]
    public double? LmSamplingTemperature { get; init; }

    [JsonPropertyName("api_http_method")]
    public string? ApiHttpMethod { get; init; }

    [JsonPropertyName("api_url")]
    public string? ApiUrl { get; init; }

    [JsonPropertyName("api_headers")]
    public string? ApiHeaders { get; init; }

    [JsonPropertyName("api_json_body")]
    public string? ApiJsonBody { get; init; }

    [JsonPropertyName("input_prompt")]
    public string? InputPrompt { get; init; }

    [JsonPropertyName("strip_html_2_text")]
    public bool? StripHtml2Text { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
