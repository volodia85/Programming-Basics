using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());

            var moneyAfter = 0.0;
            var counter = 17;

            for (int i = 1800; i <= year; i++)
            {
                counter++;
                if (i % 2 == 0)
                {
                    moneyAfter = money - 12000;
                    money = moneyAfter;

                }
                else 
                {
                    moneyAfter = money - (12000 + counter * 50);
                    money = moneyAfter;
                }

            }
            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", 
                    money);
            }
            else if (money < 0)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", money-money-money);
            }
        }
    }
}
