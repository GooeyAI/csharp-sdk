using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record GenericErrorResponseDetail
{
    [JsonPropertyName("error")]
    public required string Error { get; init; }
}
