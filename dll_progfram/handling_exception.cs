using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handling_exception
{
    internal class DivNumber
    {
        int result;
        DivNumber()
        {
            result = 0;
        }
        public void Division(int num1,int num2)
        {
            try
            {
                result = num2 / num1;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("exception found:{0}",ex);

            }
            finally
            {
                Console.WriteLine("result:{0}", result);
            }
        }
        static void Main(string[] args)
        {
            DivNumber d= new DivNumber();
            d.Division(25, 0);
            Console.ReadKey();
        }
    }
}
