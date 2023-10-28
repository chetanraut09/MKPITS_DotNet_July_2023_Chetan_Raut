using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi_reverseorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter number" + "" + i + ":");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the value store into the array:");
            for(int i=0;i<3;i++)
            {
                Console.Write(num[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("the value store into the array in reverse are:");
            for(int i=2;i>=0;i--)
            {
                Console.WriteLine(num[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
