using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hashtable_keyvalue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht=new Hashtable();
            ht.Add("001", "zara ali");
            ht.Add("002", "chetan");
            ht.Add("003", "akash");
            ht.Add("004", "lucky");
            ht.Add("005", "sarang");
            ht.Add("006", "devid");
            ht.Add("007","sujit");

            if(ht.ContainsValue("mayuri"))
            {
                Console.WriteLine("this student name is already in the list");
            }
            else
            {
                ht.Add("008", "mayuri");
            }
            ICollection key = ht.Keys;
            foreach (string k  in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
            Console.ReadLine();

        }
    }
}
