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
        public string Execute(int start, int end)
        {

            Log.Debug($"Executing FizzBuzzPlus from {start} to {end}");

            StringBuilder result = new StringBuilder();

            for (int i = start; i <= end; i++)
            {
                bool fizz = i % 3 == 0 || i.ToString().Contains('3');
                bool buzz = i % 5 == 0 || i.ToString().Contains('5');

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
