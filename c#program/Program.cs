using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaandcircumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circ;
            Console.WriteLine("enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;

            Console.WriteLine("area=" + area);
            Console.WriteLine("circumference=" + circ);
            Console.ReadKey();
        }
    }
}
