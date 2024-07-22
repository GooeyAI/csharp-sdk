using System.Text.Json.Serialization;

#nullable enable

namespace Gooey.net;

public record CreateStreamResponse
{
    /// <summary>
    /// The URL to stream the conversation. Use Server-Sent Events (SSE) to stream the response.
    /// </summary>
    [JsonPropertyName("stream_url")]
    public required string StreamUrl { get; init; }
}
