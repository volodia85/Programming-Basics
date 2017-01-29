using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            double weekends = 48;
            double game = 0;
            double allgames = 0;
            double sofiaGames = 0;
            double bornTown = 0;
            double leapYear;

            if (year == "leap")
            {
                weekends -= h;
                game = weekends * 3.0 / 4;
                sofiaGames = p * 2.0 / 3;
                allgames = game + h + sofiaGames;
                leapYear = allgames * 0.15;

                Console.WriteLine(Math.Truncate(allgames + leapYear));
            }
            if (year == "normal")
            {
                weekends -= h;
                game = weekends * 3.0 / 4;
                sofiaGames = p * 2.0 / 3;
                allgames = game + h + sofiaGames;

                Console.WriteLine(Math.Truncate(allgames));
            }
        }
    }
}
