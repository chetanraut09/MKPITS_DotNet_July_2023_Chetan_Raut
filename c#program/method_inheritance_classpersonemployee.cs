using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_inheritance_classpersonemployee
{
    public class Person
    {
        string name;
        string address;

        public void getPersonData(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }

    }
    public class employee:Person
    {
        int empno;
        int salary;

        public void getemployeeData(int empno,int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("empno:" + empno);
            Console.WriteLine("salary:" + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e=new employee();
            e.getPersonData("chetan", "nagpur");
            e.getemployeeData(123, 40000);
            e.displayEmployeeData();
            e.displayPersonData();
        }
    }
}
