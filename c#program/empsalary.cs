using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace empsalary
{
    internal class Program
    {
        static void Main()
        {
            int empno, basicsalary;
            string empname;
            float bonus=0;
            string designation;
            float totalsalary;
            Console.WriteLine("enter empno");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter empname");
            empname = Console.ReadLine();

            Console.WriteLine("enter basicsalary");
            basicsalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter designation");
            designation = Console.ReadLine();

            if (designation == "manager")
                bonus = 0.55f * basicsalary;
            else if (designation == "clerk")
                bonus = 0.25f * basicsalary;
            else if (designation == "peon")
                bonus = 0.10f * basicsalary;
            else
                Console.WriteLine("invalid designation");

            totalsalary = basicsalary + bonus;
            Console.WriteLine("emp no= {0}, empname= {1}, basicsalary={2}, designation={3}, bonus={4} ,totalsalary{5}", empno, empname, basicsalary, designation,bonus,totalsalary);
            Console.ReadKey();



        }
    }
}
