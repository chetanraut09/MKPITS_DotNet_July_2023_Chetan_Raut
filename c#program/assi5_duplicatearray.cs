using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi5_duplicatearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("element of array1:"); 
            for(int i=0;i<3;i++)
            {
                arr2[i] = arr1[i];
                Console.Write(arr1[i]);
            }
            Console.Write("\n");
            Console.WriteLine("element coppied in array2");
            for(int i=0;i<3;i++)
            {
                Console.Write(arr2[i]);
            }
            Console.ReadKey();
        }
    }
}
