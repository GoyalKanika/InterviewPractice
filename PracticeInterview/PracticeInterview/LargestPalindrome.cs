using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class LargestPalindrome
    {

        public static string largestPalindrom(string input)
        {
            string largestString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    string substring = input.Substring(i, j - i + 1);

                    if (isPalindrom(substring) && substring.Length > largestString.Length)
                    {
                        largestString = substring;
                        //Console.WriteLine(largestString);
                    }

                }
            }

            return largestString;

        }
        public static bool isPalindrom(string input)
        {
            int start = 0, end = input.Length - 1;
            while (start < end)
            {
                if (input[start] != input[end])
                {
                    return false;

                }
                start++;
                end--;
            }
            return true;
        }

       /* static void Main(string[] args)
        {
            string input = "abaxabbayabcbazabcddcbay";
            string largestPalindrome = largestPalindrom(input);
            Console.WriteLine(largestPalindrome);

        }*/
    }
}
