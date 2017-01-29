using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = decimal.Parse(Console.ReadLine());
            var second = decimal.Parse(Console.ReadLine());
            var point = decimal.Parse(Console.ReadLine());
            var pointPosition = Math.Truncate(first - second - point);

            if (point > first && point < second) 
            {
                Console.WriteLine("in");
                Console.WriteLine(pointPosition);
            }
            else if (point > first && point < second)
            {

            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(pointPosition);
            }
        }
    }
}
