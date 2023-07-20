using System;
//
// UriAttribute.cs
//
//   Created: 2022-10-16-10:50:42
//   Modified: 2022-10-30-07:14:23
//
//   Author: David G. Mooore, Jr. <david@dgmjr.io>
//
//   Copyright © 2022-2023 David G. Mooore, Jr., All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Attribute that can be applied to properties, fields, and parameters. Allows multiple instances of the attribute to be used on a single target.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
public sealed class UriAttribute : ValueAttribute<Uri>
{
    /// <summary>
    /// Initializes a new instance of the UriAttribute class with a specified Uri parameter and passes it to the base constructor.
    /// </summary>
    /// <param name="uri">The Uri value.</param>
    public UriAttribute(Uri uri) : base(uri) { }

    /// <summary>
    /// Initializes a new instance of the UriAttribute class with a specified string parameter representing a URI. It creates a new instance of Uri using the string parameter and passes it to the base constructor.
    /// </summary>
    /// <param name="uri">The string representation of the Uri value.</param>
    public UriAttribute(string uri) : this(new Uri(uri)) { }

    /// <summary>
    /// Gets the value of the URI stored in the base class's "Value" property.
    /// </summary>
    public Uri Uri => Value;
}
