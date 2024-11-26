using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    public class RemoveDuplicate
    {
      /*  public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = "HackerEarth";
            var (UniqueString, DuplicateString) = RemoveDuplicateChars(input);
            Console.WriteLine($"String after removing duplcates: {UniqueString}");
            Console.WriteLine($"Duplicate: {DuplicateString}");

        }
      */
        public static (string UniqueString, string DuplicateString) RemoveDuplicateChars(string input)
        {
            input = input.ToLower();
            // Use StringBuilder to efficiently build the result string
            StringBuilder uniques = new StringBuilder();
            StringBuilder duplicates = new StringBuilder();

            // Use HashSet to track characters we've already seen
            HashSet<char> unique = new HashSet<char>();
            HashSet<char> duplicate = new HashSet<char>();
            // If the character is a letter or a digit and not in the HashSet, add it to the result string    

            /*
         If unique.Add(c) returns true:
             The character c is added to the unique HashSet.
             The character c is also appended to the uniques StringBuilder.
         If unique.Add(c) returns false:
             The character c was already present in the unique HashSet.
             The code then checks duplicate.Add(c):
        If duplicate.Add(c) returns true:
            The character c is added to the duplicate HashSet.
            The character c is also appended to the duplicates StringBuilder.
        If duplicate.Add(c) returns false:
            The character c was already present in the duplicate HashSet.
            Nothing is added or appended to the duplicates StringBuilder
         */

            foreach (char c in input)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    if (unique.Add(c))
                    {
                        uniques.Append(c);
                        Console.WriteLine($"Added {c} to the hashset {string.Join(", ", unique)}");
                    }

                    else if (duplicate.Add(c))
                    {
                        duplicates.Append(c);
                        Console.WriteLine($"Added {c} to the hashset {string.Join(", ", duplicate)}");
                    }
                }
            }

            return (uniques.ToString(), duplicates.ToString());
        }
    }
}




