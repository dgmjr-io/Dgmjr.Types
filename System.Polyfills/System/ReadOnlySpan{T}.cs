// #if !NETSTANDARD2_1_OR_GREATER
// using System.Collections;

// namespace System;

// public struct ReadOnlySpan<T> : IEnumerable<T>
// {
//     private readonly T[] array;
//     private readonly int start;
//     private readonly int length;

//     public ReadOnlySpan(T[] array)
//     {
//         this.array = array;
//         start = 0;
//         length = array.Length;
//     }

//     public T this[int index] => array[start + index];

//     public ReadOnlySpan<T> Slice(int start) => default;

//     public ReadOnlySpan<T> Slice(int start, int length) => default;

//     public IEnumerator<T> GetEnumerator() => throw new NotImplementedException();

//     IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
// }

// public static class ReadOnlySpanExtensions
// {
//     public static ReadOnlySpan<T> Slice<T>(this ReadOnlySpan<T> span, int start) => default;

//     public static ReadOnlySpan<T> Slice<T>(this ReadOnlySpan<T> span, int start, int length) =>
//         default;

//     public static ReadOnlySpan<char> AsSpan(this string s) => new ReadOnlySpan<char>();
// }
// #else
// [assembly: TypeForwardedTo(typeof(System.ReadOnlySpan<>))]
// #endif
