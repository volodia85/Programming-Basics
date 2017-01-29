using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountCake = int.Parse(Console.ReadLine());
            var KgFlourForOneCake = int.Parse(Console.ReadLine());
            var KgFlourAvailable = int.Parse(Console.ReadLine());
            var AmountOfTruffles = int.Parse(Console.ReadLine());
            var PriceOfTruffle = int.Parse(Console.ReadLine());

            var Kg = KgFlourAvailable / KgFlourForOneCake;
            var TruffelesCoast = AmountOfTruffles * PriceOfTruffle;
            var CakePrice = (TruffelesCoast / amountCake) * 1.25;

       }
    }
}
