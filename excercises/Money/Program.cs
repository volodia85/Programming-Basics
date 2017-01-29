using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double Bitc = double.Parse(Console.ReadLine());
            double China = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());
            decimal Bit = 1168m;
            decimal usd = 1.76m;
            decimal euro = 1.95m;
            decimal jun = 0.264m;
            
            Console.WriteLine((1168 * Bit) + (China * 0.264)- ((1168 * Bitc) + (China * 0.264)* comission));
        }
    }
}
