using DocumentVersionManager.Infrastructure.Persistence;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVersionManager.Infrastructure.Utils
{
    public class DatabaseHealthCheck : IHealthCheck
    {
        private readonly DocumentVersionManagerContext _documentVersionManagerContext;
        public DatabaseHealthCheck(DocumentVersionManagerContext documentVersionManagerContext)
        {
            _documentVersionManagerContext = documentVersionManagerContext;
        }
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = _documentVersionManagerContext.Database.CanConnect();
            return Task.FromResult(isHealthy ? HealthCheckResult.Healthy() : HealthCheckResult.Unhealthy());
        }
    }
}
