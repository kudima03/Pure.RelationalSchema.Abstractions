using Pure.Primitives.Abstractions.String;
using Pure.RelationalSchema.Abstractions.ColumnType;

namespace Pure.RelationalSchema.Abstractions.Column;

public interface IColumn
{
    IString Name { get; }

    IColumnType Type { get; }
}