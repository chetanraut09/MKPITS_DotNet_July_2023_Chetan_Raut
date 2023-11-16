using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriting_method_classanimal
{
    public class animal
    {
        public void eat()
        { Console.WriteLine("eating"); }
    }
    public class dog : animal
    {
        public void bark()
        { Console.WriteLine("barking"); }
    }
    internal class Program
    {
        class TestInheritance
        {
            static void Main(string[] args)
            {
                dog d1 = new dog();
                d1.eat();
                d1.bark();
            }
        }
    }
}
