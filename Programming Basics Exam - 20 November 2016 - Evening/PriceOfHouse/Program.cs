using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceOfHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var Kitchen = double.Parse(Console.ReadLine());
            var priceOfKvm = double.Parse(Console.ReadLine());

            var bathroom = smallestRoom / 2;
            var secondRoom = smallestRoom * 1.10;
            var thirdRoom = secondRoom * 1.10;

            var allHouse = (smallestRoom + Kitchen + bathroom +
                secondRoom + thirdRoom) * 1.05;

            Console.WriteLine("{0:f2}", allHouse * priceOfKvm);
        }
    }
}
