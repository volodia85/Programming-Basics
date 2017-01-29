using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic
{
    class Program
    {
        static void Main(string[] args)
        {
            var coutOfLoads = int.Parse(Console.ReadLine());

            var counter = 0;
            double weightOfLoads = 0;

            double bus = 0;
            double truck = 0;
            double train = 0;

            for (int i = 1; i <= coutOfLoads; i++)
            {
                counter++;
                weightOfLoads = int.Parse(Console.ReadLine());
                if (weightOfLoads <= 3)
                {
                    bus+= weightOfLoads;
                }
                else if (weightOfLoads >= 4 && weightOfLoads <= 11)
                {
                    truck+= weightOfLoads;
                }
                else if (weightOfLoads >= 12)
                {
                    train+= weightOfLoads;
                }
            }
            double allCargo = bus + truck + train;
            double cargoBus = bus * 200;
            double cargoTruck = truck * 175;
            double cargoTrain = train * 120;
            double cargoByTon = (cargoBus + cargoTrain + cargoTruck) / allCargo;

            Console.WriteLine("{0:f2}", cargoByTon);
            Console.WriteLine("{0:f2}%", bus / allCargo * 100);
            Console.WriteLine("{0:f2}%", truck / allCargo * 100);
            Console.WriteLine("{0:f2}%", train / allCargo * 100);
        }
    }
}
