#if !NETSTANDARD2_1_OR_GREATER
namespace System.Diagnostics.CodeAnalysis;

/// <summary>Specifies that an output may be null even if the corresponding type disallows it.</summary>
[AttributeUsage(
    AttributeTargets.Field
        | AttributeTargets.Parameter
        | AttributeTargets.Property
        | AttributeTargets.ReturnValue,
    Inherited = false
)]
public sealed class MaybeNullAttribute : Attribute { }
#else
[assembly: TypeForwardedTo(typeof(System.Diagnostics.CodeAnalysis.MaybeNullAttribute))]
#endif
