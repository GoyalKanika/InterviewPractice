using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class FibonacciSeries
    {
        static void fibonacciSeries(int n)
        {
            int first = 0, second = 1, next;

            for (int i = 0; i < n; i++)
            {
                next = first + second;
                Console.WriteLine(next);
                first = second;
                second = next;
            }
        }
       /* static void Main(string[] args)
        {
            int n = 10;
           
           fibonacciSeries(n);

        }*/
    }
}
