using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_classemployee
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public Employee()
        {
            empno = 123;
            empname = "chetan raut";
            designation = "md";
            salary = 60000;
        }
        public void display()
        {
            Console.WriteLine("employee number:" + empno);
            Console.WriteLine("employee name:" + empname);
            Console.WriteLine("employee designation: " + designation);
            Console.WriteLine(" employee salary: " + salary);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.ReadLine();
        }
    }
}
