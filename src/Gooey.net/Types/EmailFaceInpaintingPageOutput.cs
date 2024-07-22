using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record EmailFaceInpaintingPageOutput
{
    [JsonPropertyName("input_image")]
    public required string InputImage { get; init; }

    [JsonPropertyName("resized_image")]
    public required string ResizedImage { get; init; }

    [JsonPropertyName("face_mask")]
    public required string FaceMask { get; init; }

    [JsonPropertyName("diffusion_images")]
    public IEnumerable<string> DiffusionImages { get; init; } = new List<string>();

    [JsonPropertyName("output_images")]
    public IEnumerable<string> OutputImages { get; init; } = new List<string>();

    [JsonPropertyName("email_sent")]
    public bool? EmailSent { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
