namespace hc_6589.Types;

public class TestType : InterfaceType<Test>
{
    protected override void Configure(IInterfaceTypeDescriptor<Test> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(f => f.Name);
    }
}