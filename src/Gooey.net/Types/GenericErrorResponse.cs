using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record GenericErrorResponse
{
    [JsonPropertyName("detail")]
    public required GenericErrorResponseDetail Detail { get; init; }
}
