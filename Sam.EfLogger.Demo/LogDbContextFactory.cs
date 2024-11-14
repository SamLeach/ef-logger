namespace Sam.EfCoreLogger.Demo;

public class LogDbContextFactory(string connectionString)
{
    private readonly string _connectionString = connectionString;

    public LogDbContext CreateDbContext()
    {
        return new LogDbContext(_connectionString);
    }
}
