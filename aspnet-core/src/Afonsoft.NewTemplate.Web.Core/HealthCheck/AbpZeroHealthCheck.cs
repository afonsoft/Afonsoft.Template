using Microsoft.Extensions.DependencyInjection;
using Afonsoft.NewTemplate.HealthChecks;

namespace Afonsoft.NewTemplate.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<NewTemplateDbContextHealthCheck>("Database Connection");
            builder.AddCheck<NewTemplateDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
