using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TheDonut.Infrastructure.Context;

namespace TheDonut.Application.Installers
{
    public static class DbContextInstaller
    {
         public static IServiceCollection AddDbContextServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("DbContextSettings")["ConnectionString"];
            services.AddDbContext<DonutDbContext>(options =>
                options.UseNpgsql(connectionString));

            return services;
        }
    }
}