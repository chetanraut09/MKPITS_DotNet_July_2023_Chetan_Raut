using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("java");
            li.Add("c#");
            li.Add("c");
            li.Add("c++");
            li.Add("rubby");
            li.Add("javacript");

            Console.WriteLine(li.Contains("c#"));
            Console.WriteLine(li[1]);
            Console.WriteLine(li[2]);
            li.Remove("c#");
            li.Remove("c");

            Console.WriteLine(li.Contains("c#"));

            li.Insert(4, "haskell");
            li.Sort();
            foreach (string s in li) 
            {
                Console.WriteLine(s);
            }

        }
    }
}
