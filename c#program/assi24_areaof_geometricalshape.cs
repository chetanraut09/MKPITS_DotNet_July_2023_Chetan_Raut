using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi24_areaofgeometricalshape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            float result = 0;

            Console.Write("Enter Choice (1, 2, 3 , 4, 5): ");
            choice = Convert.ToInt32(Console.ReadLine());



            if (choice == 1)
            {
                int radius;
                Console.WriteLine("\n----- Area of Circle -----\n");
                Console.Write("Enter radius: ");
                radius = Convert.ToInt32(Console.ReadLine());

                result = 3.14f * radius * radius;
            }

            else if (choice == 2)
            {
                int length, width;
                Console.WriteLine("\n----- Area of Rectangle -----\n");
                Console.Write("Enter Length: ");
                length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Widht: ");
                width = Convert.ToInt32(Console.ReadLine());

                result = length * width;
            }

            else if (choice == 3)
            {
                int bs, ht;
                Console.WriteLine("\n----- Area of Triangle -----\n");
                Console.Write("Enter Base: ");
                bs = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Height: ");
                ht = Convert.ToInt32(Console.ReadLine());

                result = (1 / 2f) * bs * ht;
            }

            else
            {
                Console.WriteLine("\nInvalid Choice: ");
            }


            Console.WriteLine("\nThe Area is : " + result);
            Console.ReadKey();


        }
    }
}
