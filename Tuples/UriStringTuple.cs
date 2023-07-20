namespace Dgmjr.Tuples;
using System;

/// <summary>
/// The uri string tuple.
/// </summary>
public abstract class UriStringTuple : Tuple<uri?, string?>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UriStringTuple"/> class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="value">The value.</param>
    protected UriStringTuple(uri? uri = default, string? value = default) : base(uri, value) { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UriStringTuple"/> class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="value">The value.</param>
    protected UriStringTuple(Uri? uri = default, string? value = default) : base(uri?.ToString()?.CreateUri(false), value) { }
    /// <summary>
    /// Gets the uri.
    /// </summary>
    public uri? Uri => Item1;
    /// <summary>
    /// Initializes a new instance of the <see cref="UriStringTuple"/> class.
    /// </summary>
    /// <param name="uri">The uri.</param>
    /// <param name="value">The value.</param>
    protected UriStringTuple(string? uri = default, string? value = default) : this(uri?.ToUri(), value) { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UriStringTuple"/> class.
    /// </summary>
    /// <param name="tuple">The tuple.</param>
    protected UriStringTuple(UriStringTuple? tuple = default) : this(tuple?.Item1, tuple?.Item2) { }
#if NETSTANDARD2_0_OR_GREATER
    protected UriStringTuple((uri?, string?)? tuple = default) : this(tuple?.Item1, tuple?.Item2) { }
    protected UriStringTuple((string?, string?)? tuple = default) : this(tuple?.Item1, tuple?.Item2) { }
#endif
    /// <summary>
    /// Initializes a new instance of the <see cref="UriStringTuple"/> class.
    /// </summary>
    protected UriStringTuple() : this(null as uri, null as string) { }

    public override bool Equals(object obj)
    {
        return obj is UriStringTuple tuple &&
            Uri == tuple.Uri &&
            Item2 == tuple.Item2;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Uri, Item2);
    }
}
