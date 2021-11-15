using Microsoft.Extensions.DependencyInjection;
using TheDonut.Api.Interfaces;
using TheDonut.Api.Services;

namespace TheDonut.Api.Installers
{
    public static class ServiceInstaller
    {
        public static IServiceCollection AddDonutServices(this IServiceCollection services)
        {
            services.AddSingleton<IDonutService, DonutService>();

            return services;
        }
    }
}