using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class Merge2Arrays
    {
        /*public static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] array2 = { 1, 5, 7 };

            int[] MergedArray = megedArray(array1, array2);

            foreach (int i in MergedArray)
            {
                Console.WriteLine(i + " ");
            }

        }*/

        public static int[] megedArray(int[] array1, int[] array2)
        {
            int[] mergedArrayLength = new int[array1.Length + array2.Length];
            Array.Sort(array1);
            Array.Sort(array2);
            int i =0 , j = 0 , k = 0 ;

            //start merging by comparing

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    mergedArrayLength[k++] = array1[i++];
                }
                else
                {
                    mergedArrayLength[k++] = array2[j++];
                }
                while (i < array1.Length)
                {
                    mergedArrayLength[k++] = array1[i++];
                }
                while (j < array2.Length)
                {
                    mergedArrayLength[k++] = array2[j++];
                }
            }
                return mergedArrayLength;
        }
    }
}
