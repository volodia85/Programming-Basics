using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfMagnolies = double.Parse(Console.ReadLine());
            var countOfhyacinthes = double.Parse(Console.ReadLine());
            var countOfRoses = double.Parse(Console.ReadLine());
            var countOfCactuses = double.Parse(Console.ReadLine());
            var priceOfPresent = double.Parse(Console.ReadLine());

            var magnolies = 3.25;
            var hyacinthes = 4.0;
            var roses = 3.50;
            var cactuses = 8.0;

            var allMoney = ((magnolies * countOfMagnolies) + (hyacinthes * countOfhyacinthes)
                + (roses * countOfRoses) + (cactuses * countOfCactuses)) * 0.95;

            if (allMoney >= priceOfPresent)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(allMoney - priceOfPresent));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(priceOfPresent - allMoney));
            }
        }
    }
}
