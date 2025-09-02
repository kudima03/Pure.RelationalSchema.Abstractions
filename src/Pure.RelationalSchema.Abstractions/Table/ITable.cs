using Pure.Primitives.Abstractions.String;
using Pure.RelationalSchema.Abstractions.Column;
using Pure.RelationalSchema.Abstractions.Index;

namespace Pure.RelationalSchema.Abstractions.Table;

public interface ITable
{
    public IString Name { get; }

    public IEnumerable<IColumn> Columns { get; }

    public IEnumerable<IIndex> Indexes { get; }
}
