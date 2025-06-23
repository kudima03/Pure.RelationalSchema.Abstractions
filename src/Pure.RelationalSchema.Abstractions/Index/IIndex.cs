using Pure.Primitives.Abstractions.Bool;
using Pure.RelationalSchema.Abstractions.Column;

namespace Pure.RelationalSchema.Abstractions.Index;

public interface IIndex
{
    IBool IsUnique { get; }

    IEnumerable<IColumn> Columns { get; }
}