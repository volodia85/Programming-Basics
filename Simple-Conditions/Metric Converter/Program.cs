using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            double inputcurrecy = double.Parse(Console.ReadLine());
            string unitin = Console.ReadLine();
            string unitout = Console.ReadLine();

            double baseMetricValue = inputcurrecy;

            if (unitout == "m")
            {
                baseMetricValue = baseMetricValue * 1;
            }

            else if (unitout == "mm")
            {
                baseMetricValue = baseMetricValue * 1000;
            }
            else if (unitout == "cm")
            {
                baseMetricValue = baseMetricValue * 100;
            }
            else if (unitout == "mi")
            {
                baseMetricValue = baseMetricValue * 0.000621371192;
            }
            else if (unitout == "in")
            {
                baseMetricValue = baseMetricValue * 39.3700787;
            }
            else if (unitout == "km")
            {
                baseMetricValue = baseMetricValue * 0.001;
            }
            else if (unitout == "ft")
            {
                baseMetricValue = baseMetricValue * 3.2808399;
            }
            else if (unitout == "yd")
            {
                baseMetricValue = baseMetricValue * 1.0936133;
            }
            if (unitin == "m")
            {
                baseMetricValue = baseMetricValue / 1;
            }
            else if (unitin == "mm")
            {
                baseMetricValue = baseMetricValue / 1000;
            }
            else if (unitin == "cm")
            {
                baseMetricValue = baseMetricValue / 100;
            }
            else if (unitin == "mi")
            {
                baseMetricValue = baseMetricValue / 0.000621371192;
            }
            else if (unitin == "in")
            {
                baseMetricValue = baseMetricValue / 39.3700787;
            }
            else if (unitin == "km")
            {
                baseMetricValue = baseMetricValue / 0.001;
            }
            else if (unitin == "ft")
            {
                baseMetricValue = baseMetricValue / 3.2808399;
            }
            else if (unitin == "yd")
            {
                baseMetricValue = baseMetricValue / 1.0936133;
            }
            Console.Write(baseMetricValue);
            Console.WriteLine(" " + unitout);
        }
    }
}
