using Serilog;

namespace FizzBuzzPlusProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Serilog for logging
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Console()
                .WriteTo.File("logs/fizzbuzzplus.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Starting FizzBuzzPlus application");

            // Run an infinite loop to show the menu continuously
            while (true)
            {
                // Display the application menu
                Console.WriteLine("\nFizzBuzzPlus Application Menu:");
                Console.WriteLine("1. Run FizzBuzzPlus");
                Console.WriteLine("2. View Instructions");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");

                // Read the user's option
                string? option = Console.ReadLine();

                // If no input is received, log a warning and continue
                if (option is null)
                {
                    Log.Warning("No input received");
                    continue;
                }

                try
                {
                    // Process the user's option

                    switch (option)
                    {
                        case "1":
                            RunFizzBuzzPlus();
                            break;
                        case "2":
                            DisplayInstructions();
                            break;
                        case "3":
                            Log.Information("Exiting FizzBuzzPlus application");
                            Log.CloseAndFlush();
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    // Log any errors that occur during the processing of the user's request

                    Log.Error(ex, "An error occurred while processing your request");
                }
            }
        }

        private static void RunFizzBuzzPlus()
        {
            Console.Write("Enter start number: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            FizzBuzzPlusService fizzBuzzPlus = new FizzBuzzPlusService();
            string output = fizzBuzzPlus.Execute(start, end);
            Console.WriteLine(output);
        }

        private static void DisplayInstructions()
        {
            // Display the instructions for the FizzBuzzPlus algorithm
            Console.WriteLine("\nFizzBuzzPlus Instructions:");
            Console.WriteLine("- Enter a range of numbers (start and end).");
            Console.WriteLine("- Numbers that are multiples of 3, or contain 3, will print 'Fizz'.");
            Console.WriteLine("- Numbers that are multiples of 5, or contain 5, will print 'Buzz'.");
        }
    }
}


