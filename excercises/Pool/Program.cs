using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double P1H = P1 * H;
            double P2H = P2 * H;
            double Pool = P1H + P2H;

            

            double OverFlow = Math.Abs(V - (P1H + P2H) );

            

            if (Pool <= V)
            {
                int PoolP = (int)(Pool  * 100 / V);
                int P1HP = (int)(P1H  * 100 / Pool) ;
                int P2HP = (int)(P2H  * 100 / Pool) ;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", 
                    PoolP,P1HP,P2HP);
            }
            else if (Pool > V)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",
                    H, OverFlow);
            }
            
        }
    }
}
