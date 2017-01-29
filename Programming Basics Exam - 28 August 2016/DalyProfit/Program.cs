using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var workpacients = int.Parse(Console.ReadLine());
            var moneyPerDay = double.Parse(Console.ReadLine());
            var dollar = double.Parse(Console.ReadLine());

            var sallary = workpacients * moneyPerDay;
            var yearSallary = sallary * 12 + sallary * 2.5;
            var tax = yearSallary * 0.75 * dollar;
            var dalyProfit = tax / 365;
            Console.WriteLine("{0:f2}",dalyProfit);
        }
    }
}
