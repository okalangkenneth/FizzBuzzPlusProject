using Serilog;
using System.Text;

namespace FizzBuzzPlusProject
{
    public class FizzBuzzPlusService
    {
        /// <summary>
        /// Executes the modified FizzBuzz logic for a specified range.
        /// </summary>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        /// <returns>A string with the modified FizzBuzz results.</returns>
        public async Task<string> ExecuteAsync(int start, int end)
        {

            Log.Debug($"Executing FizzBuzzPlus from {start} to {end}");

            StringBuilder result = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                // Simulate an asynchronous operation
                await Task.Delay(10); // Delay for 10 milliseconds

                bool fizz = i % 3 == 0 || i.ToString().Contains("3");
                bool buzz = i % 5 == 0 || i.ToString().Contains("5");

                if (fizz) result.Append("Fizz");
                if (buzz) result.Append("Buzz");
                if (!fizz && !buzz) result.Append(i);

                result.AppendLine();
            }


            Log.Information("Completed executing FizzBuzzPlus");
            return result.ToString();
        }


    }
}
