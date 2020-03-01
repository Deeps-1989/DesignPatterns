using System.Threading.Tasks;

namespace App.Common
{
    public class ClientExecutor
    {
        public ClientExecutor()
        {
        }

        public void ExecutePattern(string clientName)
        {
            using (var serviceContainer = ServiceContainer.Create())
            {
                var clientType = ClientResolver.GetPatternType(clientName);
                var client = serviceContainer.GetScript(clientType);
                client.Execute();
            }
        }
    }
}