using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    public class Factorial
    {
        public static int factos(int x)
        {
            int result = 1;
            for (int i = 1; i<=x; i++)
            {
                result *= i;
                Console.WriteLine($"Factors are: {i} ");
            }
            return result;
        }

       /* public static void Main(string[] args)
        {
            Console.WriteLine(factos(5));
        } */
    }
}
