﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_monthno_monthname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthno;
            Console.WriteLine("enter month number");
            monthno = Convert.ToInt32(Console.ReadLine());
            switch(monthno)
            {
                case 1:
                    Console.WriteLine("january");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("Jully");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("saptember");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("imvalid month");
                    break;

                
            }
            Console.ReadKey();
        }
    }
}
