# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore
dotnet build --no-restore -warnaserror /p:RunAnalyzers=true
dotnet format --verify-no-changes             # check code style (CI enforces this)
dotnet format                                  # auto-fix code style
dotnet pack --configuration Release -p:PackageVersion=<version> --output .
```

There are no test or benchmark projects in this repository — the CI pipeline only builds and checks formatting.

## Architecture

This is an **interfaces-only NuGet library** — no implementations, no tests, no runtime dependencies beyond `Pure.Primitives.Abstractions`. Every file defines exactly one interface.

**Interface hierarchy:**

- `ISchema` — root container; holds a `Name` (`IString`), a collection of `ITable`, and a collection of `IForeignKey`
- `ITable` — holds a `Name` (`IString`), a collection of `IColumn`, and a collection of `IIndex`
- `IColumn` — holds a `Name` (`IString`) and an `IColumnType`
- `IColumnType` — holds a `Name` (`IString`) representing the engine-specific type name
- `IIndex` — holds an `IsUnique` (`IBool`) flag and a collection of `IColumn`
- `IForeignKey` — holds `ReferencingTable`/`ReferencingColumns` and `ReferencedTable`/`ReferencedColumns`

`IString` and `IBool` come from [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions) (v4.3.0). All string-typed names flow through `IString` so downstream code stays consistent with the rest of the Pure ecosystem.

**Multi-targeting:** net7.0, net8.0, net9.0, net10.0. All interfaces must remain AOT-compatible (`IsAotCompatible=true`).

**Package validation:** `EnablePackageValidation=true` with `PackageValidationBaselineVersion=1.2.0`. Breaking API changes fail the build.

**Publishing:** triggered by pushing a semver tag (pattern `*.*.*`). The tag name becomes the `PackageVersion`. The package is published to both GitHub Packages and NuGet.org.

## Code Style

Enforced via `.editorconfig` and `dotnet format --verify-no-changes` in CI. Non-obvious rules:

- No `var` — always use explicit types, even when the type is apparent.
- File-scoped namespaces (`namespace Foo.Bar;` not a block).
- Expression-bodied members for properties, accessors, and indexers; **not** for methods, constructors, or operators.
- No target-typed `new()` — always spell out the type (`new List<IColumn>()` not `new()`).
- `using` directives go **outside** the namespace.
- Allman braces — opening brace always on its own line.
- Max line length: 90 characters.
- Interfaces prefixed with `I`, generic type parameters prefixed with `T`, private fields prefixed with `_` (camelCase).
- System namespaces sorted first; no blank line between import groups.

## Commit Messages

Do not mention Claude or AI assistance in commit messages.
