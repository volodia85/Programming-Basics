﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = Double.Parse(Console.ReadLine());
            var y1 = Double.Parse(Console.ReadLine());
            var x2 = Double.Parse(Console.ReadLine());
            var y2 = Double.Parse(Console.ReadLine());
            var width = Math.Abs(x1 - x2);
            var height = Math.Abs(y1 - y2);
            var area = (width * height);
            var perimeter = (2 * (width + height));
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
