using System.Data.Entity;

namespace Sam.EfCoreLogger.Demo;

public class LogDbContext : DbContext
{
    public LogDbContext(string connectionString) : base(connectionString)
    {
    }

    public DbSet<Log> Logs { get; set; }
}