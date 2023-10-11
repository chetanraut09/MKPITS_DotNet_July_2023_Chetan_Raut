using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaofrectamgle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, breadth, ans;
            Console.WriteLine("enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            ans = length * breadth;
            Console.WriteLine("area=" + ans);
            Console.ReadKey();
        }
    }
}
