namespace System.Diagnostics.CodeAnalysis;

/// <summary>Specifies that null is disallowed as an input even if the corresponding type allows it.</summary>
[AttributeUsage(
    AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property,
    Inherited = false
)]
[Conditional(global::System.Private.CoreLib.Polyfills.Constants.NOTNETSTANDARD21ORGREATER)]
internal sealed class DisallowNullAttribute : Attribute { }
