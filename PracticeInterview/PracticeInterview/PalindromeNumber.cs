using System;

public class PalindromeNumber
    
{
    /*
    // Palindrome string checker

    public static bool IsStringPalindrom(string str)
    {
       string cleanedString = string.Concat(str.Where(c => Char.IsLetterOrDigit(c))).ToLower();
        //.Where(c => Char.IsLetterOrDigit(c)) is LINQ query which is basically filtering out 
        // all the non-alphanumeric charsuch as space or punctuation or full stop and is skipping
        // them to make it palindrom check ready
        // .ToLower() making it case insensitive
        // string.Concat -- forming a new string post all filtering out and storing in cleanedString
        // Eg., "A man , A plan, A canal ,  Panama !"
        // cleanedString  = amanaplanacanalpanama

        string reverseString = new string(cleanedString.Reverse().ToArray());
        // this will use reverse() method which is another LINQ to reverse the cleanedString, it retuns 
        // IEnumerable<char> which is then stored in an array and then we convert it into a string
        // cleanedString.Reverse().ToArray() --> ['a','m','a','n','a', .....'m','a']
        //reverseString --> [amanaplanacanalpanama] (reversed string)

        return reverseString == cleanedString;
    }
    // Palindrome number checker
    public static void Main(string[] args)
    {
        Console.WriteLine("---Checking if a Number or string is Palindrome---");

        Console.WriteLine("Enter Input");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            int reverse = 0, result = 0, temp = number;

            while (number > 0)
            {
                reverse = number % 10; // Remainder - 1, 9, 1
                result = (result * 10) + reverse; // result = 1, 19, 191
                number = number / 10; // number = 19, 1, 0
            }

            // Now compare the original number (temp) with the reversed number (result)
            if (temp == result)
            {
                Console.WriteLine($"{temp} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{temp} is not a palindrome.");
            }
        }
        // Check if the input is a valid string (not a number)
        else if (!string.IsNullOrEmpty(input))
        {
            if (IsStringPalindrom(input))
                {
                Console.WriteLine($"{input} string is palindrome");
            }
            else
                Console.WriteLine($"{input} string is not a palindrome");

        }
        else
        {
            Console.WriteLine("Enter a valid input");
        }
    }
    */
}
