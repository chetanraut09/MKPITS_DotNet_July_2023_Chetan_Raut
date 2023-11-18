using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_ex
{
  public  class person
    {
       public string name;
        public string address;
        
    }
    public class student:person
    {
        public int rno;
        public float marks;
    }
     public class employee : person
    {
        public int id;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student std = new student();
            std.name = "chetan";
            std.address = "nagpur";
            std.rno = 123;
            std.marks = 99;
            Console.WriteLine("---------student info----------");
            Console.WriteLine("name:" + std.name);
            Console.WriteLine("address:" + std.address);
            Console.WriteLine("roll no:" + std.rno);
            Console.WriteLine("marks:"+std.marks);

            employee emp = new employee();
            emp.name = "lucky";
            emp.address = "nagpur";
            emp.id = 321;
            emp.designation = "md";
            Console.WriteLine("-------employee info-------");
            Console.WriteLine("name:" + emp.name);
            Console.WriteLine("address:" + emp.address);
            Console.WriteLine("id:" + emp.address);
            Console.WriteLine("designation:" + emp.designation);
            Console.ReadKey();
            
        }
    }
}
