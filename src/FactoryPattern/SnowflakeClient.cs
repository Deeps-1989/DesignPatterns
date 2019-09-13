using System;

namespace FactoryPattern
{
    public class SnowflakeClient : IDatabaseClient
    {
        public void RunQuery()
        {
            Console.WriteLine("Running Query for snowflake");
        }
    }
}