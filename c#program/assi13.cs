using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            Console.WriteLine("enter a temperature");
            temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature < 0)
                Console.WriteLine("whether is very cold");
            else if (temperature > 0 && temperature < 10)
                Console.WriteLine("very cold whether");
            else if (temperature > 20 && temperature < 30)
                Console.WriteLine("whether is normal");
            else if (temperature > 30 && temperature < 40)
                Console.WriteLine("whether is hot");
            else
                Console.WriteLine("whether is very hot");
            Console.ReadKey();
        }
    }
}
