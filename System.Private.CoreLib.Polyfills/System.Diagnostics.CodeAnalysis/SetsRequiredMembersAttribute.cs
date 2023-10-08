namespace System.Diagnostics.CodeAnalysis;

[System.AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
internal sealed class SetsRequiredMembersAttribute(params string[] members) : Attribute
{
    public SetsRequiredMembersAttribute()
        : this(null as string[]) { }

public SetsRequiredMembersAttribute(string members)
    : this(new[] { members }) { }
}
