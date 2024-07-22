using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record HttpValidationError
{
    [JsonPropertyName("detail")]
    public IEnumerable<ValidationError>? Detail { get; init; }
}
