using DocumentVersionManager.Infrastructure.Utils;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Testcontainers.MySql;
namespace DocumentVersionManager.Api.Tests
{
    public class IntegrationTestWebAppFactory : WebApplicationFactory<APIAssemblyRefrenceMarker>, IAsyncLifetime
    {

        private readonly MySqlContainer _mySqlContainer = new MySqlBuilder()
            .WithImage("mysql:8.0")
            .WithDatabase("DocumentVMDb1")
            .WithUsername("root")
            .WithPassword("Massload@1")
            .Build();
        protected override void ConfigureWebHost(Microsoft.AspNetCore.Hosting.IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                var serviceDescriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                    typeof(Microsoft.EntityFrameworkCore.DbContextOptions<Infrastructure.Persistence.DocumentVersionManagerContext>));
                if (serviceDescriptor != null)
                {
                    services.Remove(serviceDescriptor);
                }

                services.AddDbContext<Infrastructure.Persistence.DocumentVersionManagerContext>(options =>
                {
                    string constr = _mySqlContainer.GetConnectionString();
                    options.UseMySql(constr, GeneralUtils.GetMySqlVersion());
                    // options.UseMySql(constr, GeneralUtils.GetMySqlVersion());
                });
            });
        }

        public Task InitializeAsync()
        {
            return _mySqlContainer.StartAsync();
        }

        Task IAsyncLifetime.DisposeAsync()
        {
            return _mySqlContainer.StopAsync();
        }
    }
}
