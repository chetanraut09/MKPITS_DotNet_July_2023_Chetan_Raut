using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace example_remove_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar= new ArrayList();
            ar.Add(33);
            ar.Add(23);
            ar.Add(54);
            //displaying value of arraylist
            Console.WriteLine("arraylist collection without sorting");
            foreach(object o in ar)
            {
                Console.WriteLine("student rno:"+o);
            }
            ar.Remove(54);

            Console.WriteLine("array list collection after removing 54");
            foreach(object o in ar)
            {
                Console.WriteLine("student rno:" + o);
            }
            ar.RemoveAt(1);
            Console.WriteLine("array list collection after removing 1");
            foreach (object o in ar)
            {
                Console.WriteLine("student rno:" + o);

            }
        }
    }
}
