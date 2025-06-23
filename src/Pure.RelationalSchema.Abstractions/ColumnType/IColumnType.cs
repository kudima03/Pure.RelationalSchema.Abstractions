using Pure.Primitives.Abstractions.String;

namespace Pure.RelationalSchema.Abstractions.ColumnType;

public interface IColumnType
{
    internal IString Name { get; }
}