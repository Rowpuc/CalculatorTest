using System;
using ConsoleApp;
using Microsoft.Extensions.DependencyInjection;
using ConsoleApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using ConsoleApp.Service;
using ConsoleApp.DiagnosticsLogger;

namespace ConsoleApp
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            await serviceProvider.GetService<Calculate>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath($"{AppDomain.CurrentDomain.BaseDirectory}")
                .AddJsonFile("appsettings.json")
                .Build();

            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IDiagnosticsLogger, DbDiagnosticsLogger>();
            services.AddDbContext<CalculatorContext>(config => {
                config.UseSqlServer(configuration.GetConnectionString("CalculatorContext"));
            });
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<ICalculationService, CalculationService>();

            services.AddTransient<Calculate>();

            return services;
        }
    }
}
