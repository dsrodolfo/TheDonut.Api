using Microsoft.Extensions.DependencyInjection;
using TheDonut.Api.GraphQL.Queries;

namespace TheDonut.Api.Installers
{
    public static class GraphQLInstaller
    {
        public static IServiceCollection AddGraphQLServices(this  IServiceCollection services)
        {
            services.AddScoped<DonutQuery>();
            services.AddGraphQLServer()
                    .AddQueryType<DonutQuery>();

            return services;
        }
    }
}