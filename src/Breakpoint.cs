using Intellenum;

namespace Soenneker.Quark.Enums.Breakpoints;

/// <summary>
/// An enumeration for Quark, representing common responsive breakpoints.
/// This enum contains standard CSS media query breakpoints for responsive design.
/// </summary>
[Intellenum<string>]
public sealed partial class Breakpoint
{
    /// <summary>
    /// Default breakpoint. Applies to all viewport sizes (no media query).
    /// </summary>
    public static readonly Breakpoint Phone = new("");

    /// <summary>
    /// Small breakpoint (<c>sm</c>). Applies at <c>≥576px</c>.
    /// Typically used for portrait phones and small devices.
    /// </summary>
    public static readonly Breakpoint Tablet = new("sm");

    /// <summary>
    /// Medium breakpoint (<c>md</c>). Applies at <c>≥768px</c>.
    /// Typically used for tablets and small laptops.
    /// </summary>
    public static readonly Breakpoint Laptop = new("md");

    /// <summary>
    /// Large breakpoint (<c>lg</c>). Applies at <c>≥992px</c>.
    /// Typically used for desktops with standard resolutions.
    /// </summary>
    public static readonly Breakpoint Desktop = new("lg");

    /// <summary>
    /// Extra large breakpoint (<c>xl</c>). Applies at <c>≥1200px</c>.
    /// Typically used for widescreen desktops and larger displays.
    /// </summary>
    public static readonly Breakpoint Widescreen = new("xl");

    /// <summary>
    /// Extra extra large breakpoint (<c>xxl</c>). Applies at <c>≥1400px</c>.
    /// Typically used for very large desktops and ultrawide displays.
    /// </summary>
    public static readonly Breakpoint Ultrawide = new("xxl");
}