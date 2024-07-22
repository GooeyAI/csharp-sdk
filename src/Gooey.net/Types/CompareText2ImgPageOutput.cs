using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record CompareText2ImgPageOutput
{
    [JsonPropertyName("output_images")]
    public Dictionary<string, IEnumerable<string>> OutputImages { get; init; } =
        new Dictionary<string, IEnumerable<string>>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
