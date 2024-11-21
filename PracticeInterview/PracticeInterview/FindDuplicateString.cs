using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class FindDuplicateString
    {
       static void main(string [] args) { 
        string input = "hackerearth".ToLower();

        HashSet<char> seen = new HashSet<char>();

        HashSet<char> duplicates = new HashSet<char>();
            foreach(char letter in input)
            {
                if (!seen.Add(letter)) // Return true if the letter is not present in seen and then will add. 
                   //Return false if the letter is present in the seen and will not add.
                   // ! will negate the condition. That means, return false if letter is not present in seen and added
                   // ! will negate the condition. That means, return true if letter is present and is not added. and get inside if loop
                {
                    duplicates.Add(letter);
                }
            }
            if (duplicates.Count > 0)
            {
                foreach (char letter in duplicates)
                {
                    Console.WriteLine(letter);
                }
            }
            else
                Console.WriteLine("No Duplicates");

        }
       
    }
}
