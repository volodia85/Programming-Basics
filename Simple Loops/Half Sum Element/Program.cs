using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var Sum = 0;
            var max = int.MinValue;
            var number = 0;
            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());

                
                Sum += number;
                if (number >= max)
                {
                    max = number;
                }

            }
            if (Sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + (Sum - max));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(max - (Sum - max)));
            }

        }
    }
}
