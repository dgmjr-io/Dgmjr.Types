#if !NETSTANDARD2_1_OR_GREATER
namespace System.Diagnostics.CodeAnalysis;

/// <summary>Specifies that null is disallowed as an input even if the corresponding type allows it.</summary>
[AttributeUsage(
    AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property,
    Inherited = false
)]
public sealed class DisallowNullAttribute : Attribute { }
#else
[assembly: TypeForwardedTo(typeof(System.Diagnostics.CodeAnalysis.DisallowNullAttribute))]
#endif
