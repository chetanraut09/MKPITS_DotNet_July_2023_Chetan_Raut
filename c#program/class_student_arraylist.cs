using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace class_student_arraylist
{
    class student
    {
        public int rno;
        public string name;

        public student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1=new student(12,"chetan");
            student s2 = new student(13, "rahul");
            student s3 = new student(14, "akashay");

            ArrayList al= new ArrayList();
            al.Add(s1);
            al.Add(s2);
            al.Add(s3);

            foreach(student s in al)
            {
                Console.WriteLine("rno:"+s.rno);
                Console.WriteLine("name:"+s.name);
            }
            
        }
    }
}
