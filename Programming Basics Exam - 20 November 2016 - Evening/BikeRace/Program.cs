using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniorRacers = int.Parse(Console.ReadLine());
            var seniorRacers = int.Parse(Console.ReadLine());
            var typeOfRace = Console.ReadLine();

            var juniors = 0.0;
            var seniors = 0.0;
            var price = 0.0;

            if (typeOfRace == "trail")
            {
                juniors = 5.50;
                seniors = 7;
            }
            else if (typeOfRace == "cross-country")
            {
                if (juniorRacers + seniorRacers >= 50)
                {
                    juniors = 8;
                    seniors = 9.50;
                    price = (juniors * juniorRacers + seniors * seniorRacers) * 0.75;
                    Console.WriteLine("{0:f2}", price * 0.95);
                    return;
                }
                else
                {
                    juniors = 8;
                    seniors = 9.50;

                }
            }
            else if (typeOfRace == "downhill")
            {
                juniors = 12.25;
                seniors = 13.75;
            }
            else if (typeOfRace == "road")
            {
                juniors = 20;
                seniors = 21.50;
            }

            price = juniors * juniorRacers + seniors * seniorRacers;



            Console.WriteLine("{0:f2}", price * 0.95);
        }
    }
}
