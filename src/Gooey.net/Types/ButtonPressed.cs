using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record ButtonPressed
{
    /// <summary>
    /// The ID of the button that was pressed by the user
    /// </summary>
    [JsonPropertyName("button_id")]
    public required string ButtonId { get; init; }

    /// <summary>
    /// The message ID of the context message on which the button was pressed
    /// </summary>
    [JsonPropertyName("context_msg_id")]
    public required string ContextMsgId { get; init; }
}
