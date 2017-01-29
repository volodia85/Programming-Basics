using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var hri = double.Parse(Console.ReadLine());
            var roses = double.Parse(Console.ReadLine());
            var laleta = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var day = Console.ReadLine();

            var priceOfHri = 2.00;
            var priceOfRosese = 4.10;
            var priceOfLaleta = 2.50;
            var priceOfHri2 = 3.75;
            var priceOfRoses2 = 4.50;
            var priceOfLaleta2 = 4.15;

            var hr = 0.0;
            var ros = 0.0;
            var lal = 0.0;
            var allflowers = 0.0;

            
            if (season == "Spring" || season == "Summer")
            {
                if (day == "Y")
                {
                    hr = hri * priceOfHri * 1.15;
                    ros = roses * priceOfRosese * 1.15;
                    lal = laleta * priceOfLaleta * 1.15;
                    allflowers = hr + ros + lal;
                }
                else if (day == "N")
                {
                    hr = hri * priceOfHri;
                    ros = roses * priceOfRosese;
                    lal = laleta * priceOfLaleta;
                    allflowers = hr + ros + lal;
                }

            }
            else if (season == "Autumn" || season == "Winter")
            {
                if (day == "Y")
                {
                    hr = hri * priceOfHri * 1.15;
                    ros = roses * priceOfRosese * 1.15;
                    lal = laleta * priceOfLaleta * 1.15;
                    allflowers = hr + ros + lal;
                }
                else if (day == "N")
                {
                    hr = hri * priceOfHri2;
                    ros = roses * priceOfRoses2;
                    lal = laleta * priceOfLaleta2;
                    allflowers = hr + ros + lal;
                }


            }

            if (laleta >= 7 && season == "Spring")
            {
                allflowers *= 0.95;
            }
            if (roses >= 10 && season == "Winter")
            {

                allflowers *= 0.90;

            }
            if (Math.Abs(hri + roses + laleta) >= 20)
            {
                allflowers *= 0.80;
            }
            Console.WriteLine("{0:f2}", allflowers + 2);
        }
    }
}
