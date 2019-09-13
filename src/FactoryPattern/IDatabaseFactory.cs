namespace FactoryPattern
{
    public interface IDatabaseFactory
    {
        IDatabaseClient FetchDatabase();
    }
}