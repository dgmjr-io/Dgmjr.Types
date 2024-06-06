#if !NETSTANDARD2_1_OR_GREATER
namespace System.Diagnostics.CodeAnalysis;

/// <summary>Specifies that an output will not be null even if the corresponding type allows it. Specifies that an input argument was not null when the call returns.</summary>
[AttributeUsage(
    AttributeTargets.Field
        | AttributeTargets.Parameter
        | AttributeTargets.Property
        | AttributeTargets.ReturnValue,
    Inherited = false
)]
public sealed class NotNullAttribute() : Attribute
{
    /// <summary>
    /// Initializes the attribute with the specified return value condition.
    /// </summary>
    /// <param name="returnValue">The return value condition. If the method
    ///     returns this value, the associated parameter will not be null.
    ///     </param>
    public NotNullAttribute(bool returnValue)
        : this() => ReturnValue = returnValue;

/// <summary>
/// Gets the return value condition.
/// </summary>
public bool ReturnValue { get; }
}
#else
[assembly: TypeForwardedTo(typeof(System.Diagnostics.CodeAnalysis.NotNullAttribute))]
#endif
