using Pure.Primitives.Abstractions.String;
using Pure.RelationalSchema.Abstractions.ForeignKey;
using Pure.RelationalSchema.Abstractions.Table;

namespace Pure.RelationalSchema.Abstractions.Schema;

public interface ISchema
{
    public IString Name { get; }

    public IEnumerable<ITable> Tables { get; }

    public IEnumerable<IForeignKey> ForeignKeys { get; }
}
