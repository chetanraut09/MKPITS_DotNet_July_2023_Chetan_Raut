using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookclass
{
    class Book
    {
         int Id;
        string Title, Author;
        int price;

        public Book()
        {
            Id = 12345;
            Title = "dendu";
            Author = "saran bhau";
            price = 6000;

        }
        public void display()
        {
            Console.WriteLine("Book Id:" + Id);
            Console.WriteLine("Book Title:" + Title);
            Console.WriteLine("Book Author:" + Author);
            Console.WriteLine("Book Price: " + price);
        }

    }
   
        

    internal class Program
    {
        static void Main(string[] args)
        {
            Book bo = new Book();
            bo.display();
            Console.ReadLine();
        }
    }
}
