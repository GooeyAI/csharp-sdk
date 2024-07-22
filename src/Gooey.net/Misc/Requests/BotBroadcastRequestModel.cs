using Gooey.net;

#nullable enable

namespace Gooey.net;

public record BotBroadcastRequestModel
{
    public string? ExampleId { get; init; }

    public string? RunId { get; init; }

    /// <summary>
    /// Message to broadcast to all users
    /// </summary>
    public required string Text { get; init; }

    /// <summary>
    /// Audio URL to send to all users
    /// </summary>
    public string? Audio { get; init; }

    /// <summary>
    /// Video URL to send to all users
    /// </summary>
    public string? Video { get; init; }

    /// <summary>
    /// Video URL to send to all users
    /// </summary>
    public IEnumerable<string>? Documents { get; init; }

    /// <summary>
    /// Buttons to send to all users
    /// </summary>
    public IEnumerable<ReplyButton>? Buttons { get; init; }

    /// <summary>
    /// Filters to select users to broadcast to. If not provided, will broadcast to all users of this bot.
    /// </summary>
    public BotBroadcastFilters? Filters { get; init; }
}
