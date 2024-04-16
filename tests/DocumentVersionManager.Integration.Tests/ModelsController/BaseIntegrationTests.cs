using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Integration.Tests.ModelsController
{
    public class BaseIntegrationTests : IClassFixture<IntegrationTestWebAppFactory>
    {

        //private readonly IServiceScope _scope;
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
        }
    }

}
