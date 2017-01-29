using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressTheGirlFriend
{
    class Program
    {
        static void Main(string[] args)
        {
            var rubles = int.Parse(Console.ReadLine());
            var dollars = int.Parse(Console.ReadLine());
            var euro = int.Parse(Console.ReadLine());
            var levaOfferB = int.Parse(Console.ReadLine());
            var levaOfferM = int.Parse(Console.ReadLine());

            var r = rubles / 100 * 3.5;
            var d = dollars * 1.5;
            var e = euro * 1.95;

            var MaxPrice = int.MinValue;

            if (rubles >= MaxPrice)
            {
                MaxPrice += r;
            }
            Console.WriteLine(MaxPrice);
        }
    }
}
