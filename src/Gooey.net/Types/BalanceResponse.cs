using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record BalanceResponse
{
    /// <summary>
    /// Current balance in credits
    /// </summary>
    [JsonPropertyName("balance")]
    public required int Balance { get; init; }
}
