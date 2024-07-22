using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ImageSegmentationPageOutput
{
    [JsonPropertyName("output_image")]
    public required string OutputImage { get; init; }

    [JsonPropertyName("cutout_image")]
    public required string CutoutImage { get; init; }

    [JsonPropertyName("resized_image")]
    public required string ResizedImage { get; init; }

    [JsonPropertyName("resized_mask")]
    public required string ResizedMask { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
