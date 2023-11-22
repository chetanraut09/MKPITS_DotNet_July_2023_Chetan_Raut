using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_access_specifier2
{
    class person
    {
        protected string name;

    }
    class student : person
    {
        public void getdata()
        {
            name = "ravi";
            Console.WriteLine("name=" + name);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            s.getdata();
        }
    }
}
