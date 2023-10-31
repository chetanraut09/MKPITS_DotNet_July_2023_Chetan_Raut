using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_custgetdata_getdisplay
{
    class Customer
    {
        int customer_code;
        string customer_name;
        public void getdata(int cc, string cn)
        {
            customer_code = cc;
            customer_name = cn;

        }
        public void displaydata()
        {
            Console.WriteLine("customer code" + customer_code);
            Console.WriteLine("costomer name" + customer_name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata(123, "chetan");
            cust.displaydata();
            Console.ReadKey();
        }
    }
}
