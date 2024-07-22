using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record CompareUpscalerPageOutput
{
    /// <summary>
    /// Output Images
    /// </summary>
    [JsonPropertyName("output_images")]
    public Dictionary<string, string>? OutputImages { get; init; }

    /// <summary>
    /// Output Videos
    /// </summary>
    [JsonPropertyName("output_videos")]
    public Dictionary<string, string>? OutputVideos { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
