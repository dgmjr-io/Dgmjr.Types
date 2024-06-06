#if !NETSTANDARD2_1_OR_GREATER
namespace System.Diagnostics.CodeAnalysis;

/// <summary>Specifies that null is allowed as an input even if the corresponding type disallows it.</summary>
[AttributeUsage(
    AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property,
    Inherited = false
)]
public sealed class AllowNullAttribute : Attribute { }
#else
[assembly: TypeForwardedTo(typeof(System.Diagnostics.CodeAnalysis.AllowNullAttribute))]
#endif
