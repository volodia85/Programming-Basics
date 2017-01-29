using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double Budget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            string destination;
            string typeVacantion;
            if (Budget <= 100 ) 
            {
                string destinatoin = "Bulgaria";
                if (season == "summer")
                {
                    Budget *= 0.30;
                    typeVacantion = "Camp";
                }
                Console.WriteLine("Somewhere in Bulgaria " + "Camp"  +  " - {0:f2}", Budget);
                if (season == "winter")
                {
                    Budget *= 0.70;
                    typeVacantion = "Hotel";
                    Console.WriteLine("Somewhere in Bulgaria " + "Hotel" + " - {0:f2}", Budget);
                }
                
            }
        }
    }
}
