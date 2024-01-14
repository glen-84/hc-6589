namespace hc_6589.Types;

public class TestTextType : ObjectType<TestText>
{
    protected override void Configure(IObjectTypeDescriptor<TestText> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Name("TestText");

        descriptor.Implements<TestType>();

        descriptor
            .Field(f => f.Name);

        descriptor
            .Field(f => f.Text);
    }
}