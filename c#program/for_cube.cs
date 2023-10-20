using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int result = 0;
            int cnt;
            Console.WriteLine("enter no of turms");
            num = Convert.ToInt32(Console.ReadLine());
            for(cnt=1;cnt<=num;cnt++)
            {
                result = cnt * cnt * cnt ;
                Console.WriteLine("num is={0} and cube of the {1}is{2}", cnt, cnt, result);
            }
            Console.ReadKey();
        }
    }
}
