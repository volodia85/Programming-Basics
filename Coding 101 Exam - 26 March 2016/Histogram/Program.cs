using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0.0;

            var numTo200 = 0.0;
            var numTo399 = 0.0;
            var numTo599 = 0.0;
            var numTo799 = 0.0;
            var numUp800 = 0.0;

            var counterTo200 = 0.0;
            var counterTo399 = 0.0;
            var counterTo599 = 0.0;
            var counterTo799 = 0.0;
            var counterUp800 = 0.0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    numTo200++;
                    counterTo200++;
                }
                else if (num >= 200 && num <= 399)
                {
                    numTo399++;
                    counterTo399++;
                }
                else if (num >= 400 && num <= 599)
                {
                    numTo599++;
                    counterTo599++;
                }
                else if (num >= 600 && num <= 799)
                {
                    numTo799++;
                    counterTo799++;
                }
                else if (num >= 800)
                {
                    numUp800++;
                    counterUp800++;
                }
            }
            Console.WriteLine("{0:f2}%", counterTo200 / n * 100);
            Console.WriteLine("{0:f2}%", counterTo399 / n * 100);
            Console.WriteLine("{0:f2}%", counterTo599 / n * 100);
            Console.WriteLine("{0:f2}%", counterTo799 / n * 100);
            Console.WriteLine("{0:f2}%", counterUp800 / n * 100);


        }
    }
}
