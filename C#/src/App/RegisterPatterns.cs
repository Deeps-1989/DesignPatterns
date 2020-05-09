using Patterns.FactoryPattern;
using Patterns.DecoratorPattern;
using Microsoft.Extensions.DependencyInjection;

namespace App
{
    public static class RegisterPatterns
    {
        public static void RegisterPatternServices(this IServiceCollection services)
        {
            services.AddTransient<IDatabaseFactory, DatabaseFactory>();
            services.AddTransient<PostgresClient>();
            services.AddTransient<SnowflakeClient>();
            services.AddTransient<ITea, Tea>();
            services.AddTransient<SnowflakeClient>();
        }
    }
}