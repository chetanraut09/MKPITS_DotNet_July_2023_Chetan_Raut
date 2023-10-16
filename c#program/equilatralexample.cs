using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquailateralExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA, sideB, SideC;

            Console.WriteLine("Enter sideA");
            sideA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter sideB");
            sideB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter SideC");
            SideC = Convert.ToInt32(Console.ReadLine());

            if (sideA == sideB && sideB == SideC)
            {
                Console.WriteLine("This is Equalitral trangle Both side are same");
            }
            else if (sideA == SideC )
            {
                Console.WriteLine(" it is isoceles tangle"); 
            }
            else
            {
                Console.WriteLine(" it is sealene tangle");
            }

            Console.ReadKey();
        }
    }
}
