using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var numberRow = int.Parse(Console.ReadLine());
            var numberLine = int.Parse(Console.ReadLine());

            double Premiere = 12.00;
            double Normal = 7.50;
            double Discount = 5.00;
            double result;
            if (projection == "Premiere")
            {
                result = numberLine * numberRow * Premiere;
                Console.WriteLine("{0:f2}", result);
            }
             
            else if (projection == "Normal")
            {
                Console.WriteLine(7.50 * numberRow * numberLine + " leva");
            }
            else if (projection == "Discount")
            {
                Console.WriteLine(5.00 * numberRow * numberLine + " leva");
            }
        }    
    }
}
