using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int sum = 0;
            foreach(int val in arr)
            {
                Console.WriteLine(val);
                sum = sum + val;
            }
            Console.WriteLine("sum of array element are " + sum);
            Console.ReadKey();

        }
    }
}
