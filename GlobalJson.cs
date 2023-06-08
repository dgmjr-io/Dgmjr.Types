/* This code defines a C# record struct named `Json` in the `Microsoft.Net.Global` namespace. The
struct has four properties: `Sdk`, `ProjectSdks`, `Projects`, and `Tools`, each of which is an
`IDictionary` with a specific key and value type. The `Json` struct also has a constructor that
initializes all properties to their default values. Additionally, the `JProp` attribute is used to
specify the JSON property name for each property. The `using` statements import the necessary
namespaces for the code to compile. */
namespace Microsoft.Net.Global;

using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using static System.String;

/* This code is defining a C# record struct named `Json` in the `Microsoft.Net.Global` namespace. The
struct has four properties: `Sdk`, `ProjectSdks`, `Projects`, and `Tools`, each of which is an
`IDictionary` with a specific key and value type. The `Json` struct also has a constructor that
initializes all properties to their default values. Additionally, the `JProp` attribute is used to
specify the JSON property name for each property. */
public record struct Json
{
    public Json() { }
    [JProp("sdk")]
    public Sdk? Sdk { get; set; } = null;
    [JProp("msbuild-sdks")]
    public IDictionary<string, Version> ProjectSdks { get; set; } = new Dictionary<string, Version>();
    [JProp("projects")]
    public IDictionary<string, DirectoryInfo> Projects { get; set; } = new Dictionary<string, DirectoryInfo>();
    [JProp("tools")]
    public IDictionary<string, Version> Tools { get; set; } = new Dictionary<string, Version>();
}
