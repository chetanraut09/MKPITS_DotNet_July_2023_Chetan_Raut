using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_classperson
{
    class Person
    {
        public string name;
    }
    class student : Person
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s= new student();
            s.rno = 111;
            s.name = "chetan";
            Console.WriteLine("rno=" + s.rno);
            Console.WriteLine("name=" + s.name);
        }
    }
}
