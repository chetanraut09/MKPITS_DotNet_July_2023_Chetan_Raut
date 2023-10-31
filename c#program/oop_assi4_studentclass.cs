using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assi4_studentclass
{
    class Student
    {
        int rollno;
        string name;
        int[] subjectmarks;

        public void getdata(int rollno, string name, int[]m)
        {
            this.rollno = rollno;
            this.name = name;
            this.subjectmarks = m;

        }
        public void displaydata()
        {
            Console.WriteLine("rollno=" + rollno);
            Console.WriteLine("name=" + name);
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total = total + subjectmarks[i];
            }
            int avg = total / subjectmarks.Length;
            Console.WriteLine("avg=" + avg);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("enter roll no and name");
            int r = Convert.ToInt32(Console.ReadLine());
            string n = Console.ReadLine();
            int[] m = new int[5];
            Console.WriteLine("enter 3 subject marks");
            for(int i=0;i<5;i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());

            }
            s.getdata(r, n, m);
            s.displaydata();
            Console.ReadKey();
        }
    }
}
