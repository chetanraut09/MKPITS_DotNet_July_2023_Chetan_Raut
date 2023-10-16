using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi20_digit_days_month
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit;
            string days = null, month = null;

            Console.Write("Enter Month in Digit : ");
            digit = Convert.ToInt32(Console.ReadLine());

            if (digit == 1)
            {
                month = "January";
                days = "31";
            }
            else if (digit == 2)
            {
                month = "February";
                days = "28";
            }
            else if (digit == 3)
            {
                month = "March";
                days = "31";
            }
            else if (digit == 4)
            {
                month = "April";
                days = "30";
            }
            else if (digit == 5)
            {
                month = "May";
                days = "31";
            }
            else if (digit == 6)
            {
                month = "June";
                days = "30";
            }
            else if (digit == 7)
            {
                month = "July";
                days = "31";
            }
            else if (digit == 8)
            {
                month = "August";
                days = "31";
            }
            else if (digit == 9)
            {
                month = "September";
                days = "30";
            }
            else if (digit == 10)
            {
                month = "Octomber";
                days = "31";
            }
            else if (digit == 11)
            {
                month = "November";
                days = "30";
            }
            else if (digit == 12)
            {
                month = "December";
                days = "31";
            }
            else
            {
                Console.WriteLine("Invalid Digit");
            }

            Console.WriteLine("\n" + month + ": " + days + " Days");
            Console.ReadKey();
        }
    }
}
