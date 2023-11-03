using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        
        
            int productid;
            string productname;
            int price;
            int quantity;

            public Product()
            {
                productid = 12345;
                productname = "shilajit";
                price = 100;
                quantity = 1000;

            }
            public void display()
            {
                Console.WriteLine("product id: " + productid);
                Console.WriteLine("product name: "+productname);
                Console.WriteLine("product price: " + price);
                Console.WriteLine("product quanity:" + quantity);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Product pro = new Product();
        pro.display();
        Console.ReadLine();
        }
    }

