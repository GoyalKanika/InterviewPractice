using System;
class PrintPrimeNumbers
{
    public static bool IsPrime(int number)
    {
        if(number <=1)
        {
            return false;
        }
        if (number > 2 && number % 2 == 0)
        {
            return false;
        }

            for (int i = 3; i * i < number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
        return true;
    }

    public static void PrintPrime(int limit)
    {
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine($"Prime Number: {i}");
            }

        }
    }

    /*public static void Main(String[] args)
    {
        PrintPrime(40);
    }
    */
    
}