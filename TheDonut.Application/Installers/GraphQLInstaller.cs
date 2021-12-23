using Microsoft.Extensions.DependencyInjection;
using TheDonut.Infrastructure.GraphQL.Queries;

namespace TheDonut.Application.Installers
{
    public static class GraphQLInstaller
    {
        public static IServiceCollection AddGraphQLServices(this IServiceCollection services)
        {
            services.AddGraphQLServer()
                    .AddQueryType<Query>()
                    .AddProjections()
                    .AddFiltering()
                    .AddSorting();

            return services;
        }
    }
}