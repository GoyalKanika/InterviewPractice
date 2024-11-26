using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class CommonIn2Arrays
    {
        public static List<int> commonElementsList(int[] input1, int[] input2)
        {
            HashSet<int> set = new HashSet<int>(input1); //store unique numbers from array 1
            List<int> commonElements = new List<int>(); // store common elements

            foreach (int element in input2)
            {
                if (set.Contains(element))
                {
                    commonElements.Add(element);
                }
            }
            return commonElements;

        }
        /*public static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] input2 = { 1,1, 8, 5 };
            List<int> commonInArray = commonElementsList(input1, input2);
            foreach (int element in commonInArray)
            {
                Console.WriteLine(element);
            }
        }*/

    }
}
