namespace System.Diagnostics.CodeAnalysis;

/// <summary>Specifies that an output may be null even if the corresponding type disallows it.</summary>
[AttributeUsage(
    AttributeTargets.Field
        | AttributeTargets.Parameter
        | AttributeTargets.Property
        | AttributeTargets.ReturnValue,
    Inherited = false
)]
[Conditional(global::System.Private.CoreLib.Polyfills.Constants.NOTNETSTANDARD21ORGREATER)]
public sealed class MaybeNullAttribute : Attribute { }
