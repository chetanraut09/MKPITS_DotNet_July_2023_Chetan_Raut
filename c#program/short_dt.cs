using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_dt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short b = 12345;
            Console.WriteLine("value" + b);
            Console.WriteLine("enter short");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("value" + b);
            ushort b1 = 56789;
            Console.WriteLine("value" + b1);
            Console.WriteLine("enter ushort");
            b1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("value" + b1);
            Console.ReadKey();
        }
    }
}
