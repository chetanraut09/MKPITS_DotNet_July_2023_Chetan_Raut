using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized_constructor
{
    class Book
    {
        int bookid;
        string title;
        string Author;
        int price;

        public Book()
        {
            Console.WriteLine("constructor with no parameter");
            bookid = 1;
            title = "the hidden hindu";
            Author = "Akshat gupta";
            price = 500;

        }
        public Book(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.Author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id: " + bookid);
            Console.WriteLine("book title:" + title);
            Console.WriteLine("Author:" + Author);
            Console.WriteLine("book price: " + price);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();//this will call constructor with no parameter automatically
            b1.display();
              Book b2= new Book(2,"ramayan","valmiki",1000000000);//this will call parameterized constructor
            b2.display();

        }
    }
}
