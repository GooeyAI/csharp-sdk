using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record BotBroadcastFilters
{
    /// <summary>
    /// A list of WhatsApp phone numbers to broadcast to.
    /// </summary>
    [JsonPropertyName("wa_phone_number__in")]
    public IEnumerable<string>? WaPhoneNumberIn { get; init; }

    /// <summary>
    /// A list of Slack user IDs to broadcast to.
    /// </summary>
    [JsonPropertyName("slack_user_id__in")]
    public IEnumerable<string>? SlackUserIdIn { get; init; }

    /// <summary>
    /// Filter by the Slack user's name. Case insensitive.
    /// </summary>
    [JsonPropertyName("slack_user_name__icontains")]
    public string? SlackUserNameIcontains { get; init; }

    /// <summary>
    /// Filter by whether the Slack channel is personal. By default, will broadcast to both public and personal slack channels.
    /// </summary>
    [JsonPropertyName("slack_channel_is_personal")]
    public bool? SlackChannelIsPersonal { get; init; }
}
