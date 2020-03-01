using System;

namespace FactoryPattern
{
    public class SnowflakeClient : IDatabaseClient
    {
        public void RunQuery()
        {
            Console.WriteLine("");
            Console.WriteLine("Running Query for snowflake");
        }
    }
}