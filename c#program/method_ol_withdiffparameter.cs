using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_ol_withdiffparameter
{
    class Calculate
    {
        public void addition(int n1,int n2)
        {
            int res=n1 + n2;
            Console.WriteLine("addition of two int is:"+res);
        }
        public void addition(float n1,float n2)
        {
            float res=n1 + n2;
            Console.WriteLine("addition of two float:" + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate c= new Calculate();
            c.addition(1, 2);
            Console.WriteLine("now calling addition of float no");
            c.addition(2.3f, 3.2f);
            Console.ReadKey();

        }
    }
}
