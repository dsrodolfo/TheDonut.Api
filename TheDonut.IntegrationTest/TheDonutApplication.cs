using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using TheDonut.Api;

namespace TheDonut.IntegrationTest
{
    internal class TheDonutApplication : WebApplicationFactory<Program>
    {
        private readonly string _environment;

        public TheDonutApplication(string environment = "Development")
        {
            _environment = environment;
        }

        protected override IHost CreateHost(IHostBuilder builder)
        {
            builder.UseEnvironment(_environment);
            builder.ConfigureServices(services => { });

            return base.CreateHost(builder);
        }
    }
}