using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class SortArray
    {
        static void sortedArray(int[] array)
        {
            int input = array.Length; //3 
            int temp;
            bool swapped; //false
            for (int i = 0; i < input - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < input - i - 1; j++)
                { //j = 0; i = 0 // j=1 ; i =0
                    if (array[j] > array[j + 1]) // 4>22 // 22>12
                    {
                        temp = array[j]; //temp = 22 
                        array[j] = array[j + 1]; //array[1] = 12
                        array[j + 1] = temp; //array[2] = 22
                        swapped = true;
                    }
                }


                if (!swapped)
                {
                    Console.WriteLine("Array is already swapped");
                    break;
                }
            }
                Console.WriteLine("Sorted Array is: ");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
        }
        /*    public  static void Main(string[] args)
              {
                  int[] input = { 4, 22, 12};
                  sortedArray(input);

              }*/
    }
}
