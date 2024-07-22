using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record GoogleImageGenPageOutput
{
    [JsonPropertyName("output_images")]
    public IEnumerable<string> OutputImages { get; init; } = new List<string>();

    [JsonPropertyName("image_urls")]
    public IEnumerable<string> ImageUrls { get; init; } = new List<string>();

    [JsonPropertyName("selected_image")]
    public string? SelectedImage { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
