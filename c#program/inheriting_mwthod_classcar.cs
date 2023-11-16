using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriting_mwthod_classcar
{
    public class car
    {
        public void start()
        {
            Console.WriteLine("car is starting");
        }
    }
    public class wagonr:car
    {
        public void startmusic()
        {
            Console.WriteLine("music is started");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            wagonr w = new wagonr();
            w.start();
            w.startmusic();
            Console.ReadLine();

        }
    }
}
