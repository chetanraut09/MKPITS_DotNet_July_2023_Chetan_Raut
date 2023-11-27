using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionarry_generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("de", "grmanay");
            d.Add("sk", "slovakia");
            d.Add("us", "united state");
            d.Add("uk", "united kingdom");
            d.Add("ru", "russia");
            d.Add("pl", "poland");

            Console.WriteLine(d["sk"]);
            Console.WriteLine(d["de"]);
            Console.WriteLine("d has {0} items",d.Count());
            Console.WriteLine("Values of the dictionary:");

            List<string> vals = new List<string>(d.Values);

            foreach (string key in vals)
            {
                Console.WriteLine("{0}", key);
            }

            Console.WriteLine("Values of the dictionary:");

            List<string> v= new List<string>(d.Values);

            foreach (string val in vals)
            {
                Console.WriteLine("{0}", val);
            }

            Console.WriteLine("Keys and values of the dictionary:");


            foreach (KeyValuePair<string, string> kvp in d)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }



        }
    }
}
