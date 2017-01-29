using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfAdult = int.Parse(Console.ReadLine());
            var numberOfStudents = int.Parse(Console.ReadLine());
            var numberOfNights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            
            var priceOfNight = numberOfNights * 82.99;
            var priceOftrip = 0.0;
            
            if (transport == "train")
            {
                priceOftrip = (numberOfAdult * 24.99 +
                    numberOfStudents * 14.99) * 2;
                if (numberOfAdult + numberOfStudents > 50)
                {
                    priceOftrip *= 0.50;
                }

            }
            else if (transport == "bus")
            {
                priceOftrip = (numberOfAdult * 32.50 +
                    numberOfStudents * 28.50) * 2;
            }
            else if (transport == "boat")
            {
                priceOftrip = (numberOfAdult * 42.99 +
                    numberOfStudents * 39.99) * 2;
            }
            else if (transport == "airplane")
            {
                priceOftrip = (numberOfAdult * 70.00 +
                    numberOfStudents * 50.00) * 2;
            }
            var allVacantion = (priceOfNight + priceOftrip) * 1.10;
            Console.WriteLine("{0:f2}",allVacantion);


        }
    }
}
