using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 1.79549;
            double leva = double.Parse(Console.ReadLine());
            double result = Math.Round(leva * usd, 2);
            Console.WriteLine(result);
        }
    }
}
