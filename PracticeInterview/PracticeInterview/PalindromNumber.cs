using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class PalindromNumber
    {
         static bool IsPalindromNum(int input)
        {
            int i, temp, result = 0;
            temp = input;
            while (input > 0)
            {
                i = input % 10;
                result = result * 10 + i;
                input = input / 10;
            }
               
            return temp == result;
        }
        /*
         static void Main(string[] args)
        {
            int input = 1234;
            bool decide = IsPalindromNum(input);

            if (decide)
                Console.WriteLine($"Input is a palindrome: {input}");
            else
                Console.WriteLine("Its not");

        }*/
    }
}
