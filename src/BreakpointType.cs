using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// Tailwind CSS responsive breakpoints.
/// Values map directly to Tailwind utility prefixes.
/// </summary>
[EnumValue<string>]
public sealed partial class BreakpointType
{
    /// <summary>
    /// Base styles (mobile-first). Applies to all viewport sizes.
    /// </summary>
    public static readonly BreakpointType Base = new("");

    /// <summary>
    /// Small screens (sm). ≥640px.
    /// </summary>
    public static readonly BreakpointType Sm = new("sm");

    /// <summary>
    /// Medium screens (md). ≥768px.
    /// </summary>
    public static readonly BreakpointType Md = new("md");

    /// <summary>
    /// Large screens (lg). ≥1024px.
    /// </summary>
    public static readonly BreakpointType Lg = new("lg");

    /// <summary>
    /// Extra large screens (xl). ≥1280px.
    /// </summary>
    public static readonly BreakpointType Xl = new("xl");

    /// <summary>
    /// Extra extra large screens (2xl). ≥1536px.
    /// </summary>
    public static readonly BreakpointType Xxl = new("2xl");
}