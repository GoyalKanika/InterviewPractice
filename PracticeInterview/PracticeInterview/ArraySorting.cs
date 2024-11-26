using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class ArraySorting
    {
        public static void ascendingSorting(int[] arr)
        {
            int temp; bool swapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    Console.WriteLine("No swapping required. Array is sorted");
                }
            }
            Console.WriteLine("The sorted array is : ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public static void descendingSorting(int[] arr)
        {
            int temp; bool swapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapped = true;
                        }

                    }
                    if (!swapped)
                    {
                        Console.WriteLine("Array is sorted in descendign order already");
                    }
                }
            }
            Console.WriteLine("Array in Descending order");
            foreach (int n in arr)
                {
                    Console.WriteLine(n);
                }

            }

      /*      public static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 21, 5, 2, 3, 10,4,5,9,100 };
            ascendingSorting(arr);
            //reinitializing the array to make sure descending uses the original array
            arr = new int[] { 1, 4, 2, 21, 5, 2, 3, 10, 4, 5, 9, 100 };
            descendingSorting(arr);


            //sorting from smallest to largest

            //sorting from descending order
        }
      */
    }
}
