using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var countOfPeople = int.Parse(Console.ReadLine());

            var vip = 499.99;
            var normal = 249.99;
            var transport = 0.0;

            var all = 0.0;

            var ticketPrice = 0.0;

            if (countOfPeople >= 1 && countOfPeople <= 4)
            {
                transport = budget * 0.25;
            }
            else if (countOfPeople >= 5 && countOfPeople <= 9)
            {
                transport = budget * 0.40;
            }
            else if (countOfPeople >=10 && countOfPeople <= 24)
            {
                transport = budget * 0.50;
            }
            else if (countOfPeople >= 25 && countOfPeople <= 49)
            {
                transport = budget * 0.60;
            }
            else
            {
                transport = budget * 0.75;
            }

            if (type == "VIP")
            {
                ticketPrice = countOfPeople * vip;
            }
            else if (type == "Normal")
            {
                ticketPrice = countOfPeople * normal;
            }
            {
            }


            all = budget - ticketPrice;

            if (ticketPrice < transport)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.",
                    transport - ticketPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", 
                    ticketPrice - transport);
            }
        }
    }
}
