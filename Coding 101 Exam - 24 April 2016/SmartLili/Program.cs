using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            var old = int.Parse(Console.ReadLine());
            var priceOfWash = double.Parse(Console.ReadLine());
            var priceOfToy = int.Parse(Console.ReadLine());

            var money = 0;
            var moneyB = 10;
            var toy = 0;
            var getMoney = 0;

            for (int i = 1; i <= old; i++)
            {
                if (i % 2 == 0)
                {
                    money += moneyB;
                    moneyB += 10;
                    getMoney++;
                }
                else
                {
                    toy++;
                }

            }
            var selltoys = toy * priceOfToy;
            var all = money + selltoys - getMoney;

            if (all >= priceOfWash)
            {
                Console.WriteLine("Yes! {0:f2}", all - priceOfWash);
            }
            else if (all < priceOfWash)
            {
                Console.WriteLine("No! {0:f2}", priceOfWash - all);
            }


        }
    }
}
