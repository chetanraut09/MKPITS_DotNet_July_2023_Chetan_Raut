using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int fact = 1;
            Console.WriteLine("enter number");
            number = Convert.ToInt32(Console.ReadLine()); //5
            while (number > 0)
            {
                fact = fact * number;
                number--;

            }
            Console.WriteLine("factorial = " + fact);


            Console.ReadKey();

        }
    }
}
