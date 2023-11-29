using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @finally
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
            n= Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n; //error will come here and terminate the program
            }
            catch (Exception e)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine("cannot devided by zero");
            }
            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("res=" + res);
            }
            Console.WriteLine("bye");
        }
    }
}
