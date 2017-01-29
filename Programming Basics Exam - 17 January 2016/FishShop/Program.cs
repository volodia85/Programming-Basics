using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceOfSkumria = double.Parse(Console.ReadLine());
            double PriceOfCaca = double.Parse(Console.ReadLine());
            double AmountOfPalamud = double.Parse(Console.ReadLine());
            double AmountOfSafrid = double.Parse(Console.ReadLine());
            double AmountOfMidi = double.Parse(Console.ReadLine());

            double PriceOfPalamud = (PriceOfSkumria + PriceOfSkumria * 
                0.60) * AmountOfPalamud;
            double PriceOfSafrid = (PriceOfCaca + PriceOfCaca * 0.80) *
                AmountOfSafrid ;
            double PriceOfMidi = AmountOfMidi * 7.50;
            Console.WriteLine("{0:f2}",PriceOfPalamud+PriceOfSafrid+PriceOfMidi);
        }
    }
}
