# Pure.RelationalSchema.Abstractions

Immutable, composable interfaces for relational database schema metadata — part of the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.RelationalSchema.Abstractions/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.RelationalSchema.Abstractions/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.RelationalSchema.Abstractions/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.RelationalSchema.Abstractions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.RelationalSchema.Abstractions)](https://www.nuget.org/packages/Pure.RelationalSchema.Abstractions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.RelationalSchema.Abstractions` defines a minimal set of read-only interfaces for modelling relational database schemas. The interfaces represent the structural metadata of a database — schemas, tables, columns, column types, indexes, and foreign keys — without coupling to any specific database engine or ORM.

All names are expressed as `IString` from `Pure.Primitives.Abstractions`, keeping the type system consistent across the ecosystem.

## Interfaces

| Interface | Namespace | Description |
|-----------|-----------|-------------|
| `ISchema` | `Pure.RelationalSchema.Abstractions.Schema` | Root container — schema name, tables, and foreign keys |
| `ITable` | `Pure.RelationalSchema.Abstractions.Table` | Table — name, columns, and indexes |
| `IColumn` | `Pure.RelationalSchema.Abstractions.Column` | Column — name and data type |
| `IColumnType` | `Pure.RelationalSchema.Abstractions.ColumnType` | Column data type — name |
| `IIndex` | `Pure.RelationalSchema.Abstractions.Index` | Index — uniqueness flag (`IBool`) and covered columns |
| `IForeignKey` | `Pure.RelationalSchema.Abstractions.ForeignKey` | Foreign key — referencing and referenced table/column pairs |

## Design Principles

- **Immutable** — every member is a read-only property; there are no setters or mutating methods.
- **Composable** — interfaces compose through `IEnumerable<T>` collections, allowing traversal without committing to a concrete collection type.
- **AOT-compatible** — the library sets `IsAotCompatible=true` and contains no reflection or code generation.

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions/tree/4.3.0) — base interfaces for the Pure ecosystem — immutable, composable abstractions over .NET primitive types (`IString`, `IBool`, `INumber<T>`, and more).

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```bash
dotnet add package Pure.RelationalSchema.Abstractions
```

## Usage

```csharp
using Pure.RelationalSchema.Abstractions.Schema;
using Pure.RelationalSchema.Abstractions.Table;
using Pure.RelationalSchema.Abstractions.Column;

void PrintSchema(ISchema schema)
{
    Console.WriteLine(schema.Name.Value);

    foreach (ITable table in schema.Tables)
    {
        Console.WriteLine($"  {table.Name.Value}");

        foreach (IColumn column in table.Columns)
            Console.WriteLine($"    {column.Name.Value}  {column.Type.Name.Value}");
    }

    foreach (IForeignKey fk in schema.ForeignKeys)
    {
        Console.WriteLine(
            $"  FK: {fk.ReferencingTable.Name.Value} -> {fk.ReferencedTable.Name.Value}");
    }
}
```
