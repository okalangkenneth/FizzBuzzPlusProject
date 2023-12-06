using System;

namespace FizzBuzzPlusProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = "";

                // Check for multiple of 3 or contains 3
                if (i % 3 == 0 || i.ToString().Contains('3'))
                {
                    result += "Fizz";
                }

                // Check for multiple of 5 or contains 5
                if (i % 5 == 0 || i.ToString().Contains('5'))
                {
                    result += "Buzz";
                }

                // If neither condition is met, print the number
                if (string.IsNullOrEmpty(result))
                {
                    result = i.ToString();
                }

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}

