
using DocumentVersionManager.Domain.Interfaces;
using DocumentVersionManager.Domain.Utils;

using DocumentVersionManager.Infrastructure.Persistence;
using DocumentVersionManager.Infrastructure.Persistence.Repositories;
using DocumentVersionManager.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DocumentVersionManager.Infrastructure
{
    public static class InfrastructureServiceCollection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var applicationAssembly = typeof(InfrastructureServiceCollection).Assembly;
            var constr = GetConnectionstringName.GetConnectionStrName(Environment.MachineName);
            services.AddDbContext<DocumentVersionManagerContext>(option => option.UseMySql(configuration.GetConnectionString(constr)!, GeneralUtils.GetMySqlVersion()));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddHealthChecks().AddCheck<DatabaseHealthCheck>("Database");
            return services;
        }
    }
}
