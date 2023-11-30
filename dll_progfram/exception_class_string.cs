using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_class_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {


                Console.WriteLine(str.Substring(5));
            }
            catch(NullReferenceException ne) 
            {
                Console.WriteLine(ne.ToString());
            }
            Console.WriteLine("bye");
        }
    }
}
