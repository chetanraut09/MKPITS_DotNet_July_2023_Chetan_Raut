using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_level_inheritance
{
    public class Employee
    {
        public float salary = 40000;

    }
    public class Programmer : Employee
    {
        public float bonus = 10000;
    }

    internal class Program
    {
        class TestInheritance
        {
            static void Main(string[] args)
            {
                Programmer p1 = new Programmer();
                Console.WriteLine("salary:" + p1.salary);
                Console.WriteLine("bonus:" + p1.bonus);
            }
        }
    }
}
