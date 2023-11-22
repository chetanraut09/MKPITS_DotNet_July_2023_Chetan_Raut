using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_namespace
{
    using First;
    using First.Second;
    namespace First
    {
        public class Hello
        {
            public void sayHello() { Console.WriteLine("Hello First Namespace"); }
        }
        //creating a nested namespace
        namespace Second
        {
            public class Welcome
            {
                public void sayHello() { Console.WriteLine("Hello Second Namespace"); }
            }
        }
    }



    namespace ConsoleApp6
    {

        class Program
        {

            static void Main(string[] args)
            {


                Hello h1 = new Hello();
                h1.sayHello();
                Welcome w = new Welcome();
                w.sayHello();





            }
        }
    }
}
