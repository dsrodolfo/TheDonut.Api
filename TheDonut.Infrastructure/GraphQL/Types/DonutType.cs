using HotChocolate.Types;
using TheDonut.Domain.Entities;

namespace TheDonut.Infrastructure.GraphQL.Types
{
    public class DonutType : ObjectType<Donut>
    {
        protected override void Configure(IObjectTypeDescriptor<Donut> descriptor)
        {
            descriptor.Name("Donut");
            descriptor.Description("An object type");

            descriptor.Field(f => f.Id).Description("A field")
                                       .Type<IdType>();

            descriptor.Field(f => f.Name).Description("A field")
                                         .Type<StringType>();

            descriptor.Field(f => f.Price).Description("A Field")
                                          .Type<FloatType>(); ;
        }
    }
}