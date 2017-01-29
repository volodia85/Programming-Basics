using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var shirochina = double.Parse(Console.ReadLine());
            var duljina = double.Parse(Console.ReadLine());
            var stranaTri = double.Parse(Console.ReadLine());
            var visoqinaTri = double.Parse(Console.ReadLine());
            var priceByTie = double.Parse(Console.ReadLine());
            var work = double.Parse(Console.ReadLine());

            var bathArea = shirochina * duljina;
            var tilArea = stranaTri * visoqinaTri / 2;
            var needTil = Math.Ceiling(bathArea / tilArea);
            var allTil = needTil + 5;
            var price = allTil * priceByTie + work;

            if (price <= money)
            {
                Console.WriteLine("{0:f2} lv left.", Math.Abs(price - money));
            }
            else if (price > money)
             {
                Console.WriteLine("You'll need {0:f2} lv more.", Math.Abs(money - price));
            }

        }
    }
}
