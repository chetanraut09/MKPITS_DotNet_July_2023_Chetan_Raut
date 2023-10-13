using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter the vakue of x=");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y=");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("points lies in first quadrant");
            else if (x < 0 && y > 0)
                Console.WriteLine("points lies in second quadrant");
            else if (x < 0 && y < 0)
                Console.WriteLine("points lies in third quadrant");
            else
                Console.WriteLine("points lies in fourth quadrant");
            Console.ReadKey();

        }
    }
}
