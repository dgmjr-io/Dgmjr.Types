using System.Security.AccessControl;
using System;

namespace Dgmjr.Tuples;

/// <summary>
/// The uri string tuple.
/// </summary>
public abstract class UriStringTuple : Tuple<uri, string?>
{
    /// <summary>
    /// Gets the uri.
    /// </summary>
    public uri Uri => base.Item1;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriStringTuple" /> class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="value">The value.</param>
    protected UriStringTuple(uri uri, string? value)
        : base(uri, value) { }

    // /// <summary>
    // /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriStringTuple" /> class.
    // /// </summary>
    // /// <param name="uri">The uri.</param>
    // /// <param name="value">The value.</param>
    // protected UriStringTuple(Uri uri, string? value = null)
    //     : this((System.uri.From(uri), value))
    // {
    //     uri item;
    //     if (uri is not null)
    //     {
    //         string text = uri.ToString();
    //         item = ((text != null) ? TryCreateUriExtensions.CreateUri(text, false) : null);
    //     }
    // }

    // /// <summary>
    // /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriStringTuple" /> class.
    // /// </summary>
    // /// <param name="uri">The uri.</param>
    // /// <param name="value">The value.</param>
    // protected UriStringTuple(string? uri, string? value)
    //     : this((uri is not null) ? TryCreateUriExtensions.ToUri(uri) : null as uri?, value) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriStringTuple" /> class.
    /// </summary>
    /// <param name="tuple">The tuple.</param>
    protected UriStringTuple(UriStringTuple? tuple = null)
        : this((uri)(tuple?.Item1), tuple?.Item2) { }

    protected UriStringTuple((uri, string?)? tuple = null)
        : this((uri)(tuple?.Item1), tuple?.Item2) { }

    protected UriStringTuple((string?, string?)? tuple = null)
        : this(tuple?.Item1, tuple?.Item2) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Dgmjr.Tuples.UriStringTuple" /> class.
    /// </summary>
    protected UriStringTuple()
        : this((uri)null, (string?)null) { }

    public override bool Equals(object? obj)
    {
        return obj is UriStringTuple uriStringTuple
            && Uri == uriStringTuple.Uri
            && base.Item2 == uriStringTuple.Item2;
    }

    public override int GetHashCode()
    {
        return System.HashCode.Combine(Uri, base.Item2);
    }
}
