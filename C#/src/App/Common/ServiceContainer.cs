using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace App.Common
{
    public class ServiceContainer : IDisposable
    {
        private IConfigurationRoot _configuration;
        private IServiceCollection _service;
        private IServiceScope _scope;

        public ServiceContainer()
        {
            // BuildConfiguration
            // Register services
            BuildConfiguration();
            SetUpServices();
            var serviceProvider = _service.BuildServiceProvider();
            var factoryscope = serviceProvider.GetRequiredService<IServiceScopeFactory>();
            _scope = factoryscope.CreateScope();
        }

        public static ServiceContainer Create()
        {
            return new ServiceContainer();
        }

        public IClient GetScript(Type scriptType)
        {
            return (IClient) _scope.ServiceProvider.GetService(scriptType);
        }

        public void BuildConfiguration()
        {
            Console.Write(Directory.GetCurrentDirectory());
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();
            _configuration = builder.Build();
        }

        public void SetUpServices()
        {
            _service = new ServiceCollection();
            _service.RegisterScripts();
            _service.RegisterPatternServices();
        }

        public void Dispose()
        {
        }
    }
}