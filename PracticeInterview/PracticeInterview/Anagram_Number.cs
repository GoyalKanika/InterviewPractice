using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class Anagram_Number
    {
        public static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            return new string(char1) == new string(char2);
        }

        /*public static void Main(string[] args)
        {
            if (IsAnagram("kani", "ikns"))
                Console.WriteLine($"Is Anagram");
            else
                Console.WriteLine("Not Aagrams");
        }*/

    }
}
