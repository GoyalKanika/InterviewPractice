using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class MissingNumber
    {
        public static int missingNumber(int[] input, int n)
        {
          
            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            foreach (int i in input)
            {
                actualSum += i;
                
            }
            return expectedSum - actualSum;
        }
      /* public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 , 5,6};
            Console.WriteLine(missingNumber(arr, arr.Length+1));
        } 
      */
    }
}
