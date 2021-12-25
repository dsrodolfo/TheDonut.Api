using HotChocolate;
using System.Linq;
using System.Threading.Tasks;
using TheDonut.Domain.Entities;
using TheDonut.Infrastructure.Context;

namespace TheDonut.Infrastructure.GraphQL.Mutations
{
    public class Mutation
    {
        public async Task<Donut> AddDonut([Service] DonutDbContext context, int id, string name, double price)
        {
            Donut donut = new()
            {
                Id = id,
                Name = name,
                Price = price
            };

            context.Donut.Add(donut);
            await context.SaveChangesAsync();

            return donut;
        }

        public async Task<Donut> UpdateDonut([Service] DonutDbContext context, int id, string name, double price)
        {
            var donutEntity = context.Donut.SingleOrDefault(x => x.Id == id);

            if (donutEntity != null)
            {
                donutEntity.Name = name;
                donutEntity.Price = price;
                await context.SaveChangesAsync();

                return donutEntity;
            }

            return null;
        }

        public async Task<bool> DeleteDonut([Service] DonutDbContext context, int id)
        {
            var donut = context.Donut.SingleOrDefault(x => x.Id == id);

            if (donut != null)
            {
                context.Remove(donut);
                await context.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}