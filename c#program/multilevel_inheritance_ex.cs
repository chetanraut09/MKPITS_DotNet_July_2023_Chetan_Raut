using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance_ex
{
    public class animal
    {
        public void eat()
        { Console.WriteLine("eating...."); }
    }
    public class dog : animal
    {
        public void bark()
        { Console.WriteLine("barking..."); }
    }
    public class babydog:dog
    {
        public void weep()
        { Console.WriteLine("weeping..."); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            babydog b1 = new babydog();
            b1.eat();
            b1.bark();
            b1.weep();
        }
    }
}
