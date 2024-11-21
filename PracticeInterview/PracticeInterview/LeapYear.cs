using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterview
{
    internal class LeapYear
    {
        public static bool isLeap(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
       /* public static void Main(string[] args)
        {
            if (isLeap(2020)){
                Console.WriteLine("2020 is a leap year");
            }
            else
            {

                Console.WriteLine("202 is not a leap year");
            }

        }*/
    }
        }
