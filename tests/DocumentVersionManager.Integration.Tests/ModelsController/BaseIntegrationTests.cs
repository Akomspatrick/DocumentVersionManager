using DocumentVersionManager.Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Integration.Tests.ModelsController
{
    public abstract class BaseIntegrationTests : IClassFixture<IntegrationTestWebAppFactory>
    {

        private readonly IServiceScope _scope;
        private readonly IntegrationTestWebAppFactory _factory;
        public readonly HttpClient _httpClient;
        public BaseIntegrationTests(IntegrationTestWebAppFactory factory)
        {
            _factory = factory;
            using (_scope = factory.Services.CreateScope())
            {

                //var contextManager = _scope.ServiceProvider.GetRequiredService<Infrastructure.Persistence.DocumentVersionManagerContext>();
                //contextManager.Database.EnsureCreated();
                //contextManager.TestingModeGroups.Add(TestingModeGroup.Create("Groupname", "defaultmode", "description", Guid.NewGuid()));
                //contextManager.TestingModeGroups.Add(TestingModeGroup.Create("Groupname1", "defaultmode1", "description1", Guid.NewGuid()));
                //contextManager.TestingModeGroups.Add(TestingModeGroup.Create("Groupname2", "defaultmode2", "descriptio1n2", Guid.NewGuid()));
                //contextManager.SaveChanges();
                // contextManager.Database.EnsureCreated();
                //  Infrastructure.Persistence.EntitiesConfig.TestingModeGroupConfigSeedData(contextManager);

            }
            _httpClient = factory.CreateClient();
        }
    }

}
