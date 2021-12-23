using HotChocolate;
using HotChocolate.Data;
using System.Linq;
using TheDonut.Domain.Entities;
using TheDonut.Infrastructure.Context;

namespace TheDonut.Infrastructure.GraphQL.Queries
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Donut> Donuts([Service] DonutDbContext context) 
        {
            var donuts = context.Donut;
            return donuts;
        }
    }
}