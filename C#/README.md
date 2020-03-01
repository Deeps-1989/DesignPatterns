# DesignPatterns
Design Patterns in c#

### Example usage:

Under src/App folder, please run the following command:

```
For development environment
dotnet run -s <Client Name> for eg dotnet run -s FactoryClient

For other environments
ASPNETCORE_ENVIRONMENT=prod    dotnet run -s FactoryClient 
ASPNETCORE_ENVIRONMENT=staging  dotnet run -s FactoryClient
```

Under DesignPatterns folder:

```
dotnet build DesignPatterns.sln
cd src/App
ASPNETCORE_ENVIRONMENT=<environment>    dotnet run -s FactoryClient 

```

### Values for environment:

- development
- prod
- staging
