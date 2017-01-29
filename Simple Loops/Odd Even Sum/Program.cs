using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var odd = 0;
            var even = 0;
            for (int i = 0; i < number; i++)
            {
                var unit = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += unit;
                    Console.WriteLine("No, Diff = " + Math.Abs(odd - even));
                    
                }
                else
                {
                    odd += unit;
                    Console.WriteLine("Yes, Sum = " + odd);
                }
                
            }

        }
    }
}
