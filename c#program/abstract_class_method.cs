using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_method
{
    abstract class account
    {
        public abstract void dipposit();//abstract method

        public void showbalance()
        {
            Console.WriteLine("balance method");

        }
        

    }
    class saving: account
    {
        public override void dipposit()
        {
            Console.WriteLine("hellow from saving deposite");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            account acc = new saving();
            acc.dipposit();
            acc.showbalance();
           Console.ReadLine();
        }
    }
}
