using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi6_mm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Enter Number");
            m = Convert.ToInt32(Console.ReadLine());

            if (m <= 0)
                Console.WriteLine("n=-1");
            else
                Console.WriteLine("n=1");

            Console.ReadLine();
        }
    }
}
