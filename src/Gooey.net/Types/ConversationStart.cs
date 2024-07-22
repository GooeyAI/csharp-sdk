using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record ConversationStart
{
    /// <summary>
    /// The conversation ID you provided in the request, or a random ID if not provided
    /// </summary>
    [JsonPropertyName("conversation_id")]
    public required string ConversationId { get; init; }

    /// <summary>
    /// The user ID associated with this conversation
    /// </summary>
    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    /// <summary>
    /// The user message ID you provided in the request, or a random ID if not provided.
    /// </summary>
    [JsonPropertyName("user_message_id")]
    public required string UserMessageId { get; init; }

    /// <summary>
    /// The bot message ID. Use this ID as the `context_msg_id` when sending a `button_pressed`.
    /// </summary>
    [JsonPropertyName("bot_message_id")]
    public required string BotMessageId { get; init; }

    /// <summary>
    /// Time when the conversation was created as ISO format
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// The conversation was started. Save the IDs for future requests.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
