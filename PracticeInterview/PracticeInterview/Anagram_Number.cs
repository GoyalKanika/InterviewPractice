using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class Anagram_Number
    {
        public static bool IsAnagramUsingInBuiltFunctions(string str1, string str2)
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
        public static bool IsAnagramUsingTraditional(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            for(int i = 0; i<char1.Length; i++)
            {
                if (char1[i] != char2[i])
                {
                    return false;
                }
            }
            return true;

        }

        /*public static void Main(string[] args)
        {
            if (IsAnagramUsingTraditional("kani as 123", "ikna sa 321"))
                Console.WriteLine($"Is Anagram");
            else
                Console.WriteLine("Not Aagrams");
        }
        */

    }
}
