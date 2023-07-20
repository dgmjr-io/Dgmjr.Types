/* 
 * EnumValueAttribute.cs
 * 
 *   Created: 2023-04-01-03:29:38
 *   Modified: 2023-04-01-03:29:38
 * 
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *   
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */
namespace System.ComponentModel.DataAnnotations;
/// <summary>
/// Attribute to store a custom value for an enum member.
/// </summary>
public class EnumValueAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EnumValueAttribute"/> class with a string value.
    /// </summary>
    /// <param name="value">The custom value to be associated with the enum member.</param>
    public EnumValueAttribute(string value)
    {
        Value = value;
    }

    /// <summary>
    /// Gets the custom value associated with the enum member.
    /// </summary>
    public string Value { get; }
}
