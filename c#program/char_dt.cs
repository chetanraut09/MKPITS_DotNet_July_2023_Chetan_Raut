using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_dt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char b = 'M';
            Console.WriteLine("value" + b);
            Console.WriteLine("enter value");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("value=" + b);
            Console.ReadLine();

        }
    }
}
