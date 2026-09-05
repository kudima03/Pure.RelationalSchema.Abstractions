# Changelog

All notable changes to Pure.RelationalSchema.Abstractions are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [1.2.0] — 2026-12-01

### Changed

- Now multi-targets `net7.0`, `net8.0`, `net9.0`, and `net10.0` (previously
  `net9.0` only).

## [1.1.0] — 2025-11-02

### Changed

- The package now declares `IsAotCompatible=true`, replacing the separate
  trim/AOT analyzer flags, and continues to advertise NativeAOT compatibility
  to consumers.

## [1.0.0] — 2025-09-26

- Promoted the `1.0.0-preview.0.1.0` release to stable `1.0.0`; no further
  code changes.

## [1.0.0-preview.0.1.0] — 2025-09-26

### Changed

- **Breaking:** `IForeignKey.ReferencingColumn` and
  `IForeignKey.ReferencedColumn` (single `IColumn`) replaced by
  `ReferencingColumns` and `ReferencedColumns` (`IEnumerable<IColumn>`),
  enabling composite foreign keys.

### Added

- The package is now marked trim- and NativeAOT-analyzer compatible
  (`IsTrimmable`, `EnableTrimAnalyzer`, `EnableAotAnalyzer`).

## [0.2.1] — 2025-08-22

- Maintenance release: dependency and build updates.

## [0.2.0] — 2025-08-21

### Added

- `IColumnType.Name` is now a public property (previously accessible only
  as an internal member).

## [0.1.3] — 2025-06-24

- Maintenance release: dependency and build updates.

## [0.1.2] — 2025-06-24

- Maintenance release: dependency and build updates.

## [0.1.1] — 2025-06-24

- Maintenance release: dependency and build updates.

## [0.1.0] — 2025-06-23

### Added

- Initial release: read-only interfaces for modelling relational database
  schema metadata.
- `ISchema` — schema name, `Tables`, and `ForeignKeys`.
- `ITable` — table name, `Columns`, and `Indexes`.
- `IColumn` — column name and `IColumnType`.
- `IColumnType` — column type name (internal member).
- `IIndex` — uniqueness flag (`IBool`) and covered `Columns`.
- `IForeignKey` — referencing and referenced table/column pairs.
- All names are expressed as `IString` from `Pure.Primitives.Abstractions`.
