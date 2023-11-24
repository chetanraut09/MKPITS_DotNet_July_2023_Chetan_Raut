using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace class_program_arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add("chetan");
            ar.Add("akash");
            ar.Add("lucky");
            ar.Add("sarang");
            ar.Add("sujjju");
            ar.Add("devid ali");
            foreach(object obj in ar)
            {
                Console.WriteLine("student name:"+obj);
            }
        }
    }
}
