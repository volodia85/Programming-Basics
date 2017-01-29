using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double posH = h * 100;
            double posW = (w - 1) * 100 ;
            var positionH = 120;
            var positionW = 70;
            var colum = Math.Round(posH / positionH );
            var round = Math.Round(posW / positionW);
            Console.WriteLine(round * colum - 3);
        }
    }
}
