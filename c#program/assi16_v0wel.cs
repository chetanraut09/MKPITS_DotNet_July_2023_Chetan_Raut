using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assi16_vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' ||ch== 'e' ||ch== 'i' ||ch== 'o' ||ch== 'u')
                Console.WriteLine("it is vowel");
            else
                Console.WriteLine("it is consonant");
            Console.ReadKey();
        }
    }
}
