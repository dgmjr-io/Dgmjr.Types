#if !NET7_0_OR_GREATER
namespace System.Runtime.CompilerServices;

/// <summary>
/// Indicates that compiler support for a particular feature is required for the location where this attribute is applied.
/// </summary>
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
public sealed class CompilerFeatureRequiredAttribute(string? featureName, bool isOptional)
    : Attribute
{
    public CompilerFeatureRequiredAttribute(string? featureName)
        : this(featureName, false) { }

    public CompilerFeatureRequiredAttribute()
        : this(null) { }

    /// <summary>
    /// The <see cref="FeatureName"/> used for the ref structs C# feature.
    /// </summary>
    public const string RefStructs = nameof(RefStructs);

    /// <summary>
    /// The <see cref="FeatureName"/> used for the required members C# feature.
    /// </summary>
    public const string RequiredMembers = nameof(RequiredMembers);

    /// <summary>
    /// The name of the compiler feature.
    /// </summary>
    public string FeatureName { get; } = featureName;

    /// <summary>
    /// If <see langword="true" />, the compiler can choose to allow access to the location where this attribute is applied if it does not understand <see cref="FeatureName"/>.
    /// </summary>
    public bool IsOptional { get; init; } = isOptional;
}
#else
[assembly: TypeForwardedTo(
    typeof(System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute)
)]
#endif
