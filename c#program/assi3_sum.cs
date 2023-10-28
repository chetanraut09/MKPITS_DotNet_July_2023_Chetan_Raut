using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi3_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {2,5,8};
            int sum = 0;
            for(int i=0;i<3;i++)
            {

                sum = sum + num[i];
            }
            Console.WriteLine("sum:" + sum);
            
            Console.ReadLine();
        }
    }
}
