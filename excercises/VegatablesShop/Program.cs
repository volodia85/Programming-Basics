using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegatablesShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var PriceKgVega = double.Parse(Console.ReadLine());
            var PriceKgFruits = double.Parse(Console.ReadLine());
            var KgVega = double.Parse(Console.ReadLine());
            var KgFruits = double.Parse(Console.ReadLine());

            var VegaPrice = PriceKgVega * KgVega;
            var FruitsPrice = PriceKgFruits * KgFruits;
            var Total = ((VegaPrice + FruitsPrice) / 1.94) ;
            Console.WriteLine(Total);
        }
    }
}
