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

public record struct Sdk
{
    public Sdk() { }
    [JProp("version")]
    public Version? Version { get; set; } = null;
    [JProp("versions")]
    public IDictionary<string, Version> Versions { get; set; } = new Dictionary<string, Version>();

    /// <summary>
    /// Specify information about the SDK
    /// </summary>
    [JProp("description"), JIgnore(Condition = JIgnoreCond.WhenWritingNull)]
    public string Description { get; set; }

    [JProp("allowPrerelease")]
    public bool AllowPrerelease { get; set; } = true;

    /// <summary>
    /// <inhertitdoc cref="Microsoft.Net.Global.RollForward" path="/summary" />
    /// </summary>
    [JProp("rollForward"), System.Text.Json.Serialization.]
    public RollForward RollForward { get; set; } = RollForward.Disable;
}
