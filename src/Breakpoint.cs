using Intellenum;

namespace Soenneker.Quark.Enums.Breakpoints;

/// <summary>
/// An enumeration for Quark, representing common responsive breakpoints.
/// This enum contains standard CSS media query breakpoints for responsive design.
/// </summary>
[Intellenum<string>]
public partial class Breakpoint
{
    /// <summary>
    /// Extra small devices (phones in portrait mode).
    /// Typically used for screens smaller than 576px.
    /// </summary>
    public static readonly Breakpoint ExtraSmall = new("xs");

    /// <summary>
    /// Small devices (phones in landscape mode).
    /// Typically used for screens 576px and up.
    /// </summary>
    public static readonly Breakpoint Small = new("sm");

    /// <summary>
    /// Medium devices (tablets).
    /// Typically used for screens 768px and up.
    /// </summary>
    public static readonly Breakpoint Medium = new("md");

    /// <summary>
    /// Large devices (desktops).  
    /// Typically used for screens 992px and up.
    /// </summary>
    public static readonly Breakpoint Large = new("lg");

    /// <summary>
    /// Extra large devices (large desktops).
    /// Typically used for screens 1200px and up.
    /// </summary>
    public static readonly Breakpoint ExtraLarge = new("xl");

    /// <summary>
    /// Extra extra large devices (larger desktops).
    /// Typically used for screens 1400px and up.
    /// </summary>
    public static readonly Breakpoint ExtraExtraLarge = new("xxl");

    /// <summary>
    /// Phone devices (mobile phones in portrait mode).
    /// Alternative name for extra small breakpoint.
    /// </summary>
    public static readonly Breakpoint Phone = new("phone");

    /// <summary>
    /// Tablet devices (tablets and small laptops).
    /// Alternative name for medium breakpoint.
    /// </summary>
    public static readonly Breakpoint Tablet = new("tablet");

    /// <summary>
    /// Laptop devices (laptops and small desktops).
    /// Alternative name for large breakpoint.
    /// </summary>
    public static readonly Breakpoint Laptop = new("laptop");

    /// <summary>
    /// Desktop devices (large desktops and monitors).
    /// Alternative name for extra large breakpoint.
    /// </summary>
    public static readonly Breakpoint Desktop = new("desktop");

    /// <summary>
    /// Mobile devices (phones and small tablets).
    /// Covers both portrait and landscape phone orientations.
    /// </summary>
    public static readonly Breakpoint Mobile = new("mobile");

    /// <summary>
    /// Handheld devices (phones and tablets).
    /// Covers mobile phones and tablets.
    /// </summary>
    public static readonly Breakpoint Handheld = new("handheld");

    /// <summary>
    /// Print media breakpoint.
    /// Used for print stylesheets.
    /// </summary>
    public static readonly Breakpoint Print = new("print");

    /// <summary>
    /// Screen media breakpoint.
    /// Used for screen-based media queries.
    /// </summary>
    public static readonly Breakpoint Screen = new("screen");

    /// <summary>
    /// All media types breakpoint.
    /// Used for media queries that apply to all media types.
    /// </summary>
    public static readonly Breakpoint All = new("all");

    /// <summary>
    /// Only screen media breakpoint.
    /// Used specifically for screen-based media queries excluding print.
    /// </summary>
    public static readonly Breakpoint OnlyScreen = new("only screen");

    /// <summary>
    /// Portrait orientation breakpoint.
    /// Used for devices in portrait orientation.
    /// </summary>
    public static readonly Breakpoint Portrait = new("portrait");

    /// <summary>
    /// Landscape orientation breakpoint.
    /// Used for devices in landscape orientation.
    /// </summary>
    public static readonly Breakpoint Landscape = new("landscape");
}
