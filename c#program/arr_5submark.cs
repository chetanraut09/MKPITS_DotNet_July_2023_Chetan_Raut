using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr_5submark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int total = 0;
            float per = 0;
            string grade = null;
            for(int cnt=0;cnt<5;cnt++)
            {
                Console.WriteLine("enter 5 sub marks");
                marks[cnt] = Convert.ToInt32(Console.ReadLine());

            }
            for(int cnt=0;cnt<5;cnt++)
            {
                total = total + marks[cnt];
                per = (total / 500.0f) * 100.0f;

            }
            
            if(per>90)
            {
                grade = "distinction";

            }
            else if(per>80 && per<90)
            {
                grade = "first class";
            }
            else if(per>60 && per<80)
            {
                grade = "second class";
            }
            else
            {
                grade = "failed";
            }
            Console.WriteLine("total : " + total);
            Console.WriteLine("per: " + per);
            Console.WriteLine("grade: " + grade);
            Console.ReadKey();

      
        }
    }
}
