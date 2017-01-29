using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputcurrecy = double.Parse(Console.ReadLine());
            var unitOne = Console.ReadLine();
            var unitTwo = Console.ReadLine();

            var bgn = 1;
            var usd = 1.79549;
            var eur = 1.9558;
            var gbp = 2.53405;

            if (unitOne == "usd" && unitTwo == "bgn")
            {
                Console.WriteLine("{0} * {1} / {2}",inputcurrecy, usd, bgn, 2);
            }
            else if (unitOne == "bgn" && unitTwo == "eur")
            {
                Console.WriteLine("{0}*{1}", bgn, eur, 2);
            }
            else if (unitOne == "eur" && unitTwo == "gbp")
            {
                Console.WriteLine("{0}*{1}", eur, gbp, 2);
            }
            else if (unitOne == "usd" && unitTwo == "eur")
            {
                Console.WriteLine("{0}*{1}", usd, eur, 2);
            }
            

        }
    }
}
