using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record QrCodeGeneratorPageOutput
{
    [JsonPropertyName("output_images")]
    public IEnumerable<string> OutputImages { get; init; } = new List<string>();

    [JsonPropertyName("raw_images")]
    public IEnumerable<string> RawImages { get; init; } = new List<string>();

    [JsonPropertyName("shortened_url")]
    public string? ShortenedUrl { get; init; }

    [JsonPropertyName("cleaned_qr_code")]
    public required string CleanedQrCode { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
