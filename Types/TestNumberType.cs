namespace hc_6589.Types;

public class TestNumberType : ObjectType<TestNumber>
{
    protected override void Configure(IObjectTypeDescriptor<TestNumber> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Name("TestNumber");

        descriptor.Implements<TestType>();

        descriptor
            .Field(f => f.Name);

        descriptor
            .Field(f => f.Number);
    }
}