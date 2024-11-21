using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class SwapStrings
    {
        public static string swapStrings(string input)
        {
            // Step 1: Normalize spaces and split the input into words
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length-1; i += 2)
            {
                string temp = words[i];
                words[i] = words[i + 1];
                words[i + 1] = temp;
            }
            // Step 3: Rebuild the sentence
            string swappedStrings = string.Join(" ", words);

            return swappedStrings;
        }
        public static string reverseString(string input) {
            if (input.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Reverse(words);
                return string.Join(" ", words);
            }
            else
            { // If the sentence contains punctuation or special characters, use Regex-based split
                string[] words = Regex.Split(input, @"(\W+|\s+|\b)")
                                      .Where(s => !string.IsNullOrEmpty(s))
                                      .ToArray();
                Array.Reverse(words);
                return string.Join(" ", words);
            }
        }
      /*  public static void Main(string[] args) 
            {
            string input = "Today is Sunday and tomorrow onwards schools starts";
            string swapped = swapStrings(input);
            Console.WriteLine("Swapped Words: " + swapped);

            // Reverse the sentence (handle punctuation)
            Console.WriteLine("Reversed Sentence: " + reverseString(input));

        }
      */
    }
}
