using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi3_positivenegativeno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >=0)
                Console.WriteLine("given no is positive");
            else
                Console.WriteLine("given  no is negative");
            Console.ReadKey();

        }
    }
}
