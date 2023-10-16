using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade_decription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;
            string description;
            Console.WriteLine("enter grade(E, V, G, A, F)");
            grade = Convert.ToChar(Console.ReadLine());
            if (grade == 'E')
                Console.WriteLine("description=Excellent");
            else if (grade == 'V')
                Console.WriteLine("description=very good");
            else if (grade == 'G')
                Console.WriteLine("description=Good");
            else if (grade == 'A')
                Console.WriteLine("description= Average");
            else if (grade == 'F')
                Console.WriteLine("description= failed");
            else
                Console.WriteLine("invalid description");
            Console.ReadKey();


        }
    }
}
