using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi4_vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
                if (age >=18)
                Console.WriteLine("eligible for vote");
            else
                Console.WriteLine("not eligible for vote");
            Console.ReadKey();

        }
    }
}
