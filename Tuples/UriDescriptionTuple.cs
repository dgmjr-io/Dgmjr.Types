using System;

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
    /// Initializes a new instance of the <see cref="UriDescriptionTuple"/>
    /// class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="description">The description.</param>
    protected UriDescriptionTuple(uri? uri, string? description = default) : base(uri, description) { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UriDescriptionTuple"/>
    /// class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="description">The description.</param>
    protected UriDescriptionTuple(Uri? uri, string? description = default) : base(uri, description) { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UriDescriptionTuple"/>
    /// class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="description">The description.</param>
    protected UriDescriptionTuple(string uri, string? description = default) : this(uri.ToUri(), description) { }
#if NETSTANDARD2_0_OR_GREATER
    protected UriDescriptionTuple((uri?, string?)? tuple = default) : base(tuple?.Item1, tuple?.Item2) { }
    protected UriDescriptionTuple((string?, string?)? tuple = default) : base(tuple?.Item1, tuple?.Item2) { }

#endif
    public static implicit operator string?(UriDescriptionTuple tuple) => tuple.Uri;
    public static implicit operator uri?(UriDescriptionTuple tuple) => tuple.Uri;

    public override bool Equals(object? obj)
    {
        return obj is UriDescriptionTuple tuple &&
            base.Equals(obj) &&
            System.Collections.Generic.EqualityComparer<uri?>.Default.Equals(Item1, tuple.Item1) &&
            Item2 == tuple.Item2 &&
            System.Collections.Generic.EqualityComparer<uri?>.Default.Equals(Uri, tuple.Uri) &&
            Description == tuple.Description;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Uri, Description);
    }
}
