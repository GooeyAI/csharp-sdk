using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record SmartGptPageOutput
{
    [JsonPropertyName("output_text")]
    public IEnumerable<string> OutputText { get; init; } = new List<string>();

    [JsonPropertyName("prompt_tree")]
    public IEnumerable<PromptTreeNode>? PromptTree { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
