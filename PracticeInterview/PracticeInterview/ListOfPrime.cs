using System;

namespace PracticeInterview
{
    internal class ListOfPrime
    {
        // Method to check if a number is prime
        public static bool isPrime(int input)
        {
            if (input <= 1 ) return false;
            if (input == 2) return true; // Special case for 2, which is prime
            if(input %2 == 0) return false;
            // Check divisibility from 3 to the square root of the input number
            for (int i = 3; i <= Math.Sqrt(input); i += 2)
            {
                if (input % i == 0)
                    return false; // If divisible, it's not prime
            }

            return true; // Otherwise, it's prime
        }

       /* public static void Main(string[] args)
        {
            int count = 0;
            int number = 2;

            // Loop until 50 prime numbers are found
            while (count < 50)
            {
                if (isPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }
            Console.WriteLine(); // Newline after printing all primes
        }
       */
    }
}
