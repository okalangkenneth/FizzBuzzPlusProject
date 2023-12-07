namespace FizzBuzzPlusProject.View
{
    /// <summary>
    /// Represents the view component in the MVC pattern for FizzBuzzPlus. 
    /// This class handles all user interactions and console outputs.
    /// </summary>
    public class FizzBuzzPlusView
    {
        
        public void DisplayMenu()
        {
            // Display the menu for the FizzBuzzPlus application
            Console.WriteLine("\nFizzBuzzPlus Application Menu. Type 1,2,or 3 to choose a menu:");
            Console.WriteLine("1. Run FizzBuzzPlus");
            Console.WriteLine("2. View Instructions");
            Console.WriteLine("3. Exit");
        }

        
        public void DisplayInstructions()
        {
            // Display the instructions for the FizzBuzzPlus algorithm
            Console.WriteLine("\nFizzBuzzPlus Instructions:");
            Console.WriteLine("- Enter a range of numbers (start and end).");
            Console.WriteLine("- Numbers that are multiples of 3, or contain 3, will print 'Fizz'.");
            Console.WriteLine("- Numbers that are multiples of 5, or contain 5, will print 'Buzz'.");
        }

        
        public void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }

        
        public void DisplayError(string message)
        {
            Console.WriteLine($"Error: {message}");
        }

        
        public int ReadIntegerInput(string prompt)
        {

            int number;
            Console.Write(prompt);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write(prompt);
            }

            return number;
        }
    }
}

