using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DallyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var WorksDay = double.Parse(Console.ReadLine());
            var MoneyPerDay = double.Parse(Console.ReadLine());
            var Dolar = double.Parse(Console.ReadLine());

            var Sallary = WorksDay * MoneyPerDay;
            var YearSallary = Sallary * 12;
            var Bonus = Sallary * 2.5;

            var all = (YearSallary + Bonus)  ;
            var Tax = Math.Abs(all * 0.25 - all);
            var DaySallaryLeva =  Tax * Dolar / 365;
            Console.WriteLine("{0:f2}", DaySallaryLeva);
        }
    }
}
