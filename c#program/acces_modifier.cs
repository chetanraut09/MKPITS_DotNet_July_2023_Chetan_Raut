using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acces_modifier
{

    internal class Program
    {
        class PublicTest
        {

            public string name = "santosh kumar";
            public void msg(string msg)
            {
                Console.WriteLine("hello" + msg);
            }
        }
            
        
        static void Main(string[] args)
        {
            PublicTest test = new PublicTest();
            Console.WriteLine("hellow" + test.name);
            test.msg("chetan");
        }
    }
}
