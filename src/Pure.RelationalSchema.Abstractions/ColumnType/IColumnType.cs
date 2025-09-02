using Pure.Primitives.Abstractions.String;

namespace Pure.RelationalSchema.Abstractions.ColumnType;

public interface IColumnType
{
    public IString Name { get; }
}
