using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace arraylist2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
             foreach(object o in ar)
            {
                Console.WriteLine("student rno:"+o);
            }
            Console.WriteLine("capacity :{0}" + ar.Capacity);
            Console.WriteLine("count : {0}"+ar.Count);
        }
    }
}
