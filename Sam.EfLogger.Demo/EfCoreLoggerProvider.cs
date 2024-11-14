namespace Sam.EfCoreLogger.Demo;

using Microsoft.Extensions.Logging;

public class EfCoreLoggerProvider(LogDbContextFactory logDbContextFactory) : ILoggerProvider
{
    private readonly LogDbContextFactory logDbContextFactory = logDbContextFactory;

    public ILogger CreateLogger(string categoryName)
    {
        return new EfLogger(logDbContextFactory);
    }

    public void Dispose() { }
}
