﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            String t;
            t =Console.ReadLine();
            double x;
            x = double.Parse(t);
            double r;
            r = Math.Sqrt(1 - Math.Pow (Math.Sin(x*Math.PI/180),2));
           Console.WriteLine("{0:F4}", r);
        }
    }
}
