using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assi2_personclass
{
    class Person
    {
        int age;
        string name;
        string adress;
        public void getdata(int age,string name,string adress)
        {
            this.age = age;
            this.name = name;
            this.adress = adress;

        }
        public void displaydata()
        {
            Console.WriteLine("age=" + age);
            Console.WriteLine("name=" + name);
            Console.WriteLine("adress=" + adress);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.getdata(23, "chetan raut", "chatrapati square");
            person1.displaydata();
            Console.ReadKey();
        }
    }
}
