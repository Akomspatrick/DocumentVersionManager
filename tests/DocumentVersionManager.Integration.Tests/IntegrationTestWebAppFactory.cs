using DocumentVersionManager.Api;
using DocumentVersionManager.Infrastructure.Utils;
using DotNet.Testcontainers.Builders;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Testcontainers.MySql;
namespace DocumentVersionManager.Integration.Tests
{
    public class IntegrationTestWebAppFactory : WebApplicationFactory<APIAssemblyRefrenceMarker>, IAsyncLifetime
    {

        private readonly MySqlContainer _mySqlContainer;

        public IntegrationTestWebAppFactory()
        {

            _mySqlContainer = new MySqlBuilder()
            .WithImage("mysql:8.0").WithDatabase("TestDocumentVersionManagerDB")
            .WithUsername("root").WithPassword("TestDocumentVersionManager@1")
            .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(3306))// default port for mysql
            .Build();
        }



        protected override void ConfigureWebHost(Microsoft.AspNetCore.Hosting.IWebHostBuilder builder)
        {
            var constr = "_mySqlContainer.GetConnectionString()";
            var constr2 = _mySqlContainer.GetConnectionString();
            builder.ConfigureTestServices(services =>
            {
                var serviceDescriptor = services.SingleOrDefault(d => d.ServiceType ==
                    typeof(DbContextOptions<Infrastructure.Persistence.DocumentVersionManagerContext>));
                if (serviceDescriptor != null) services.Remove(serviceDescriptor);
                services.AddDbContext<Infrastructure.Persistence.DocumentVersionManagerContext>(options =>
                {
                    constr = _mySqlContainer.GetConnectionString();
                    options.UseMySql(constr, GeneralUtils.GetMySqlVersion());
                });
            });
            constr2 = "_mySqlContainer.GetConnectionString()";
        }

        public async Task InitializeAsync()
        {
            await _mySqlContainer.StartAsync();
        }


        async Task IAsyncLifetime.DisposeAsync()
        {
            await _mySqlContainer.StopAsync();
        }
    }
}
