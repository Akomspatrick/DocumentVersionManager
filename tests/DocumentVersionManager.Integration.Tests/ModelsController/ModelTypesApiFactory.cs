using DocumentVersionManager.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentVersionManager.Integration.Tests.ModelsController
{
    public class ModelTypesApiFactory : WebApplicationFactory<APIAssemblyRefrenceMarker>
    {

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestContainer<IServiceCollection>(services =>
            {
                services.AddHttpClient();
            });

            builder.ConfigureTestServices(services =>
            {
            });
        }
    }
}
//var constr = GetConnectionstringName.GetConnectionStrName(Environment.MachineName);
//var conn = _configuration.GetConnectionString(constr);
//optionsBuilder.UseMySql(conn!, GeneralUtils.GetMySqlVersion());