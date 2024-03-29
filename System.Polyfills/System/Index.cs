#if NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER

#if POLYKIT_PUBLIC
[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Index))]
#endif

#elif POLYKIT_USE_VALUETUPLE

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

#pragma warning disable CA1305 // Specify IFormatProvider - Preserving original code.
#pragma warning disable CA1815 // Override equals and operator equals on value types - Preserving original code.
#pragma warning disable CA2225 // Operator overloads have named alternates - Preserving original code.
#pragma warning disable CA2231 // Overload operator equals on overriding value type Equals - Preserving original code.
#pragma warning disable SA1201 // Elements should appear in the correct order - Preserving original code.
#pragma warning disable SA1623 // Property summary documentation should match accessors - Copied from dotnet/runtime.
#pragma warning disable SA1642 // Constructor summary documentation should begin with standard text - Copied from dotnet/runtime.

// https://github.com/dotnet/runtime/blob/v8.0.0/src/libraries/System.Private.CoreLib/src/System/Index.cs

/// <summary>
/// Represent a type can be used to index a collection either from the start or the end.
/// </summary>
/// <remarks>
/// Index is used by the C# compiler to support the index syntax.
/// <code>
/// int[] someArray = new int[5] { 1, 2, 3, 4, 5 } ;
/// int lastElement = someArray[^1]; // lastElement = 5
/// </code>
/// </remarks>
public // polyfill!
readonly struct Index : IEquatable<Index>
{
    private readonly int _value;

    /// <summary>
    /// Construct an Index using a value and indicating if the index is from the start or from the end.
    /// </summary>
    /// <param name="value">The index value. it has to be zero or positive number.</param>
    /// <param name="fromEnd">Indicating if the index is from the start or from the end.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> is negative.</exception>
    /// <remarks>
    /// If the Index constructed from the end, index value 1 means pointing at the last element and index value 0 means pointing at beyond last element.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Index(int value, bool fromEnd = false)
    {
        if (value < 0)
        {
            ThrowValueArgumentOutOfRange_NeedNonNegNumException();
        }

        _value = fromEnd ? ~value : value;
    }

    // The following private constructors mainly created for perf reason to avoid the checks
    private Index(int value)
    {
        _value = value;
    }

    /// <summary>
    /// Create an Index pointing at first element.
    /// </summary>
    public static Index Start => new(0);

    /// <summary>
    /// Create an Index pointing at beyond last element.
    /// </summary>
    public static Index End => new(~0);

    /// <summary>
    /// Create an Index from the start at the position indicated by the value.
    /// </summary>
    /// <param name="value">The index value from the start.</param>
    /// <returns>A newly-created Index.</returns>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> is negative.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Index FromStart(int value)
    {
        if (value < 0)
        {
            ThrowValueArgumentOutOfRange_NeedNonNegNumException();
        }

        return new Index(value);
    }

    /// <summary>
    /// Create an Index from the end at the position indicated by the value.
    /// </summary>
    /// <param name="value">The index value from the end.</param>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="value"/> is negative.</exception>
    /// <returns>A newly-created Index.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Index FromEnd(int value)
    {
        if (value < 0)
        {
            ThrowValueArgumentOutOfRange_NeedNonNegNumException();
        }

        return new Index(~value);
    }

    /// <summary>
    /// Gets the index value.
    /// </summary>
    public int Value =>
        _value switch
        {
            < 0 => ~_value,
            _ => _value,
        };

    /// <summary>Indicates whether the index is from the start or the end.</summary>
    public bool IsFromEnd => _value < 0;

    /// <summary>
    /// Calculate the offset from the start using the giving collection length.
    /// </summary>
    /// <param name="length">The length of the collection that the Index will be used with.
    /// This has to be a positive value.</param>
    /// <returns>The offset from the start of the collection.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public int GetOffset(int length)
    {
        var offset = _value;
        if (IsFromEnd)
        {
            // offset = length - (~value)
            // offset = length + (~(~value) + 1)
            // offset = length + value + 1
            offset += length + 1;
        }

        return offset;
    }

    /// <summary>
    /// Indicates whether the current Index object is equal to another object of the same type.
    /// </summary>
    /// <param name="obj">An object to compare with this object.</param>
    /// <returns><see langword="true"/> if the objects are equal;
    /// otherwise, <see langword="false"/>.</returns>
    public override bool Equals([NotNullWhen(true)] object? obj) =>
        obj is Index other && _value == other._value;

    /// <summary>
    /// Indicates whether the current Index object is equal to another Index object.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true"/> if the objects are equal;
    /// otherwise, <see langword="false"/>.</returns>
    public bool Equals(Index other) => _value == other._value;

    /// <summary>
    /// Returns the hash code for this instance.
    /// </summary>
    /// <returns>The hash code.</returns>
    public override int GetHashCode() => _value;

    /// <summary>
    /// Converts an integer number to an Index.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    public static implicit operator Index(int value) => FromStart(value);

    /// <summary>
    /// Converts the value of the current Index object to its equivalent string representation.
    /// </summary>
    /// <returns>A string representation of the current instance.</returns>
    public override string ToString() =>
        IsFromEnd ? '^' + Value.ToString() : ((uint)Value).ToString();

    private static void ThrowValueArgumentOutOfRange_NeedNonNegNumException()
    {
        throw new ArgumentOutOfRangeException("value", "Non-negative number required.");
    }
}

#endif
