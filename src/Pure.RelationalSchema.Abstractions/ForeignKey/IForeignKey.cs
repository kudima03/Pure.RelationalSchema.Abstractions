using Pure.RelationalSchema.Abstractions.Column;
using Pure.RelationalSchema.Abstractions.Table;

namespace Pure.RelationalSchema.Abstractions.ForeignKey;

public interface IForeignKey
{
    public ITable ReferencingTable { get; }

    public IColumn ReferencingColumn { get; }

    public ITable ReferencedTable { get; }

    public IColumn ReferencedColumn { get; }
}
