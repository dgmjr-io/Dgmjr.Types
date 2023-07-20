using System;
namespace System.ComponentModel.DataAnnotations;

/// <summary>
/// Attribute that stores an array of synonyms for a given value. 
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false)]
public sealed class SynonymsAttribute : ValueAttribute<string[]>
{
    /// <summary>
    /// Initializes a new instance of the SynonymsAttribute class with a specified array of string parameters and passes it to the base constructor.
    /// </summary>
    /// <param name="synonyms">The array of synonyms.</param>
    public SynonymsAttribute(params string[] synonyms) : base(synonyms)
    {

    }

    /// <summary>
    /// Gets the array of synonyms stored in the base class's "Value" property.
    /// </summary>
    public string[] Synonyms => Value;
}
