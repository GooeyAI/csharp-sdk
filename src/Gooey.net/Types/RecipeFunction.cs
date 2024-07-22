using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record RecipeFunction
{
    /// <summary>
    /// The URL of the [function](https://gooey.ai/functions) to call.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>
    /// When to run this function. `pre` runs before the recipe, `post` runs after the recipe.
    /// </summary>
    [JsonPropertyName("trigger")]
    public required Trigger Trigger { get; init; }
}
