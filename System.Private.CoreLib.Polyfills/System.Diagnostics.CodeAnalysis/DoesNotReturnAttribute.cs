namespace System.Diagnostics.CodeAnalysis;

/// <summary>Applied to a method that will never return under any circumstance.</summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
[Conditional(global::System.Private.CoreLib.Polyfills.Constants.NOTNETSTANDARD21ORGREATER)]
internal sealed class DoesNotReturnAttribute : Attribute { }
