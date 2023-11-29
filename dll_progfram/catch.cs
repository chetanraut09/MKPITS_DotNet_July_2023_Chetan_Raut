using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("enter number1");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            n=Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n; //error will come here and program will terminate

            }
            catch (Exception e) 
            {
                
                Console.WriteLine("cannot divided by zero");

            }
            Console.WriteLine("res=" + res);
            Console.WriteLine("bye");

        }
    }
}
