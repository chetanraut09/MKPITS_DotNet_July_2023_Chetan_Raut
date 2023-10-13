using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi2_evenodd
{
    internal class Program
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("given no is even");
            else
                Console.WriteLine("given ni is odd");
            Console.ReadKey();
        }
    }
}
