using HotChocolate.Data.Sorting;

namespace hc_6589.Types;

public class TestSortInput : SortInputType<Test>
{
    protected override void Configure(ISortInputTypeDescriptor<Test> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(f => f.Name);
    }
}