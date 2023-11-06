using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace emp_construct_eithuservalvue
{
    class Employee
    {
        int empid;
        string empname;
        string designation;
        int salary;

        public Employee()
        {
            empid = 1;
            empname = "chetan";
            designation = "md";
            salary = 80000;
                
        }
        public Employee(int empid, string empname, string designation, int salary)
        {
            this.empid = empid;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
         
        public void display()
        {
            Console.WriteLine("EMployee Id = " + empid);
            Console.WriteLine("Employee name = " + empname);
            Console.WriteLine("Designation= " + designation);
            Console.WriteLine("Salary = " + salary);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp= new Employee();
            emp.display();

            Console.WriteLine("-------------Employee1details------------");
            Employee emp1= new Employee(1,"chetan","md",80000);
            emp1.display();

            Console.WriteLine("_------------employee1 details--------------");

            Console.WriteLine("----------Employee 2 datails----------");
            Console.WriteLine("Enter employee id");
            int empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name ");
            string empname = Console.ReadLine();
            Console.WriteLine("enter designation");
            string designation = Console.ReadLine();
            Console.WriteLine("enter salary");
            int salary= Convert.ToInt32(Console.ReadLine());

            
            Employee emp2= new Employee(empno,"empname","designation",salary);
            emp2.display(); 

            Console.ReadKey();





        }
    }
}
