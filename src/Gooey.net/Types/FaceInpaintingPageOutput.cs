using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record FaceInpaintingPageOutput
{
    [JsonPropertyName("resized_image")]
    public required string ResizedImage { get; init; }

    [JsonPropertyName("face_mask")]
    public required string FaceMask { get; init; }

    [JsonPropertyName("diffusion_images")]
    public IEnumerable<string> DiffusionImages { get; init; } = new List<string>();

    [JsonPropertyName("output_images")]
    public IEnumerable<string> OutputImages { get; init; } = new List<string>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
