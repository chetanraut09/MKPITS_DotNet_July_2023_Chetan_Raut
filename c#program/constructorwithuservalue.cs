using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constroctorwithuservalue
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
         
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("constructor with parametere called");

            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
            Console.WriteLine("price : " + price);



        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter book id");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter book titl");
            string t1 = Console.ReadLine();
            Console.WriteLine(" enter book author");
            string a1 = Console.ReadLine();
            Console.WriteLine("enter book price");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Book b2 = new Book(b1, t1, a1, p1); //this will call parameterized constructor
            b2.display();

        }
    }
}
