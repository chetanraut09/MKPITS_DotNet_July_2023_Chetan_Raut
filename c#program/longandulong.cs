using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longandulong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long b = -23456789L;
            Console.WriteLine("value" + b);
            Console.WriteLine("enter");
            b = Convert.ToInt64(Console.ReadLine());
            ulong b1 = 23456L;
            Console.WriteLine("value" + b1);
            Console.WriteLine("enter");
            b1 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("value=" + b1);
            Console.ReadLine();
        }
    }
}
