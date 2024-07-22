using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record ChatCompletionContentPartImageParam
{
    [JsonPropertyName("image_url")]
    public ImageUrl? ImageUrl { get; init; }
}
