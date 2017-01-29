using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = int.Parse(Console.ReadLine());
            var grapeByArea = double.Parse(Console.ReadLine());
            var needWine = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grape = area * grapeByArea;
            var wine = grape * 0.40 / 2.5;

            
            if (wine >= needWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", 
                    wine);
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(wine - needWine), Math.Ceiling((wine - needWine) / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", 
                    Math.Floor(needWine - wine));
            }
        }
    }
}
