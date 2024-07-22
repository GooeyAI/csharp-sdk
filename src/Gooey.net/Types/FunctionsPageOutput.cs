using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record FunctionsPageOutput
{
    [JsonPropertyName("return_value")]
    public object? ReturnValue { get; init; }

    /// <summary>
    /// JS Error from the code. If there are no errors, this will be null
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; init; }

    /// <summary>
    /// Console logs from the code execution
    /// </summary>
    [JsonPropertyName("logs")]
    public IEnumerable<ConsoleLogs>? Logs { get; init; }

    [JsonPropertyName("called_functions")]
    public IEnumerable<CalledFunctionResponse>? CalledFunctions { get; init; }
}
