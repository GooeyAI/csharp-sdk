namespace Gooey.net;

public record StatusGoogleGptRequest
{
    public required string RunId { get; init; }
}
