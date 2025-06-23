using Pure.RelationalSchema.Abstractions.Column;
using Pure.RelationalSchema.Abstractions.Table;

namespace Pure.RelationalSchema.Abstractions.ForeignKey;

public interface IForeignKey
{
    ITable ReferencingTable { get; }

    IColumn ReferencingColumn { get; }

    ITable ReferencedTable { get; }

    IColumn ReferencedColumn { get; }
}