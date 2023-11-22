using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    public class Animal
    {
        public virtual void eat() { Console.WriteLine("eating..."); }
        public virtual void run() { Console.WriteLine("running..."); }

    }
    public class Dog : Animal
    {
        public override void eat() { Console.WriteLine("eating bread..."); }
        public sealed override void run()
        {
            Console.WriteLine("running very fast...");
        }
    }
    public class BabyDog : Dog
    {
        public override void eat() { Console.WriteLine("eating biscuits..."); }
        
    }
    public class TestSealed
    {
        public static void Main()
        {
            BabyDog d = new BabyDog();
            d.eat();
            d.run();
        }
    }
}
