using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi7_personheight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("enter height");
            height = Convert.ToInt32(Console.ReadLine());
            if (height < 147)
                Console.WriteLine("the person is dwarf");
            else
                Console.WriteLine("the person is giant");
            Console.ReadKey();

        }
    }
}
