﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("amitabh");
            sb.Append("chetan");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("bye");
        }
    }
}
