using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    public class RemoveDuplicate
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string UnqueString = RemoveDuplicateChars(input);

            Console.WriteLine($"String after removing duplcates: {UnqueString}");
        }

        static string RemoveDuplicateChars(string input)
        {
            // Use StringBuilder to efficiently build the result string
            StringBuilder result = new StringBuilder();
            // Use HashSet to track characters we've already seen
            HashSet<char> chars = new HashSet<char>();

            foreach (char c in input)
            { // If the character is not in the HashSet, add it to the result string    
                if (Char.IsLetterOrDigit(c) && !chars.Contains(c))
                {
                    result.Append(c);
                    chars.Add(c);
                    Console.WriteLine($"Added {c} to the hashset {string.Join(", ", chars)}");
                }

            }
            
            return result.ToString();
        }
    }
}
