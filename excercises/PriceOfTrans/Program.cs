using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceOfTrans
{
    class Program
    {
        static void Main(string[] args)
        {
            var Km = int.Parse(Console.ReadLine());
            var DayOrNight = Console.ReadLine().ToLower();

            if (Km < 20)
            {
                if (DayOrNight == "day")
                {
                    Console.WriteLine((Km * 0.79)+ 0.70);
                }
                else if (DayOrNight == "night")
                {
                    Console.WriteLine((Km * 0.90)+ 0.70);
                }
            }
            if (Km >=20 && Km < 100)
            {
                Console.WriteLine(Km * 0.09);
            }
            if (Km >= 100)
            {
                Console.WriteLine(Km * 0.06);
            }

        }
    }
}
