using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_fabonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=0;
            int num2=1;
            int add;
            for(int num=0;num<10;num++)
            {
                Console.WriteLine(num2);
                add = num1 + num2;
                num1 = num2;
                num2 = add;
            }
            Console.ReadKey();

        }
    }
}
