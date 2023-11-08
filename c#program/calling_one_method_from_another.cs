
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_one_method_from_another
{
    class book
    {
        string title, author;

        public void getdata(string title)
        {
            Console.WriteLine("method with one parameter");
            getdata(title, "mansi");  //calling method with 2 parameters
        }
        public void getdata(string title, string author)
        {
            Console.WriteLine("method with 2 parameter");
            this.title = title;
            this.author = author;
        }

        public void display()
        {
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            book b1 = new book();
            b1.getdata("html");
            b1.display();
            Console.ReadKey();
        }
    }
}
