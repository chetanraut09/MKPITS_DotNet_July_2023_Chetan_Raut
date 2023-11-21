using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_class_rectangle1
{
    
    internal class Program
    {
        public interface drawable
        {
            void draw();
            
        }
        public class rectangle:drawable
        {
         public void draw()
            {
                Console.WriteLine("drawing rectangle....");
            }
        }
        public class circle : drawable
        {
            public void draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }
        static void Main(string[] args)
        {
            drawable d;
            d= new rectangle();
            d.draw();
            d=new circle();
            d.draw();


        }
    }
}
