using FizzBuzzPlusProject.Controller;
using FizzBuzzPlusProject.Model;
using FizzBuzzPlusProject.View;
using Serilog;

namespace FizzBuzzPlusProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Configure Serilog for logging
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/fizzbuzzplus.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Starting FizzBuzzPlus application");

            var view = new FizzBuzzPlusView();
            var service = new FizzBuzzPlusService();
            var controller = new FizzBuzzPlusController(view, service);

            await controller.RunAsync();

            Log.CloseAndFlush();
        }
    }
}


