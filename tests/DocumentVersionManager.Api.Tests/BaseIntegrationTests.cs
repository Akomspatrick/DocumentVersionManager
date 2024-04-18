using DocumentVersionManager.Infrastructure.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Api.Tests
{
    public class BaseIntegrationTests : IClassFixture<IntegrationTestWebAppFactory>
    {

        private readonly IServiceScope _scope;
        //protected readonly ISender sender;
        //protected BaseIntegrationTests(IntegrationTestWebAppFactory factory)
        //{

        //    _scope = factory.Services.CreateScope();
        //    sender = _scope.ServiceProvider.GetRequiredService<ISender>();

        //}
        private readonly IntegrationTestWebAppFactory _factory;
        public BaseIntegrationTests(IntegrationTestWebAppFactory factory)
        {
            _factory = factory;
            _scope = factory.Services.CreateScope();
            /// use this to get the contextmanager
            /// create the seed data
            var contextManager = _scope.ServiceProvider.GetRequiredService<Infrastructure.Persistence.DocumentVersionManagerContext>();
            contextManager.Database.EnsureCreated();
            // Infrastructure.Persistence.TrySeedData.EnsureUsers(_factory);
            //  contextManager.SeedData();

        }
    }

}
