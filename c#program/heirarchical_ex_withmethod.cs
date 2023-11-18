using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heirarchical_ex_withmethod
{
    public class person
    {
        public string name;
        public string address;
         
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
    public class student : person
    {
        public int rollno;
        public int marks;
         
        public void getstudentData(int rollno, int marks)
        {
            this.rollno = rollno;
            this.marks = marks;
        }
        public void displaystudentData()
        {
            Console.WriteLine("rollno:" + rollno);
            Console.WriteLine("marks:" + marks);

        }
    }
    public class employee : student
    {
        public int id;
        public string designation;

        public void getemployeeData(int rollno, string marks)
        {
            this.id = 123;
            this.designation = "md";
        }
        public void displayemployeeData()
        {
            Console.WriteLine("id:" + id);
            Console.WriteLine("designation:" + designation);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.getpersonData("chetan", "nagpur");
            s.getstudentData(123, 99);
            s.displaystudentData();
            s.displaypersonData();

            employee e1= new employee();
            e1.getpersonData("chetan", "nagpur");
            e1.getemployeeData(321, "md");
            e1.displayemployeeData();
            e1.displaypersonData();
            Console.ReadLine();



        }
    }
}
