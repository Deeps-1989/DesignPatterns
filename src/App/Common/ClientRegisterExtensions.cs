using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace App.Common
{
    public static class ClientRegisterExtensions
    {
        public static void RegisterScripts(this IServiceCollection services)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            var types = currentAssembly.GetTypes().ToList().Where(p => typeof(IClient).IsAssignableFrom(p) && p != typeof(IClient));
            foreach (var type in types)
            {
                services.AddTransient(type);
            }
        }
    }
}