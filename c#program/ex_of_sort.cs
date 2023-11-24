using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_of_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar= new ArrayList();
            ar.Add(15);
            ar.Add(8);
            ar.Add(33);
            Console.WriteLine("array list collection without sorting");

            foreach(object o in ar)
            {
                Console.WriteLine("student rno:"+o);
            }
             ar.Sort();
            Console.WriteLine("array list collection with sorting");
            foreach(object o in ar)
            {
                Console.WriteLine("student rno:" + o);
            }
        }
    }
}
