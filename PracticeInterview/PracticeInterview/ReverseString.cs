using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PracticeInterview
{
    public class ReverseString
    {
        /*
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter your string : ");
            string input = Console.ReadLine();
            // Convert string to char array
            char[] chars = input.ToCharArray();
            Array.Reverse(chars); //reverse the characters
            string reversedString = new string(chars); // join them in string
            Console.WriteLine(reversedString);

            Console.WriteLine("Another way is - ");
          
            Console.WriteLine("Enter input: ");
            string str = Console.ReadLine();
            string reverseString = "";

            for (int i = str.Length - 1; i >= 0; i--) // str = Kanika
                // i = 5
            {
                reverseString += str[i]; // += is actually concatenation. Not recommended. Use String
                                         //String Builder is better and more efficient.
                // StringBuilder reverseString = new StringBuilder();
               // for (int i = str.Length - 1; i >= 0; i--)
               // {
               //     reverseString.Append(str[i]);  // Efficient way to append characters
               // }
            }
            Console.WriteLine(reverseString);
        }
        */

    }
}
