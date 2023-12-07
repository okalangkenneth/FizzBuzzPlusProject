using FizzBuzzPlusProject.Model;
using FizzBuzzPlusProject.View;
using Serilog;

namespace FizzBuzzPlusProject.Controller
{
    /// <summary>
    /// Represents the controller component in the MVC pattern for FizzBuzzPlus.
    /// This class manages the application flow, interpreting user input,
    /// and coordinating the view and the service.
    /// </summary>
    
    public class FizzBuzzPlusController
    {
        private readonly FizzBuzzPlusView _view;
        private readonly FizzBuzzPlusService _service;

        public FizzBuzzPlusController(FizzBuzzPlusView view, FizzBuzzPlusService service)
        {
            _view = view;
            _service = service;
        }

        public async Task RunAsync()
        {
            // Run an infinite loop to show the menu continuously
            while (true)
            {
                // Read the user's option
                _view.DisplayMenu();
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
                            await RunFizzBuzzPlusAsync();
                            break;
                        case "2":
                            _view.DisplayInstructions();
                            break;
                        case "3":
                            Log.Information("Exiting FizzBuzzPlus application");
                            return;
                        default:
                            _view.DisplayError("Invalid option. Please try again.");
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

        private async Task RunFizzBuzzPlusAsync()
        {
            int start = _view.ReadIntegerInput("Enter start number: ");
            int end = _view.ReadIntegerInput("Enter end number: ");

            string output = await _service.ExecuteAsync(start, end);
            _view.DisplayResult(output);
        }
    }
}
