// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// From https://github.com/dotnet/runtime/blob/5da4a9e919dcee35f831ab69b6e475baaf798875/src/libraries/System.Private.CoreLib/src/System/Runtime/CompilerServices/CallerArgumentExpressionAttribute.cs

#if !NETCOREAPP3_0_OR_GREATER
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
public sealed class CallerArgumentExpressionAttribute : Attribute
{
    public CallerArgumentExpressionAttribute(string parameterName)
    {
        ParameterName = parameterName;
    }

    public string ParameterName { get; }
}
#else
[assembly: TypeForwardedTo(
    typeof(System.Runtime.CompilerServices.CallerArgumentExpressionAttribute)
)]
#endif
