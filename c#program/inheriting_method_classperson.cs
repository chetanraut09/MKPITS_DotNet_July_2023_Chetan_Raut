using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriting_method_classperson
{
    public class person
    {
        string name;
        string address;

        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayperdata()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("address:" + address);

        }
        

    }
    public class employee : person
    {
        int empno;
        int salary;

        public void getempdata(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }

        public void displayempdata()
        {
            Console.WriteLine("Empno  " + empno);
            Console.WriteLine("Salary " +  salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp= new employee();

            emp.getPersonData("Cheaten", " Nagpur");
            emp.getempdata(1, 6000);

            emp.displayperdata();
            emp.displayempdata();

            Console.ReadKey();

        }
    }
}
