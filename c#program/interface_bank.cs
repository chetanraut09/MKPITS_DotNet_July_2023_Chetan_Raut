using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank
{
    interface bank
    {
        string deposit(int actno, int amt);
    }
    class saving : bank
    {
        int actno;
        int bal=1000;
        public string deposit(int actno, int amt)
        {
            this .actno = actno;
            bal = bal + amt;
            return "deposit successfully successfully , bal is" + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b;
            b=new saving();
            string str=b.deposit(1, 200);
            Console.WriteLine(str);
        }
    }
}
