using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public record DocSearchPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("search_query")]
    public required string SearchQuery { get; init; }

    [JsonPropertyName("keyword_query")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, IEnumerable<string>>>))]
    public OneOf<string, IEnumerable<string>>? KeywordQuery { get; init; }

    [JsonPropertyName("documents")]
    public IEnumerable<string>? Documents { get; init; }

    [JsonPropertyName("max_references")]
    public int? MaxReferences { get; init; }

    [JsonPropertyName("max_context_words")]
    public int? MaxContextWords { get; init; }

    [JsonPropertyName("scroll_jump")]
    public int? ScrollJump { get; init; }

    [JsonPropertyName("doc_extract_url")]
    public string? DocExtractUrl { get; init; }

    [JsonPropertyName("embedding_model")]
    public DocSearchPageRequestEmbeddingModel? EmbeddingModel { get; init; }

    /// <summary>
    /// Weightage for dense vs sparse embeddings. `0` for sparse, `1` for dense, `0.5` for equal weight.
    /// Generally speaking, dense embeddings excel at understanding the context of the query, whereas sparse vectors excel at keyword matches.
    /// </summary>
    [JsonPropertyName("dense_weight")]
    public double? DenseWeight { get; init; }

    [JsonPropertyName("task_instructions")]
    public string? TaskInstructions { get; init; }

    [JsonPropertyName("query_instructions")]
    public string? QueryInstructions { get; init; }

    [JsonPropertyName("selected_model")]
    public DocSearchPageRequestSelectedModel? SelectedModel { get; init; }

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

    [JsonPropertyName("citation_style")]
    public DocSearchPageRequestCitationStyle? CitationStyle { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
