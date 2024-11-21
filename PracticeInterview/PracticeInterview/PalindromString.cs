using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class PalindromString
    {
        
         static bool IsPalindrome(string input) {
            
           
            char[] arr = input.ToCharArray();
            int start = 0, end = arr.Length - 1;

            while (end > start)
            {
                if(arr[start] != arr[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
}
        /*
        static void Main(string[] args)
        {
            string input = "madam";
            bool decide = IsPalindrome(input);
            if (decide)
                Console.WriteLine($"String is a palindrome: {input}");
            else
                Console.WriteLine($"String is not a palindroms : {input}");
        }
        */
    }
}
