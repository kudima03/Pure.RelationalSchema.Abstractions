using Pure.Primitives.Abstractions.String;
using Pure.RelationalSchema.Abstractions.Schema;

namespace Pure.RelationalSchema.Abstractions.Adapter;

public interface IAdapter
{
    IString Name { get; }

    IEnumerable<ISchema> Schemas { get; }
}