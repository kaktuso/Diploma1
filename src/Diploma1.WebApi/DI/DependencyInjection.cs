using Microsoft.Extensions.DependencyInjection;
using Diploma1.Infrastructure;

namespace Diploma1.WebApi.DI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebApiLayer(this IServiceCollection services, string connectionString)
        {
            services.AddInfrastructure(connectionString);
            // Add more WebApi-specific DI here
            return services;
        }
    }
}