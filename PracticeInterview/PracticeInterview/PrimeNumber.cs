using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class PrimeNumber
    {
        public static bool isPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i * i < number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        /* public static void Main(string[] args)
         {
             int number = 7;
             var decide = isPrime(number);
             if (decide)
             {
                 Console.WriteLine($"number is prime - {number}");

           }
             else
                 Console.WriteLine($"number is not prime - {number}");
         }*/
    }
}
