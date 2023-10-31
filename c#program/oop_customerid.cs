using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_customerid
{
    class Customer
    {
       public int Customer_code;
        public string Customer_name;

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer Cust= new Customer();
            Cust.Customer_code = 123;
            Cust.Customer_name = "chetan";
            Console.WriteLine("customer code=" + Cust.Customer_code);
            Console.WriteLine("customer name=" + Cust.Customer_name);
            Console.ReadKey();


        }
    }
}
