using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_geometrical_shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r, num, sqr, num1,num2, rectangle, l, b;
            float area;
            Console.WriteLine("enter your choice no");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("enter radius of circle");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("area=" + area);
                    break;
                case 2:
                    Console.WriteLine("enter num1");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter num2");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    sqr = num1 * num2;
                    Console.WriteLine("suare=" + sqr);
                    break;
                case 3:
                    Console.WriteLine("enter length");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter breadth");
                    b = Convert.ToInt32(Console.ReadLine());
                    rectangle = l * b;
                    Console.WriteLine("rectangle=" + rectangle);
                    break;
                default:
                    Console.WriteLine("invalid shapes");
                    break;
            }
            Console.ReadKey();
        }
    }
}
