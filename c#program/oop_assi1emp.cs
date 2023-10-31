using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assi1emp
{
    class Employee
    {
        int empno;
        int salary;
        string designation;
        string empname;



        public void getdata(int empno, int salary, string designation, string empname)
       {
            this.empno=empno;
            this.salary = salary;
            this.designation = designation;
            this.empname = empname;
        }
        public void displaydata()
        {
            Console.WriteLine("employee no=" + empno);
            Console.WriteLine("salary=" + salary);
            Console.WriteLine("designation=" + designation);
            Console.WriteLine("empname=" + empname);
        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getdata(123, 50000, "md", "Chetan");
            emp.displaydata();
            Console.ReadKey();
        }
    }
}
