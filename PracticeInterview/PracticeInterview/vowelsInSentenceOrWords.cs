using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class vowelsInSentenceOrWords
    {
        public static string PrintVowels(string input)
        {
            string vowelSet = "aeiouAEIOU";
            StringBuilder vowels = new StringBuilder();

            foreach(char c in input)
            if (vowelSet.Contains(c))
            {
                vowels.Append(c);
            }
            return vowels.ToString();
        }
       /* public static void Main(string[] args)
        {
            string input = "Kanika is learning aeious";

            string vowels = PrintVowels(input);
            Console.WriteLine(vowels);  

        }*/

    }
}
