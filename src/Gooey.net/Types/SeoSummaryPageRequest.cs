using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record SeoSummaryPageRequest
{
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

    [JsonPropertyName("keywords")]
    public required string Keywords { get; init; }

    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonPropertyName("company_url")]
    public required string CompanyUrl { get; init; }

    [JsonPropertyName("task_instructions")]
    public string? TaskInstructions { get; init; }

    [JsonPropertyName("enable_html")]
    public bool? EnableHtml { get; init; }

    [JsonPropertyName("selected_model")]
    public SeoSummaryPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("sampling_temperature")]
    public double? SamplingTemperature { get; init; }

    [JsonPropertyName("max_tokens")]
    public int? MaxTokens { get; init; }

    [JsonPropertyName("num_outputs")]
    public int? NumOutputs { get; init; }

    [JsonPropertyName("quality")]
    public double? Quality { get; init; }

    [JsonPropertyName("avoid_repetition")]
    public bool? AvoidRepetition { get; init; }

    [JsonPropertyName("max_search_urls")]
    public int? MaxSearchUrls { get; init; }

    [JsonPropertyName("enable_crosslinks")]
    public bool? EnableCrosslinks { get; init; }

    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
