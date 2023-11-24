using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_of_insert_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar= new ArrayList();
            ar.Add(12);
            ar.Add(33);
            ar.Add(22);

            Console.WriteLine("array list without sorting");

            foreach(object o in ar)
            {
                Console.WriteLine("student rno:"+o);
            }
            ar.Insert(2,17);
            Console.WriteLine("array list collection after adding element at 2 position");
            
            foreach (object o in ar)
            {
                Console.WriteLine("student rno:" + o);

            }
        }
    }
}
