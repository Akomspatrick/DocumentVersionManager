using DocumentVersionManager.Api;
using DocumentVersionManager.Domain.Entities;
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
            .WithUsername("root").WithPassword("Manager123")
            .WithWaitStrategy(Wait.ForUnixContainer())//.UntilPortIsAvailable(3306))// default port for mysql
            .Build();
        }



        protected override void ConfigureWebHost(Microsoft.AspNetCore.Hosting.IWebHostBuilder builder)
        {

            var constr2 = _mySqlContainer.GetConnectionString();
            builder.ConfigureTestServices(services =>
            {
                var serviceDescriptor = services.SingleOrDefault(d => d.ServiceType ==
                    typeof(DbContextOptions<Infrastructure.Persistence.DocumentVersionManagerContext>));
                if (serviceDescriptor != null) services.Remove(serviceDescriptor);
                services.AddDbContext<Infrastructure.Persistence.DocumentVersionManagerContext>(options =>
                {
                    var constr = _mySqlContainer.GetConnectionString();
                    options.UseMySql(constr, GeneralUtils.GetMySqlVersion());
                });
            });
            constr2 = "_mySqlContainer.GetConnectionString()";

        }

        public async Task InitializeAsync()
        {
            await _mySqlContainer.StartAsync();
            using (var scope = Services.CreateScope())
            {
                //var context = scope.ServiceProvider.GetRequiredService<Infrastructure.Persistence.DocumentVersionManagerContext>();
                //context.Database.EnsureCreated();
                var contextManager = scope.ServiceProvider.GetRequiredService<Infrastructure.Persistence.DocumentVersionManagerContext>();
                contextManager.Database.EnsureCreated();
                contextManager.ProcessFlowGroups.Add(ProcessFlowGroup.Create("Groupname", "defaultmode", "description", Guid.NewGuid()));
                contextManager.ProcessFlowGroups.Add(ProcessFlowGroup.Create("Groupname1", "defaultmode1", "description1", Guid.NewGuid()));
                contextManager.ProcessFlowGroups.Add(ProcessFlowGroup.Create("Groupname2", "defaultmode2", "descriptio1n2", Guid.NewGuid()));
                contextManager.SaveChanges();
            }
        }


        async Task IAsyncLifetime.DisposeAsync()
        {
            await _mySqlContainer.StopAsync();
        }
    }
}
