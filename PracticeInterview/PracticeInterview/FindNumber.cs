using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class FindNumber
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

        static int Is2ndLargest(int[] input)
        { //{ 4, 3, 23, 22, 56, 89 }
            int max = int.MinValue; //3
            int secondMax = int.MinValue; //3

            foreach(int item in input) //4 // 3 //23 //22 //56 //89
            {
                if(item> max) //4>3 //23>4 //56>23 //89>56
                {
                    secondMax = max; //secondMax = 3 //4 //23 //56
                    max = item; // 4 //23 //56 //89
                }
                
            }
            return secondMax;
        }
        
        static int Is2ndSmallest(int[] input)
        {//{ 4, 3, 23, 22, 56, 89 }
            int min = int.MaxValue; //89
            int secondMin = int.MaxValue; //89

            foreach(int item in input) //4 //3 /23
            {
                if(item<min) //4<89 //3<4 //23<3 // 56<3 //89<3
                {
                    secondMin = min; // 89 // 4 //
                    min = item; //4 // 3
                }
            }
            return secondMin;
        }
        
      /*  public static void Main(string[] args)
        {
            int[] input = { 4, 3, 23, 22, 56, 89,3,2,90,89 };
            int maxNum = IsMax(input);
            int minNum = IsMin(input);
            int secondMaxNum = Is2ndLargest(input);
            int secondMinNum = Is2ndSmallest(input);
            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);
            Console.WriteLine(secondMaxNum);
            Console.WriteLine(secondMinNum);
        }
        */
    }
}
