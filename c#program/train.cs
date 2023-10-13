using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin, destination, classname, passenger, date,totalfare;
            int trainno;
            Console.WriteLine("enter originplace");
            origin = Console.ReadLine();
            Console.WriteLine("enter destination");
            destination = Console.ReadLine();
            Console.WriteLine("enter classname");
            classname= Console.ReadLine();
            Console.WriteLine("enter pasanger");
            passenger = Console.ReadLine();
            Console.WriteLine("enter date");
            date = Console.ReadLine();
            Console.WriteLine("trainno");
            trainno = Convert.ToInt32(Console.ReadLine());
            if (destination == mubaiiiiiiiiiiiiii)
                totalfare = 100;
            else if (destination == delhiiiiiiii)
                totalfare = 200;
            else if (destination == nashiiiiiiik)
                totalfare = 300;
            else
                Console.WriteLine("invalid destination");
            Console.WriteLine("origin= {0}, destination= {1}")


        }
    }
}
