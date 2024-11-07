using System;

class PrimeNumbers
{
    /*
    // Method to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number < 1) {
            Console.WriteLine("Its not a valid input");
            return false; // Numbers less than or equal to 1 are not prime
        }
        for (int i = 2; i * i <= number; i++)
        {
            if (number == 1)
            {
                
                return true;
            }
            if (number % i == 0)
            {
                
                return false; // Found a factor, so it's not prime
            }
        }
        return true; // No factors found, the number is prime
    }

    static void Main()
    {
        string input;

        // Continuously ask the user for input until they type "exit"
        while (true)
        {
            Console.WriteLine("Enter a number to check if it is prime (or type 'exit' to quit):");
            input = Console.ReadLine(); // default return type is String and hence we would need to convert

            // Check if the user wants to exit
            if (input.ToLower() == "exit")
            {
                break; // Exit the loop if user types "exit"
            }

            // Try to parse the input
            if (int.TryParse(input, out int result)) // its like try-catch block operation,
                                                     // this expression returns a bool
                // TryParse will convert the user input to Int, and if the conversion is successful, it shall
                //return true and set the converted output to int result.
                // but if the coversion fails, then TryParse will return a False and will not set the output value to int result
                //that's when user will be prompted again , until user enters exit.

                //Difference b/w int.Parse and int.TryParse
                // int.Parse - will throw exception
                // int.TryParse - will return false and fail gracefully
            {
                // Check if the number is prime
                if (IsPrime(result))
                {
                    Console.WriteLine($"{result} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{result} is not a prime number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        Console.WriteLine("Program has ended.");
    }
   */
}