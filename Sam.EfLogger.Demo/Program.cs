﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sam.EfCoreLogger.Demo;

class Program
{
    static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton(new LogDbContextFactory("connectionString"));

                services.AddSingleton<ILoggerProvider, EfCoreLoggerProvider>();

                services.AddTransient<ServiceA>();
            })
            .Build();

        var serviceA = host.Services.GetRequiredService<ServiceA>();
        
        // Prints 3 different DbContext Hash Codes
        serviceA.DoSomething();
        serviceA.DoSomething();
        serviceA.DoSomething();

        Console.ReadKey();
    }
}
