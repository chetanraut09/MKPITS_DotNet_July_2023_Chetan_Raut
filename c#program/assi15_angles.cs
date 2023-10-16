using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi15_angles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("enter angle 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter angle2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter angle 3");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b + c == 180)
                Console.WriteLine("triangle is valid");
            else
                Console.WriteLine("triangle is not valid");
            Console.ReadKey();
        }
    }
}
