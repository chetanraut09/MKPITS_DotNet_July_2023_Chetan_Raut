﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance_overriding
{
     class account
     {
        public int actno;
        public int bal;
        public void deposit(int amt)
        {
            Console.WriteLine("this is deposit method of account class");
        }
     }
    class saving : account
    {
      public void deposit(int amt)
        {
            int interest = 500;
            bal = bal + amt + interest;
            Console.WriteLine("amount deposited with interest bal is " + bal);
        }

    }

    class current : account
    {
        //override the deposit method
        public void deposit(int amt)
        {

            bal = bal + amt;
            Console.WriteLine("amount deposited without interest bal is " + bal);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            saving s = new saving();
            s.actno = 111;
            s.deposit(1000);

            current c = new current();
            c.actno = 121;
            c.deposit(1000);


        }
    }
}
