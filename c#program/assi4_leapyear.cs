using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi4_leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine("year is leap");
            else
                Console.WriteLine("year is not leap");
            Console.ReadKey();


        }
    }
}
