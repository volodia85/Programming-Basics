using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var begin = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());

            var counter = 0;
            
            for (int i = begin; i <= end; i++)
            {
                for (int b = begin; b <= end; b++)
                {
                    counter++;
                    Console.Write("<{0}-{1}>", i, b);
                    if (counter == maxCombinations)
                    {
                        break;
                    }
                }
                if (counter == maxCombinations)
                {
                    break;
                }
            }
        }
    }
}
