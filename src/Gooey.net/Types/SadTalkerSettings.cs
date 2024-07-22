using System.Text.Json.Serialization;
using Gooey.net;

#nullable enable

namespace Gooey.net;

public record SadTalkerSettings
{
    [JsonPropertyName("still")]
    public bool? Still { get; init; }

    /// <summary>
    /// SadTalker only generates 512x512 output. 'crop' handles this by cropping the input to 512x512. 'resize' scales down the input to fit 512x512 and scales it back up after lipsyncing (does not work well for full person images, better for portraits). 'full' processes the cropped region and pastes it back into the original input. 'extcrop' and 'extfull' are similar to 'crop' and 'full' but with extended cropping.
    /// </summary>
    [JsonPropertyName("preprocess")]
    public Preprocess? Preprocess { get; init; }

    /// <summary>
    /// Random seed 0-45 inclusive that affects how the pose is animated.
    /// </summary>
    [JsonPropertyName("pose_style")]
    public int? PoseStyle { get; init; }

    /// <summary>
    /// Scale the amount of expression motion. 1.0 is normal, 0.5 is very reduced, and 2.0 is quite a lot.
    /// </summary>
    [JsonPropertyName("expression_scale")]
    public double? ExpressionScale { get; init; }

    /// <summary>
    /// Optional reference video for eyeblinks to make the eyebrow movement more natural.
    /// </summary>
    [JsonPropertyName("ref_eyeblink")]
    public string? RefEyeblink { get; init; }

    /// <summary>
    /// Optional reference video to pose the head.
    /// </summary>
    [JsonPropertyName("ref_pose")]
    public string? RefPose { get; init; }

    [JsonPropertyName("input_yaw")]
    public IEnumerable<int>? InputYaw { get; init; }

    [JsonPropertyName("input_pitch")]
    public IEnumerable<int>? InputPitch { get; init; }

    [JsonPropertyName("input_roll")]
    public IEnumerable<int>? InputRoll { get; init; }
}
