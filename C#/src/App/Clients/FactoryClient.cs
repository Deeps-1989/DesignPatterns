using App.Common;
using Patterns.FactoryPattern;
/*
To check the behaviour according to different environments and on runtime
For other environments
ASPNETCORE_ENVIRONMENT=prod    dotnet run -s FactoryClient 
ASPNETCORE_ENVIRONMENT=staging  dotnet run -s FactoryClient
```

Under DesignPatterns folder:

```
dotnet build DesignPatterns.sln
cd src/App
ASPNETCORE_ENVIRONMENT=<environment> dotnet run -s FactoryClient 

```

### Values for environment:

- development
- prod
- staging*/

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