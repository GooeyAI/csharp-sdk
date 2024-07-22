using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record RunSettings
{
    /// <summary>
    /// Policy for retaining the run data.
    /// </summary>
    [JsonPropertyName("retention_policy")]
    public RunSettingsRetentionPolicy? RetentionPolicy { get; init; }
}
