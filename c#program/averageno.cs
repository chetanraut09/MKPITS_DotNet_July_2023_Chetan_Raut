using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, avg, sum;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num4");
            num4 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2 + num3 + num4;
            avg = sum / 4;
            Console.WriteLine("Average of: " + num1 + "," + num2 + "," + num3 + "," + num4 + " is " + avg);
            Console.ReadKey();
        }
    }
}
