using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_table
{
    internal class Program
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            int result =0;
            int cnt = 1;
            for(cnt=1;cnt<=10;cnt++)
            {
                result = num * cnt;
                Console.WriteLine("{0}*{1}={2}", num, cnt, result);
            }
            Console.ReadKey();
        }
    }
}
