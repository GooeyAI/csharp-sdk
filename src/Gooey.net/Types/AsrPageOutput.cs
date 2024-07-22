using System.Text.Json.Serialization;
using Gooey.net;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public record AsrPageOutput
{
    [JsonPropertyName("raw_output_text")]
    public IEnumerable<string>? RawOutputText { get; init; }

    [JsonPropertyName("output_text")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, AsrOutputJson>,
            OneOfSerializer<OneOf<string, AsrOutputJson>>
        >)
    )]
    public IEnumerable<OneOf<string, AsrOutputJson>> OutputText { get; init; } =
        new List<OneOf<string, AsrOutputJson>>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
