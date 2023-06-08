/*
 * Sdk.cs
 *
 *   Created: 2023-06-08-05:26:59
 *   Modified: 2023-06-08-05:27:00
 *
 *   Author: David G. Moore, Jr. <david@dgmjr.io>
 *
 *   Copyright © 2022 - 2023 David G. Moore, Jr., All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Net.Global;


public class Sdk
{
    public Sdk() { }
    [JProp("version")]
    public Version? Version { get; set; } = null;
    [JProp("versions")]
    public IDictionary<string, Version> Versions { get; set; } = new Dictionary<string, Version>();
}
