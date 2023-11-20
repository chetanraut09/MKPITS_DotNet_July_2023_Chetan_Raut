using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_method_accountclass
{
    abstract class account
    {
        public int accno;
        public int balance = 1000;

        public abstract void deposit(int amt);
         
        public void showbalance()
        {
            Console.WriteLine("balance amt for acc no {0} is {1}", accno, balance);
        }
    }
    class current : account
    {
        public override void deposit(int amt)
        {
            balance= balance + amt;
        }
    }
    class saving:account
    {
        public override void deposit(int amt)
        {
            int interest = 200;
            balance=balance + amt+interest;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account no");
            int accno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ammt to be diposited");
            int amt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type current or saving");
            string acttype=Console.ReadLine();
            account act = null;
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }
            act.accno = accno;
            act.deposit(amt);
            act.showbalance();



        }
    }
}
