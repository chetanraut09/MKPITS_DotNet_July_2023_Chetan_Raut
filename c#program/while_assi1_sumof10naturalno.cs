using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_assi1_sumof10naturalno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while(num<=10)
            {
                Console.WriteLine(num);
                sum += num;
                num++;

            }
            Console.WriteLine("result=" + sum);
            Console.ReadKey();

        }
    }
}
