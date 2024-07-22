using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record GoogleGptPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("serp_search_location")]
    public SerpSearchLocation? SerpSearchLocation { get; init; }

    /// <summary>
    /// DEPRECATED: use `serp_search_location` instead
    /// </summary>
    [JsonPropertyName("scaleserp_locations")]
    public IEnumerable<string>? ScaleserpLocations { get; init; }

    [JsonPropertyName("serp_search_type")]
    public SerpSearchType? SerpSearchType { get; init; }

    /// <summary>
    /// DEPRECATED: use `serp_search_type` instead
    /// </summary>
    [JsonPropertyName("scaleserp_search_field")]
    public string? ScaleserpSearchField { get; init; }

    [JsonPropertyName("search_query")]
    public required string SearchQuery { get; init; }

    [JsonPropertyName("site_filter")]
    public required string SiteFilter { get; init; }

    [JsonPropertyName("task_instructions")]
    public string? TaskInstructions { get; init; }

    [JsonPropertyName("query_instructions")]
    public string? QueryInstructions { get; init; }

    [JsonPropertyName("selected_model")]
    public GoogleGptPageRequestSelectedModel? SelectedModel { get; init; }

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

    [JsonPropertyName("max_search_urls")]
    public int? MaxSearchUrls { get; init; }

    [JsonPropertyName("max_references")]
    public int? MaxReferences { get; init; }

    [JsonPropertyName("max_context_words")]
    public int? MaxContextWords { get; init; }

    [JsonPropertyName("scroll_jump")]
    public int? ScrollJump { get; init; }

    [JsonPropertyName("embedding_model")]
    public GoogleGptPageRequestEmbeddingModel? EmbeddingModel { get; init; }

    /// <summary>
    /// Weightage for dense vs sparse embeddings. `0` for sparse, `1` for dense, `0.5` for equal weight.
    /// Generally speaking, dense embeddings excel at understanding the context of the query, whereas sparse vectors excel at keyword matches.
    /// </summary>
    [JsonPropertyName("dense_weight")]
    public double? DenseWeight { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
