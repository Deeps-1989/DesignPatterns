using System;
using System.Linq;
using System.Reflection;

namespace App.Common
{
    public static class ClientResolver
    {
        public static Type GetPatternType(string scriptName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes().ToList().Where(p => typeof(IClient).IsAssignableFrom(p));
            try
            {
                var type = types.SingleOrDefault(x => x.Name.EndsWith(scriptName));
                return type;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception {e.Message}");
                return null;
            }
        }
    }
}