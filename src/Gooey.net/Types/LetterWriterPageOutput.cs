using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record LetterWriterPageOutput
{
    [JsonPropertyName("output_letters")]
    public IEnumerable<string> OutputLetters { get; init; } = new List<string>();

    [JsonPropertyName("response_json")]
    public object? ResponseJson { get; init; }

    [JsonPropertyName("generated_input_prompt")]
    public required string GeneratedInputPrompt { get; init; }

    [JsonPropertyName("final_prompt")]
    public required string FinalPrompt { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
