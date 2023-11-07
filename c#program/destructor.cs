using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex0f
{
    class Employee
    {
        //creating a constructor
        public Employee()
        {
            Console.WriteLine("constructor called");

        }
        ~Employee()
        {
            Console.WriteLine("destructer called");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.ReadKey();
            Employee emp1= new Employee();
            Console.ReadKey();
        }
    }
}
