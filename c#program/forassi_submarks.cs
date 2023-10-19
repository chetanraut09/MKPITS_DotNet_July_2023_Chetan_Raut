using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forassi_submarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks;
            float total=0, per;
            string grade = null;
            for(int cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("enter marks");
                marks = Convert.ToInt32(Console.ReadLine());
                total = total + marks;
            }
            per = (total / 500.0f) * 100;
            if (per > 90)
            {
                grade = "A";
                
            }
            else if(per>80 && per<=90)
            {
                grade = "B";
            }
            else if(per>60 && per<=80)
            {
                grade = "c";
            }
            else
            {
                grade = "failed";
            }
            Console.WriteLine("total=" + total);
            Console.WriteLine("percentage=" + per);
            Console.WriteLine("grade=" + grade);
        }
    }
}
