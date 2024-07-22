namespace Gooey.net;

public record StatusTextToSpeechRequest
{
    public required string RunId { get; init; }
}
