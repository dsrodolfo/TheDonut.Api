using HotChocolate.Types;
using TheDonut.Api.Models;

namespace TheDonut.Api.GraphQL.Types
{
    public class DonutType : ObjectType<Donut>
    {
        protected override void Configure(IObjectTypeDescriptor<Donut> descriptor)
        {
            descriptor.Name("Donut");
            descriptor.Description("An object type");
            descriptor.Field(f => f.Id).Description("A field");
            descriptor.Field(f => f.Name).Description("A field");
            descriptor.Field(f => f.Price).Description("A Field");
        }
    }
}