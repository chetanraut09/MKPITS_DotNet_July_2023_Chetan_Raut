using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellonamesepereate
{
    internal class Program
    {
        static void Main()
        {
            string name;
            Console.WriteLine("hello");
            
            Console.WriteLine("enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello ! " + name);
            Console.ReadKey();
        }
    }
}
