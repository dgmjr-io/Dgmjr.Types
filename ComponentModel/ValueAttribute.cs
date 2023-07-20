//
// ValueAttribute.cs
//
//   Created: 2022-10-30-07:15:06
//   Modified: 2022-10-30-07:15:06
//
//   Author: David G. Mooore, Jr. <david@dgmjr.io>
//
//   Copyright © 2022-2023 David G. Mooore, Jr., All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//
namespace System.ComponentModel.DataAnnotations;
/// <summary>
/// Provides a base class for custom attributes that have a single value of type T.
/// </summary>
/// <typeparam name="T">The type of the attribute's value.</typeparam>
public abstract class ValueAttribute<T> : Attribute
{
    /// <summary>
    /// Initializes a new instance of the ValueAttribute class with the specified value.
    /// </summary>
    /// <param name="value">The value of the attribute.</param>
    public ValueAttribute(T value) => Value = value;

    /// <summary>
    /// Gets the value of the attribute.
    /// </summary>
    public T Value { get; }
}
