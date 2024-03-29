namespace System.Diagnostics.CodeAnalysis;

[global::System.AttributeUsage(
    AttributeTargets.Constructor,
    AllowMultiple = false,
    Inherited = false
)]
public sealed class SetsRequiredMembersAttribute(params string[] members) : Attribute
{
    public string[] Members { get; } = members;

    public SetsRequiredMembersAttribute()
        : this(null as string[]) { }

    public SetsRequiredMembersAttribute(string members)
        : this(new[] { members }) { }
}
