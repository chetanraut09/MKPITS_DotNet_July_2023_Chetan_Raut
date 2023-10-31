using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assi3_rectangleclass
{
    class Rectangle
    {
        int width, height, area = 0;
        public void getdata(int width,int height)
        {
            this.width = width;
            this.height = height;
            area = width * height;


        }
        public void displaydata()
        {
            Console.WriteLine("width=" + width);
            Console.WriteLine("height=" + height);
            Console.WriteLine("area=" + area);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.getdata(5, 10);
            rect.displaydata();
            Console.ReadKey();
        }
    }
}
