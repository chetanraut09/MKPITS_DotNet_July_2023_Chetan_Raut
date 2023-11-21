using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_baseclass_constructor_internalyy
{
    class company
    {
        public string name = "mkcl";
        public company()
        {
            Console.WriteLine("base class constructor");
            Console.WriteLine("company name:" + name);

        }
    }
    class franchise:company
    {
        public string name = "mkpit";
        public franchise()
        {
            Console.WriteLine("derived class constructor");
            Console.WriteLine("franchise name:" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            franchise f= new franchise();
            Console.ReadLine();
        }
    }
}
