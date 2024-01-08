using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum3
{
    internal class Program
    {
        enum category { student, it_proffetional}
        static void Main(string[] args)
        {
            int c= Convert .ToInt32(category.it_proffetional);
            if (c == 0)
            {
                Console.WriteLine("category is student");
            }
            else if(c == 1)
            {
                Console.WriteLine("category is it proffetional");
            }
            Console.ReadKey();
        }
    }
}
