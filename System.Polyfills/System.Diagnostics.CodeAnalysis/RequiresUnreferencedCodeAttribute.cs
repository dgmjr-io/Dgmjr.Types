#if !NET5_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.All, Inherited = false)]
    public sealed class RequiresUnreferencedCodeAttribute(string message) : Attribute
    {
        public string Message => message;
}
}
#else
[assembly: TypeForwardedTo(
    typeof(System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute)
)]
#endif
