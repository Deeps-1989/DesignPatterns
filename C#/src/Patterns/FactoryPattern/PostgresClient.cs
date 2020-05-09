using System;

namespace Patterns.FactoryPattern
{
    public class PostgresClient : IDatabaseClient
    {
        public void RunQuery()
        {
            Console.WriteLine("");
            Console.WriteLine("Running query for postgres client");
        }
    }
}