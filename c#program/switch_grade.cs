using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade;
            Console.WriteLine("enter grade");
            grade = Console.ReadLine();
            switch(grade)
            {
                case "v":
                    Console.WriteLine("very good");
                    break;
                case "e":
                    Console.WriteLine("exellent");
                    break;
                case "g":
                    Console.WriteLine("good");
                    break;
                case "a":
                    Console.WriteLine("average");
                    break;
                case "f":
                    Console.WriteLine("failed");
                    break;



            }
            Console.ReadKey();
        }
    }
}
