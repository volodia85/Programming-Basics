using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal celsium = decimal.Parse(Console.ReadLine());
            decimal farenheit = Math.Round(celsium * 9 / 5 + 32, 2, MidpointRounding.ToEven);

            Console.WriteLine(farenheit);
        

        }
    }
}
