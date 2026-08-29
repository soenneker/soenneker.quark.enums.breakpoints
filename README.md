[![](https://img.shields.io/nuget/v/soenneker.quark.enums.breakpoints.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.breakpoints/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.breakpoints/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.breakpoints/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.breakpoints.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.breakpoints/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.breakpoints/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.breakpoints/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.Breakpoints

Tailwind CSS responsive breakpoints. Values map directly to Tailwind utility prefixes.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.Breakpoints
```

## What you get

- `BreakpointType` — Tailwind CSS responsive breakpoints. Values map directly to Tailwind utility prefixes.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `BreakpointType.Base` | Base styles (mobile-first). Applies to all viewport sizes. | Base styles (mobile-first). Applies to all viewport sizes. |
| `BreakpointType.Xxl` | Extra extra large screens (2xl). ≥1536px. | Extra extra large screens (2xl). ≥1536px. |
