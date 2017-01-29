using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fights
{
    class Program
    {
        static void Main(string[] args)
        {
            var FirstPlayer = int.Parse(Console.ReadLine());
            var SecondPlayer = int.Parse(Console.ReadLine());
            var MaxFights = int.Parse(Console.ReadLine());

            var counter = 0;
            for (int i = 1; i <= SecondPlayer; i++)
            {
                
                for (int a = 1; a <= SecondPlayer; a++)
                {
                    Console.Write("({0} <-> {1}) ",i,a);
                    counter++;
                    if (counter == MaxFights)
                    {
                        break;
                    }
                }
                if (counter == MaxFights)
                {
                    break;
                }
            }
        }
    }
}
