using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    class student
    {
        internal int rno;
        internal string name;
        public void displaydata()
        {
            Console.WriteLine("rno:" + rno);
            Console.WriteLine("name:" + name);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            s.rno = 1;
            s.name = "chetan";
            s.displaydata();
        }
    }
}
