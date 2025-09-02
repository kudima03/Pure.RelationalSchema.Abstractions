using Pure.Primitives.Abstractions.String;
using Pure.RelationalSchema.Abstractions.ColumnType;

namespace Pure.RelationalSchema.Abstractions.Column;

public interface IColumn
{
    public IString Name { get; }

    public IColumnType Type { get; }
}
