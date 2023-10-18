using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_assi4_sumandavgof10no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            double avg = 0;
            while(num<=10)
            {
                Console.WriteLine(num);
                sum += num;
                avg = sum / 10.0;
                num++;
            }
            Console.WriteLine("result=" + sum);
            Console.WriteLine("avg=" + avg);
            Console.ReadKey();

        }
    }
}
