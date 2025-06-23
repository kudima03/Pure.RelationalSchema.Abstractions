using Pure.Primitives.Abstractions.String;
using Pure.RelationalSchema.Abstractions.ForeignKey;
using Pure.RelationalSchema.Abstractions.Table;

namespace Pure.RelationalSchema.Abstractions.Schema;

public interface ISchema
{
    IString Name { get; }

    IEnumerable<ITable> Tables { get; }

    IEnumerable<IForeignKey> ForeignKeys { get; }
}