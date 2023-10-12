using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteandsbyte_dt
{
    internal class Program
    {
        static void Main()
        {
            byte b;
           
            Console.WriteLine("enter byte");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte=" + b);

            sbyte b1;
            Console.WriteLine("enter sbyte");
            b1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte=" + b1);
            Console.ReadKey();


        }
    }
}
