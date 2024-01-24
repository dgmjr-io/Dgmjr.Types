#if !NET6_0_OR_GREATER
#region Assembly System.Private.CoreLib, Version=8.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e
// /usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.0-preview.5.23280.8/System.Private.CoreLib.dll
// Decompiled with ICSharpCode.Decompiler 7.2.1.6856
#endregion

namespace System.Resources;

public readonly struct ResourceLocator
{
    public int DataPosition { get; }

    public object? Value { get; }

    public ResourceLocator(int dataPos, object? value)
    {
        DataPosition = dataPos;
        Value = value;
    }

    public static bool CanCache(ResourceTypeCode value)
    {
        return value <= ResourceTypeCode.TimeSpan;
    }
}
#endif
