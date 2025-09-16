using Intellenum;

namespace Soenneker.Quark.Enums.Breakpoints;

/// <summary>
/// An enumeration for Quark, representing common responsive breakpoints.
/// This enum contains standard CSS media query breakpoints for responsive design.
/// </summary>
[Intellenum<string>]
public sealed partial class Breakpoint
{
    public static readonly Breakpoint Default = new("");    // <576px, no infix
    public static readonly Breakpoint Small = new("sm");  // ≥576px
    public static readonly Breakpoint Medium = new("md");  // ≥768px
    public static readonly Breakpoint Large = new("lg");  // ≥992px
    public static readonly Breakpoint ExtraLarge = new("xl");  // ≥1200px
    public static readonly Breakpoint ExtraExtraLarge = new("xxl"); // ≥1400px

    public static Breakpoint Phone => Default;
    public static Breakpoint Tablet => Small;
    public static Breakpoint Laptop => Medium;
    public static Breakpoint Desktop => Large;
    public static Breakpoint Widescreen => ExtraLarge;
    public static Breakpoint Ultrawide => ExtraExtraLarge;
}