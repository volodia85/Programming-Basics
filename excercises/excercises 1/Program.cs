﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercises_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());

            var a = Math.Abs(x2 - x3);
            var h = Math.Abs(y2 - y1);
            
            var area = (a * h) / 2;
            Console.WriteLine("area = " + area);
            
        }
    }
}
