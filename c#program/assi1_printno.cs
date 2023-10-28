using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi1_printno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("enter number");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Elements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num[i]+" ");

            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
