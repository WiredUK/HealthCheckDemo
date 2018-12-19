using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthCheckDemo.HealthChecks
{
    public class FolderExistsHealthCheck : IHealthCheck
    {
        private readonly string _folder;

        public FolderExistsHealthCheck(string folder)
        {
            _folder = folder;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = new CancellationToken())
        {
            await Task.CompletedTask;

            return Directory.Exists(_folder)
                ? HealthCheckResult.Healthy()
                : HealthCheckResult.Unhealthy();
        }
    }
}