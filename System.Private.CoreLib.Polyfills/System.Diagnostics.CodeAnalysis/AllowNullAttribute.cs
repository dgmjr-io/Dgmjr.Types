namespace System.Diagnostics.CodeAnalysis;

/// <summary>Specifies that null is allowed as an input even if the corresponding type disallows it.</summary>
[AttributeUsage(
    AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property,
    Inherited = false
)]
[Conditional(global::System.Private.CoreLib.Polyfills.Constants.NOTNETSTANDARD21ORGREATER)]
internal sealed class AllowNullAttribute : Attribute { }
