using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record EmbeddingsPageOutput
{
    [JsonPropertyName("embeddings")]
    public IEnumerable<IEnumerable<double>> Embeddings { get; init; } =
        new List<IEnumerable<double>>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
