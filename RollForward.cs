namespace Microsoft.Net.Global;

/// <summary>
/// The roll-forward policy when selecting an SDK version, either as a fallback to accommodate missing a specific SDK version or as a directive to use a later version.
/// </summary>
public enum RollForward
{
    Disable = 0,
    Patch = 1,
    Feature,
    Minor,
    Major,
    LatestPatch,
    LatestFeature,
    LatestMinor,
    LatestMajor,
}
