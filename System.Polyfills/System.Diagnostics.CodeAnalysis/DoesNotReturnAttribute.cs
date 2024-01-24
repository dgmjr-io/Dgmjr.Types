#if !NETSTANDARD2_1_OR_GREATER
namespace System.Diagnostics.CodeAnalysis;

/// <summary>Applied to a method that will never return under any circumstance.</summary>
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public sealed class DoesNotReturnAttribute : Attribute { }
#endif
