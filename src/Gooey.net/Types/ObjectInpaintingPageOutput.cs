using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ObjectInpaintingPageOutput
{
    [JsonPropertyName("resized_image")]
    public required string ResizedImage { get; init; }

    [JsonPropertyName("obj_mask")]
    public required string ObjMask { get; init; }

    [JsonPropertyName("output_images")]
    public IEnumerable<string> OutputImages { get; init; } = new List<string>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
