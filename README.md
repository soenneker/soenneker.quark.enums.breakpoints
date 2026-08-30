[![](https://img.shields.io/nuget/v/soenneker.quark.enums.breakpoints.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.breakpoints/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.breakpoints/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.breakpoints/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.breakpoints/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.breakpoints/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.breakpoints.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.breakpoints/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.breakpoints/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.breakpoints/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Breakpoints

Strongly named Tailwind responsive breakpoint tokens for Quark builders and component APIs.

## Installation

```bash
dotnet add package Soenneker.Quark.Enums.Breakpoints
```

## Usage

```csharp
using Soenneker.Quark;

BreakpointType breakpoint = BreakpointType.Md;
string prefix = breakpoint.Value;
// md

string responsiveClass = $"{breakpoint.Value}:grid";
// md:grid
```

| Value | Token | Default minimum width |
| --- | --- | --- |
| `BreakpointType.Base` | empty | All viewport sizes |
| `BreakpointType.Sm` | `sm` | 640px |
| `BreakpointType.Md` | `md` | 768px |
| `BreakpointType.Lg` | `lg` | 1024px |
| `BreakpointType.Xl` | `xl` | 1280px |
| `BreakpointType.Xxl` | `2xl` | 1536px |

The widths are Tailwind's default breakpoints; a customized Tailwind theme can assign different CSS values to the same tokens. `Base.Value` is empty because mobile-first base utilities have no prefix.
