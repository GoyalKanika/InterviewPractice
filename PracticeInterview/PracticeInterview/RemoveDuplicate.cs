using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    public class RemoveDuplicate
    { /*
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a string");
            string input = "HackerEarth";
            var result = RemoveDuplicateChars(input);
            Console.WriteLine($"String after removing duplcates: {result.UniqueString}");
            Console.WriteLine($"Duplicate: {result.DuplicateString}");
        }
        */
        public static (string UniqueString, string DuplicateString) RemoveDuplicateChars(string input)
        {
            // Use StringBuilder to efficiently build the result string
            StringBuilder uniques = new StringBuilder();
            StringBuilder duplicates = new StringBuilder();

            // Use HashSet to track characters we've already seen
            HashSet<char> unique = new HashSet<char>();
            HashSet<char> duplicate = new HashSet<char>();

            foreach (char c in input)
            { // If the character is a letter or a digit and not in the HashSet, add it to the result string    
                if (Char.IsLetterOrDigit(c))
                {
                    if (unique.Add(c))// chars.Add(c) will return true when c is not present in Char and Add will
                    {           //add it.
                        uniques.Append(c);
                        Console.WriteLine($"Added {c} to the hashset {string.Join(", ", unique)}");
                    }
                    else
                    {
                        if (!duplicate.Contains(c))
                        {
                            duplicates.Append(c);
                            duplicate.Add(c);
                        }
                        Console.WriteLine($"Added {c} to the hashset {string.Join(", ", duplicate)}");
                    }
                }
            }
            return (uniques.ToString(), duplicates.ToString());
        }
    }
}


