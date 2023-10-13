using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3submarks_ifelseif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade = null;
            Console.WriteLine("enter marjs of subject");
            sub1 = Convert.ToInt32(Console.ReadLine());
            sub2 = Convert.ToInt32(Console.ReadLine());
            sub3 = Convert.ToInt32(Console.ReadLine());
            total = sub1 + sub2 + sub3;
            Console.WriteLine("total=" + total);
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("percentage=" +per);
            if(per>=75)
            {
                grade = "distinction";

            }
            else if(per>=60 && per<=75)
            {
                grade = "first class";

            }
            else
            {
                grade = "failed";

            }
            Console.WriteLine("grade=" + grade);
            Console.ReadKey();
        }
    }
}
