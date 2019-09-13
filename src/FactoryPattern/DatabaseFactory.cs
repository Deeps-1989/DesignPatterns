using System;
using System.Globalization;

namespace FactoryPattern
{
    public class DatabaseFactory : IDatabaseFactory
    {
        public IDatabaseClient FetchDatabase()
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Development";
            if (env.ToLower(CultureInfo.InvariantCulture) != "staging" &&
                env.ToLower(CultureInfo.InvariantCulture) != "prod")
            {
                return new PostgresClient();
            }

            return new SnowflakeClient();
        }
    }
}