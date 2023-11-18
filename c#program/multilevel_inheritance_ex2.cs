using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance_ex2
{
    public class person
    {
        string name;
        string address;

        public void getpersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersonData()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);
        }
    }
    public class employee : person
    {
        int salary;
        int empno;

        public void getemployeeData(int salary, int empno)
        {
            this.salary = salary;
            this.empno = empno;
        }
        public void displayemployeeData()
        {
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("empno:" + empno);
        }
    }
    public class parttimeemployee:employee
    {
        int no_of_hours;

        public void getparttimeemployeeData(int no_of_hours)
        {
            this.no_of_hours = no_of_hours;
        }
        public void displayparttimeemployeeData()
        {
            Console.WriteLine("no of hours:" + no_of_hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.getpersonData("chetan", "nagpur");
            p.displaypersonData();

            employee Emp  = new employee();
            Emp.getemployeeData(6000, 1);
            Emp.displayemployeeData();  



          parttimeemployee e= new parttimeemployee();
            e.getparttimeemployeeData(8);
            e.displayparttimeemployeeData();

            Console.ReadKey();
        }
    }
}
