using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_shape
{
    internal class Program
    {
        interface shape
        {
            void draw();
        }
        class rectangle: shape
        {
            public void draw()
            {
                Console.WriteLine("draw method of rectangle class");
            }
        }
        class circle : shape
        {
            public void draw()
            {
                Console.WriteLine("draw method of circle class");
            }
        }
        static void Main(string[] args)
        {
            shape s=new rectangle();
            s.draw();
            s=new circle();
            Console.ReadLine();
        }
    }
}
