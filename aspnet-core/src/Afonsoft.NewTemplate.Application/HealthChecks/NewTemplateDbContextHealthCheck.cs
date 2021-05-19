using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Afonsoft.NewTemplate.EntityFrameworkCore;

namespace Afonsoft.NewTemplate.HealthChecks
{
    public class NewTemplateDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public NewTemplateDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("NewTemplateDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("NewTemplateDbContext could not connect to database"));
        }
    }
}
