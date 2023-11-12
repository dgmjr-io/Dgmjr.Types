using System.Security.AccessControl;
using System;
using System.Collections.Generic;

namespace Dgmjr.Tuples;

/// <summary>
/// The uri description tuple.
/// </summary>
public abstract class UriDescriptionTuple : UriStringTuple
{
    /// <summary>
    /// Gets the description.
    /// </summary>
    public virtual string? Description => Item2;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriDescriptionTuple" />
    /// class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="description">The description.</param>
    protected UriDescriptionTuple(uri uri, string? description = null)
        : base(uri, description) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriDescriptionTuple" />
    /// class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="description">The description.</param>
    protected UriDescriptionTuple(Uri? uri, string? description = null)
        : base(System.uri.From(uri), description) { }

    // /// <summary>
    // /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriDescriptionTuple" />
    // /// class.
    // /// </summary>
    // /// <param name="uri">The uri.</param>
    // /// <param name="description">The description.</param>
    // protected UriDescriptionTuple(string uri, string? description = null)
    //     : this(TryCreateUriExtensions.ToUri(uri), description) { }

    protected UriDescriptionTuple((uri, string?)? tuple = null)
        : base((uri)(tuple?.Item1), tuple?.Item2) { }

    protected UriDescriptionTuple((string?, string?)? tuple = null)
        : base(tuple?.Item1, tuple?.Item2) { }

    public static implicit operator string?(UriDescriptionTuple tuple)
    {
        return tuple.Uri;
    }

    public static implicit operator uri(UriDescriptionTuple tuple)
    {
        return tuple.Uri;
    }

    public override bool Equals(object? obj)
    {
        return obj is UriDescriptionTuple uriDescriptionTuple
            && base.Equals(obj)
            && EqualityComparer<uri>.Default.Equals(base.Item1, uriDescriptionTuple.Item1)
            && base.Item2 == uriDescriptionTuple.Item2
            && EqualityComparer<uri>.Default.Equals(base.Uri, uriDescriptionTuple.Uri)
            && Description == uriDescriptionTuple.Description;
    }

    public override int GetHashCode()
    {
        return System.HashCode.Combine(base.Uri, Description);
    }
}
