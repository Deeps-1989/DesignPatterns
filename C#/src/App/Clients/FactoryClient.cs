using System.Threading.Tasks;
using App.Common;
using FactoryPattern;

namespace App.Clients
{
    public class FactoryClient : IClient
    {
        private IDatabaseFactory _factory;

        public FactoryClient(IDatabaseFactory factory)
        {
            _factory = factory;
        }

        public void Execute()
        {
            var db = _factory.FetchDatabase();
            db.RunQuery();
        }
    }
}