using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greaterno_ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("num1 is greater than num2");
            else
                Console.WriteLine("num2 is greater than num1");
            Console.ReadKey();
        }
    }
}
