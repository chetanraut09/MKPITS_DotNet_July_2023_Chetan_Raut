using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance1
{
    public class Person
    {
        public string name;
        public string Address;
    }
    public class Student:Person
    {
        public int rno;
        public int marks;
    }


    internal class Program
    {
      class TestInheritance
            {

            static void Main(string[] args)
            {
                Student p1 = new Student();
                p1.rno = 111;
                p1.name = "chetan";
                p1.Address = "nagpur, maharastra";
                p1.marks = 99;
                Console.WriteLine("rollno:" + p1.rno);
                Console.WriteLine("name:" + p1.name);
                Console.WriteLine("Address:" + p1.Address);
                Console.WriteLine("marks:" + p1.marks);
            }
        }
    }
}
