using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_array_asparameter
{
    internal class Program
    {
        static void acceptarray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[1];
            }
            Console.WriteLine("sum of array elements are:" + sum);
        }

            static void Main(string[] args)
            {
                int[] num1 = { 11, 22, 33 };
                acceptarray(num1);
                Console.ReadKey();
            }
        
    }
}
