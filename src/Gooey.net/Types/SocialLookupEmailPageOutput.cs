using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record SocialLookupEmailPageOutput
{
    [JsonPropertyName("person_data")]
    public Dictionary<string, object> PersonData { get; init; } = new Dictionary<string, object>();

    [JsonPropertyName("final_prompt")]
    public required string FinalPrompt { get; init; }

    [JsonPropertyName("output_text")]
    public IEnumerable<string> OutputText { get; init; } = new List<string>();

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
