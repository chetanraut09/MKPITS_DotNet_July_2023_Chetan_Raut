using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance_assignment1
{
    public class person
    {
        public string name;
        public string address;
    }
    public class employee : person
    {
        public int empno;
        public float salary;
        public string designation;
    }

    internal class Program
    {
        class TestInheritance
        {


            static void Main(string[] args)
            {
                employee e1 = new employee();
                e1.name = "chetan";
                e1.address = "nagpur,maharashtra";
                e1.empno = 1;
                e1.salary = 400000;
                e1.designation = "md";
                Console.WriteLine("name:" + e1.name);
                Console.WriteLine("address:" + e1.address);
                Console.WriteLine("empno:" + e1.empno);
                Console.WriteLine("salary :" + e1.salary);
                Console.WriteLine("designation:" + e1.designation);
            }
        }
    }
}
