namespace Patterns.FactoryPattern
{
    public interface IDatabaseFactory
    {
        IDatabaseClient FetchDatabase();
    }
}