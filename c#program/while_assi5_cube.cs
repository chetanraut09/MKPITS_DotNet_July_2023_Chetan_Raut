using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_assi5_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count = 1, result = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while(count<=num)
            {
                result = count * count * count;
                Console.WriteLine("number is:{0}and cube of the {1} is {2}", count, count, result);
                count++;

            }
            Console.ReadKey();

        }
    }
}
