using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = Double.Parse(Console.ReadLine());
            var b2 = Double.Parse(Console.ReadLine());
            var h = Double.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2;

            Console.WriteLine("Trapezoid Area = "+ area);
        }
    }
}
