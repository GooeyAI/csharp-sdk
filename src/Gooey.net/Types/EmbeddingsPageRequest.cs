using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record EmbeddingsPageRequest
{
    [JsonPropertyName("functions")]
    public IEnumerable<RecipeFunction>? Functions { get; init; }

    /// <summary>
    /// Variables to be used as Jinja prompt templates and in functions as arguments
    /// </summary>
    [JsonPropertyName("variables")]
    public Dictionary<string, object>? Variables { get; init; }

    [JsonPropertyName("texts")]
    public IEnumerable<string> Texts { get; init; } = new List<string>();

    [JsonPropertyName("selected_model")]
    public EmbeddingsPageRequestSelectedModel? SelectedModel { get; init; }

    [JsonPropertyName("settings")]
    public RunSettings? Settings { get; init; }
}
