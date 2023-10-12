using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean_dt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean b = true;
            Console.WriteLine("value" + b);
            Console.WriteLine("enter value");
            b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("value=" + b);
            Console.ReadLine();
        }
    }
}
