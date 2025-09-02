using Pure.Primitives.Abstractions.Bool;
using Pure.RelationalSchema.Abstractions.Column;

namespace Pure.RelationalSchema.Abstractions.Index;

public interface IIndex
{
    public IBool IsUnique { get; }

    public IEnumerable<IColumn> Columns { get; }
}
