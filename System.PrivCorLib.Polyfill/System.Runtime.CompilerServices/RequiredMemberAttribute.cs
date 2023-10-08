namespace System.Runtime.CompilerServices;

/// <summary>Specifies that a type has required members or that a member is required.</summary>
[System.AttributeUsage(
    System.AttributeTargets.Class
        | System.AttributeTargets.Field
        | System.AttributeTargets.Property
        | System.AttributeTargets.Struct,
    AllowMultiple = false,
    Inherited = false
)]
internal sealed class RequiredMemberAttribute : Attribute { }
