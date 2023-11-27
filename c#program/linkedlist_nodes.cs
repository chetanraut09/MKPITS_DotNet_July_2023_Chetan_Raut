using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist_nodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> num = new LinkedList<int>();
            num.AddLast(32);
            num.AddLast(22);
            num.AddLast(11);
            num.AddLast(33);
            num.AddLast(44);
            num.AddFirst(99);
            num.AddFirst(77);

            LinkedListNode<int> node = num.Find(77);
            num.AddBefore(node, 5);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
