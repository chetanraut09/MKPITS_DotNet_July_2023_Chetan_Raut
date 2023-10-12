using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_dt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float b = 123.4567890f;
            Console.WriteLine("value" + b);
            Console.WriteLine("enter value");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("value=" + b);
            Console.ReadLine();
        }
    }
}
