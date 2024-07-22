using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record FailedReponseModelV2
{
    [JsonPropertyName("detail")]
    public required FailedResponseDetail Detail { get; init; }
}
