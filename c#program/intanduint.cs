using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intanduint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = -233456;
            Console.WriteLine("value" + b);
            Console.WriteLine("enter");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value=" + b);
            uint b1 = 234567;
            Console.WriteLine("value= " + b1);
            Console.WriteLine("enter ");
            b1 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("value=" + b1);
            Console.ReadKey();


        }
    }
}
