using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    public class ArmstrongNumber
    {
        /*
        // 153 = 1*1*1 + 5*5*5 + 3*3*3
        //check if it is a valid numbe
       
        static void Main(String[] args)
        {

            int input, num, sum = 0;
            Console.WriteLine("Enter the number");
            if (!int.TryParse(Console.ReadLine(),out input) || input<0)
                {
                Console.WriteLine("Please enter a valid positive integer.");
                return;
            }
           
            int temp = input;
            // check if it is an armstrong number
            while (input > 0)
            {
                //input = 153
                num = input % 10; //3 // 5 // 1
                sum = sum + (num * num * num); // 0+3*3*3 // 27 + (5*5*5) = 152 // 152 + (1*1*1) = 153 
                input = input / 10; // 15 // 1 // <0
            }
            if (temp == sum)
            {
                Console.WriteLine($"{temp} is an Armstron number");
            }
            else
            {
                Console.WriteLine($"{temp} is not an armstrong number");
            }


        }*/
    }
}