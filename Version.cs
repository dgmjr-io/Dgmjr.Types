namespace Microsoft.Net.Global;

[RegexDto("(?<Major:int>\\d+)\\.(?<Minor:int>\\d+)\\.(?<Build:int>\\d+)(\\.(?<Revision:int>\\d+))?(?:-(?<Suffix>.+))?(\\+(?<Metadata>.+))?")]
public partial record struct Version
{
    public Version(System.Version sysVersion)
    {
        this.Major = sysVersion.Major;
        this.Minor = sysVersion.Minor;
        this.Build = sysVersion.Build;
        this.Revision = sysVersion.Revision;
    }

    public Version(int major, int minor, int build, int revision)
    {
        this.Major = major;
        this.Minor = minor;
        this.Build = build;
        this.Revision = revision;
    }

    public Version(int major, int minor, int build, int revision, string suffix, string metadata)
    {
        this.Major = major;
        this.Minor = minor;
        this.Build = build;
        this.Revision = revision;
        this.Suffix = suffix;
        this.Metadata = metadata;
    }

    public readonly bool IsPreRelease => !IsNullOrWhiteSpace(this.Suffix);

    public static implicit operator Version(System.Version sysVersion) => new(sysVersion);
    public static implicit operator System.Version(Version version) => new(version.Major, version.Minor, version.Build, version.Revision);
}
