using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseclassmethod_classcompany
{
    class company
    {
        public string name = "mkcl";
        public void display()
        {
            Console.WriteLine("comapany name:" + name);

        }
    }
    class franchize:company
    {
        public string name = "mkpits";
        public void display()
        {
            base.display();
            Console.WriteLine("franchize name:"+name);
        }
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            franchize f = new franchize();
            f.display();
            Console.ReadKey();
        }
    }
}
