using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    abstract class person
    {
        public string name;
    }
    class student : person
    {
        public int rno;
    }
    sealed class parttimestudent : student
    {
        public int hours;
    }
    /*
    class newstudent : parttimestudent //error
    {

    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            //    person p = new person(); //error
            parttimestudent p = new parttimestudent();
            p.rno = 22;
            p.name = "ratan";
            p.hours = 5;
            Console.WriteLine("rno " + p.rno);
            Console.WriteLine("name " + p.name);
            Console.WriteLine("hours " + p.hours);
        }
    }
}
