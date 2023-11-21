using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_keyword_classanimal
{
    class Animal
    {
        public string color = "white";

    }
    class Dog : Animal
    {
        public string color = "red";

        public void displaycolor()
        {
            Console.WriteLine("dog color:" + color);
            Console.WriteLine("animal color:" + base.color);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d= new Dog();
            d.displaycolor();
            Console.ReadLine();
        }
    }
}
