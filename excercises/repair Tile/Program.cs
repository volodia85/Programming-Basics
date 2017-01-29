using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repair_Tile
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double tileW = double.Parse(Console.ReadLine());
            double tileL = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double P = M * O;
            double tile = tileL * tileW;
            double ground = N * 2;

            double allarea = ground - P;

            Console.WriteLine(((N*N)- (M*O))/(tileW*tileL));
            Console.WriteLine(((N * N) - (M * O)) / (tileW * tileL) * 0.2);


        }
    }
}
