﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = typeof(string);
            
            Console.WriteLine(name.GetType());
        }
    }
}
