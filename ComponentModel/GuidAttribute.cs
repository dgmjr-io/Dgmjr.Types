//
// GuidAttribute.cs
//
//   Created: 2022-10-19-05:58:09
//   Modified: 2022-10-30-07:16:07
//
//   Author: David G. Mooore, Jr. <david@dgmjr.io>
//
//   Copyright © 2022-2023 David G. Mooore, Jr., All Rights Reserved
//      License: MIT (https://opensource.org/licenses/MIT)
//

namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// A class that represents a Guid attribute.
/// </summary>
public sealed class GuidAttribute : ValueAttribute<Guid>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GuidAttribute"/> class
    /// using the specified string representation of a GUID.
    /// </summary>
    /// <param name="guid">A string representation of a GUID.</param>
    public GuidAttribute(string guid) : this(Guid.Parse(guid)) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="GuidAttribute"/> class
    /// using the specified GUID value.
    /// </summary>
    /// <param name="guid">A GUID value.</param>
    public GuidAttribute(Guid guid) : base(guid) { }

    /// <summary>
    /// Gets the GUID value represented by the current <see cref="GuidAttribute"/>.
    /// </summary>
    public Guid Guid => Value;
}
