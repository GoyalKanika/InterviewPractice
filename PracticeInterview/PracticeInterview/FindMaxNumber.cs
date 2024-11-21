using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class FindMaxNumber
    {
       static int IsMax(int[] input)
        {
            int max = input[0];            
            foreach (int item in input)
            {
                if (item>max)
                  max = item;
            }
            return max;
        }

        static int IsMin(int[] input)
        {
            int min = input[0];
            foreach(int item in input)
                if(item<min)
                    min = item;

            return min;
        }
        
        /*
        public static void Main(string[] args)
        {
            int[] input = { 4, 3, 23, 22, 56, 89 };
            int maxNum = IsMax(input);
            int minNum = IsMin(input);
            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);
        }
        */
    }
}
