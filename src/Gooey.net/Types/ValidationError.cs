using System.Text.Json.Serialization;
using Gooey.net.Core;
using OneOf;

#nullable enable

namespace Gooey.net;

public record ValidationError
{
    [JsonPropertyName("loc")]
    [JsonConverter(
        typeof(CollectionItemSerializer<OneOf<string, int>, OneOfSerializer<OneOf<string, int>>>)
    )]
    public IEnumerable<OneOf<string, int>> Loc { get; init; } = new List<OneOf<string, int>>();

    [JsonPropertyName("msg")]
    public required string Msg { get; init; }

    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
