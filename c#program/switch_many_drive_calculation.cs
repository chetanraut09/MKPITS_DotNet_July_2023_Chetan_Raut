using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_meny_drive_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, add, mul, sub, choice;
            float div;
            
            Console.WriteLine("choice 1 for addition");         
            Console.WriteLine("choice 2 for multiplication");          
            Console.WriteLine("choice 3 for substraction");        
            Console.WriteLine("choice 4 for divison");

            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            
            switch (choice)
            {
                case 1:
                   
                    add = num1 + num2;
                    Console.WriteLine("addition=" + add);
                    break;
                case 2:

                    mul = num1 * num2;
                    Console.WriteLine("multiplication=" +mul);
                    break;
                case 3:

                    sub = num1 - num2;
                    Console.WriteLine("substraction=" + sub);
                    break;
                case 4:


                    div = num1 / num2;
                    Console.WriteLine("division=" + div);
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;



            }
            Console.ReadKey();



        }
    }
}
