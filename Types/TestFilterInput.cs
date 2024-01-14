using HotChocolate.Data.Filters;

namespace hc_6589.Types;

public class TestFilterInput : FilterInputType<Test>
{
    protected override void Configure(IFilterInputTypeDescriptor<Test> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(f => f.Name);
    }
}