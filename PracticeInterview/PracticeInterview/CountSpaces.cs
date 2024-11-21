using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    public class CountSpaces
    {
        public static int CountSpace(string input)
        {
            // Null or empty check to avoid exceptions
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int count = 0;

            // Iterate through each character in the input string
            foreach (char c in input)
            {
                if (c == ' ')  // Check if the character is a space
                {
                    count++;
                }
            }

            return count;
        }

       /* public static void Main(string[] args)
        {
            // Example input
            string input = "This is Kanika. This is my city.";

            // Call the CountSpace method and display the result
            Console.WriteLine(CountSpace(input));  // Output: 5
        }*/
    }
}
