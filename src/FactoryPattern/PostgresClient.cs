using System;

namespace FactoryPattern
{
    public class PostgresClient : IDatabaseClient
    {
        public void RunQuery()
        {
            Console.WriteLine("Running query for postgres client");
        }
    }
}