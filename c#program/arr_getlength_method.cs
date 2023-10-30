using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr_getlength_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3,5,8,3,4 };
            int l = arr.GetLength(0);
            Console.WriteLine("length" + l);
            Console.ReadKey();
        }
    }
}
