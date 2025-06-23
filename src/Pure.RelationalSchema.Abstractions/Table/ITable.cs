using Pure.Primitives.Abstractions.String;
using Pure.RelationalSchema.Abstractions.Column;
using Pure.RelationalSchema.Abstractions.Index;

namespace Pure.RelationalSchema.Abstractions.Table;

public interface ITable
{
    IString Name { get; }

    IEnumerable<IColumn> Columns { get; }

    IEnumerable<IIndex> Indexes { get; }
}